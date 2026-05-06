using TeleMedichineProject.Models;
using TeleMedichineProject.Models.Common;
using TeleMedichineProject.Models.TeleClass;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace TeleMedichineProject.Common
{
    public class AppUserLogin
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ErcDbContext _appDbContext;
        private readonly CommonDbContext _commonDbContext;

        public AppUserLogin(ErcDbContext appDbContext, CommonDbContext commonDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _appDbContext = appDbContext;
            _commonDbContext = commonDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        private ISession Session => _httpContextAccessor.HttpContext.Session;

        public string HostName
        {
            get => Session.GetString("User:host") ?? string.Empty;
            set => Session.SetString("User:host", value);
        }

        public string UserName
        {
            get => Session.GetString("User:Name") ?? string.Empty;
            set => Session.SetString("User:Name", value);
        }

        public string FullUserName
        {
            get => Session.GetString("User:FName") ?? string.Empty;
            set => Session.SetString("User:FName", value);
        }

        public Guid UserID
        {
            get => Session.GetString("User:UserID") != null ? Guid.Parse(Session.GetString("User:UserID")) : Guid.Empty;
            set => Session.SetString("User:UserID", value.ToString());
        }

        public string Password
        {
            get => Session.GetString("User:Password") ?? string.Empty;
            set => Session.SetString("User:Password", value);
        }

        public long LogID
        {
            get => long.TryParse(Session.GetString("User:logid"), out var result) ? result : 0;
            set => Session.SetString("User:logid", value.ToString());
        }

        public string LoginQueryString
        {
            get => Session.GetString("User:qs") ?? string.Empty;
            set => Session.SetString("User:qs", value);
        }

        public string SiteCode
        {
            get => Session.GetString("User:SiteCode") ?? string.Empty;
            set => Session.SetString("User:SiteCode", value);
        }

        public int SiteDepartmentID
        {
            get => int.TryParse(Session.GetString("User:sdid"), out var result) ? result : 0;
            set => Session.SetString("User:sdid", value.ToString());
        }

        public string Email
        {
            get => Session.GetString("User:email") ?? string.Empty;
            set => Session.SetString("User:email", value);
        }

        public string Address
        {
            get => Session.GetString("User:address") ?? string.Empty;
            set => Session.SetString("User:address", value);
        }

        public string PhoneNo
        {
            get => Session.GetString("User:phone") ?? string.Empty;
            set => Session.SetString("User:phone", value);
        }


        public string Specialty
        {
            get => Session.GetString("User:Specialty") ?? string.Empty;
            set => Session.SetString("User:Specialty", value);
        }

        public int ServiceUnitID
        {
            get => int.TryParse(Session.GetString("User:suid"), out var result) ? result : 0;
            set => Session.SetString("User:suid", value.ToString());
        }

        public int ParamedicId
        {
            get => int.TryParse(Session.GetString("User:parid"), out var result) ? result : 0;
            set => Session.SetString("User:parid", value.ToString());
        }

        public string ParamedicType
        {
            get => Session.GetString("User:paratype") ?? string.Empty;
            set => Session.SetString("User:paratype", value);
        }

        public Guid RoleID
        {
            get => Session.GetString("User:roleId") != null ? Guid.Parse(Session.GetString("User:roleId")) : Guid.Empty;
            set => Session.SetString("User:roleId", value.ToString());
        }

        public string ModuleID
        {
            get => Session.GetString("User:mdid") ?? string.Empty;
            set => Session.SetString("User:mdid", value);
        }

        public string HelpUrl
        {
            get => Session.GetString("User:hlpurl") ?? string.Empty;
            set => Session.SetString("User:hlpurl", value);
        }

        // TODO: Tambahin fungsi-fungsi lainnya kayak CreateUserLog dan Populate
        // nanti kita refactor juga (bisa kita bahas di bawah kalau lo siapin Db-nya atau ORM-nya)

        public async Task<long> CreateUserLogAsync(Guid userID, string siteCode, Guid? roleID, string moduleID)
        {
            var context = _httpContextAccessor.HttpContext;
            var userAgent = context?.Request?.Headers["User-Agent"].ToString() ?? "Unknown";
            var userName = context?.User?.Identity?.Name ?? "Unknown";
            var ipAddress = context?.Connection?.RemoteIpAddress?.ToString() ?? "Unknown";
            string sessionID = GetOrCreateSessionId(_httpContextAccessor.HttpContext.Session);

            // tutup log lama
            var oldLogs = await _appDbContext.sysUserLog
                .Where(l => l.UserId == userID && l.LogOutDateTime == null).ToListAsync();

            oldLogs.ForEach(l =>
            {
                l.LogOutDateTime = DateTime.Now;
                l.LastUpdatedDateTime = DateTime.Now;
                l.IsLogOut = true;
                l.GCLogOutType = "LogoutWhenLogIn";
            });

            var log = new sysUserLog
            {
                UserId = userID,
                SiteCode = siteCode,
                RoleId = roleID ?? Guid.Empty,
                ModuleID = moduleID,
                ModuleSessionID = sessionID,
                LogInDateTime = DateTime.Now,
                LastUpdatedDateTime = DateTime.Now,
                HostName = ipAddress,
                BrowserName = GetBrowserName(userAgent),
                BrowserUserAgent = userAgent,
                BrowserPlatform = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                IsMobileDevice = IsMobileDevice(userAgent),
                LastUpdatedBy = userName,
            };

            _appDbContext.sysUserLog.Add(log);
            await _appDbContext.SaveChangesAsync();

            return log.LogID;
        }

        private bool IsMobileDevice(string userAgent)
        {
            if (string.IsNullOrEmpty(userAgent)) return false;

            string[] mobileDevices = new[]
            {
                "iphone", "ipad", "android", "opera mini", "blackberry", "windows phone"
            };

            userAgent = userAgent.ToLower();

            return mobileDevices.Any(d => userAgent.Contains(d));
        }

        private string GetBrowserName(string userAgent)
        {
            if (string.IsNullOrWhiteSpace(userAgent))
                return "Unknown";

            // Cek dari yang paling umum dipake
            if (userAgent.Contains("Chrome") && !userAgent.Contains("Edg/"))
            {
                var match = Regex.Match(userAgent, @"Chrome/(\d+(\.\d+)?)");
                if (match.Success)
                {
                    return "Chrome " + match.Groups[1].Value;
                }
            }
            else if (userAgent.Contains("Edg/")) // Edge pakai Edg/
            {
                var match = Regex.Match(userAgent, @"Edg/(\d+(\.\d+)?)");
                if (match.Success)
                {
                    return "Edge " + match.Groups[1].Value;
                }
            }
            else if (userAgent.Contains("Firefox"))
            {
                var match = Regex.Match(userAgent, @"Firefox/(\d+(\.\d+)?)");
                if (match.Success)
                {
                    return "Firefox " + match.Groups[1].Value;
                }
            }
            else if (userAgent.Contains("Safari") && userAgent.Contains("Version"))
            {
                var match = Regex.Match(userAgent, @"Version/(\d+(\.\d+)?)");
                if (match.Success)
                {
                    return "Safari " + match.Groups[1].Value;
                }
            }

            return "Unknown";
        }

        public static string GetOrCreateSessionId(ISession session)
        {
            const string SessionKey = "NewEMR";

            var existingSessionId = session.GetString(SessionKey);
            if (!string.IsNullOrEmpty(existingSessionId))
                return existingSessionId;

            // generate random string mirip format .NET 4
            var newSessionId = GenerateRandomString(24); // panjang 24 char
            session.SetString(SessionKey, newSessionId);
            return newSessionId;
        }

        private static string GenerateRandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public async Task<long> PopulateAsync(string qs)
        {
            if (string.IsNullOrWhiteSpace(qs))
                return 0;

            // Normalize & decrypt
            qs = NormalizeQs(qs);
            var decrypted = EncDec.Decrypt(qs);
            var arrQs = decrypted.Split('|');

            // Assign basic info
            this.UserID = Guid.Parse(arrQs[0]);
            this.UserName = arrQs[1];
            this.Password = arrQs[2];
            this.SiteCode = arrQs[3];

            // 1. Cek user ada atau tidak
            var user = await _commonDbContext.aspnet_Users
                .FirstOrDefaultAsync(u => u.UserName == this.UserName);

            if (user == null)
                return -1; // User tidak ditemukan

            var userId = user.UserId;

            // 2. Validasi password
            if (!ValidateLegacyUser(this.UserName, this.Password))
                return -2; // Password salah

            var roleID = Guid.Parse(arrQs[4]);

            // 3. Validasi role
            var roles = await _commonDbContext.sysUserRoleInSite
                .Where(r => r.UserId == userId)
                .ToListAsync();

            if (!roles.Any())
                return -3; // User tidak memiliki akses profile

            var roleFound = roles.FirstOrDefault(r => r.RoleId == roleID);
            if (roleFound == null)
                return -4; // Role tidak sesuai dengan database

            this.RoleID = roleID;

            var role = await _commonDbContext.sysRoles.FindAsync(roleID);
            this.ModuleID = role?.ModuleID ?? "";

            // Assign additional info
            this.SiteDepartmentID = Convert.ToInt32(arrQs[5]);
            this.ServiceUnitID = Convert.ToInt32(arrQs[6]);
            this.LogID = Convert.ToInt64(arrQs[7]);
            this.HostName = _httpContextAccessor.HttpContext?.Connection?.RemoteIpAddress?.ToString() ?? "Unknown";

            // 4. Ambil sysUser
            var sysUser = await _appDbContext.sysUser
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.UserId == this.UserID);

            if (sysUser == null)
                return -1; // User tidak ditemukan di system (sinkronisasi beda tabel)

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

            // Set user detail
            if (sysUser.IsParamedic == true && sysUser.ParamedicID != null)
            {
                this.ParamedicId = sysUser.ParamedicID.Value;

                var paramedic = await _appDbContext.Paramedic
                    .AsNoTracking()
                    .FirstOrDefaultAsync(d => d.ParamedicID == this.ParamedicId);

                if (paramedic != null)
                {
                    this.FullUserName = paramedic.ParamedicName.Trim();
                    this.ParamedicType = paramedicTypeName;
                }
            }
            else
            {
                this.FullUserName = $"{sysUser.FirstName} {sysUser.MiddleName} {sysUser.LastName}".Trim();
            }

            // 5. Update log
            var log = await _appDbContext.sysUserLog
                .FirstOrDefaultAsync(x => x.LogID == this.LogID);

            if (log != null)
            {
                log.ModuleSessionID = GetOrCreateSessionId(_httpContextAccessor.HttpContext.Session);
                log.LastUpdatedDateTime = DateTime.Now;
                log.LastUpdatedBy = this.UserName;

                await _appDbContext.SaveChangesAsync();
            }

            return this.LogID;
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

        private string NormalizeQs(string qs)
        {
            // kalau masih encoded → decode
            if (qs.Contains("%"))
                qs = WebUtility.UrlDecode(qs);

            // perbaiki spasi jadi +
            qs = qs.Replace(" ", "+");

            return qs;
        }
    }
}
