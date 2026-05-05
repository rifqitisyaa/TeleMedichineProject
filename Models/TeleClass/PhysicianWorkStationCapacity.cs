using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ParamedicID", "WorkStationCode", "Time")]
public partial class PhysicianWorkStationCapacity
{
    [Key]
    public int ParamedicID { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string WorkStationCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Shift { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string Time { get; set; } = null!;

    public int? Capacity { get; set; }

    public int? CapacityNow { get; set; }

    public int? CapacityNonJKN { get; set; }

    public int? CapacityBPJS { get; set; }

    public int? AverageTime { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
