using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DistributionOrderNo", "SequenceNo")]
public partial class OutstandingDODt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DistributionOrderNo { get; set; } = null!;

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

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Min { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Max { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DistributionOrderNo")]
    [InverseProperty("OutstandingDODt")]
    public virtual OutstandingDOHd DistributionOrderNoNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("OutstandingDODt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("OutstandingDODt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;
}
