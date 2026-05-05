using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Question
{
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string QuestionID { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string ParentID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string QuestionGroupID { get; set; } = null!;

    public byte QuestionOrder { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string QuestionText { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string SummarizeQuestionText { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string AnswerType { get; set; } = null!;

    [Unicode(false)]
    public string? NormalValue { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCValueCodeID { get; set; } = null!;

    public bool IsSingleAnswer { get; set; }

    public bool IsActive { get; set; }

    public bool? IsRequired { get; set; }

    public bool? IsYesNoQuestion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? YesNoQuestionGroup { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Question")]
    public virtual ICollection<QuestionAnswer> QuestionAnswer { get; set; } = new List<QuestionAnswer>();

    [ForeignKey("QuestionGroupID")]
    [InverseProperty("Question")]
    public virtual QuestionGroup QuestionGroup { get; set; } = null!;
}
