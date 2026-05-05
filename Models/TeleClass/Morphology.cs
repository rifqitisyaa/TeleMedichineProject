using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Morphology
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MorphologyID { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? DiagnosisCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string MorphologyName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DiagnosisCode")]
    [InverseProperty("Morphology")]
    public virtual Diagnosis? DiagnosisCodeNavigation { get; set; }

    [InverseProperty("Morphology")]
    public virtual ICollection<EpisodeDiagnosis> EpisodeDiagnosis { get; set; } = new List<EpisodeDiagnosis>();
}
