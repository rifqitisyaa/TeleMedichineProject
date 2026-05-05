using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("IssuedUnplannedNo", "SequenceNo")]
public partial class IssuedUnplannedDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string IssuedUnplannedNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal BaseQuantity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string BaseItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

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

    [ForeignKey("BaseItemUnitCode")]
    [InverseProperty("IssuedUnplannedDtBaseItemUnitCodeNavigation")]
    public virtual ItemUnit BaseItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("IssuedUnplannedNo")]
    [InverseProperty("IssuedUnplannedDt")]
    public virtual IssuedUnplannedHd IssuedUnplannedNoNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("IssuedUnplannedDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("IssuedUnplannedDtItemUnitCodeNavigation")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;
}
