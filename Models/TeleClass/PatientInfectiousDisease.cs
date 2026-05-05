using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PatientInfectiousDisease
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string InfectiousDiseaseCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InfectiousDiseaseDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("PatientInfectiousDisease")]
    public virtual EpisodeDiagnosis EpisodeDiagnosis { get; set; } = null!;

    [ForeignKey("InfectiousDiseaseCode")]
    [InverseProperty("PatientInfectiousDisease")]
    public virtual InfectiousDisease InfectiousDiseaseCodeNavigation { get; set; } = null!;

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientInfectiousDisease")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;
}
