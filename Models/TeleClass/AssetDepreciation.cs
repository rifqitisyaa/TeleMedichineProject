using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetDepreciation
{
    [Key]
    public int Id { get; set; }

    public int AssetsID { get; set; }

    public int? Year { get; set; }

    public int? Period { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AssetAmountBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AssetAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DepreciationAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AccumulatedDepreciationAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AssetAmountAdjustment { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DepreciationAdjustmentAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? TargetMeterQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? SccumulatedTargetMeterQty { get; set; }

    public bool IsPosted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetsID")]
    [InverseProperty("AssetDepreciation")]
    public virtual Assets Assets { get; set; } = null!;

    [ForeignKey("Year, Period")]
    [InverseProperty("AssetDepreciation")]
    public virtual FiscalPeriodDt? FiscalPeriodDt { get; set; }
}
