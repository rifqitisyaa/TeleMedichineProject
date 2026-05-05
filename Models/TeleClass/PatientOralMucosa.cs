using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientOralMucosa
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCOralMucosa { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TreatmentDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ProcedureCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCOralMucosa")]
    [InverseProperty("PatientOralMucosa")]
    public virtual sysGeneralCode GCOralMucosaNavigation { get; set; } = null!;

    [ForeignKey("ProcedureCode")]
    [InverseProperty("PatientOralMucosa")]
    public virtual Procedures ProcedureCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientOralMucosa")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientOralMucosa")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
