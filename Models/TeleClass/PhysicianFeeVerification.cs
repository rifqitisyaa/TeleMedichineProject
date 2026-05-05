using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PhysicianFeeVerification
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VerificationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public DateOnly VerificationDate { get; set; }

    public int ParamedicID { get; set; }

    public DateOnly? DueDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalChargesAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? FeeAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AdditionalFeeAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalPhysicianTax { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DPPAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PaymentAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? GuaranteeAmount { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("PhysicianFeeVerification")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [InverseProperty("VerificationNoNavigation")]
    public virtual ICollection<PhysicianFeeAdditionalFee> PhysicianFeeAdditionalFee { get; set; } = new List<PhysicianFeeAdditionalFee>();

    [InverseProperty("VerificationNoNavigation")]
    public virtual ICollection<PhysicianFeeItem> PhysicianFeeItem { get; set; } = new List<PhysicianFeeItem>();

    [InverseProperty("VerificationNoNavigation")]
    public virtual ICollection<PhysicianFeeItemJobOrder> PhysicianFeeItemJobOrder { get; set; } = new List<PhysicianFeeItemJobOrder>();

    [InverseProperty("VerificationNoNavigation")]
    public virtual ICollection<PhysicianFeePaymentPlanDt> PhysicianFeePaymentPlanDt { get; set; } = new List<PhysicianFeePaymentPlanDt>();

    [InverseProperty("VerificationNoNavigation")]
    public virtual ICollection<PhysicianTaxSummaryDt> PhysicianTaxSummaryDt { get; set; } = new List<PhysicianTaxSummaryDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("PhysicianFeeVerification")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("PhysicianFeeVerification")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
