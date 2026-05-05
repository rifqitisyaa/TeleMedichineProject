using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SampleID", "SequenceNo")]
public partial class TatBarcodeScan
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    public int SampleID { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? Barcode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ScannedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScannedDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("TatBarcodeScan")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SampleID")]
    [InverseProperty("TatBarcodeScan")]
    public virtual Sample Sample { get; set; } = null!;
}
