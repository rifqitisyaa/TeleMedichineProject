using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class sidilanTable
{
    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? TotalRow { get; set; }

    [StringLength(255)]
    public string? Type { get; set; }

    [StringLength(255)]
    public string? InjectedData { get; set; }

    [StringLength(255)]
    public string? Index { get; set; }
}
