using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PPITargetDt
{
    public int? Period { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? GCInfeksiPPI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? No { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Type { get; set; }

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
    public decimal? CalcDesember { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
