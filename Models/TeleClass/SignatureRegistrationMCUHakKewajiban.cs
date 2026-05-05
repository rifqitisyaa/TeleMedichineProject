using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SignatureRegistrationMCUHakKewajiban
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[]? Signature { get; set; }

    [Column(TypeName = "image")]
    public byte[]? SignaturePetugas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SignatureNamePetugas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SignatureName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
