using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
[Index("RegistrationNo", Name = "IX_EpisodeDiagnosis_RegistrationNo")]
public partial class EpisodeDiagnosis
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int ParamedicID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDiagnosisType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCFinalStatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDifferentialStatus { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? MorphologyID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DifferentialDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinalDateTime { get; set; }

    public bool? ISOHRelatedDisease { get; set; }

    public bool? IsChronicDisease { get; set; }

    public bool? IsOldCase { get; set; }

    public bool? IsConfirmed { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DiagnosisCode")]
    [InverseProperty("EpisodeDiagnosis")]
    public virtual Diagnosis DiagnosisCodeNavigation { get; set; } = null!;

    [ForeignKey("GCDiagnosisType")]
    [InverseProperty("EpisodeDiagnosisGCDiagnosisTypeNavigation")]
    public virtual sysGeneralCode? GCDiagnosisTypeNavigation { get; set; }

    [ForeignKey("GCDifferentialStatus")]
    [InverseProperty("EpisodeDiagnosisGCDifferentialStatusNavigation")]
    public virtual sysGeneralCode? GCDifferentialStatusNavigation { get; set; }

    [ForeignKey("GCFinalStatus")]
    [InverseProperty("EpisodeDiagnosisGCFinalStatusNavigation")]
    public virtual sysGeneralCode? GCFinalStatusNavigation { get; set; }

    [ForeignKey("MorphologyID")]
    [InverseProperty("EpisodeDiagnosis")]
    public virtual Morphology? Morphology { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("EpisodeDiagnosis")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [InverseProperty("EpisodeDiagnosis")]
    public virtual PatientInfectiousDisease? PatientInfectiousDisease { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("EpisodeDiagnosis")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("EpisodeDiagnosis")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
