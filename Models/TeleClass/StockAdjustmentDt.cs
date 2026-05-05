using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AdjustmentNo", "SequenceNo")]
public partial class StockAdjustmentDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AdjustmentNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string BaseItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal BaseQuantity { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AdjustmentNo")]
    [InverseProperty("StockAdjustmentDt")]
    public virtual StockAdjustmentHd AdjustmentNoNavigation { get; set; } = null!;

    [ForeignKey("BaseItemUnitCode")]
    [InverseProperty("StockAdjustmentDtBaseItemUnitCodeNavigation")]
    public virtual ItemUnit BaseItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("StockAdjustmentDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("StockAdjustmentDtItemUnitCodeNavigation")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;
}
