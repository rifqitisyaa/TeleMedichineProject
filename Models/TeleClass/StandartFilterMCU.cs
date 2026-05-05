using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class StandartFilterMCU
{
    [Key]
    public int filtercode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FilterValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ValueReference { get; set; }
}
