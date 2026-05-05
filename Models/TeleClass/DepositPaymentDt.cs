using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DepositNo", "SequenceNo")]
public partial class DepositPaymentDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DepositNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPaymentMethod { get; set; }

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

    [StringLength(100)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsReconciliation { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BankID")]
    [InverseProperty("DepositPaymentDt")]
    public virtual Bank? Bank { get; set; }

    [ForeignKey("DepositNo")]
    [InverseProperty("DepositPaymentDt")]
    public virtual DepositPaymentHd DepositNoNavigation { get; set; } = null!;

    [ForeignKey("GCCardProvider")]
    [InverseProperty("DepositPaymentDtGCCardProviderNavigation")]
    public virtual sysGeneralCode? GCCardProviderNavigation { get; set; }

    [ForeignKey("GCCardType")]
    [InverseProperty("DepositPaymentDtGCCardTypeNavigation")]
    public virtual sysGeneralCode? GCCardTypeNavigation { get; set; }

    [ForeignKey("GCPaymentMethod")]
    [InverseProperty("DepositPaymentDtGCPaymentMethodNavigation")]
    public virtual sysGeneralCode? GCPaymentMethodNavigation { get; set; }
}
