using TeleMedichineProject.Common;

namespace TeleMedichineProject.Services
{
    public interface IAuthService
    {
        Task SignInAsync(HttpContext context, AppUserLogin user, string sid = null, string logId = null);
    }
}
