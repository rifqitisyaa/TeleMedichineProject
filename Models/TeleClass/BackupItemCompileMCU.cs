using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BackupItemCompileMCU
{
    [StringLength(20)]
    [Unicode(false)]
    public string ItemCompileCode { get; set; } = null!;

    [Unicode(false)]
    public string ItemCompileName { get; set; } = null!;

    [Unicode(false)]
    public string? ItemCompileName2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCCompileType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ParentCode { get; set; }

    public bool IsHeader { get; set; }

    public bool IsActive { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsNormal { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
