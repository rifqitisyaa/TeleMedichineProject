using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceOrderNo", "SequenceNo")]
public partial class ServiceOrderDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ServiceOrderNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ServiceOrderRequestNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? SORequestSequenceNo { get; set; }

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

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
    public decimal? CostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountAmount { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TaxPercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TaxAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ServiceOrderDt")]
    public virtual ICollection<AssetExpense> AssetExpense { get; set; } = new List<AssetExpense>();

    [ForeignKey("ItemID")]
    [InverseProperty("ServiceOrderDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("ServiceOrderDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("ServiceOrderNo")]
    [InverseProperty("ServiceOrderDt")]
    public virtual ServiceOrderHd ServiceOrderNoNavigation { get; set; } = null!;

    [ForeignKey("ServiceOrderRequestNo, SORequestSequenceNo")]
    [InverseProperty("ServiceOrderDt")]
    public virtual ServiceOrderRequestDt? ServiceOrderRequestDt { get; set; }
}
