using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RL311JiwaHD
{
    public double? Id { get; set; }

    public double? No { get; set; }

    [StringLength(255)]
    public string? JenisPelayanan { get; set; }

    public double? OrderNo { get; set; }
}
