using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "GCTooth", "SequenceNo")]
public partial class PatientOdontogramNew
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

    [StringLength(255)]
    [Unicode(false)]
    public string? Occlusi { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TorusPalantinus { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TorusMandibularis { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Palatum { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Diastema { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? DentalAnomaly { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Others { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Missing { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Filling { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Decay { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ConditionDesc { get; set; }

    [Column(TypeName = "image")]
    public byte[]? ImageDental { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? MoreDesc { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCSpecialCase { get; set; }

    public int? ParamedicId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PemFisOhiSequenceNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? DiastemaText { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? DentalAnomalyText { get; set; }

    [ForeignKey("GCTooth")]
    [InverseProperty("PatientOdontogramNewGCToothNavigation")]
    public virtual sysGeneralCode GCToothNavigation { get; set; } = null!;

    [ForeignKey("GCToothProblem")]
    [InverseProperty("PatientOdontogramNewGCToothProblemNavigation")]
    public virtual sysGeneralCode? GCToothProblemNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientOdontogramNew")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("ProcedureCode")]
    [InverseProperty("PatientOdontogramNew")]
    public virtual Procedures? ProcedureCodeNavigation { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientOdontogramNew")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientOdontogramNew")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
