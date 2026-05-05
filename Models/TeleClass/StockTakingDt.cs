using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("StockTakingNo", "SequenceNo")]
public partial class StockTakingDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string StockTakingNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "numeric(5, 0)")]
    public decimal PageNumber { get; set; }

    public int ItemID { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal SystemQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal CountQty { get; set; }

    public bool IsApproved { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostAmount { get; set; }

    public bool IsAlreadyInput { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("StockTakingDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("StockTakingNo")]
    [InverseProperty("StockTakingDt")]
    public virtual StockTakingHd StockTakingNoNavigation { get; set; } = null!;
}
