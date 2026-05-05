using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("ReferenceNo", Name = "IX_PatientMergeLog")]
public partial class PatientMergeLog
{
    [Key]
    public long AuditLogID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ActionType { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? PrimaryKeyData { get; set; }

    [Unicode(false)]
    public string? LogData { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? HostName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LogDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;
}
