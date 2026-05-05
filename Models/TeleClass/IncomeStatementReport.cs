using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class IncomeStatementReport
{
    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CoaName { get; set; }

    public byte? CoaLevel { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CoaType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NormalPosition { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? JanAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? FebAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? MarAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AprAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? MeiAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? JunAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? JulAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AugAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? SepAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? OctAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? NovAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DecmAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
