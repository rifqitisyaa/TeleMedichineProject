using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class TMPRL13FASILITASTEMPATTIDURDT
{
    public double? IdDetail { get; set; }

    public double? No { get; set; }

    [StringLength(255)]
    public string? ServiceUnitName { get; set; }

    [StringLength(255)]
    public string? ClassRS { get; set; }

    public double? JumlahTT { get; set; }
}
