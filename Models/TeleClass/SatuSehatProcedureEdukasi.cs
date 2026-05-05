using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProcedureEdukasiIHSNo", "EncounterIHSNo")]
public partial class SatuSehatProcedureEdukasi
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ProcedureEdukasiIHSNo { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string EncounterIHSNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    public int ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
