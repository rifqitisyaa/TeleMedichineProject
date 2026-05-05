using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpDoubleUpdate
{
    public double? ItemId { get; set; }

    [StringLength(255)]
    public string? ItemName1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? QtyOnHand { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Mutasi { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? StockAwal { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? StockAkhir { get; set; }
}
