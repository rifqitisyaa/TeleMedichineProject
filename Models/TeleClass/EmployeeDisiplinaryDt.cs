using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DocumentNo", "SequenceNo")]
public partial class EmployeeDisiplinaryDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    public int? LastViolationType { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DocumentNo")]
    [InverseProperty("EmployeeDisiplinaryDt")]
    public virtual EmployeeDisiplinaryHd DocumentNoNavigation { get; set; } = null!;

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeDisiplinaryDt")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("LastViolationType")]
    [InverseProperty("EmployeeDisiplinaryDt")]
    public virtual ViolationType? LastViolationTypeNavigation { get; set; }
}
