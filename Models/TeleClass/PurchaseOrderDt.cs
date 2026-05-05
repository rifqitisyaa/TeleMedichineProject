using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PurchaseOrderNo", "SequenceNo")]
public partial class PurchaseOrderDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PurchaseOrderNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    public DateOnly? POReleaseDate { get; set; }

    public DateOnly? PODueDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? QuantityCalculation { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QuantityOrder { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? QuantityReceipt { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Discount1Percentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Discount2Percentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PriceBefore { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Discount1PercentageBefore { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Discount2PercentageBefore { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TaxPercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TaxAmount { get; set; }

    [Unicode(false)]
    public string? ReasonNotes { get; set; }

    public bool IsBonusItem { get; set; }

    public bool IsClosed { get; set; }

    public bool? IsTariffChange { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("PurchaseOrderDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("PurchaseOrderDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("PurchaseOrderNo")]
    [InverseProperty("PurchaseOrderDt")]
    public virtual PurchaseOrderHd PurchaseOrderNoNavigation { get; set; } = null!;
}
