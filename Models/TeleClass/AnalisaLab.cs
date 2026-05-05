using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class AnalisaLab
{
    [StringLength(200)]
    [Unicode(false)]
    public string? nama { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }
}
