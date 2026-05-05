using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo", "DiagnosisCode")]
public partial class JobOrderDtDiagnose
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DiagnosisCode")]
    [InverseProperty("JobOrderDtDiagnose")]
    public virtual Diagnosis DiagnosisCodeNavigation { get; set; } = null!;

    [ForeignKey("JobOrderNo, SequenceNo")]
    [InverseProperty("JobOrderDtDiagnose")]
    public virtual JobOrderDt JobOrderDt { get; set; } = null!;
}
