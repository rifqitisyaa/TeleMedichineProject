using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CreditNote
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string CreditNoteNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly CreditNoteDate { get; set; }

    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RetunToSupplierNo { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OutstandingAmount { get; set; }

    public byte? RevisionNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SupplierDocumentNo { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool IsPrinted { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("CreditNoteNoNavigation")]
    public virtual ICollection<AccountPayableDtCreditNote> AccountPayableDtCreditNote { get; set; } = new List<AccountPayableDtCreditNote>();

    [InverseProperty("CreditNoteNoNavigation")]
    public virtual ICollection<AccountPayablePaymentPlanDtCreditNote> AccountPayablePaymentPlanDtCreditNote { get; set; } = new List<AccountPayablePaymentPlanDtCreditNote>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("CreditNote")]
    public virtual Supplier BusinessPartner { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("CreditNote")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("CreditNote")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
