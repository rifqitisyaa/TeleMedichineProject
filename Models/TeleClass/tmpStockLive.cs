using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpStockLive
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

    public double? Qty { get; set; }

    [StringLength(255)]
    public string? Cost { get; set; }

    [StringLength(255)]
    public string? F9 { get; set; }

    [StringLength(255)]
    public string? F10 { get; set; }

    [StringLength(255)]
    public string? F11 { get; set; }

    [StringLength(255)]
    public string? F12 { get; set; }

    [StringLength(255)]
    public string? F13 { get; set; }

    [StringLength(255)]
    public string? F14 { get; set; }

    [StringLength(255)]
    public string? F15 { get; set; }

    [StringLength(255)]
    public string? F16 { get; set; }

    [StringLength(255)]
    public string? F17 { get; set; }

    [StringLength(255)]
    public string? F18 { get; set; }

    [StringLength(255)]
    public string? F19 { get; set; }

    [StringLength(255)]
    public string? F20 { get; set; }

    [StringLength(255)]
    public string? F21 { get; set; }

    [StringLength(255)]
    public string? F22 { get; set; }

    [StringLength(255)]
    public string? F23 { get; set; }

    [StringLength(255)]
    public string? F24 { get; set; }

    [StringLength(255)]
    public string? F25 { get; set; }

    [StringLength(255)]
    public string? F26 { get; set; }
}
