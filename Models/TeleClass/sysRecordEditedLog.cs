using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class sysRecordEditedLog
{
    [Key]
    public long LogID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string PrimaryKeyData { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string SessionID { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? UserHostAddress { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ProcessType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
