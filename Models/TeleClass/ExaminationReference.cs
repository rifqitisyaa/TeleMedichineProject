using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ExaminationReference
{
    [Key]
    public int Id { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string ExaminationType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    public bool IsBySex { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    public bool IsByAge { get; set; }

    public int? AgeAbove { get; set; }

    public int? AgeYearTo { get; set; }

    public int? AgeMonthTo { get; set; }

    public int? AgeWeekTo { get; set; }

    public int? AgeDayTo { get; set; }

    public int? AgeToInDay { get; set; }

    public int? AgeBelow { get; set; }

    public int? AgeYearFrom { get; set; }

    public int? AgeMonthFrom { get; set; }

    public int? AgeWeekFrom { get; set; }

    public int? AgeDayFrom { get; set; }

    public int? AgeFromInDay { get; set; }

    public bool IsByPregnancy { get; set; }

    public bool? IsPregnant { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? MinNormalValue { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? MaxNormalValue { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CriticalValueHigh { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CriticalValueLow { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? IntervalCriticalValueHigh { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? IntervalCriticalValueLow { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? NormalValueText { get; set; }

    [Unicode(false)]
    public string? ReferenceRangeDescription { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("ExaminationReference")]
    public virtual sysGeneralCode? GCSexNavigation { get; set; }
}
