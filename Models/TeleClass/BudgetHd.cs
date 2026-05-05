using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BudgetHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string BudgetNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime BudgetDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public int BudgetYear { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int? SiteDepartmentID { get; set; }

    public int? ServiceUnitID { get; set; }

    [Column(TypeName = "numeric(20, 4)")]
    public decimal? BudgetAmount { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("BudgetNoNavigation")]
    public virtual ICollection<BudgetSubDt> BudgetSubDt { get; set; } = new List<BudgetSubDt>();

    [ForeignKey("BudgetYear")]
    [InverseProperty("BudgetHd")]
    public virtual FiscalPeriodHd BudgetYearNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("BudgetHd")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("BudgetHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteDepartmentID")]
    [InverseProperty("BudgetHd")]
    public virtual SiteDepartment? SiteDepartment { get; set; }

    [ForeignKey("TransactionCode")]
    [InverseProperty("BudgetHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
