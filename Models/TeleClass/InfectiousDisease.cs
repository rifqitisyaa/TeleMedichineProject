using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class InfectiousDisease
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string InfectiousDiseaseCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string InfectiousDiseaseName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string CausativeAgent { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string InfectiousDiseaseLabel { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCInfectiousDiseaseType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCInfectiousDiseaseCategory { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("InfectiousDiseaseCodeNavigation")]
    public virtual ICollection<Diagnosis> Diagnosis { get; set; } = new List<Diagnosis>();

    [InverseProperty("InfectiousDiseaseCodeNavigation")]
    public virtual ICollection<DiagnosisTB> DiagnosisTB { get; set; } = new List<DiagnosisTB>();

    [ForeignKey("GCInfectiousDiseaseCategory")]
    [InverseProperty("InfectiousDiseaseGCInfectiousDiseaseCategoryNavigation")]
    public virtual sysGeneralCode? GCInfectiousDiseaseCategoryNavigation { get; set; }

    [ForeignKey("GCInfectiousDiseaseType")]
    [InverseProperty("InfectiousDiseaseGCInfectiousDiseaseTypeNavigation")]
    public virtual sysGeneralCode? GCInfectiousDiseaseTypeNavigation { get; set; }

    [InverseProperty("InfectiousDiseaseCodeNavigation")]
    public virtual ICollection<PatientInfectiousDisease> PatientInfectiousDisease { get; set; } = new List<PatientInfectiousDisease>();
}
