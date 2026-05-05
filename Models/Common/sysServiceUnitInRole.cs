using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("RoleId", "ServiceUnitCode")]
public partial class sysServiceUnitInRole
{
    [Key]
    public Guid RoleId { get; set; }

    /// <summary>
    /// Link ke DepartmentServiceUnit
    /// </summary>
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
