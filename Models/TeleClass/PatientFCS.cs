using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientFCS
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
    public string? GCEyeResponse { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMotorResponseFCS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBrainstemReflexes { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRespirationFCS { get; set; }

    public byte? FourCommaScale { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCBrainstemReflexes")]
    [InverseProperty("PatientFCSGCBrainstemReflexesNavigation")]
    public virtual sysGeneralCode? GCBrainstemReflexesNavigation { get; set; }

    [ForeignKey("GCEyeResponse")]
    [InverseProperty("PatientFCSGCEyeResponseNavigation")]
    public virtual sysGeneralCode? GCEyeResponseNavigation { get; set; }

    [ForeignKey("GCMotorResponseFCS")]
    [InverseProperty("PatientFCSGCMotorResponseFCSNavigation")]
    public virtual sysGeneralCode? GCMotorResponseFCSNavigation { get; set; }

    [ForeignKey("GCRespirationFCS")]
    [InverseProperty("PatientFCSGCRespirationFCSNavigation")]
    public virtual sysGeneralCode? GCRespirationFCSNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientFCS")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientFCS")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientFCS")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientFCS")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
