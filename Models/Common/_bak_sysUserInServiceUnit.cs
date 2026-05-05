using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("SiteCode", "UserId", "ServiceUnitID")]
public partial class _bak_sysUserInServiceUnit
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public Guid UserId { get; set; }

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
