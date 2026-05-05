using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "ItemID", "ItemUnitCode")]
public partial class ItemPurchasePrice
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? LastPrice { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? LastDiscount1Percentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? LastDiscount2Percentage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("ItemPurchasePrice")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemPurchasePrice")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
