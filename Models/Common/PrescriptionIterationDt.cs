using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("JobOrderNo", "SequenceNo", "IterationNo")]
public partial class PrescriptionIterationDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [Column(TypeName = "numeric(10, 2)")]
    public decimal IterationNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PlanningDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RealizationNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RealizationDate { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
