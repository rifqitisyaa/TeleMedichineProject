using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("QuestionID", "AnswerID")]
public partial class QuestionAnswer
{
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string QuestionID { get; set; } = null!;

    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string AnswerID { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string ParentID { get; set; } = null!;

    public byte AnswerOrder { get; set; }

    public byte AnswerLevel { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string PrefixText { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string AnswerText { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string SuffixText { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string AnswerType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCValueCodeID { get; set; } = null!;

    public bool IsHasChild { get; set; }

    public bool IsActive { get; set; }

    public bool? IsRequired { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NormalValue { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NAValue { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DefaultValue { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("QuestionAnswer")]
    public virtual ICollection<PatientQuestionaireDt> PatientQuestionaireDt { get; set; } = new List<PatientQuestionaireDt>();

    [ForeignKey("QuestionID")]
    [InverseProperty("QuestionAnswer")]
    public virtual Question Question { get; set; } = null!;
}
