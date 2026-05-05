using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PatientQuestionaireHd
{
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

    public int? ParamedicTo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCInstructionBy { get; set; }

    public bool? IsNeedReviewed { get; set; }

    public bool? IsReviewed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("FormID")]
    [InverseProperty("PatientQuestionaireHd")]
    public virtual QuestionaireForm Form { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientQuestionaireHd")]
    public virtual Paramedic? Paramedic { get; set; }

    [InverseProperty("PatientQuestionaireHd")]
    public virtual ICollection<PatientQuestionaireDt> PatientQuestionaireDt { get; set; } = new List<PatientQuestionaireDt>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientQuestionaireHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientQuestionaireHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
