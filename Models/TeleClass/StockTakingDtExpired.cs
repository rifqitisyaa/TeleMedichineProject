using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("StockTakingNo", "SequenceNo", "DetailNumber")]
public partial class StockTakingDtExpired
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string StockTakingNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string DetailNumber { get; set; } = null!;

    public int ItemID { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal CountQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
