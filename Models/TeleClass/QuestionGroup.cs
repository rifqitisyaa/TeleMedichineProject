using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class QuestionGroup
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string QuestionGroupID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ParentID { get; set; } = null!;

    public byte GroupLevel { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string QuestionGroupName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SummarizeGroupText { get; set; } = null!;

    public bool? IsShowSetValue { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("QuestionGroup")]
    public virtual ICollection<Question> Question { get; set; } = new List<Question>();

    [InverseProperty("QuestionGroup")]
    public virtual ICollection<QuestionGroupInForm> QuestionGroupInForm { get; set; } = new List<QuestionGroupInForm>();
}
