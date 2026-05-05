using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GCProvider", "SequenceNo")]
public partial class BankChargesDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCProvider { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCCardType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCCardProvider { get; set; } = null!;

    [Column(TypeName = "numeric(5, 2)")]
    public decimal BankChargesPercentage { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpadateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [ForeignKey("GCCardProvider")]
    [InverseProperty("BankChargesDtGCCardProviderNavigation")]
    public virtual sysGeneralCode GCCardProviderNavigation { get; set; } = null!;

    [ForeignKey("GCCardType")]
    [InverseProperty("BankChargesDtGCCardTypeNavigation")]
    public virtual sysGeneralCode GCCardTypeNavigation { get; set; } = null!;

    [ForeignKey("GCProvider")]
    [InverseProperty("BankChargesDt")]
    public virtual BankChargesHd GCProviderNavigation { get; set; } = null!;
}
