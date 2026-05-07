using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeleMedichineProject.Common;
using TeleMedichineProject.Helpers;
using TeleMedichineProject.Models;
using TeleMedichineProject.Models.TeleClass;

namespace TeleMedichineProject.Controllers
{
    [Authorize]
    public class DoctorController : Controller
    {
        private readonly ErcDbContext _db;
        private readonly AppUserLogin _appUserLogin;

        public DoctorController(ErcDbContext db, AppUserLogin appUserLogin)
        {
            _db = db;
            _appUserLogin = appUserLogin;
        }

        public async Task<IActionResult> Index()
        {
            // Ambil workstation dokter yang login
            var workStation = await _db.WorkStation
                .AsNoTracking()
                .FirstOrDefaultAsync(w => w.ParamedicID == _appUserLogin.ParamedicId);

            if (workStation == null)
                return View("EmptyState", "Workstation dokter tidak ditemukan.");

            // Ambil registrasi hari ini berdasarkan workstation
            var today = DateTime.Today;
            var latestReg = await _db.Registration
                .AsNoTracking()
                .Where(r => !r.IsDeleted
                         && r.WorkStationCode == workStation.WorkStationCode
                         && r.RegistrationDateTime.Date == today)
                .OrderByDescending(r => r.RegistrationDateTime)
                .FirstOrDefaultAsync();

            if (latestReg == null)
                return View("EmptyState"); // empty state

            // Ada pasien → redirect ke detail
            return RedirectToAction("DetailDashboard", "Home",
                new { registrationNo = EncryptHelper.Encrypt(latestReg.RegistrationNo) });
        }
    }
}