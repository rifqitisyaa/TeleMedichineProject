using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SatuSehatConditionCode", "GCDischargeCondition")]
public partial class SatuSehatDischargeCondition
{
    [Key]
    public int SatuSehatConditionCode { get; set; }

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string GCDischargeCondition { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? SatuSehatConditionName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
