using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class InventoryMovementStock
{
    public int? ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Unicode(false)]
    public string? ItemName1 { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? Begining_Balanace { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Qty_In { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Qty_Out { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Qty_Retur_Beli { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Qty_Retur_Jual { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Qty_Adjustment { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Qty_TO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Ending_Balance { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CurrentMaterial { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }
}
