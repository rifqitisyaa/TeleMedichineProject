using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ItemInventoryHistory
{
    public int? TransactionHistoryID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionSource { get; set; }

    public int? LocationID { get; set; }

    public int? ItemID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? QuantityChange { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? EndingBalanceLocation { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? BeginingBalanceLocation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ItemHistoryInjectDate { get; set; }
}
