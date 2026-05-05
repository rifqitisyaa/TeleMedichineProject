using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeScheduleHd
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GroupCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CycleCode { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [ForeignKey("CycleCode")]
    [InverseProperty("EmployeeScheduleHd")]
    public virtual WorkCycleHd? CycleCodeNavigation { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeScheduleHd")]
    public virtual Employee Employee { get; set; } = null!;

    [InverseProperty("IdNavigation")]
    public virtual ICollection<EmployeeScheduleDt> EmployeeScheduleDt { get; set; } = new List<EmployeeScheduleDt>();

    [ForeignKey("GroupCode")]
    [InverseProperty("EmployeeScheduleHd")]
    public virtual EmployeeGroupHd? GroupCodeNavigation { get; set; }
}
