using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Diagnosis
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string DiagnosisName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? AlternateDiagnosisName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DiagnosisNameCustom { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DTDNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ICDBlockID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InfectiousDiseaseCode { get; set; }

    public bool IsDisease { get; set; }

    public bool IsChronicDisease { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DTDNo")]
    [InverseProperty("Diagnosis")]
    public virtual DTD? DTDNoNavigation { get; set; }

    [InverseProperty("DiagnosisCodeNavigation")]
    public virtual ICollection<DiagnosisMostFrequent> DiagnosisMostFrequent { get; set; } = new List<DiagnosisMostFrequent>();

    [InverseProperty("DiagnosisCodeNavigation")]
    public virtual ICollection<EpisodeDiagnosis> EpisodeDiagnosis { get; set; } = new List<EpisodeDiagnosis>();

    [ForeignKey("ICDBlockID")]
    [InverseProperty("Diagnosis")]
    public virtual ICDBlock? ICDBlock { get; set; }

    [InverseProperty("DiagnosisCodeNavigation")]
    public virtual ICollection<InacbgSimulationDiagnose> InacbgSimulationDiagnose { get; set; } = new List<InacbgSimulationDiagnose>();

    [ForeignKey("InfectiousDiseaseCode")]
    [InverseProperty("Diagnosis")]
    public virtual InfectiousDisease? InfectiousDiseaseCodeNavigation { get; set; }

    [InverseProperty("DiagnosisCodeNavigation")]
    public virtual ICollection<JobOrderDtDiagnose> JobOrderDtDiagnose { get; set; } = new List<JobOrderDtDiagnose>();

    [InverseProperty("DiagnosisCodeNavigation")]
    public virtual ICollection<Morphology> Morphology { get; set; } = new List<Morphology>();

    [InverseProperty("DiagnosisCodeNavigation")]
    public virtual ICollection<PatientProblem> PatientProblem { get; set; } = new List<PatientProblem>();
}
