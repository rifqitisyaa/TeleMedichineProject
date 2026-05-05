using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "QuestionID", "AnswerID")]
public partial class PatientQuestionaireDt
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
    [StringLength(25)]
    [Unicode(false)]
    public string QuestionID { get; set; } = null!;

    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string AnswerID { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Unicode(false)]
    public string AnswerText { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("PatientQuestionaireDt")]
    public virtual PatientQuestionaireHd PatientQuestionaireHd { get; set; } = null!;

    [ForeignKey("QuestionID, AnswerID")]
    [InverseProperty("PatientQuestionaireDt")]
    public virtual QuestionAnswer QuestionAnswer { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientQuestionaireDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
