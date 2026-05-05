using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProjectMCUNo", "SequenceNo", "QuestionNo")]
public partial class RiwayatKesehatanMCUDataList
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProjectMCUNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string QuestionNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string? SourceSequenceNo { get; set; }

    [Unicode(false)]
    public string? QuestionGroup { get; set; }

    [Unicode(false)]
    public string? Question { get; set; }

    [Unicode(false)]
    public string? Answer { get; set; }

    public bool? IsShow { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
