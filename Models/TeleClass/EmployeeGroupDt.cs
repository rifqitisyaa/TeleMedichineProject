using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GroupCode", "EmployeeId")]
public partial class EmployeeGroupDt
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string GroupCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeGroupDt")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("GroupCode")]
    [InverseProperty("EmployeeGroupDt")]
    public virtual EmployeeGroupHd GroupCodeNavigation { get; set; } = null!;
}
