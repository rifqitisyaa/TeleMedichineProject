using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeleMedichineProject.Models.TeleClass;

[Table("TM_AuditLog")]
public class AuditLog
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    public string TableName { get; set; } = string.Empty;

    [StringLength(20)]
    public string Action { get; set; } = string.Empty; // Added, Modified, Deleted

    [StringLength(200)]
    public string? PrimaryKey { get; set; }

    public string? OldValues { get; set; } // JSON

    public string? NewValues { get; set; } // JSON

    public string? ChangedColumns { get; set; } // JSON array

    [StringLength(100)]
    public string ChangedBy { get; set; } = string.Empty;

    public DateTime ChangedAt { get; set; } = DateTime.Now;

    [StringLength(50)]
    public string? SiteCode { get; set; }
}
