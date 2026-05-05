using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Period", "ParamedicId", "VerificationNo")]
public partial class PhysicianTaxSummaryDt
{
    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    [Key]
    public int ParamedicId { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VerificationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("Period, ParamedicId")]
    [InverseProperty("PhysicianTaxSummaryDt")]
    public virtual PhysicianTaxSummaryHd PhysicianTaxSummaryHd { get; set; } = null!;

    [ForeignKey("VerificationNo")]
    [InverseProperty("PhysicianTaxSummaryDt")]
    public virtual PhysicianFeeVerification VerificationNoNavigation { get; set; } = null!;
}
