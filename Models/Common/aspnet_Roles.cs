using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class aspnet_Roles
{
    public Guid ApplicationId { get; set; }

    [Key]
    public Guid RoleId { get; set; }

    [StringLength(256)]
    public string RoleName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredRoleName { get; set; } = null!;

    [StringLength(256)]
    public string? Description { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("aspnet_Roles")]
    public virtual aspnet_Applications Application { get; set; } = null!;

    [InverseProperty("Role")]
    public virtual ICollection<sysMenuEntryMode> sysMenuEntryMode { get; set; } = new List<sysMenuEntryMode>();

    [InverseProperty("Role")]
    public virtual ICollection<sysMenuInRole> sysMenuInRole { get; set; } = new List<sysMenuInRole>();

    [InverseProperty("Role")]
    public virtual sysRolePersonalization? sysRolePersonalization { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("Role")]
    public virtual ICollection<aspnet_Users> User { get; set; } = new List<aspnet_Users>();
}
