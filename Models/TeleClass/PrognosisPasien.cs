using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SnomedCode")]
public partial class PrognosisPasien
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string SnomedCode { get; set; } = null!;

    [Unicode(false)]
    public string? SnomedName { get; set; }

    [Unicode(false)]
    public string? Summary { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DiagnosticReportReference { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ObservationReference { get; set; }

    [Unicode(false)]
    public string? InvestigationNotes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Status { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
