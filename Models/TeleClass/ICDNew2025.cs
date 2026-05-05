using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ICDNew2025
{
    [StringLength(512)]
    [Unicode(false)]
    public string? DiagnosisCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? DiagnosisName { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? AlternateDiagnosisName { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? DiagnosisNameCustom { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? DTDNo { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ICDBlockID { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? InfectiousDiseaseCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsDisease { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsChronicDisease { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Remark { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsActive { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsDeleted { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? LastUpdatedDateTime { get; set; }
}
