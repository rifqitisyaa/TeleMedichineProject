using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AccountPayableHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string APNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Source { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SupplierInvoiceNo { get; set; }

    public DateOnly? SupplierInvoiceDate { get; set; }

    public int? PORLocation { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SupplierTaxNo { get; set; }

    public DateOnly? SupplierTaxDate { get; set; }

    public DateOnly APDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TermOfPayment { get; set; } = null!;

    public DateOnly APDueDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? APAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalDiscount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CorrectionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PaymentAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CreditNoteAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCIncomeTaxName { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? IncomeTaxPercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? IncomeTaxAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DPAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DpTaxAmount { get; set; }

    public bool? IsApproved { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("APNoNavigation")]
    public virtual ICollection<AccountPayableDtAccrual> AccountPayableDtAccrual { get; set; } = new List<AccountPayableDtAccrual>();

    [InverseProperty("APNoNavigation")]
    public virtual ICollection<AccountPayableDtCreditNote> AccountPayableDtCreditNote { get; set; } = new List<AccountPayableDtCreditNote>();

    [InverseProperty("APNoNavigation")]
    public virtual ICollection<AccountPayablePaymentPlanDt> AccountPayablePaymentPlanDt { get; set; } = new List<AccountPayablePaymentPlanDt>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("AccountPayableHd")]
    public virtual Supplier BusinessPartner { get; set; } = null!;

    [InverseProperty("APNoNavigation")]
    public virtual ICollection<DownPaymentReverse> DownPaymentReverse { get; set; } = new List<DownPaymentReverse>();

    [ForeignKey("GCIncomeTaxName")]
    [InverseProperty("AccountPayableHd")]
    public virtual sysGeneralCode? GCIncomeTaxNameNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("AccountPayableHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TermOfPayment")]
    [InverseProperty("AccountPayableHd")]
    public virtual Term TermOfPaymentNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("AccountPayableHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
