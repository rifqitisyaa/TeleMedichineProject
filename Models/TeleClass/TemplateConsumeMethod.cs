using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TemplateConsumeMethod
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string ConsumeMethodName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ShortName { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Dose { get; set; }

    public int? Frequency { get; set; }

    public int? Duration { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Embalace { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DosageUnit { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lastUpdatedDateTime { get; set; }
}
