using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
[Table("ItemLoincUpload$")]
public partial class ItemLoincUpload_
{
    public double? ItemID { get; set; }

    [StringLength(255)]
    public string? LoincCode { get; set; }

    [StringLength(255)]
    public string? LoincName { get; set; }

    [StringLength(255)]
    public string? category { get; set; }

    [StringLength(255)]
    public string? JenisPanel { get; set; }

    public double? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedDateTime { get; set; }

    [StringLength(255)]
    public string? F9 { get; set; }
}
