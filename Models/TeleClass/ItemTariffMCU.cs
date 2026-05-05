using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemTariffMCU
{
    [Key]
    public int TariffId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int ItemId { get; set; }

    public int ParentItemId { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal McuPrice { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemTariffMCUItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParentItemId")]
    [InverseProperty("ItemTariffMCUParentItem")]
    public virtual Item ParentItem { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemTariffMCU")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
