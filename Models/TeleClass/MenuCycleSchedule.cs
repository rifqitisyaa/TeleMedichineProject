using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MenuCycleSchedule
{
    [Key]
    public int ScheduleNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ScheduledDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ScheduledBy { get; set; } = null!;

    public int SiklusId { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
