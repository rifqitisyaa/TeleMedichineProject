using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SequenceNo", "Period")]
public partial class PKRSTargetDt
{
    [Key]
    public int Period { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string GroupName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SequenceCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? No { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Total { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcJanuary { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcFebruary { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcMarch { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcApril { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcMay { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcJune { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcJuly { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcAugust { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcSeptember { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcOctober { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcNovember { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalcDecember { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
