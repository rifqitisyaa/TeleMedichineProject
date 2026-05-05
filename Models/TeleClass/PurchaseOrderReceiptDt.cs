using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("POReceiptNo", "SequenceNo")]
public partial class PurchaseOrderReceiptDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string POReceiptNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? PurchaseOrderNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string POSequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ReturnedQuantity { get; set; }

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
    public decimal CostAmount { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TaxPercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TaxAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountAmount { get; set; }

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

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? InvoicedQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? InvoicedAmount { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("PurchaseOrderReceiptDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("PurchaseOrderReceiptDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("POReceiptNo")]
    [InverseProperty("PurchaseOrderReceiptDt")]
    public virtual PurchaseOrderReceiptHd POReceiptNoNavigation { get; set; } = null!;

    [ForeignKey("PurchaseOrderNo")]
    [InverseProperty("PurchaseOrderReceiptDt")]
    public virtual PurchaseOrderHd? PurchaseOrderNoNavigation { get; set; }
}
