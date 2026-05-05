using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AssetID", "BookCode", "BookSequenceNo")]
public partial class AssetDepreciationParameter
{
    [Key]
    public int AssetID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string BookCode { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string BookSequenceNo { get; set; } = null!;

    public int MethodID { get; set; }

    public int ServiceLife { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? DepreciationFactor { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? TotalUnits { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UnitOfMeasure { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? UnitUsedInPeriod { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? AnnualFlatRate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CustomTablePerYear { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BookCode, BookSequenceNo")]
    [InverseProperty("AssetDepreciationParameter")]
    public virtual AssetBook AssetBook { get; set; } = null!;

    [ForeignKey("MethodID")]
    [InverseProperty("AssetDepreciationParameter")]
    public virtual AssetDepreciationMethod Method { get; set; } = null!;
}
