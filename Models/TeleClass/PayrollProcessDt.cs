using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PayrollProcessNo", "EmployeeId", "SalaryCode")]
public partial class PayrollProcessDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PayrollProcessNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SalaryCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("PayrollProcessDt")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("SalaryCode")]
    [InverseProperty("PayrollProcessDt")]
    public virtual SalaryComponent SalaryCodeNavigation { get; set; } = null!;
}
