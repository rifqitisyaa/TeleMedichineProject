using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PaymentNo", "ARNo", "ARANo")]
public partial class AccountReceivablePaymentReg
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ARNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ARANo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ARANo")]
    [InverseProperty("AccountReceivablePaymentReg")]
    public virtual AccountReceivableAccrual ARANoNavigation { get; set; } = null!;

    [ForeignKey("ARNo")]
    [InverseProperty("AccountReceivablePaymentReg")]
    public virtual AccountReceivableHd ARNoNavigation { get; set; } = null!;

    [ForeignKey("PaymentNo")]
    [InverseProperty("AccountReceivablePaymentReg")]
    public virtual AccountReceivablePaymentHd PaymentNoNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("AccountReceivablePaymentReg")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
