using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RecalculationNo", "TransactionNo", "SequenceNo", "ItemID")]
public partial class RecalculationDtBom
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RecalculationNo { get; set; } = null!;

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

    [StringLength(5)]
    [Unicode(false)]
    public string RecalculationSequenceNo { get; set; } = null!;

    public int? ParentItemID { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? QtyTaken { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CostPrice { get; set; }

    public int? ServiceUnitIdBefore { get; set; }

    public int? ServiceUnitIdAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmountBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmountAfter { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("RecalculationDtBomItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParentItemID")]
    [InverseProperty("RecalculationDtBomParentItem")]
    public virtual Item? ParentItem { get; set; }

    [ForeignKey("RecalculationNo")]
    [InverseProperty("RecalculationDtBom")]
    public virtual RecalculationHd RecalculationNoNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitIdAfter")]
    [InverseProperty("RecalculationDtBomServiceUnitIdAfterNavigation")]
    public virtual DepartmentServiceUnit? ServiceUnitIdAfterNavigation { get; set; }

    [ForeignKey("ServiceUnitIdBefore")]
    [InverseProperty("RecalculationDtBomServiceUnitIdBeforeNavigation")]
    public virtual DepartmentServiceUnit? ServiceUnitIdBeforeNavigation { get; set; }

    [ForeignKey("TransactionNo, SequenceNo")]
    [InverseProperty("RecalculationDtBom")]
    public virtual TransactionChargesDt TransactionChargesDt { get; set; } = null!;
}
