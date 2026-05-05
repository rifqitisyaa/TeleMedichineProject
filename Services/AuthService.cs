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
            context.Response.Cookies.Append("RoleID", user.RoleID.ToString());
            context.Response.Cookies.Append("ServiceUnitID", user.ServiceUnitID.ToString());

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName ?? ""),
                new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()),
                new Claim("DoctorId", user.ParamedicId.ToString()),
                new Claim("RoleID", user.RoleID.ToString()),
                new Claim("ServiceUnitID", user.ServiceUnitID.ToString()),
                new Claim("FullUserName", user.FullUserName ?? "")
            };

            var identity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            var principal = new ClaimsPrincipal(identity);

            await context.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal
            );
        }
    }
}