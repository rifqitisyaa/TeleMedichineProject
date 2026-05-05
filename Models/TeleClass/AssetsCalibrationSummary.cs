using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetsCalibrationSummary
{
    [Key]
    public int AssetsId { get; set; }

    public bool IsCallibrationAssets { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CalibrationExpiredDate { get; set; }

    [Unicode(false)]
    public string? CalibrationCriteria { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CalibrationStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AssignBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssignDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CalibrationBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CalibrationScheduleDate { get; set; }

    [Unicode(false)]
    public string? CalibrationSummary { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
