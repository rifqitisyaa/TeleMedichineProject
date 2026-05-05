using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_PurchaseOrder
{
    [StringLength(20)]
    [Unicode(false)]
    public string PurchaseOrderNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SiteName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PurchaseOrderDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ItemType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Supplier { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnit { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Location { get; set; }

    public DateOnly? POReleaseDate { get; set; }

    public DateOnly? PODueDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Term { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Notes { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBy1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBy2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QuantityOrder { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? QuantityReceipt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemUnit { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Discount1Percentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Discount2Percentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalDiscountAmount { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TaxPercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TaxAmount { get; set; }

    public bool IsClosed { get; set; }

    public bool IsDeleted { get; set; }
}
