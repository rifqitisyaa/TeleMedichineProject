using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Year", "Period", "SiteCode", "DepartmentCode", "ServiceUnitCode", "CoaCode", "ServiceUnitID")]
public partial class AccountPeriodLastPosting
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

    [Key]
    public int ServiceUnitID { get; set; }

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
}
