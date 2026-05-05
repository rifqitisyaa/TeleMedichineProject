using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Patient_Payment
{
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PaymentDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BusinessPartnerCode { get; set; }

    public bool IsForceClose { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? OnBehalfOf { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? PaymentMethodName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PaymentMethodName2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CardProviderName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CardProviderName2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CardTypeName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CardTypeName2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EDCMachineCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CardHolderName { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CardFeeAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BankCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferenceTransferBankName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferenceTransferBankName2 { get; set; }

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

    public bool IsDeletedDetil { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedByDetil { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTimeDetil { get; set; }
}
