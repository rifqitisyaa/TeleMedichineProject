using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DietMonitoringId", "SequenceNo")]
public partial class DietMonitoringDt
{
    [Key]
    public int DietMonitoringId { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCCategory { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? HidratArang { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LaukHewani { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LaukNabati { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Sayur { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Buah { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Cairan { get; set; }

    public bool IsDone { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
