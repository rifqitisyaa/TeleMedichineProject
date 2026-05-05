using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AllocationId", "SequenceNo")]
public partial class AllocationCodeDt
{
    [Key]
    public int AllocationId { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    public int ServiceUnitId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CoaCode { get; set; } = null!;

    [Column(TypeName = "numeric(6, 2)")]
    public decimal ValuePercentage { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lastUpdatedDateTime { get; set; }

    [ForeignKey("AllocationId")]
    [InverseProperty("AllocationCodeDt")]
    public virtual AllocationCodeHd Allocation { get; set; } = null!;

    [ForeignKey("CoaCode")]
    [InverseProperty("AllocationCodeDt")]
    public virtual ChartOfAccount CoaCodeNavigation { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("AllocationCodeDt")]
    public virtual Department DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("AllocationCodeDt")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("AllocationCodeDt")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("AllocationCodeDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
