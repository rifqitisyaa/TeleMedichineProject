using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PaymentRefundMedication
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentRefundNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPaymentType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRefundType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PaymentRefundDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal RefundAmount { get; set; }

    public int? BankID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReferenceTransferBank { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReferenceTransferDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenceTransferNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransferBankAccountNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransferBankAccountName { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BankID")]
    [InverseProperty("PaymentRefundMedication")]
    public virtual Bank? Bank { get; set; }

    [ForeignKey("GCReferenceTransferBank")]
    [InverseProperty("PaymentRefundMedication")]
    public virtual sysGeneralCode? GCReferenceTransferBankNavigation { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PaymentRefundMedication")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PaymentRefundMedication")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("PaymentRefundMedication")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
