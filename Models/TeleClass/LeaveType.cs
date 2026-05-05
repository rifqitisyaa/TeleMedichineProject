using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LeaveType
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string LeaveCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string LeaveName { get; set; } = null!;

    public int LeaveEntitlement { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCLeavePeriod { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? AbsenceCode { get; set; }

    public int TakebleAfter { get; set; }

    public bool IsAllowCarryOver { get; set; }

    public int MaxCarryOver { get; set; }

    public int ForfeiturePeriod { get; set; }

    public bool IsLinkToSchedule { get; set; }

    public int MaxHalfDay { get; set; }

    public bool IsBalaceCashable { get; set; }

    public bool IsAutoGenerate { get; set; }

    public bool IsDefault { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("LeaveCodeNavigation")]
    public virtual ICollection<EmployeeLeave> EmployeeLeave { get; set; } = new List<EmployeeLeave>();

    [ForeignKey("GCLeavePeriod")]
    [InverseProperty("LeaveType")]
    public virtual sysGeneralCode GCLeavePeriodNavigation { get; set; } = null!;

    [InverseProperty("LeaveCodeNavigation")]
    public virtual ICollection<LeaveAdjustmentHd> LeaveAdjustmentHd { get; set; } = new List<LeaveAdjustmentHd>();

    [InverseProperty("LeaveCodeNavigation")]
    public virtual ICollection<LeaveRequest> LeaveRequest { get; set; } = new List<LeaveRequest>();
}
