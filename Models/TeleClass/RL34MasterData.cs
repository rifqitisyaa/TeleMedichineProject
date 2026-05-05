using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RL34MasterData
{
    public int? ColNo { get; set; }

    [Unicode(false)]
    public string? ColType { get; set; }

    public int? Year { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DiagnosisCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }
}
