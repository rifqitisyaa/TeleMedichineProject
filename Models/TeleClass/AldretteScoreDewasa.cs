using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class AldretteScoreDewasa
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

    [Column(TypeName = "datetime")]
    public DateTime? JamPascaAnesthesi { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Sirkulasi { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Kesadaran { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Respirasi { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? WarnaKulit { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Ekstrimitas { get; set; }

    public int? ScoreAldrtett { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JamPindahRuang { get; set; }

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
