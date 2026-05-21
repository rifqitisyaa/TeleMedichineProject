
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

    public class PatientHistoryController : Controller
    {

        private readonly ErcDbContext _db;
        private readonly AppDbContext _appDb;
        private readonly AppUserLogin _appUserLogin;

        public PatientHistoryController(ErcDbContext db, AppUserLogin appUserLogin)
        {
            _db = db;
            _appUserLogin = appUserLogin;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatientHistory(string medicalNo)
        {
            var patientHistory = await (from reg in _db.Registration
                                      join pat in _db.Patient on reg.MedicalNo equals pat.MedicalNo
                                        where reg.MedicalNo == medicalNo && !reg.IsDeleted
                                       orderby reg.RegistrationDateTime descending
                                       select new
                                       {
                                           regNo = reg.RegistrationNo,
                                           pateintName = pat.PatientName,
                                           regDate = reg.RegistrationDateTime.ToString(CultureInfo.InvariantCulture)
                                       }).ToListAsync();

            return Json(new { success = true, data = patientHistory });
        }

        [HttpGet]
        public async Task<IActionResult> GetVitalHistory(string RegistrationNumber)
        {
            try
            {
                var result = await _db.Database
                    .SqlQueryRaw<VitalSignHistory>(
                        "EXEC UspVitalSignTelemedichine @RegistrationNumber",
                        new SqlParameter("@RegistrationNumber", RegistrationNumber)
                    ).ToListAsync();

                return Json(new { success = true, data = result });
            }
            catch (Exception ex) when (ex.Message.Contains("required column") ||
                                       ex.Message.Contains("not present in the results"))
            {
                // SP balik kosong → schema ga ke-return → treat as no data
                return Json(new { success = true, data = Array.Empty<object>() });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetLabHistory(string RegistrationNumber)
        {
            try
            {
                var result = await _db.Database
                    .SqlQueryRaw<LaboratoryHistory>(
                        "EXEC UspLaboratoryTelemedichine @RegistrationNumber",
                        new SqlParameter("@RegistrationNumber", RegistrationNumber)
                    ).ToListAsync();

                return Json(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
