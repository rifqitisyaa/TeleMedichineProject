using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientGCSPediatric
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
    [InverseProperty("PatientGCSPediatricGCEyeOpeningNavigation")]
    public virtual sysGeneralCode? GCEyeOpeningNavigation { get; set; }

    [ForeignKey("GCMotorResponse")]
    [InverseProperty("PatientGCSPediatricGCMotorResponseNavigation")]
    public virtual sysGeneralCode? GCMotorResponseNavigation { get; set; }

    [ForeignKey("GCVerbalResponse")]
    [InverseProperty("PatientGCSPediatricGCVerbalResponseNavigation")]
    public virtual sysGeneralCode? GCVerbalResponseNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientGCSPediatric")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientGCSPediatric")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientGCSPediatric")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientGCSPediatric")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
