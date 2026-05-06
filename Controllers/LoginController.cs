using TeleMedichineProject.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using TeleMedichineProject.Common;
using TeleMedichineProject.Models;
using TeleMedichineProject.Models.TeleClass;
using TeleMedichineProject.Models.Common;

namespace TeleMedichineProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly ErcDbContext _appDbContext;
        private readonly CommonDbContext _commonDbContext;
        private readonly AppUserLogin _appUserLogin;
        private readonly IAuthService _authService;
        private static readonly Regex _pwdRegex = new Regex(@"^(?!\.)(?!.*[><|_])(?=.*\d)(?=.*[^A-Za-z0-9]).{7,}$");

        public LoginController(
            ErcDbContext appDbContext,
            CommonDbContext commonDbContext,
            AppUserLogin appUserLogin,
            IAuthService authService)
        {
            _appDbContext = appDbContext;
            _commonDbContext = commonDbContext;
            _appUserLogin = appUserLogin;
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("~/Views/Account/Login.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> PostLogin(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View("~/Views/Account/Login.cshtml", model);

            // 1. Cek user ada atau tidak
            var user = await _commonDbContext.aspnet_Users
                .FirstOrDefaultAsync(u => u.UserName == model.Username);

            if (user == null)
            {
                ViewBag.Error = "User tidak ditemukan";
                return View("~/Views/Account/Login.cshtml", model);
            }

            var userId = user.UserId;

            // 2. Validasi password
            var isPwdValid = ValidateLegacyUser(model.Username, model.Password);
            if (!isPwdValid)
            {
                ViewBag.Error = "Password salah";
                return View("~/Views/Account/Login.cshtml", model);
            }

            // 3. Validasi role
            var roles = await _commonDbContext.sysUserRoleInSite
                .Where(r => r.UserId == userId)
                .ToListAsync();

            if (!roles.Any())
            {
                ViewBag.Error = "User tidak memiliki akses profile";
                return View("~/Views/Account/Login.cshtml", model);
            }

            var roleId = roles.First().RoleId;
            var siteCode = roles.First().SiteCode;

            var role = await _commonDbContext.sysRoles.FindAsync(roleId);

            var serviceUnits = await _commonDbContext.sysServiceUnitInUser
                .Where(s => s.UserId == userId)
                .ToListAsync();

            // SET AppUserLogin
            _appUserLogin.UserID = userId;
            _appUserLogin.UserName = model.Username;
            _appUserLogin.Password = model.Password;
            _appUserLogin.SiteCode = siteCode;
            _appUserLogin.RoleID = roleId;
            _appUserLogin.ModuleID = role?.ModuleID;

            // 4. Ambil SysUser (sama seperti SSO)
            var sysUser = await _appDbContext.sysUser
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.UserId == userId);

            if (sysUser == null)
            {
                ViewBag.Error = "User tidak ditemukan di system";
                return View("~/Views/Account/Login.cshtml", model);
            }

            string paramedicTypeName = null;

            if (sysUser.ParamedicID != null)
            {
                paramedicTypeName = (
                    from p in _appDbContext.Paramedic
                    join g in _appDbContext.sysGeneralCode
                        on p.GCParamedicType equals g.GeneralCodeID
                    where p.ParamedicID == sysUser.ParamedicID
                    select g.GeneralCodeName1
                ).FirstOrDefault();
            }

            // APPLY ke AppUserLogin
            if (sysUser.IsParamedic == true && sysUser.ParamedicID != null)
            {
                _appUserLogin.ParamedicId = sysUser.ParamedicID.Value;

                var paramedic = await _appDbContext.Paramedic
                    .AsNoTracking()
                    .FirstOrDefaultAsync(d => d.ParamedicID == _appUserLogin.ParamedicId);

                if (paramedic != null)
                {
                    _appUserLogin.FullUserName = paramedic.ParamedicName.Trim();
                    _appUserLogin.ParamedicType = paramedicTypeName;

                    var address = await _appDbContext.Address
                        .AsNoTracking()
                        .FirstOrDefaultAsync(a => a.EntityRecordID == paramedic.ParamedicCode && a.GCAddressType == "0190^H");
                    if (address != null)
                    {
                        _appUserLogin.Email = address.Email1 ?? address.Email2;
                        _appUserLogin.Address = address.Line1.Trim();
                        _appUserLogin.PhoneNo = address.PhoneNo1 ?? address.PhoneNo2;
                    }

                    var speciality = await _appDbContext.Specialty
                        .AsNoTracking()
                        .FirstOrDefaultAsync(s => s.SpecialtyCode == paramedic.SpecialtyCode);

                    if (speciality != null)
                    {
                        _appUserLogin.Specialty = speciality.SpecialtyName1.Trim();
                    }
                }
            }
            else
            {
                _appUserLogin.FullUserName =
                    $"{sysUser.FirstName} {sysUser.MiddleName} {sysUser.LastName}".Trim();
            }

            return await ContinueLogin(model);
        }

        public async Task<IActionResult> ContinueLogin(LoginViewModel model)
        {
            var userID = _appUserLogin.UserID;

            // =========================
            // TEMP (sementara hardcode, nanti dari View)
            // =========================
            var SelectedSiteCode = string.IsNullOrEmpty(model.SiteCode)
                ? "001"
                : model.SiteCode;

            var SelectedRoleId = model.RoleId != Guid.Empty
                ? model.RoleId
                : Guid.Parse("8d4628b9-5b97-4fdd-9107-08aa7a0ed069");

            var SelectedServiceUnitId = model.ServiceUnitId != 0
                ? model.ServiceUnitId
                : 23;
            // =========================

            int siteDepartmentID = 0;

            var deptServiceUnit = await _appDbContext.DepartmentServiceUnit
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.ServiceUnitID == SelectedServiceUnitId);

            if (deptServiceUnit != null)
            {
                siteDepartmentID = deptServiceUnit.SiteDepartmentID;
            }

            // Create log
            var logID = await _appUserLogin.CreateUserLogAsync(
                userID,
                SelectedSiteCode,
                SelectedRoleId,
                "M04" // masih hardcode (ikuti flow existing)
            );

            // FINAL STATE user (sinkron sama SSO)
            _appUserLogin.SiteCode = SelectedSiteCode;
            _appUserLogin.RoleID = SelectedRoleId;
            _appUserLogin.ServiceUnitID = SelectedServiceUnitId;
            _appUserLogin.SiteDepartmentID = siteDepartmentID;

            // unified login (SAMA kayak SSO)
            await _authService.SignInAsync(
                HttpContext,
                _appUserLogin,
                null,
                logID.ToString()
            );

            ViewBag.Message = "Login successful!"; // tetap dipertahankan

            return RedirectToAction("Index", "Home");
        }

        public bool ValidateLegacyUser(string inputUsername, string inputPassword)
        {
            var user = _commonDbContext.aspnet_Users
                .Include(u => u.aspnet_Membership)
                .FirstOrDefault(u => u.UserName == inputUsername);

            if (user == null || user.aspnet_Membership == null)
                return false;

            var passwordFormat = user.aspnet_Membership.PasswordFormat;
            var storedPassword = user.aspnet_Membership.Password;
            var salt = user.aspnet_Membership.PasswordSalt;

            switch (passwordFormat)
            {
                case 0:
                    return storedPassword == inputPassword;

                case 1:
                    using (var sha1 = SHA1.Create())
                    {
                        var saltBytes = Convert.FromBase64String(salt);
                        var passwordBytes = Encoding.Unicode.GetBytes(inputPassword);
                        var combined = saltBytes.Concat(passwordBytes).ToArray();

                        var hash = sha1.ComputeHash(combined);
                        var base64Hash = Convert.ToBase64String(hash);

                        return storedPassword == base64Hash;
                    }

                default:
                    return false;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(string oldPassword, string newPassword)
        {
            if (!_pwdRegex.IsMatch(newPassword))
            {
                TempData["Error"] = "Password tidak sesuai aturan.";
                return RedirectToAction("Index", "Home");
            }

            var user = _commonDbContext.aspnet_Users
                .Include(u => u.aspnet_Membership)
                .FirstOrDefault(u => u.UserName == _appUserLogin.UserName);

            if (user == null || user.aspnet_Membership == null)
            {
                TempData["Error"] = "User tidak ditemukan.";
                return RedirectToAction("Index", "Home");
            }

            var membership = user.aspnet_Membership;

            // 1. Validasi password lama
            bool isOldValid = false;

            switch (membership.PasswordFormat)
            {
                case 0:
                    isOldValid = membership.Password == oldPassword;
                    break;

                case 1:
                    using (var sha1 = SHA1.Create())
                    {
                        var saltBytes = Convert.FromBase64String(membership.PasswordSalt);
                        var passwordBytes = Encoding.Unicode.GetBytes(oldPassword);
                        var combined = saltBytes.Concat(passwordBytes).ToArray();

                        var hash = sha1.ComputeHash(combined);
                        var base64Hash = Convert.ToBase64String(hash);

                        isOldValid = membership.Password == base64Hash;
                    }
                    break;
            }

            if (!isOldValid)
            {
                TempData["Error"] = "Password lama salah.";
                return RedirectToAction("Index", "Home");
            }

            // 2. Generate salt baru
            byte[] newSaltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(newSaltBytes);
            }

            var newSalt = Convert.ToBase64String(newSaltBytes);

            // 3. Hash password baru
            string newHashedPassword;

            switch (membership.PasswordFormat)
            {
                case 0:
                    newHashedPassword = newPassword;
                    break;

                case 1:
                    using (var sha1 = SHA1.Create())
                    {
                        var passwordBytes = Encoding.Unicode.GetBytes(newPassword);
                        var combined = newSaltBytes.Concat(passwordBytes).ToArray();

                        var hash = sha1.ComputeHash(combined);
                        newHashedPassword = Convert.ToBase64String(hash);
                    }
                    break;

                default:
                    TempData["Error"] = "Format password tidak didukung.";
                    return RedirectToAction("Index", "Home");
            }

            // 4. Save ke DB
            membership.Password = newHashedPassword;
            membership.PasswordSalt = newSalt;
            membership.LastPasswordChangedDate = DateTime.Now;

            _commonDbContext.SaveChanges();

            TempData["Success"] = "Password berhasil diganti.";
            return RedirectToAction("Index", "Home");
        }
    }
}