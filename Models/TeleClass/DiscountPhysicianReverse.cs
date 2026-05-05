using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DiscountPhysicianReverse
{
    [Key]
    public long DiscReverseID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DiscountPhysicianNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string PaymentNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountReverseAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DiscountPhysicianNo")]
    [InverseProperty("DiscountPhysicianReverse")]
    public virtual DiscountPhysician DiscountPhysicianNoNavigation { get; set; } = null!;

    [ForeignKey("PaymentNo")]
    [InverseProperty("DiscountPhysicianReverse")]
    public virtual AccountReceivablePaymentHd PaymentNoNavigation { get; set; } = null!;
}
