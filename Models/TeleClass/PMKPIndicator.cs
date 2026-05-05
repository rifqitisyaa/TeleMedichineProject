using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PMKPIndicator
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string IndicatorCode { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string IndicatorName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IndicatorDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCGroupIndicator { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
