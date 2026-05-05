using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class VitalSignHdFromVs3
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Source { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime VitalSignDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransferDateTime { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsRejected { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("VitalSignHdFromVs3")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [InverseProperty("VitalSignHdFromVs3")]
    public virtual ICollection<VitalSignDtFromVs3> VitalSignDtFromVs3 { get; set; } = new List<VitalSignDtFromVs3>();
}
