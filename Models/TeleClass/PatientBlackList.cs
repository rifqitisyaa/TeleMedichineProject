using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientBlackList
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
    public DateTime BlackListDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string BlackListBy { get; set; } = null!;

    [Unicode(false)]
    public string BlackListReason { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? UnBlackListDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? UnBlackListBy { get; set; }

    [Unicode(false)]
    public string? UnBlackListReason { get; set; }

    public bool IsBlackList { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientBlackList")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;
}
