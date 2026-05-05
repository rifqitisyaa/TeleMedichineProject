using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("WorkOrderNo", "EmployeeId")]
public partial class OvertimeWorkOrderDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string WorkOrderNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("OvertimeWorkOrderDt")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("WorkOrderNo")]
    [InverseProperty("OvertimeWorkOrderDt")]
    public virtual OvertimeWorkOrder WorkOrderNoNavigation { get; set; } = null!;
}
