using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeTerminate
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TerminateDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCTerminateType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPerfomance { get; set; }

    public bool IsPaidThisMonth { get; set; }

    public bool IsPaidLeave { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal LeaveQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LeaveAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal SeveranceQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SeveranceAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal MentQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MentAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal SeparationQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SeparationAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal IndemnityQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal IndemnityAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAddition { get; set; }

    public bool IsHasLoan { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LoanAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OtherDeductionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalDeduction { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalTransaction { get; set; }

    public bool IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeTerminate")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("GCPerfomance")]
    [InverseProperty("EmployeeTerminateGCPerfomanceNavigation")]
    public virtual sysGeneralCode? GCPerfomanceNavigation { get; set; }

    [ForeignKey("GCTerminateType")]
    [InverseProperty("EmployeeTerminateGCTerminateTypeNavigation")]
    public virtual sysGeneralCode GCTerminateTypeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("EmployeeTerminate")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("EmployeeTerminate")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
