using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
[Table("Sheet1$")]
public partial class Sheet1_
{
    [StringLength(255)]
    public string? Title { get; set; }

    public double? IsHeader { get; set; }

    [StringLength(255)]
    public string? ControlType { get; set; }

    public double? IsBold { get; set; }

    public double? IsActive { get; set; }

    public double? OrderNo { get; set; }

    public double? HeaderId { get; set; }
}
