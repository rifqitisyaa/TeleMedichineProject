using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientGCS
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
    public string? GCEyeOpening { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCVerbalResponse { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMotorResponse { get; set; }

    public byte? GlasgowComaScale { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCEyeOpening")]
    [InverseProperty("PatientGCSGCEyeOpeningNavigation")]
    public virtual sysGeneralCode? GCEyeOpeningNavigation { get; set; }

    [ForeignKey("GCMotorResponse")]
    [InverseProperty("PatientGCSGCMotorResponseNavigation")]
    public virtual sysGeneralCode? GCMotorResponseNavigation { get; set; }

    [ForeignKey("GCVerbalResponse")]
    [InverseProperty("PatientGCSGCVerbalResponseNavigation")]
    public virtual sysGeneralCode? GCVerbalResponseNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientGCS")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientGCS")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientGCS")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientGCS")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
