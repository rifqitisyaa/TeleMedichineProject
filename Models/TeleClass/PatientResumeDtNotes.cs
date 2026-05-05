using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "ResumeType")]
public partial class PatientResumeDtNotes
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ResumeType { get; set; } = null!;

    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDischargeNotes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AppointmentDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, ResumeType")]
    [InverseProperty("PatientResumeDtNotes")]
    public virtual PatientResumeHd PatientResumeHd { get; set; } = null!;
}
