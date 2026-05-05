using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionNo", "SequenceNo")]
public partial class ItemTransactionMcuDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemId { get; set; }

    public int? ServiceUnitId { get; set; }

    public int? ParamedicId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AllocateRevenuePrice { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ReasonOfCancel { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Qty { get; set; }

    public bool? IsVerifiedRevenue { get; set; }

    public bool IsRealization { get; set; }

    public bool IsCancel { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemTransactionMcuDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParamedicId")]
    [InverseProperty("ItemTransactionMcuDt")]
    public virtual Paramedic? Paramedic { get; set; }

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("ItemTransactionMcuDt")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("TransactionNo")]
    [InverseProperty("ItemTransactionMcuDt")]
    public virtual ItemTransactionMcuHd TransactionNoNavigation { get; set; } = null!;
}
