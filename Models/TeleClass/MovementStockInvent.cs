using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class MovementStockInvent
{
    public int ItemID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName1 { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Begining_Balance { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Qty_In { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Qty_Out { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Qty_Retur_Beli { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Qty_Retur_Jual { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Qty_Adjustment { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Qty_TO { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Ending_Balance { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CurrentMaterial { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime transacDate { get; set; }
}
