using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientProblem
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? OnsetDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCChronicity { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCProblemStatus { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? SnomedCode { get; set; }

    [Unicode(false)]
    public string? SnomedName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DiagnosisCode")]
    [InverseProperty("PatientProblem")]
    public virtual Diagnosis DiagnosisCodeNavigation { get; set; } = null!;

    [ForeignKey("GCChronicity")]
    [InverseProperty("PatientProblemGCChronicityNavigation")]
    public virtual sysGeneralCode GCChronicityNavigation { get; set; } = null!;

    [ForeignKey("GCProblemStatus")]
    [InverseProperty("PatientProblemGCProblemStatusNavigation")]
    public virtual sysGeneralCode GCProblemStatusNavigation { get; set; } = null!;

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientProblem")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;
}
