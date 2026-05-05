using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WorkCycleDt
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CycleCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string DaysNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ShiftCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CycleCode")]
    [InverseProperty("WorkCycleDt")]
    public virtual WorkCycleHd CycleCodeNavigation { get; set; } = null!;

    [ForeignKey("ShiftCode")]
    [InverseProperty("WorkCycleDt")]
    public virtual WorkShiftHrd ShiftCodeNavigation { get; set; } = null!;
}
