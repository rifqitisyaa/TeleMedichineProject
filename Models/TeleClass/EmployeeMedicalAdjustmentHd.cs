using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeMedicalAdjustmentHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AdjustmentNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AdjustmentDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int MedicalBenefitId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartEffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndEffectiveDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [InverseProperty("AdjustmentNoNavigation")]
    public virtual ICollection<EmployeeMedicalAdjustmentDt> EmployeeMedicalAdjustmentDt { get; set; } = new List<EmployeeMedicalAdjustmentDt>();

    [ForeignKey("MedicalBenefitId")]
    [InverseProperty("EmployeeMedicalAdjustmentHd")]
    public virtual MedicalBenefitType MedicalBenefit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("EmployeeMedicalAdjustmentHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("EmployeeMedicalAdjustmentHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
