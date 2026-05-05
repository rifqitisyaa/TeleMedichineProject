using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class TempOpeningBalance
{
    [StringLength(255)]
    public string? coacode { get; set; }

    [StringLength(255)]
    public string? coaname { get; set; }

    [StringLength(255)]
    public string? NormalPosition { get; set; }

    public double? amount { get; set; }
}
