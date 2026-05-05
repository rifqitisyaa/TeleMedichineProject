using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "Year", "Period", "CalculatedDateTime", "ItemID")]
public partial class AverageCostBySystem
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int Year { get; set; }

    [Key]
    public int Period { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime CalculatedDateTime { get; set; }

    [Key]
    public int ItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BeforeCalculatedDateTime { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal BeginningQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BeginningAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal CurrentInQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CurrentInAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal CurrentOutQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal EndingQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal EndingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaterialCostAmount { get; set; }

    public bool IsFromAverageCost { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("Year, Period")]
    [InverseProperty("AverageCostBySystem")]
    public virtual FiscalPeriodDt FiscalPeriodDt { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("AverageCostBySystem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("AverageCostBySystem")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
