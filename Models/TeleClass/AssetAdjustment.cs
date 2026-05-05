using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetAdjustment
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AdjustmentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int AssetsID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AdjustmentDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CostAmountAdjustment { get; set; }

    public int? ServiceLifeAdjustment { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetsID")]
    [InverseProperty("AssetAdjustment")]
    public virtual Assets Assets { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("AssetAdjustment")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("AssetAdjustment")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
