using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("LeaveAdjustmentNo", "EmployeeId")]
public partial class LeaveAdjustmentDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string LeaveAdjustmentNo { get; set; } = null!;

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

    [ForeignKey("EmployeeId")]
    [InverseProperty("LeaveAdjustmentDt")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("LeaveAdjustmentNo")]
    [InverseProperty("LeaveAdjustmentDt")]
    public virtual LeaveAdjustmentHd LeaveAdjustmentNoNavigation { get; set; } = null!;
}
