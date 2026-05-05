using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "VitalSignCodeVs3")]
public partial class VitalSignDtFromVs3
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCodeVs3 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? VitalSignCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignValue { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NormalValue { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SampleType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceTransactionNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ReferenceTransactionSequenceNo { get; set; }

    public bool IsRejected { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("VitalSignCode")]
    [InverseProperty("VitalSignDtFromVs3")]
    public virtual VitalSignType? VitalSignCodeNavigation { get; set; }

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("VitalSignDtFromVs3")]
    public virtual VitalSignHdFromVs3 VitalSignHdFromVs3 { get; set; } = null!;
}
