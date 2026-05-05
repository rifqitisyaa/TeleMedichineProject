using Microsoft.AspNetCore.Mvc;
using TeleMedichineProject.Models;
using TeleMedichineProject.Helpers;

namespace TeleMedichineProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;

        public AccountController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            // Kalau sudah login, langsung redirect ke dashboard
            if (HttpContext.Session.GetString("Username") != null)
                return RedirectToAction("Index", "Home");

            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Cari user di database
            // Sesuaikan dengan tabel & kolom user kamu
            var user = _db.Users
                .FirstOrDefault(u => u.Username == model.Username);

            if (user == null || user.Password != model.Password)
            {
                model.ErrorMessage = "Username atau password salah.";
                return View(model);
            }

            // Simpan session
            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetString("FullName", user.FullName ?? user.Username);
            HttpContext.Session.SetString("Role", user.Role ?? "Staff");

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}