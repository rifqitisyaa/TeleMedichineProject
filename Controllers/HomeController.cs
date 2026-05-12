
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using TeleMedichineProject.Common;
using TeleMedichineProject.Helpers;
using TeleMedichineProject.Models;
using TeleMedichineProject.Models.DTO;
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

            // Join ke Paramedic
            var workstationCodes = data
                .Where(a => !string.IsNullOrEmpty(a.WorkStationCode))
                .Select(a => a.WorkStationCode)
                .Distinct()
                .ToList();

            var paramedics = await _db.Paramedic
                .Where(p => workstationCodes.Contains(p.ParamedicCode))
                .ToDictionaryAsync(p => p.ParamedicCode, p => p.ParamedicName);

            ViewBag.Paramedics = paramedics;
            ViewBag.Search = search;
            ViewBag.Date = date;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;


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

        [HttpGet]
        public async Task<IActionResult> GetAllAppointmentNos(string? date, string? search = "")
        {
            try
            {
                var query = _db.Appointment.Where(a => !a.IsDeleted);

                if (!string.IsNullOrEmpty(date) && DateTime.TryParse(date, out var parsedDate))
                    query = query.Where(a => a.AppointmentDateTime.Date == parsedDate.Date);

                if (!string.IsNullOrEmpty(search))
                    query = query.Where(a =>
                        a.PatientName.Contains(search) ||
                        a.AppointmentNo.Contains(search));

                var nos = await query.Select(a => a.AppointmentNo).ToListAsync();
                return Json(new { success = true, data = nos });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, data = Array.Empty<string>() });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetLatestAppointments(string date, string search = "")
        {
            try
            {
                var query = _db.Appointment.AsQueryable();

                if (!string.IsNullOrEmpty(date) && DateTime.TryParse(date, out var parsedDate))
                    query = query.Where(a => a.AppointmentDateTime.Date == parsedDate.Date);
                else
                    query = query.Where(a => a.AppointmentDateTime.Date == DateTime.Today);

                if (!string.IsNullOrEmpty(search))
                    query = query.Where(a =>
                        a.PatientName.Contains(search) ||
                        a.AppointmentNo.Contains(search));

                var appointments = await query
                     .OrderByDescending(a => a.AppointmentDateTime)
                     .Select(a => new {
                         appointmentNo = a.AppointmentNo,
                         patientName = a.PatientName ?? (a.FirstName + " " + a.LastName).Trim(),
                         appointmentDate = a.AppointmentDateTime.ToString("d-M-yyyy"),
                         hasWorkstation = a.WorkStationCode != null && a.WorkStationCode != ""
                     })
                     .ToListAsync();

                var result = appointments.Select(a => new {
                    a.appointmentNo,
                    a.patientName,
                    a.appointmentDate,
                    a.hasWorkstation,
                    encryptedAptNo = EncryptHelper.Encrypt(a.appointmentNo)
                });

                return Json(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                // Jangan crash — return empty supaya polling tetap jalan
                Console.WriteLine($"[GetLatestAppointments] Error: {ex.Message}");
                return Json(new { success = false, data = Array.Empty<object>() });
            }
        }

        public IActionResult EmptyState()
        {
            return View();
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
                Registration = reg?.RegistrationNo,
                PatientName = appointment.PatientName,
                FirstName = appointment.FirstName,
                MiddleName = appointment.MiddleName,
                LastName = appointment.LastName,
                AppointmentDateTime = appointment.AppointmentDateTime,
                MedicalNo = reg?.MedicalNo,
                VisitTypeValue = vty?.VisitTypeName,
                WorkStationCode = appointment.WorkStationCode,
                MobilePhoneNo = appointment.MobilePhoneNo,
                PhoneNo = appointment.PhoneNo,
                EmailAddress = appointment.EmailAddress,
                Address = appointment.Address,
                RegistrationDateTime = reg?.RegistrationDateTime
            };

            var workCode = await _db.WorkStation
                .FirstOrDefaultAsync(w => w.ParamedicID == _appUserLogin.ParamedicId);

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
                                        where !a.IsDeleted && !r.IsDeleted && a.WorkStationCode == workCode.WorkStationCode
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

        public class SaveRegistrasiRequest
        {
            public string AppointmentNo { get; set; }
            public int? SelectedParamedicId { get; set; }
            public string? SelectedWorkStationCode { get; set; }
        }

        [HttpGet]
        public async Task<IActionResult> GetDokterList()
        {
            var dokters = await _db.Paramedic
                .Where(p => !p.IsDeleted && p.IsActive == true && p.GCParamedicType == "X0055^001")
                .Select(p => new
                {
                    paramedicId = p.ParamedicID,
                    paramedicName = p.ParamedicName,
                    workStationCode = p.ParamedicCode
                })
                .OrderBy(p => p.paramedicName)
                .ToListAsync();

            return Json(dokters);
        }

        [HttpPost]
        public async Task<IActionResult> SaveRegistrasi([FromBody] SaveRegistrasiRequest request)
        {
            int paramedicId = 0;
            try
            {
                var appointmentNo = EncryptHelper.Decrypt(request.AppointmentNo);

                var appointment = await _db.Appointment
                    .AsNoTracking()
                    .FirstOrDefaultAsync(a => a.AppointmentNo == appointmentNo && !a.IsDeleted);

                if (appointment == null)
                    return Json(new { success = false, message = "Appointment tidak ditemukan." });



                var existingReg = await _db.Registration
                    .AsNoTracking()
                    .FirstOrDefaultAsync(r => r.AppointmentNo == appointmentNo && !r.IsDeleted);

                if (existingReg != null)
                    return Json(new { success = false, message = $"Pasien sudah terdaftar dengan nomor {existingReg.RegistrationNo}." });


                var parReg = await _db.Paramedic
                    .AsNoTracking()
                    .FirstOrDefaultAsync(pr => pr.ParamedicCode == appointment.WorkStationCode);


                if (parReg == null)
                {
                    var parnull = await _db.Paramedic
                   .AsNoTracking()
                   .FirstOrDefaultAsync(pr => pr.ParamedicCode == request.SelectedWorkStationCode);

                    paramedicId = parnull.ParamedicID;
                }
                else
                {
                    paramedicId = parReg.ParamedicID;
                }

                var transCode = "001";

                var transDate = DateTime.Now;
                var siteCode = _appUserLogin.SiteCode;

                var serviceUnitId = await _db.sysParameter
                    .AsNoTracking()
                    .FirstOrDefaultAsync(su => su.ParameterCode == "ServiceUnitDefaultTelemedichine");

                if (serviceUnitId == null)
                    return Json(new { success = false, message = "Parameter ServiceUnitDefaultTelemedichine tidak ditemukan." });

                var patientTypeId = await _db.Patient
                    .AsNoTracking()
                    .FirstOrDefaultAsync(pat => pat.MedicalNo == appointment.MedicalNo);

                if (patientTypeId == null)
                    return Json(new { success = false, message = "Data Pasien tidak ditemukan di database." });

                var businessPartnerId = await _db.BusinessPartner
                    .AsNoTracking()
                    .FirstOrDefaultAsync(buid => buid.BusinessPartnerCode == patientTypeId.GCPatientCategory);

                if (businessPartnerId == null)
                    return Json(new { success = false, message = "Data Business Partner untuk kategori pasien ini tidak ditemukan." });

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


                if (paramedicId == 0)
                    return Json(new { success = false, message = $"Data Paramedis dengan kode {appointment.WorkStationCode} tidak ditemukan." });

                if (parReg == null)
                {
                    var workCode = await _db.WorkStation
                        .FirstOrDefaultAsync(wc => wc.WorkStationCode == request.SelectedWorkStationCode);

                    if (workCode == null)
                    {
                        var workPar = await _db.Paramedic
                        .FirstOrDefaultAsync(wp => wp.ParamedicCode == request.SelectedWorkStationCode);

                        return Json(new { success = false, message = $"Data Workstation {workPar.ParamedicName} tidak ditemukan." });
                    }
                    appointment.WorkStationCode = request.SelectedWorkStationCode;

                    _db.Appointment.Update(appointment);
                    await _db.SaveChangesAsync();
                }

                var registration = new Registration
                {
                    RegistrationNo = registrationNo,
                    SiteCode = siteCode,
                    TransactionCode = transCode,
                    RegistrationDateTime = transDate,
                    AppointmentNo = appointmentNo,
                    MedicalNo = appointment.MedicalNo ?? "",
                    ServiceUnitID = Convert.ToInt16(serviceUnitId.ParameterValue),
                    ParamedicID = paramedicId,
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

        [HttpGet]
        public async Task<IActionResult> GetRegistrationDetail(string registrationNo)
        {
            if (string.IsNullOrEmpty(registrationNo))
                return Json(new { success = false, message = "Registration No kosong" });


            var reg = await _db.Registration
                .AsNoTracking()
                .FirstOrDefaultAsync(r => r.RegistrationNo == registrationNo && !r.IsDeleted);

            if (reg == null)
            {
                return Json(new { success = false, message = $"Registrasi {registrationNo} tidak ditemukan" });
            }

            var appointment = await _db.Appointment
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.AppointmentNo == reg.AppointmentNo && !a.IsDeleted);

            var patientName = appointment?.PatientName
                ?? $"{appointment?.FirstName} {appointment?.LastName}".Trim()
                ?? "-";

            var detailUrl = Url.Action("DetailDashboard", "Home",
                new { appointmentNo = EncryptHelper.Encrypt(reg.AppointmentNo) });

            return Json(new
            {
                success = true,
                registrationNo = reg.RegistrationNo,
                registrationDate = reg.RegistrationDateTime.ToString("dd MMM yyyy HH:mm"),
                patientName = patientName,
                detailUrl = detailUrl
            });
        }

    }
    public class SaveSoapRequest
    {
        public string Subjective { get; set; }
        public string Objective { get; set; }
        public string Assessment { get; set; }
        public string Plan { get; set; }
    }

}
