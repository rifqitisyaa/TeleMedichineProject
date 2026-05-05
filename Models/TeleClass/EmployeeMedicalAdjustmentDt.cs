using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AdjustmentNo", "EmployeeId")]
public partial class EmployeeMedicalAdjustmentDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AdjustmentNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AdjustmentAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AdjustmentNo")]
    [InverseProperty("EmployeeMedicalAdjustmentDt")]
    public virtual EmployeeMedicalAdjustmentHd AdjustmentNoNavigation { get; set; } = null!;

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeMedicalAdjustmentDt")]
    public virtual Employee Employee { get; set; } = null!;
}
