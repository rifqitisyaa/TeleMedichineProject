
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeleMedichineProject.Helpers;
using TeleMedichineProject.Models;
using TeleMedichineProject.Models.TeleClass;
using Microsoft.AspNetCore.Authorization;


namespace TeleMedichineProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ErcDbContext _db;

        public HomeController(ErcDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(string? search, string? workstation, int page = 1)
        {
            int pageSize = 10;

            var query = _db.Appointment.AsQueryable();

            if (!string.IsNullOrEmpty(search))
                query = query.Where(a =>
                    a.AppointmentNo.Contains(search) ||
                    a.PatientName!.Contains(search) ||
                    a.FirstName.Contains(search));

            if (!string.IsNullOrEmpty(workstation))
                query = query.Where(a => a.WorkStationCode == workstation);

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
            ViewBag.SelectedWorkstation = workstation;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(data);
        }

        public async Task<IActionResult> DetailDashboard(string appointmentNo)
        {
            var decrypted = EncryptHelper.Decrypt(appointmentNo);

            var appointment = await _db.Appointment
         .FirstOrDefaultAsync(a => a.AppointmentNo == decrypted && !a.IsDeleted);

            if (appointment == null) return NotFound();

            var patientList = await _db.Appointment
    .Where(a => !a.IsDeleted)
    .OrderByDescending(a => a.AppointmentDateTime)
    .ToListAsync();

            // Group by nama di memory, ambil data terbaru per pasien
            patientList = patientList
                .GroupBy(a => a.PatientName ?? $"{a.FirstName} {a.LastName}".Trim())
                .Select(g => g.First())  // First() karena udah disorting descending, jadi ini data terbaru
                .OrderBy(a => a.AppointmentDateTime)  // sort dari terlama ke terbaru
                .Take(20)
                .ToList();

            ViewBag.PatientList = patientList;

            ViewBag.PatientList = patientList;
            ViewBag.CurrentAptNo = decrypted;

            return View(appointment);
        }
    }
}
