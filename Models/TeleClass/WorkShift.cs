using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WorkShift
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string WorkShiftCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string WorkShiftName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string StartingTime1 { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string EndingTime1 { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string? StartingTime2 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? EndingTime2 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? StartingTime3 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? EndingTime3 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? StartingTime4 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? EndingTime4 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? StartingTime5 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? EndingTime5 { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
