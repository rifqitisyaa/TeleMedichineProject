using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("LocationID", "ItemID")]
public partial class ItemInventory
{
    [Key]
    public int LocationID { get; set; }

    [Key]
    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyOnHand { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyOnRequest { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyOnGIT { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyOnOrder { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyAllocate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ItemInventory")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("LocationID")]
    [InverseProperty("ItemInventory")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemInventory")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
