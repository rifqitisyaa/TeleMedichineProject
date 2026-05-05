using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientCAPPIRO
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

    public bool? IsCOPD { get; set; }

    public bool? IsAgeAbove70 { get; set; }

    public bool? IsBacteremia { get; set; }

    public bool? IsShock { get; set; }

    public bool? IsAcuteRenalFailure { get; set; }

    public bool? IsMultilobalOpacities { get; set; }

    public bool? IsSevereHypoxemia { get; set; }

    public bool? IsARDS { get; set; }

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

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientCAPPIRO")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientCAPPIRO")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientCAPPIRO")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientCAPPIRO")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
