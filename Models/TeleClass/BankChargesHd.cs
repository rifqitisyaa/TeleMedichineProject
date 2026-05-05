using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BankChargesHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCProvider { get; set; } = null!;

    [Column(TypeName = "numeric(5, 2)")]
    public decimal BankChargesPercentage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("GCProviderNavigation")]
    public virtual ICollection<BankChargesDt> BankChargesDt { get; set; } = new List<BankChargesDt>();

    [ForeignKey("GCProvider")]
    [InverseProperty("BankChargesHd")]
    public virtual sysGeneralCode GCProviderNavigation { get; set; } = null!;
}
