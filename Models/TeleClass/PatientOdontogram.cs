using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "GCTooth", "SequenceNo")]
public partial class PatientOdontogram
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCTooth { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TreatmentDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCToothProblem { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCToothStatus { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ProcedureCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsFirstVisit { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCPermukaanGigi { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCKeadaanGigi { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCBahanRestorasi { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCRestorasi { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCProtesa { get; set; }

    [ForeignKey("GCTooth")]
    [InverseProperty("PatientOdontogramGCToothNavigation")]
    public virtual sysGeneralCode GCToothNavigation { get; set; } = null!;

    [ForeignKey("GCToothProblem")]
    [InverseProperty("PatientOdontogramGCToothProblemNavigation")]
    public virtual sysGeneralCode? GCToothProblemNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientOdontogram")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("ProcedureCode")]
    [InverseProperty("PatientOdontogram")]
    public virtual Procedures? ProcedureCodeNavigation { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientOdontogram")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientOdontogram")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
