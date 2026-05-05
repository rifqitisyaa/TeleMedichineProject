using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("HeaderId", "AttendDate", "EmployeeId", "TimeIn", "TimeOut")]
public partial class TimeAttendanceRecapDetailDt
{
    [Key]
    public int HeaderId { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime AttendDate { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string TimeIn { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string TimeOut { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateOut { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ShiftCode { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? WorkingHours { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Overtime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Deduction { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("TimeAttendanceRecapDetailDt")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("HeaderId")]
    [InverseProperty("TimeAttendanceRecapDetailDt")]
    public virtual TimeAttendanceRecapDetailHd Header { get; set; } = null!;

    [ForeignKey("ShiftCode")]
    [InverseProperty("TimeAttendanceRecapDetailDt")]
    public virtual WorkShiftHrd? ShiftCodeNavigation { get; set; }
}
