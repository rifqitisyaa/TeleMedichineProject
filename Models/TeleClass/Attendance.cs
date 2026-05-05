using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Attendance
{
    [Key]
    public int AttendanceId { get; set; }

    public int ParamedicId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AttendanceMonthPeriod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AttendanceYearPeriod { get; set; }

    public int TotalAttendance { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
