using Microsoft.EntityFrameworkCore;
using TeleMedichineProject.Models.TeleClass;

namespace TeleMedichineProject.Models.TeleClass
{
    // Partial class extension — jangan edit ErcDbContext.cs asli (scaffold-generated)
    public partial class ErcDbContext
    {
        public virtual DbSet<AuditLog> AuditLog { get; set; }
    }
}
