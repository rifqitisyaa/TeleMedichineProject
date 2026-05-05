using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DepositPaymentDtReverse
{
    [Key]
    public long DPReverseID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DepositNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DepositReverseAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DepositNo")]
    [InverseProperty("DepositPaymentDtReverse")]
    public virtual DepositPaymentHd DepositNoNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("DepositPaymentDtReverse")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
