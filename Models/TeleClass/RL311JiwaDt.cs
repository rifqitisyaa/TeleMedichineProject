using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RL311JiwaDt
{
    public double? IdDetail { get; set; }

    public double? No { get; set; }

    [StringLength(255)]
    public string? ItemCode { get; set; }
}
