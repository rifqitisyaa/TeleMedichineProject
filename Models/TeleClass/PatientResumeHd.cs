using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "ResumeType")]
public partial class PatientResumeHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ResumeType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("PatientResumeHd")]
    public virtual ICollection<PatientResumeDtCPOE> PatientResumeDtCPOE { get; set; } = new List<PatientResumeDtCPOE>();

    [InverseProperty("PatientResumeHd")]
    public virtual PatientResumeDtNotes? PatientResumeDtNotes { get; set; }
}
