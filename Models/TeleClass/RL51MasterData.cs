using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RL51MasterData
{
    public int? ColNo { get; set; }

    [Unicode(false)]
    public string? ColType { get; set; }

    public int? Year { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Month { get; set; }

    public int? MonthNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }
}
