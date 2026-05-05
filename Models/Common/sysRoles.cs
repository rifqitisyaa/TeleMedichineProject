using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysRoles
{
    [Key]
    public Guid RoleId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ModuleID { get; set; } = null!;

    /// <summary>
    /// Untuk keperluan penamaan checkbox pada entry User Profiles
    /// </summary>
    public int RoleShortID { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Role")]
    public virtual sysRoleInGroupRole? sysRoleInGroupRole { get; set; }
}
