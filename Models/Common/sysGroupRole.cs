using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysGroupRole
{
    [Key]
    [StringLength(50)]
    public string GroupRoleCode { get; set; } = null!;

    [StringLength(256)]
    public string GroupRoleName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredGroupRoleName { get; set; } = null!;

    [StringLength(256)]
    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("GroupRoleCodeNavigation")]
    public virtual ICollection<sysRoleInGroupRole> sysRoleInGroupRole { get; set; } = new List<sysRoleInGroupRole>();
}
