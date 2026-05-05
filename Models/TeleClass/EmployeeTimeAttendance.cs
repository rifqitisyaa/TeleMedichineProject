using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("EmployeeId", "AttendanceDate", "TimeIn", "TimeOut")]
public partial class EmployeeTimeAttendance
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime AttendanceDate { get; set; }

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

    public bool? IsManualClocking { get; set; }

    public int? ImportId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string WorkingHours { get; set; } = null!;

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeTimeAttendance")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("ImportId")]
    [InverseProperty("EmployeeTimeAttendance")]
    public virtual ImportClocking? Import { get; set; }
}
