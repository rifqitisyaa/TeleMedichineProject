using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class StewardScoreAnak
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Kesadaran { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Respirasi { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AktivitasMotorik { get; set; }

    public int? ScoreSteward { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JamPascaAnesthesi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JamPindahRuangRawat { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? KesimpulanScore { get; set; }
}
