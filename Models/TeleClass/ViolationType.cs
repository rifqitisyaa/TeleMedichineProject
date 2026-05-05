using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ViolationType
{
    [Key]
    public int Id { get; set; }

    [Column("ViolationType")]
    [StringLength(100)]
    [Unicode(false)]
    public string ViolationType1 { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? ViolationDescription { get; set; }

    [Unicode(false)]
    public string? Saction { get; set; }

    [Unicode(false)]
    public string? Advice { get; set; }

    public int ValidityPeriod { get; set; }

    public int DisiplinaryLevel { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("LastViolationTypeNavigation")]
    public virtual ICollection<EmployeeDisiplinaryDt> EmployeeDisiplinaryDt { get; set; } = new List<EmployeeDisiplinaryDt>();

    [InverseProperty("ViolationType")]
    public virtual ICollection<EmployeeDisiplinaryHd> EmployeeDisiplinaryHd { get; set; } = new List<EmployeeDisiplinaryHd>();
}
