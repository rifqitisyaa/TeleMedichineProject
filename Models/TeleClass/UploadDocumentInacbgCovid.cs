using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "SepNo", "FileID")]
public partial class UploadDocumentInacbgCovid
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
    [StringLength(20)]
    [Unicode(false)]
    public string SepNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string FileID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FileType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FileSize { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FileClass { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
