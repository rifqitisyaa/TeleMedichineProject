using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ItemID", "ParentItemID")]
public partial class ItemBomDt
{
    [Key]
    public int ItemID { get; set; }

    [Key]
    public int ParentItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveEndDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string QtyPer { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LowerQty { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal? UpperQty { get; set; }

    public int PercentageScrap { get; set; }

    public int? ServiceUnitId { get; set; }

    public bool? IsUsingAllocationPercentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? AllocationPercentageAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AllocationAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ItemBomDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParentItemID")]
    [InverseProperty("ItemBomDt")]
    public virtual ItemBomHd ParentItem { get; set; } = null!;
}
