using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionNo", "SequenceNo", "ItemID")]
public partial class TransactionChargesDtBOM
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    public int? ParentItemID { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? QtyTaken { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostPrice { get; set; }

    public int? ServiceUnitId { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("TransactionChargesDtBOMItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParentItemID")]
    [InverseProperty("TransactionChargesDtBOMParentItem")]
    public virtual Item? ParentItem { get; set; }

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("TransactionChargesDtBOM")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("TransactionNo, SequenceNo")]
    [InverseProperty("TransactionChargesDtBOM")]
    public virtual TransactionChargesDt TransactionChargesDt { get; set; } = null!;
}
