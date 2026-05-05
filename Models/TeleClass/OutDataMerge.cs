using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class OutDataMerge
{
    [StringLength(10)]
    [Unicode(false)]
    public string? MatchType { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? SuggestedMedicalNoTo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SuggestedPatientNameTo { get; set; }

    public int? RegCountTo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? SuggestedMedicalNoFrom { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SuggestedPatientNameFrom { get; set; }

    public int? RegCountFrom { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CleanName_A { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CleanName_B { get; set; }

    public int? ScoreNamaDepan { get; set; }

    public int? ScoreNamaBelakang { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string ReasonFromSelected { get; set; } = null!;

    [StringLength(33)]
    [Unicode(false)]
    public string AlreadyInPendingMerge { get; set; } = null!;

    [StringLength(48)]
    [Unicode(false)]
    public string MergeReadinessStatus { get; set; } = null!;
}
