using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo", "DetailNo")]
public partial class RiskFallDt
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ControlName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ControlValue { get; set; }

    [Unicode(false)]
    public string? ControlText { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MedicalNo, SequenceNo")]
    [InverseProperty("RiskFallDt")]
    public virtual RiskFallHd RiskFallHd { get; set; } = null!;
}
