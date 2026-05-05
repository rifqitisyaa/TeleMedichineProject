using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TargetNo", "SequenceNo")]
public partial class PMKPTargetSubDt
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TargetNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string IndicatorCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CalculatedTarget { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RevisedTarget { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AccountTarget { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
