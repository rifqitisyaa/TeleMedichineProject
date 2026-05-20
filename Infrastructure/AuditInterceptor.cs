using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Text.Json;
using TeleMedichineProject.Models.TeleClass;

namespace TeleMedichineProject.Infrastructure
{
    public class AuditInterceptor : SaveChangesInterceptor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        // Tabel-tabel yang ingin di-audit (tambah sesuai kebutuhan)
        private static readonly HashSet<string> AuditedTables = new(StringComparer.OrdinalIgnoreCase)
        {
            "Registration",
            "Appointment",
            "PatientNotes",
            "JobOrderHd",
            "JobOrderDt",
            "JobOrderDtMedication",
        };

        public AuditInterceptor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
            DbContextEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            if (eventData.Context is null) return base.SavingChangesAsync(eventData, result, cancellationToken);

            var userName = _httpContextAccessor.HttpContext?.Session.GetString("User:Name") ?? "system";
            var siteCode = _httpContextAccessor.HttpContext?.Session.GetString("User:SiteCode");

            var auditLogs = new List<AuditLog>();

            foreach (var entry in eventData.Context.ChangeTracker.Entries())
            {
                if (entry.State is not (EntityState.Added or EntityState.Modified or EntityState.Deleted))
                    continue;

                var tableName = entry.Metadata.GetTableName() ?? entry.Metadata.ShortName();

                if (!AuditedTables.Contains(tableName))
                    continue;

                // Ambil primary key value
                var primaryKey = string.Join(",", entry.Metadata.FindPrimaryKey()?.Properties
                    .Select(p => entry.Property(p.Name).CurrentValue?.ToString() ?? "") ?? []);

                string? oldValues = null;
                string? newValues = null;
                string? changedColumns = null;

                if (entry.State == EntityState.Modified)
                {
                    var oldDict = entry.Properties
                        .Where(p => p.IsModified)
                        .ToDictionary(p => p.Metadata.Name, p => p.OriginalValue);

                    var newDict = entry.Properties
                        .Where(p => p.IsModified)
                        .ToDictionary(p => p.Metadata.Name, p => p.CurrentValue);

                    oldValues = JsonSerializer.Serialize(oldDict);
                    newValues = JsonSerializer.Serialize(newDict);
                    changedColumns = JsonSerializer.Serialize(oldDict.Keys.ToList());
                }
                else if (entry.State == EntityState.Added)
                {
                    var newDict = entry.Properties
                        .ToDictionary(p => p.Metadata.Name, p => p.CurrentValue);
                    newValues = JsonSerializer.Serialize(newDict);
                }
                else if (entry.State == EntityState.Deleted)
                {
                    var oldDict = entry.Properties
                        .ToDictionary(p => p.Metadata.Name, p => p.OriginalValue);
                    oldValues = JsonSerializer.Serialize(oldDict);
                }

                auditLogs.Add(new AuditLog
                {
                    TableName  = tableName,
                    Action     = entry.State.ToString(),
                    PrimaryKey = primaryKey,
                    OldValues  = oldValues,
                    NewValues  = newValues,
                    ChangedColumns = changedColumns,
                    ChangedBy  = userName,
                    ChangedAt  = DateTime.Now,
                    SiteCode   = siteCode
                });
            }

            if (auditLogs.Count > 0)
                eventData.Context.Set<AuditLog>().AddRange(auditLogs);

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}
