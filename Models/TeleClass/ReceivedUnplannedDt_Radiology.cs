using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ReceivedUnplannedDt_Radiology
{
    [StringLength(255)]
    public string? LocationID { get; set; }

    [StringLength(255)]
    public string? SequenceNo { get; set; }

    [StringLength(255)]
    public string? ItemID { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    [StringLength(255)]
    public string? GCItemTypeName { get; set; }

    [StringLength(255)]
    public string? ItemGroupName { get; set; }

    [StringLength(255)]
    public string? Quantity { get; set; }

    [StringLength(255)]
    public string? BaseQuantity { get; set; }

    [StringLength(255)]
    public string? ItemUnitCode { get; set; }

    [StringLength(255)]
    public string? BaseItemUnitCode { get; set; }

    [StringLength(255)]
    public string? ConversionFactor { get; set; }
}
