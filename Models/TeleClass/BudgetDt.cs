using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BudgetNo", "SequenceNo", "DetailNo")]
public partial class BudgetDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string BudgetNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    public int MonthPeriod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Label { get; set; }

    public DateOnly StartPeriod { get; set; }

    public DateOnly EndPeriod { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalculatedBudget { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RevisedBudget { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AccountBudget { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RevisedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RevisedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BudgetNo, SequenceNo")]
    [InverseProperty("BudgetDt")]
    public virtual BudgetSubDt BudgetSubDt { get; set; } = null!;
}
