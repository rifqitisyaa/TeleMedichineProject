using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WorkShiftHrd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ShiftCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ShiftName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string TimeIn { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string TimeOut { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string? BreakIn { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? BreakOut { get; set; }

    public int ToleranceLate { get; set; }

    public int? OvertimeTolerance { get; set; }

    public bool IsAutoSPL { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ScheduleShiftCodeNavigation")]
    public virtual ICollection<DaySubstitute> DaySubstituteScheduleShiftCodeNavigation { get; set; } = new List<DaySubstitute>();

    [InverseProperty("SubstituteShiftCodeNavigation")]
    public virtual ICollection<DaySubstitute> DaySubstituteSubstituteShiftCodeNavigation { get; set; } = new List<DaySubstitute>();

    [InverseProperty("ShiftCodeNavigation")]
    public virtual ICollection<EmployeeScheduleDt> EmployeeScheduleDt { get; set; } = new List<EmployeeScheduleDt>();

    [InverseProperty("ShiftCodeNavigation")]
    public virtual ICollection<OvertimeWorkOrder> OvertimeWorkOrder { get; set; } = new List<OvertimeWorkOrder>();

    [InverseProperty("ShiftCodeNavigation")]
    public virtual ICollection<TimeAttendanceRecapDetailDt> TimeAttendanceRecapDetailDt { get; set; } = new List<TimeAttendanceRecapDetailDt>();

    [InverseProperty("ShiftCodeNavigation")]
    public virtual ICollection<WorkCycleDt> WorkCycleDt { get; set; } = new List<WorkCycleDt>();
}
