using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class TemplatePhysicalExamHd
{
    [StringLength(10)]
    [Unicode(false)]
    public string? QuestionCode { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int? ParamedicID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime QuestionaireDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string FormID { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public bool IsDeleted { get; set; }

    [Unicode(false)]
    public string? Summary { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
