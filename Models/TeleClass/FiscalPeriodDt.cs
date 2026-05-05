using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Year", "Period")]
[Index("FiscalPeriod", Name = "UNIQUE_IX_FiscalPeriodDt", IsUnique = true)]
public partial class FiscalPeriodDt
{
    [Key]
    public int Year { get; set; }

    [Key]
    public int Period { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FiscalPeriod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Label { get; set; } = null!;

    public DateOnly StartingDate { get; set; }

    public DateOnly EndingDate { get; set; }

    public bool IsMonthEndClosed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MonthEndClosedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MonthEndClosedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MonthEndOpenedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MonthEndOpenedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("FiscalPeriodDt")]
    public virtual ICollection<AccountPeriod> AccountPeriod { get; set; } = new List<AccountPeriod>();

    [InverseProperty("FiscalPeriodDt")]
    public virtual ICollection<AssetDepreciation> AssetDepreciation { get; set; } = new List<AssetDepreciation>();

    [InverseProperty("FiscalPeriodDt")]
    public virtual ICollection<AssetMeter> AssetMeter { get; set; } = new List<AssetMeter>();

    [InverseProperty("FiscalPeriodDt")]
    public virtual ICollection<AverageCost> AverageCost { get; set; } = new List<AverageCost>();

    [InverseProperty("FiscalPeriodDt")]
    public virtual ICollection<AverageCostBySystem> AverageCostBySystem { get; set; } = new List<AverageCostBySystem>();

    [InverseProperty("FiscalPeriodDt")]
    public virtual ICollection<CashFlowStatement> CashFlowStatement { get; set; } = new List<CashFlowStatement>();

    [InverseProperty("FiscalPeriodDt")]
    public virtual ICollection<CashFlowStatementDt> CashFlowStatementDt { get; set; } = new List<CashFlowStatementDt>();

    [ForeignKey("Year")]
    [InverseProperty("FiscalPeriodDt")]
    public virtual FiscalPeriodHd YearNavigation { get; set; } = null!;
}
