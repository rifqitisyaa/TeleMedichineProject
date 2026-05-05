using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PemeriksaanFisikOHIS
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? DebrisBodySiteSnomedCode { get; set; }

    [Unicode(false)]
    public string? DebrisBodySiteSnomedName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DebrisValueCode { get; set; }

    [Unicode(false)]
    public string? DebrisValueName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DebrisIndeksScore { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KalkulusBodySiteSnomedCode { get; set; }

    [Unicode(false)]
    public string? KalkulusBodySiteSnomedName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KalkulusValueCode { get; set; }

    [Unicode(false)]
    public string? KalkulusValueName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KalkulusIndeksScore { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OHISInterpretationCode { get; set; }

    [Unicode(false)]
    public string? OHISInterpretationName { get; set; }

    [Unicode(false)]
    public string? OHISInterpretationText { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TotalScoreOHIS { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
