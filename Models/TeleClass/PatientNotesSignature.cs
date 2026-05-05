using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "SignaturePicType")]
public partial class PatientNotesSignature
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
    [StringLength(100)]
    [Unicode(false)]
    public string SignaturePicType { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? SignaturePicTypeName { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Signature { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? SignaturePicName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
