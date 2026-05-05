using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class CirculationChart
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PainonPassive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LossDecrease { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TenseSwelling { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ChangesInColor { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ChangesInTemp { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AbsenceOfPulse { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ParalysisParesis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Unicode(false)]
    public string? Noted { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
