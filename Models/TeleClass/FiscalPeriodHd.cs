using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class FiscalPeriodHd
{
    [Key]
    public int Year { get; set; }

    public DateOnly? StartingDate { get; set; }

    public DateOnly? EndingDate { get; set; }

    public bool IsYearEndClosed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? YearEndClosedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? YearEndDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? YearEndOpenedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? YearEndOpenedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("BudgetYearNavigation")]
    public virtual ICollection<BudgetHd> BudgetHd { get; set; } = new List<BudgetHd>();

    [InverseProperty("YearNavigation")]
    public virtual ICollection<FiscalPeriodDt> FiscalPeriodDt { get; set; } = new List<FiscalPeriodDt>();

    [InverseProperty("ForecastYearNavigation")]
    public virtual ICollection<ForecastHd> ForecastHd { get; set; } = new List<ForecastHd>();
}
