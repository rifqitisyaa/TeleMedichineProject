using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Id", "SequenceNo")]
public partial class EmployeeScheduleDt
{
    [Key]
    public int Id { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ScheduleDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShiftCode { get; set; } = null!;

    public int? DaySubtituteId { get; set; }

    public bool? IsCancel { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("EmployeeScheduleDt")]
    public virtual EmployeeScheduleHd IdNavigation { get; set; } = null!;

    [ForeignKey("ShiftCode")]
    [InverseProperty("EmployeeScheduleDt")]
    public virtual WorkShiftHrd ShiftCodeNavigation { get; set; } = null!;
}
