using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("FormID", "QuestionGroupID")]
public partial class QuestionGroupInForm
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string FormID { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string QuestionGroupID { get; set; } = null!;

    public byte GroupOrder { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("FormID")]
    [InverseProperty("QuestionGroupInForm")]
    public virtual QuestionaireForm Form { get; set; } = null!;

    [ForeignKey("QuestionGroupID")]
    [InverseProperty("QuestionGroupInForm")]
    public virtual QuestionGroup QuestionGroup { get; set; } = null!;
}
