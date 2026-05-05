using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("SiteCode", "UserId", "RoleId", "ServiceUnitID")]
public partial class sysServiceUnitInUser
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public Guid UserId { get; set; }

    [Key]
    public Guid RoleId { get; set; }

    /// <summary>
    /// Link ke DepartmentServiceUnit
    /// </summary>
    [Key]
    public int ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
