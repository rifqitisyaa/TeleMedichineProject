using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "DiagnosisCode")]
public partial class InacbgSimulationDiagnose
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? DiagnosisStatus { get; set; }

    public int? Severity { get; set; }

    [Unicode(false)]
    public string? InpatientGroup { get; set; }

    [Unicode(false)]
    public string? OutpatientGroup { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DiagnosisCode")]
    [InverseProperty("InacbgSimulationDiagnose")]
    public virtual Diagnosis DiagnosisCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("InacbgSimulationDiagnose")]
    public virtual InacbgSimulation InacbgSimulation { get; set; } = null!;
}
