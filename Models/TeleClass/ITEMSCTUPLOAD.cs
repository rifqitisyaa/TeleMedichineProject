using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ITEMSCTUPLOAD
{
    public double? ItemId { get; set; }

    [StringLength(255)]
    public string? ItemName { get; set; }

    public double? SctCode { get; set; }

    [StringLength(255)]
    public string? SctName { get; set; }

    [StringLength(255)]
    public string? Category { get; set; }

    [StringLength(255)]
    public string? JenisPanel { get; set; }

    public double? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedByDateTime { get; set; }
}
