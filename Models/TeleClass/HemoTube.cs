using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class HemoTube
{
    [Key]
    public int TubeID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TubeName { get; set; } = null!;

    public int? UsedQty { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExaminationDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTubeStatus { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
