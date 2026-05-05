using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class GuidelineSummary
{
    [Key]
    public long Id { get; set; }

    public int GuidelineInclusionId { get; set; }

    [Unicode(false)]
    public string Activity { get; set; } = null!;

    [Unicode(false)]
    public string? Part1 { get; set; }

    [Unicode(false)]
    public string? Part2 { get; set; }

    [Unicode(false)]
    public string? Part3 { get; set; }

    [Unicode(false)]
    public string? Part4 { get; set; }

    [Unicode(false)]
    public string? Part5 { get; set; }

    [Unicode(false)]
    public string? Part6 { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GuidelineInclusionId")]
    [InverseProperty("GuidelineSummary")]
    public virtual GuidelineInclusionHd GuidelineInclusion { get; set; } = null!;
}
