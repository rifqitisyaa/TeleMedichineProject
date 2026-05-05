using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "ResumeType", "JobOrderNo", "SequenceNo", "ItemID")]
public partial class PatientResumeDtCPOE
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ResumeType { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Unicode(false)]
    public string? ResultValue { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, ResumeType")]
    [InverseProperty("PatientResumeDtCPOE")]
    public virtual PatientResumeHd PatientResumeHd { get; set; } = null!;
}
