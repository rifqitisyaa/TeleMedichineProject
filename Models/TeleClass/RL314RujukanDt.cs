using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RL314RujukanDt
{
    [Key]
    public int IdDetail { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? No { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? SpecialtyCode { get; set; }
}
