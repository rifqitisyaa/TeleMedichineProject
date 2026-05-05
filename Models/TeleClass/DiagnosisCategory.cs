using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DiagnosisCategory
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? DiagnosisName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string GCDiagnosisCategory { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
