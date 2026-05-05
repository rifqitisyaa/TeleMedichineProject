using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LeaveRequest
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string LeaveRequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LeaveRequestDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LeaveCode { get; set; } = null!;

    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? LeaveBalanceQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? LeaveWorkingDayQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? LeaveRemainingBalaceQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndEffectiveDate { get; set; }

    public bool? IsRejected { get; set; }

    [Unicode(false)]
    public string? RejectedReason { get; set; }

    public bool? IsReviewed { get; set; }

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

    [ForeignKey("EmployeeId")]
    [InverseProperty("LeaveRequest")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("LeaveCode")]
    [InverseProperty("LeaveRequest")]
    public virtual LeaveType LeaveCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("LeaveRequest")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("LeaveRequest")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
