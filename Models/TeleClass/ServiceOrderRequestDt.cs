using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceOrderRequestNo", "SequenceNo")]
public partial class ServiceOrderRequestDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ServiceOrderRequestNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    public DateOnly? DueDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QuantityOrder { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? QuantityRealized { get; set; }

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

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ReferenceSequence { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsClosed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ServiceOrderRequestDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("ServiceOrderRequestDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [InverseProperty("ServiceOrderRequestDt")]
    public virtual ICollection<ServiceOrderDt> ServiceOrderDt { get; set; } = new List<ServiceOrderDt>();

    [ForeignKey("ServiceOrderRequestNo")]
    [InverseProperty("ServiceOrderRequestDt")]
    public virtual ServiceOrderRequestHd ServiceOrderRequestNoNavigation { get; set; } = null!;
}
