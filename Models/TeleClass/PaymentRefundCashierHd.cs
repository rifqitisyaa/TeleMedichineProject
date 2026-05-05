using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PaymentRefundCashierHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentRefundCashierNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string PaymentNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PaymentRefundDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal RefundAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
