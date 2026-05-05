using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProcedureIHSNo", "EncounterIHSNo")]
public partial class SatuSehatEpisodeProcedure
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ProcedureIHSNo { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string EncounterIHSNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

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
}
