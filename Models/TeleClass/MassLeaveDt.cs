using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DocumentNo", "EmployeeId")]
public partial class MassLeaveDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    public int LeaveBalance { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DocumentNo")]
    [InverseProperty("MassLeaveDt")]
    public virtual MassLeaveHd DocumentNoNavigation { get; set; } = null!;

    [ForeignKey("EmployeeId")]
    [InverseProperty("MassLeaveDt")]
    public virtual Employee Employee { get; set; } = null!;
}
