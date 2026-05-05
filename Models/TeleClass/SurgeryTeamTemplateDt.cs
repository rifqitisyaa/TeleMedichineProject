using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SurgeryTeamCode", "SequenceNo")]
public partial class SurgeryTeamTemplateDt
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SurgeryTeamCode { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ParamedicID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCSurgeryParamedicType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCSurgeryParamedicType")]
    [InverseProperty("SurgeryTeamTemplateDt")]
    public virtual sysGeneralCode GCSurgeryParamedicTypeNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("SurgeryTeamTemplateDt")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("SurgeryTeamCode")]
    [InverseProperty("SurgeryTeamTemplateDt")]
    public virtual SurgeryTeamTemplateHd SurgeryTeamCodeNavigation { get; set; } = null!;
}
