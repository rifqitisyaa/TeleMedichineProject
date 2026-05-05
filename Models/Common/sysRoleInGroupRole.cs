using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysRoleInGroupRole
{
    [Key]
    public Guid RoleId { get; set; }

    [StringLength(50)]
    public string GroupRoleCode { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GroupRoleCode")]
    [InverseProperty("sysRoleInGroupRole")]
    public virtual sysGroupRole GroupRoleCodeNavigation { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("sysRoleInGroupRole")]
    public virtual sysRoles Role { get; set; } = null!;
}
