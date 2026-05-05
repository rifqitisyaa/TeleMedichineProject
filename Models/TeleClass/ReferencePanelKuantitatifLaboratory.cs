using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReferencePanelKuantitatifLaboratory
{
    [Key]
    public int ID { get; set; }

    public int? ItemID { get; set; }

    public bool? IsBySex { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    public bool? IsByAge { get; set; }

    public int? AgeYearFrom { get; set; }

    public int? AgeYearTo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? HighValue { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? HighText { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BorderlineLowValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BorderlineHighValue { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? BorderlineText { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LowValue { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LowText { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
