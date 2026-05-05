using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DocumentNo", "SequenceNo")]
public partial class TimeAttendanceRecapDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal AttendanceQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal OvertimeQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OvertimeAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal DeductionQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DeductionAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal LeaveQty { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DocumentNo")]
    [InverseProperty("TimeAttendanceRecapDt")]
    public virtual TimeAttendanceRecapHd DocumentNoNavigation { get; set; } = null!;

    [ForeignKey("EmployeeId")]
    [InverseProperty("TimeAttendanceRecapDt")]
    public virtual Employee Employee { get; set; } = null!;
}
