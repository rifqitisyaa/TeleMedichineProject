using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Year", "Period", "SiteCode")]
public partial class CashFlowStatementDt
{
    [Key]
    public int Year { get; set; }

    [Key]
    public int Period { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Balance { get; set; }

    [ForeignKey("Year, Period")]
    [InverseProperty("CashFlowStatementDt")]
    public virtual FiscalPeriodDt FiscalPeriodDt { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("CashFlowStatementDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
