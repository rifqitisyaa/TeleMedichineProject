using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using TeleMedichineProject.Common;

namespace TeleMedichineProject.Services
{
    public class AuthService : IAuthService
    {
        public async Task SignInAsync(HttpContext context, AppUserLogin user, string sid = null, string logId = null)
        {
            await context.Session.LoadAsync();

            context.Session.SetString("UserName", user.UserName ?? "");
            context.Session.SetInt32("DoctorId", user.ParamedicId);

            if (!string.IsNullOrEmpty(logId))
                context.Response.Cookies.Append("LogID", logId);

            context.Response.Cookies.Append("SessionID", sid ?? context.Session.Id);
            context.Response.Cookies.Append("UserName", user.UserName ?? "");
            context.Response.Cookies.Append("FullUserName", user.FullUserName ?? "");
            context.Response.Cookies.Append("Email", user.Email ?? "");
            context.Response.Cookies.Append("Specialty", user.Specialty ?? "");
            context.Response.Cookies.Append("Address", user.Address ?? "");
            context.Response.Cookies.Append("PhoneNo", user.PhoneNo ?? "");
            context.Response.Cookies.Append("RoleID", user.RoleID.ToString());
            context.Response.Cookies.Append("ServiceUnitID", user.ServiceUnitID.ToString());
            context.Response.Cookies.Append("ParamedicType", user.ParamedicType.ToString());

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName ?? ""),
                new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()),
                new Claim("DoctorId", user.ParamedicId.ToString()),
                new Claim("RoleID", user.RoleID.ToString()),
                new Claim("ServiceUnitID", user.ServiceUnitID.ToString()),
                new Claim("FullUserName", user.FullUserName ?? ""),
                new Claim("ParamedicType", user.ParamedicType ?? ""),

                new Claim("Email", user.Email.ToString()),
                new Claim("Specialty", user.Specialty.ToString()),
                new Claim("PhoneNo", user.PhoneNo.ToString()),
                new Claim("Address", user.Address ?? "")
            };

            var identity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            var principal = new ClaimsPrincipal(identity);

            await context.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal,
                new AuthenticationProperties
                {
                    IsPersistent = false,
                    ExpiresUtc = null
                }
            );
        }
    }
}