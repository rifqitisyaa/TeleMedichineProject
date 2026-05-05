using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Category", "Year", "Period")]
public partial class MedicalRecordDailyReport
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? GroupName { get; set; }

    [Key]
    public int Year { get; set; }

    [Key]
    public int Period { get; set; }

    public int? Row { get; set; }

    [Column("1", TypeName = "numeric(18, 4)")]
    public decimal? _1 { get; set; }

    [Column("2", TypeName = "numeric(18, 4)")]
    public decimal? _2 { get; set; }

    [Column("3", TypeName = "numeric(18, 4)")]
    public decimal? _3 { get; set; }

    [Column("4", TypeName = "numeric(18, 4)")]
    public decimal? _4 { get; set; }

    [Column("5", TypeName = "numeric(18, 4)")]
    public decimal? _5 { get; set; }

    [Column("6", TypeName = "numeric(18, 4)")]
    public decimal? _6 { get; set; }

    [Column("7", TypeName = "numeric(18, 4)")]
    public decimal? _7 { get; set; }

    [Column("8", TypeName = "numeric(18, 4)")]
    public decimal? _8 { get; set; }

    [Column("9", TypeName = "numeric(18, 4)")]
    public decimal? _9 { get; set; }

    [Column("10", TypeName = "numeric(18, 4)")]
    public decimal? _10 { get; set; }

    [Column("11", TypeName = "numeric(18, 4)")]
    public decimal? _11 { get; set; }

    [Column("12", TypeName = "numeric(18, 4)")]
    public decimal? _12 { get; set; }

    [Column("13", TypeName = "numeric(18, 4)")]
    public decimal? _13 { get; set; }

    [Column("14", TypeName = "numeric(18, 4)")]
    public decimal? _14 { get; set; }

    [Column("15", TypeName = "numeric(18, 4)")]
    public decimal? _15 { get; set; }

    [Column("16", TypeName = "numeric(18, 4)")]
    public decimal? _16 { get; set; }

    [Column("17", TypeName = "numeric(18, 4)")]
    public decimal? _17 { get; set; }

    [Column("18", TypeName = "numeric(18, 4)")]
    public decimal? _18 { get; set; }

    [Column("19", TypeName = "numeric(18, 4)")]
    public decimal? _19 { get; set; }

    [Column("20", TypeName = "numeric(18, 4)")]
    public decimal? _20 { get; set; }

    [Column("21", TypeName = "numeric(18, 4)")]
    public decimal? _21 { get; set; }

    [Column("22", TypeName = "numeric(18, 4)")]
    public decimal? _22 { get; set; }

    [Column("23", TypeName = "numeric(18, 4)")]
    public decimal? _23 { get; set; }

    [Column("24", TypeName = "numeric(18, 4)")]
    public decimal? _24 { get; set; }

    [Column("25", TypeName = "numeric(18, 4)")]
    public decimal? _25 { get; set; }

    [Column("26", TypeName = "numeric(18, 4)")]
    public decimal? _26 { get; set; }

    [Column("27", TypeName = "numeric(18, 4)")]
    public decimal? _27 { get; set; }

    [Column("28", TypeName = "numeric(18, 4)")]
    public decimal? _28 { get; set; }

    [Column("29", TypeName = "numeric(18, 4)")]
    public decimal? _29 { get; set; }

    [Column("30", TypeName = "numeric(18, 4)")]
    public decimal? _30 { get; set; }

    [Column("31", TypeName = "numeric(18, 4)")]
    public decimal? _31 { get; set; }
}
