using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpStockLab
{
    public double? itemid { get; set; }

    [StringLength(255)]
    public string? Type { get; set; }

    [StringLength(255)]
    public string? ItemGroupname1 { get; set; }

    [StringLength(255)]
    public string? ItemName1 { get; set; }

    [StringLength(255)]
    public string? BaseUnitCode { get; set; }

    [StringLength(255)]
    public string? Satuan { get; set; }

    [StringLength(255)]
    public string? Qty { get; set; }

    [StringLength(255)]
    public string? Cost { get; set; }
}
