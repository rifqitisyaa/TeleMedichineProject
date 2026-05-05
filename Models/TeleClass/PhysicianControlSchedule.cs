using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PhysicianControlSchedule
{
    [Key]
    public long ID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string WorkStationCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AttendDateTime { get; set; }

    public DateOnly ScheduleDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string StartingTime { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string EndingTime { get; set; } = null!;

    public bool IsAttend { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCScheduleStatus { get; set; } = null!;

    public int? RoomId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remark { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
