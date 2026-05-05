using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BackPaySalary
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SalaryEffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BackPayDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PayrollPeriod { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BackPayAmount { get; set; }

    public bool IsProcess { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("BackPaySalary")]
    public virtual Employee Employee { get; set; } = null!;
}
