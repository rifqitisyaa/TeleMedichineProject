using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeLoanHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string LoanNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LoanDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LoanAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal InterestRatePerYear { get; set; }

    public int NumberOfInstaledment { get; set; }

    public int? LoanYear { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeLoanHd")]
    public virtual Employee Employee { get; set; } = null!;

    [InverseProperty("LoanNoNavigation")]
    public virtual ICollection<EmployeeLoanDt> EmployeeLoanDt { get; set; } = new List<EmployeeLoanDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("EmployeeLoanHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("EmployeeLoanHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
