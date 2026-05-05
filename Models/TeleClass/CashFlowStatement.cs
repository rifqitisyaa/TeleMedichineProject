using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Year", "Period", "SiteCode", "SequenceNo")]
public partial class CashFlowStatement
{
    [Key]
    public int Year { get; set; }

    [Key]
    public int Period { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string DescriptionOtherLanguage { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AmountIncrease { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AmountDecrease { get; set; }

    public bool IsTotal { get; set; }

    [ForeignKey("CoaCode")]
    [InverseProperty("CashFlowStatement")]
    public virtual ChartOfAccount? CoaCodeNavigation { get; set; }

    [ForeignKey("Year, Period")]
    [InverseProperty("CashFlowStatement")]
    public virtual FiscalPeriodDt FiscalPeriodDt { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("CashFlowStatement")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
