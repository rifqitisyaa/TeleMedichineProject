using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WorkCycleHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CycleCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CycleName { get; set; } = null!;

    public int BumberOfCycle { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("CycleCodeNavigation")]
    public virtual ICollection<EmployeeScheduleHd> EmployeeScheduleHd { get; set; } = new List<EmployeeScheduleHd>();

    [InverseProperty("CycleCodeNavigation")]
    public virtual ICollection<WorkCycleDt> WorkCycleDt { get; set; } = new List<WorkCycleDt>();
}
