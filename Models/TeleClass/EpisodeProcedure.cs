using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class EpisodeProcedure
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

    public int ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ProcedureCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ProcedureDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SurgeryTeamCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSurgeryType { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsSurgeryProcedurePerform { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("EpisodeProcedure")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("ProcedureCode")]
    [InverseProperty("EpisodeProcedure")]
    public virtual Procedures ProcedureCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("EpisodeProcedure")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("EpisodeProcedure")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SpecialtyCode")]
    [InverseProperty("EpisodeProcedure")]
    public virtual Specialty SpecialtyCodeNavigation { get; set; } = null!;

    [ForeignKey("SurgeryTeamCode")]
    [InverseProperty("EpisodeProcedure")]
    public virtual SurgeryTeamTemplateHd? SurgeryTeamCodeNavigation { get; set; }
}
