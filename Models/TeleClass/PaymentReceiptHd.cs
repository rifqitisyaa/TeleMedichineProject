using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PaymentReceiptHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentReceiptNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PaymentReceiptDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentReceiptAmount { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string OnBehalfOf { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("PaymentReceiptNoNavigation")]
    public virtual ICollection<PaymentReceiptDt> PaymentReceiptDt { get; set; } = new List<PaymentReceiptDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("PaymentReceiptHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("PaymentReceiptHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
