using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AccountPayablePaymentPlanHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentPlanNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PaymentDate { get; set; }

    public byte? DueDays { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? PaymentPlanDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? BudgetAmount { get; set; }

    public int? BusinessPartnerID { get; set; }

    public byte? RevisionNo { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Amount { get; set; }

    public int? BankID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PaymentPlanMethod { get; set; }

    [Unicode(false)]
    public string? ChequeInformation { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBy2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool? IsPrintedChequeOrList { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedChequeOrListBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedChequeOrListDateTime { get; set; }

    public bool? IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ProceedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProceedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("PaymentPlanNoNavigation")]
    public virtual ICollection<AccountPayablePaymentPlanDt> AccountPayablePaymentPlanDt { get; set; } = new List<AccountPayablePaymentPlanDt>();

    [ForeignKey("BankID")]
    [InverseProperty("AccountPayablePaymentPlanHd")]
    public virtual Bank? Bank { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("AccountPayablePaymentPlanHd")]
    public virtual Supplier? BusinessPartner { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("AccountPayablePaymentPlanHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("AccountPayablePaymentPlanHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
