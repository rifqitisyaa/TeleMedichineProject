using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PaymentReceiptNo", "SequenceNo")]
public partial class PaymentReceiptDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentReceiptNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCPaymentType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCPaymentType")]
    [InverseProperty("PaymentReceiptDt")]
    public virtual sysGeneralCode GCPaymentTypeNavigation { get; set; } = null!;

    [ForeignKey("PaymentReceiptNo")]
    [InverseProperty("PaymentReceiptDt")]
    public virtual PaymentReceiptHd PaymentReceiptNoNavigation { get; set; } = null!;
}
