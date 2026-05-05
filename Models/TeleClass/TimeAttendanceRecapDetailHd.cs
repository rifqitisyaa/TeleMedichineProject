using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TimeAttendanceRecapDetailHd
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RecapDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AttendFromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AttendToDate { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? PayrollPeriod { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Header")]
    public virtual ICollection<TimeAttendanceRecapDetailDt> TimeAttendanceRecapDetailDt { get; set; } = new List<TimeAttendanceRecapDetailDt>();
}
