using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ParamedicSignature
{
    [Key]
    [StringLength(10)]
    public string ParamedicID { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[]? Signature { get; set; }

    [Unicode(false)]
    public string? SignatureByUrl { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
