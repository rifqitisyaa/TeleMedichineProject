using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PaymentPlanNo", "SequenceNo")]
public partial class PhysicianFeePaymentPlanDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentPlanNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string VerificationNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OutstandingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("PaymentPlanNo")]
    [InverseProperty("PhysicianFeePaymentPlanDt")]
    public virtual PhysicianFeePaymentPlanHd PaymentPlanNoNavigation { get; set; } = null!;

    [ForeignKey("VerificationNo")]
    [InverseProperty("PhysicianFeePaymentPlanDt")]
    public virtual PhysicianFeeVerification VerificationNoNavigation { get; set; } = null!;
}
