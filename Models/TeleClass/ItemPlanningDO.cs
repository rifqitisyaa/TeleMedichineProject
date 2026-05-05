using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "LocationID", "ItemID")]
public partial class ItemPlanningDO
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int LocationID { get; set; }

    [Key]
    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal MinOrderQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal MaxOrderQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ItemPlanningDO")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("LocationID")]
    [InverseProperty("ItemPlanningDO")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemPlanningDO")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
