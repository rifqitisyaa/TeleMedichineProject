using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("EmployeeId", "SequenceNo")]
public partial class SalaryComponentEmployee
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SalaryCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("SalaryComponentEmployee")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("SalaryCode")]
    [InverseProperty("SalaryComponentEmployee")]
    public virtual SalaryComponent SalaryCodeNavigation { get; set; } = null!;
}
