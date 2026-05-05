using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class _tmp_ICD2008
{
    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string DiagnosisName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? DiagnosisNameCustom { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DTDNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ICDBlockID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InfectiousDiseaseCode { get; set; }

    public bool? IsDisease { get; set; }

    public bool? IsChronicDisease { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
