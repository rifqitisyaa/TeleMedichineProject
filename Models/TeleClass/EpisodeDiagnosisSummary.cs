using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class EpisodeDiagnosisSummary
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public string? DiagnosisName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateTime { get; set; }
}
