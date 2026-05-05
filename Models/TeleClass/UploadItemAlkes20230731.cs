using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class UploadItemAlkes20230731
{
    [StringLength(255)]
    public string? ItemId { get; set; }

    [StringLength(255)]
    public string? ItemCode { get; set; }

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
}
