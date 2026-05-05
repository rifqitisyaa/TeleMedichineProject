using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatEpisodeDiagnosis
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ConditionIHSNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string EncounterIHSNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDiagnosisType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
