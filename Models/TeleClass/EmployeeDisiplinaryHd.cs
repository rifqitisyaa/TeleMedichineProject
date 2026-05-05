using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeDisiplinaryHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocumentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartEffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndEffectiveDate { get; set; }

    public int ViolationTypeId { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    [Unicode(false)]
    public string? Saction { get; set; }

    [Unicode(false)]
    public string? Advice { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("DocumentNoNavigation")]
    public virtual ICollection<EmployeeDisiplinaryDt> EmployeeDisiplinaryDt { get; set; } = new List<EmployeeDisiplinaryDt>();

    [ForeignKey("ViolationTypeId")]
    [InverseProperty("EmployeeDisiplinaryHd")]
    public virtual ViolationType ViolationType { get; set; } = null!;
}
