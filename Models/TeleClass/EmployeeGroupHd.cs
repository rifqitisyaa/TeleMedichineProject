using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeGroupHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string GroupCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string GroupName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("GroupCodeNavigation")]
    public virtual ICollection<EmployeeGroupDt> EmployeeGroupDt { get; set; } = new List<EmployeeGroupDt>();

    [InverseProperty("GroupCodeNavigation")]
    public virtual ICollection<EmployeeScheduleHd> EmployeeScheduleHd { get; set; } = new List<EmployeeScheduleHd>();
}
