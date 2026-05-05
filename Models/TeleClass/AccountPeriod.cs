using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Year", "Period", "SiteCode", "DepartmentCode", "ServiceUnitCode", "CoaCode")]
public partial class AccountPeriod
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
    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string CoaCode { get; set; } = null!;

    public int? ServiceUnitID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BeginningBalance { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MutationDebit { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MutationCredit { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal EndingBalance { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCode")]
    [InverseProperty("AccountPeriod")]
    public virtual ChartOfAccount CoaCodeNavigation { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("AccountPeriod")]
    public virtual Department DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("Year, Period")]
    [InverseProperty("AccountPeriod")]
    public virtual FiscalPeriodDt FiscalPeriodDt { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("AccountPeriod")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("AccountPeriod")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("AccountPeriod")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
