using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("EmployeeId", "SequenceNo")]
public partial class EmployeeLeave
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string LeaveCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartEffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndEffectiveDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal LeaveEntitlementQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal LeaveTakenQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal LeaveBalanceQty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeLeave")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("LeaveCode")]
    [InverseProperty("EmployeeLeave")]
    public virtual LeaveType LeaveCodeNavigation { get; set; } = null!;

    [InverseProperty("EmployeeLeave")]
    public virtual ICollection<LeaveHistory> LeaveHistory { get; set; } = new List<LeaveHistory>();
}
