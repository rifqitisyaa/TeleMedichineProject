using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BudgetNo", "SequenceNo")]
public partial class BudgetSubDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string BudgetNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? KodeAnggaran { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalculatedBudget { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RevisedBudget { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AccountBudget { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("BudgetSubDt")]
    public virtual ICollection<BudgetDt> BudgetDt { get; set; } = new List<BudgetDt>();

    [ForeignKey("BudgetNo")]
    [InverseProperty("BudgetSubDt")]
    public virtual BudgetHd BudgetNoNavigation { get; set; } = null!;
}
