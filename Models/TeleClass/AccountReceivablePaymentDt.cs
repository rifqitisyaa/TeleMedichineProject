using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PaymentNo", "SequenceNo")]
public partial class AccountReceivablePaymentDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCPaymentMethod { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCardProvider { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCardType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EDCMachineCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CardHolderName { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CardFeeAmount { get; set; }

    public int? BankID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

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

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AuthorizedNo { get; set; }

    public bool? IsReconciliation { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReason { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DiscountReason { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BankID")]
    [InverseProperty("AccountReceivablePaymentDt")]
    public virtual Bank? Bank { get; set; }

    [ForeignKey("EDCMachineCode")]
    [InverseProperty("AccountReceivablePaymentDt")]
    public virtual EDCMachine? EDCMachineCodeNavigation { get; set; }

    [ForeignKey("GCCardProvider")]
    [InverseProperty("AccountReceivablePaymentDtGCCardProviderNavigation")]
    public virtual sysGeneralCode? GCCardProviderNavigation { get; set; }

    [ForeignKey("GCCardType")]
    [InverseProperty("AccountReceivablePaymentDtGCCardTypeNavigation")]
    public virtual sysGeneralCode? GCCardTypeNavigation { get; set; }

    [ForeignKey("GCPaymentMethod")]
    [InverseProperty("AccountReceivablePaymentDtGCPaymentMethodNavigation")]
    public virtual sysGeneralCode GCPaymentMethodNavigation { get; set; } = null!;

    [ForeignKey("GCReferenceTransferBank")]
    [InverseProperty("AccountReceivablePaymentDtGCReferenceTransferBankNavigation")]
    public virtual sysGeneralCode? GCReferenceTransferBankNavigation { get; set; }

    [ForeignKey("PaymentNo")]
    [InverseProperty("AccountReceivablePaymentDt")]
    public virtual AccountReceivablePaymentHd PaymentNoNavigation { get; set; } = null!;
}
