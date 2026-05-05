using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProjectMCUNo", "Sequence")]
public partial class ProjectDocument
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string ProjectMCUNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string Sequence { get; set; } = null!;

    [Unicode(false)]
    public string? FileName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UploadDateTime { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }
}
