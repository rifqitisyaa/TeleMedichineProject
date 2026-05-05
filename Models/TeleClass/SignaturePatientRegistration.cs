using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "MenuID", "SignaturePicType")]
public partial class SignaturePatientRegistration
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string SignaturePicType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? SignatureTitle { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Signature { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SignatureName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
