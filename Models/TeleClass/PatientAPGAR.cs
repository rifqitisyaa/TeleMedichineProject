using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientAPGAR
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
    public string? GCAppearanceSkinColor { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPulseHeartRate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCGrimaceReflexIrritability { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCActivityMuscleTone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRespirationBreathing { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCAPGARType { get; set; } = null!;

    public byte? APGARScore { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ScoreCategory { get; set; }

    [Unicode(false)]
    public string? Keterangan { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCAPGARType")]
    [InverseProperty("PatientAPGARGCAPGARTypeNavigation")]
    public virtual sysGeneralCode GCAPGARTypeNavigation { get; set; } = null!;

    [ForeignKey("GCActivityMuscleTone")]
    [InverseProperty("PatientAPGARGCActivityMuscleToneNavigation")]
    public virtual sysGeneralCode? GCActivityMuscleToneNavigation { get; set; }

    [ForeignKey("GCAppearanceSkinColor")]
    [InverseProperty("PatientAPGARGCAppearanceSkinColorNavigation")]
    public virtual sysGeneralCode? GCAppearanceSkinColorNavigation { get; set; }

    [ForeignKey("GCGrimaceReflexIrritability")]
    [InverseProperty("PatientAPGARGCGrimaceReflexIrritabilityNavigation")]
    public virtual sysGeneralCode? GCGrimaceReflexIrritabilityNavigation { get; set; }

    [ForeignKey("GCPulseHeartRate")]
    [InverseProperty("PatientAPGARGCPulseHeartRateNavigation")]
    public virtual sysGeneralCode? GCPulseHeartRateNavigation { get; set; }

    [ForeignKey("GCRespirationBreathing")]
    [InverseProperty("PatientAPGARGCRespirationBreathingNavigation")]
    public virtual sysGeneralCode? GCRespirationBreathingNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientAPGAR")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientAPGAR")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientAPGAR")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientAPGAR")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
