
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TeleMedichineProject.Common;
using TeleMedichineProject.Helpers;
using TeleMedichineProject.Models;
using TeleMedichineProject.Models.TeleClass;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace TeleMedichineProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ErcDbContext _db;
        private readonly AppDbContext _appDb;
        private readonly AppUserLogin _appUserLogin;

        public HomeController(ErcDbContext db, AppUserLogin appUserLogin)
        {
            _db = db;
            _appUserLogin = appUserLogin;
        }
        public async Task<IActionResult> Index(string? search, string? date, int page = 1)
        {

            int pageSize = 10;

            var query = _db.Appointment.AsQueryable();

            if (!string.IsNullOrEmpty(search))
                query = query.Where(a =>
                    a.AppointmentNo.Contains(search) ||
                    a.PatientName!.Contains(search) ||
                    a.FirstName.Contains(search));

            if (!string.IsNullOrEmpty(date) && DateTime.TryParse(date, out var filterDate))
                query = query.Where(a => a.AppointmentDateTime.Date == filterDate.Date);

            query = query.Where(a => !a.IsDeleted)
                         .OrderByDescending(a => a.AppointmentDateTime);

            int totalData = await query.CountAsync();
            int totalPages = (int)Math.Ceiling(totalData / (double)pageSize);

            var data = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.Workstations = await _db.Appointment
                .Where(a => !a.IsDeleted && a.WorkStationCode != null)
                .Select(a => a.WorkStationCode!)
                .Distinct().ToListAsync();

            ViewBag.Search = search;
            ViewBag.Date = date;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;


            // Di query Index, cek existing registration
            var appointmentNos = data.Select(a => a.AppointmentNo).ToList();
            var existingRegs = await _db.Registration
                .Where(r => appointmentNos.Contains(r.AppointmentNo) && !r.IsDeleted)
                .Select(r => new { r.AppointmentNo, r.RegistrationNo })
                .ToListAsync();

            ViewBag.ExistingRegs = existingRegs
                .GroupBy(r => r.AppointmentNo)
                .ToDictionary(g => g.Key, g => g.First().RegistrationNo);

            return View(data);
        }

        public async Task<IActionResult> DetailDashboard(string appointmentNo)
        {
            var decrypted = EncryptHelper.Decrypt(appointmentNo);

            var appointment = await _db.Appointment
         .FirstOrDefaultAsync(a => a.AppointmentNo == decrypted && !a.IsDeleted);

            if (appointment == null) return NotFound();

            var reg = await _db.Registration
                .FirstOrDefaultAsync(r => r.AppointmentNo == decrypted && !r.IsDeleted);

            var vty = await _db.VisitType
                .FirstOrDefaultAsync(v => v.VisitTypeCode == appointment.VisitTypeCode);

            var viewmodel = new DetailDashboardModel
            {
                AppointmentNo = appointment.AppointmentNo,
                Registration = reg.RegistrationNo,
                PatientName = appointment.PatientName,
                FirstName = appointment.FirstName,
                MiddleName = appointment.MiddleName,
                LastName = appointment.LastName,
                AppointmentDateTime = appointment.AppointmentDateTime,
                MedicalNo = reg.MedicalNo,
                VisitTypeValue = vty.VisitTypeName,
                WorkStationCode = appointment.WorkStationCode,
                MobilePhoneNo = appointment.MobilePhoneNo,
                PhoneNo = appointment.PhoneNo,
                EmailAddress = appointment.EmailAddress,
                Address = appointment.Address,
                RegistrationDateTime = reg.RegistrationDateTime
            };

            var patientList = await _db.Appointment
                .Where(a => !a.IsDeleted)
                .OrderByDescending(a => a.AppointmentDateTime)
                .ToListAsync();

            patientList = patientList
                .GroupBy(a => a.PatientName ?? $"{a.FirstName} {a.LastName}".Trim())
                .Select(g => g.First())  
                .OrderBy(a => a.AppointmentDateTime)  
                .Take(20)
                .ToList();


            var patientListReg = await (from a in _db.Appointment
                                     join r in _db.Registration on a.AppointmentNo equals r.AppointmentNo
                                        where !a.IsDeleted && !r.IsDeleted 
                                     orderby a.AppointmentDateTime descending
                                     select a)
                         .ToListAsync();

            // Logic GroupBy dan Take tetap sama
            patientListReg = patientListReg
                .GroupBy(a => a.PatientName ?? $"{a.FirstName} {a.LastName}".Trim())
                .Select(g => g.First())
                .OrderBy(a => a.AppointmentDateTime)
                .Take(20)
                .ToList();

            ViewBag.PatientListWithRegistration = patientListReg;

            ViewBag.PatientList = patientList;
            ViewBag.CurrentAptNo = decrypted;

            return View(viewmodel);
        }

        [HttpPost]
        public async Task<IActionResult> SaveRegistrasi([FromBody] SaveRegistrasiRequest request)
        {
            try
            {
                // 1. Decrypt appointmentNo
                var appointmentNo = EncryptHelper.Decrypt(request.AppointmentNo);

                // 2. Ambil data appointment
                var appointment = await _db.Appointment
                    .AsNoTracking()
                    .FirstOrDefaultAsync(a => a.AppointmentNo == appointmentNo && !a.IsDeleted);

                if (appointment == null)
                    return Json(new { success = false, message = "Appointment tidak ditemukan." });

                // 3. Cek apakah sudah pernah diregistrasi
                var existingReg = await _db.Registration
                    .AsNoTracking()
                    .FirstOrDefaultAsync(r => r.AppointmentNo == appointmentNo && !r.IsDeleted);

                if (existingReg != null)
                    return Json(new { success = false, message = $"Pasien sudah terdaftar dengan nomor {existingReg.RegistrationNo}." });

                // 4. Ambil parameter dari sysParameter
                var transCode = "001"; //Always

                // 5. Generate RegistrationNo via uspTransactionNumber
                var transDate = DateTime.Now;
                var siteCode = _appUserLogin.SiteCode;

                var serviceUnitId = await _db.sysParameter
                    .AsNoTracking()
                    .FirstOrDefaultAsync(su => su.ParameterCode == "ServiceUnitDefaultTelemedichine");

                var patientTypeId = await _db.Patient
                    .AsNoTracking()
                    .FirstOrDefaultAsync(pat => pat.MedicalNo == appointment.MedicalNo);

                var businessPartnerId = await _db.BusinessPartner
                    .AsNoTracking()
                    .FirstOrDefaultAsync(buid => buid.BusinessPartnerCode == patientTypeId.GCPatientCategory);

                var regNoResult = await _db.Database
                    .SqlQueryRaw<TransactionNumberResult>(
                        "EXEC uspTransactionNumber @SiteCode, @TransactionCode, @ServiceUnitID, @TransactionDate",
                        new SqlParameter("@SiteCode", siteCode),
                        new SqlParameter("@TransactionCode", transCode),
                        new SqlParameter("@ServiceUnitID", "OP"),
                        new SqlParameter("@TransactionDate", DateTime.Now.ToString("yyyyMMdd"))
                    ).ToListAsync();

                var registrationNo = regNoResult.FirstOrDefault()?.TransactionNumber;

                if (string.IsNullOrEmpty(registrationNo))
                    return Json(new { success = false, message = "Gagal generate nomor registrasi." });

                // 6. Simpan Registration
                var registration = new Registration
                {
                    RegistrationNo = registrationNo,
                    SiteCode = siteCode,
                    TransactionCode = transCode,
                    RegistrationDateTime = transDate,
                    AppointmentNo = appointmentNo,
                    MedicalNo = appointment.MedicalNo ?? "",
                    ServiceUnitID = Convert.ToInt16(serviceUnitId.ParameterValue),
                    ParamedicID = _appUserLogin.ParamedicId,
                    WorkStationCode = appointment.WorkStationCode,
                    VisitTypeCode = appointment.VisitTypeCode,
                    ClassCode = "A",   // sesuaikan
                    ChargeClassCode = "A",   // sesuaikan
                    BusinessPartnerID = businessPartnerId.BusinessPartnerID,      // sesuaikan
                    IsNewPatient = false,
                    IsDeleted = false,
                    IsAttend = true,
                    EntryBy = _appUserLogin.UserName,
                    EntryDateTime = transDate,
                };

                _db.Registration.Add(registration);
                await _db.SaveChangesAsync();

                // 7. Return sukses
                var detailUrl = Url.Action("DetailDashboard", "Home",
                    new { appointmentNo = EncryptHelper.Encrypt(appointmentNo) });

                return Json(new
                {
                    success = true,
                    registrationNo = registrationNo,
                    detailUrl = detailUrl
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Terjadi kesalahan: " + ex.Message });
            }
        }

    }
    public class SaveRegistrasiRequest
    {
        public string AppointmentNo { get; set; }
    }

    public class TransactionNumberResult
    {
        public string TransactionNumber { get; set; } // sesuaikan nama kolom return SP
    }

}
