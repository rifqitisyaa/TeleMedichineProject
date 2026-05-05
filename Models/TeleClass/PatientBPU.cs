using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientBPU
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
    public DateTime AssessmentDateTime { get; set; }

    public int ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSensoryPerception { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMoisture { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCActivity { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMobility { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCNutrition { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCFrictionAndShear { get; set; }

    public byte? Score { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ScoreCategory { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCActivity")]
    [InverseProperty("PatientBPUGCActivityNavigation")]
    public virtual sysGeneralCode? GCActivityNavigation { get; set; }

    [ForeignKey("GCFrictionAndShear")]
    [InverseProperty("PatientBPUGCFrictionAndShearNavigation")]
    public virtual sysGeneralCode? GCFrictionAndShearNavigation { get; set; }

    [ForeignKey("GCMobility")]
    [InverseProperty("PatientBPUGCMobilityNavigation")]
    public virtual sysGeneralCode? GCMobilityNavigation { get; set; }

    [ForeignKey("GCMoisture")]
    [InverseProperty("PatientBPUGCMoistureNavigation")]
    public virtual sysGeneralCode? GCMoistureNavigation { get; set; }

    [ForeignKey("GCNutrition")]
    [InverseProperty("PatientBPUGCNutritionNavigation")]
    public virtual sysGeneralCode? GCNutritionNavigation { get; set; }

    [ForeignKey("GCSensoryPerception")]
    [InverseProperty("PatientBPUGCSensoryPerceptionNavigation")]
    public virtual sysGeneralCode? GCSensoryPerceptionNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientBPU")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientBPU")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientBPU")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientBPU")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
