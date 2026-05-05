using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetsBook
{
    [Key]
    public int AssetsBookID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string AssetsBookCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string AssetsBookName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? AssetsCoaCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CutBackCoaCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DepreciationCoaCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BurdenCoaCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RevenueCoaCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ExpenseCoaCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EliminationCoaCode { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetsCoaCode")]
    [InverseProperty("AssetsBookAssetsCoaCodeNavigation")]
    public virtual ChartOfAccount? AssetsCoaCodeNavigation { get; set; }

    [ForeignKey("BurdenCoaCode")]
    [InverseProperty("AssetsBookBurdenCoaCodeNavigation")]
    public virtual ChartOfAccount? BurdenCoaCodeNavigation { get; set; }

    [ForeignKey("CutBackCoaCode")]
    [InverseProperty("AssetsBookCutBackCoaCodeNavigation")]
    public virtual ChartOfAccount? CutBackCoaCodeNavigation { get; set; }

    [ForeignKey("DepreciationCoaCode")]
    [InverseProperty("AssetsBookDepreciationCoaCodeNavigation")]
    public virtual ChartOfAccount? DepreciationCoaCodeNavigation { get; set; }

    [ForeignKey("EliminationCoaCode")]
    [InverseProperty("AssetsBookEliminationCoaCodeNavigation")]
    public virtual ChartOfAccount? EliminationCoaCodeNavigation { get; set; }

    [ForeignKey("ExpenseCoaCode")]
    [InverseProperty("AssetsBookExpenseCoaCodeNavigation")]
    public virtual ChartOfAccount? ExpenseCoaCodeNavigation { get; set; }
}
