using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientCHDRisk
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
    public DateTime? AssessmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    public int? Age { get; set; }

    public int? LDLValue { get; set; }

    public int? CholesterolValue { get; set; }

    public int? HDLValue { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSystolic { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDiastolic { get; set; }

    public int? DiabetesValue { get; set; }

    public int? SmokerValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CHDRiskValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CholesterolValue")]
    [InverseProperty("PatientCHDRiskCholesterolValueNavigation")]
    public virtual CHDPredictor? CholesterolValueNavigation { get; set; }

    [ForeignKey("DiabetesValue")]
    [InverseProperty("PatientCHDRiskDiabetesValueNavigation")]
    public virtual CHDPredictor? DiabetesValueNavigation { get; set; }

    [ForeignKey("GCDiastolic")]
    [InverseProperty("PatientCHDRiskGCDiastolicNavigation")]
    public virtual sysGeneralCode? GCDiastolicNavigation { get; set; }

    [ForeignKey("GCSystolic")]
    [InverseProperty("PatientCHDRiskGCSystolicNavigation")]
    public virtual sysGeneralCode? GCSystolicNavigation { get; set; }

    [ForeignKey("HDLValue")]
    [InverseProperty("PatientCHDRiskHDLValueNavigation")]
    public virtual CHDPredictor? HDLValueNavigation { get; set; }

    [ForeignKey("LDLValue")]
    [InverseProperty("PatientCHDRiskLDLValueNavigation")]
    public virtual CHDPredictor? LDLValueNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientCHDRisk")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientCHDRisk")]
    public virtual Paramedic? Paramedic { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientCHDRisk")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientCHDRisk")]
    public virtual Site? SiteCodeNavigation { get; set; }

    [ForeignKey("SmokerValue")]
    [InverseProperty("PatientCHDRiskSmokerValueNavigation")]
    public virtual CHDPredictor? SmokerValueNavigation { get; set; }
}
