using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class sysParameterReport
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Unicode(false)]
    public string ParameterCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string ParameterName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ParentCode { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsParent { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
