using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("IssuedUnplannedNo", "SequenceNo")]
public partial class IssueUnplannedSignature
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string IssuedUnplannedNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[]? Signature { get; set; }

    [Unicode(false)]
    public string? SignatureName { get; set; }

    public int? ParamedicId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SignatureDatetime { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }
}
