using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo", "ItemID")]
public partial class JobOrderBOMLaboratory
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResultDateTime { get; set; }

    public int? ParentItemID { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? QtyTaken { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostPrice { get; set; }

    public int? PositionIndexNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ResultValue { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NormalValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResultValueIndicator { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CriticalIndicator { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public int? AssetsID { get; set; }

    public bool IsCancel { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetsID")]
    [InverseProperty("JobOrderBOMLaboratory")]
    public virtual Assets? Assets { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("JobOrderBOMLaboratoryItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("JobOrderNo, SequenceNo")]
    [InverseProperty("JobOrderBOMLaboratory")]
    public virtual JobOrderDt JobOrderDt { get; set; } = null!;

    [ForeignKey("ParentItemID")]
    [InverseProperty("JobOrderBOMLaboratoryParentItem")]
    public virtual Item? ParentItem { get; set; }
}
