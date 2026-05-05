using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class QuestionaireForm
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string FormID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string FormName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCFormType { get; set; }

    public bool IsNursingForm { get; set; }

    public bool IsOPHForm { get; set; }

    public bool IsResultForm { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsDisplaySign { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCFormType")]
    [InverseProperty("QuestionaireForm")]
    public virtual sysGeneralCode? GCFormTypeNavigation { get; set; }

    [InverseProperty("Form")]
    public virtual ICollection<PatientQuestionaireHd> PatientQuestionaireHd { get; set; } = new List<PatientQuestionaireHd>();

    [InverseProperty("Form")]
    public virtual ICollection<QuestionGroupInForm> QuestionGroupInForm { get; set; } = new List<QuestionGroupInForm>();
}
