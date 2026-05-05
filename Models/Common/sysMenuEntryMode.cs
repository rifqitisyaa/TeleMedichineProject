using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("SiteCode", "UserID", "RoleId", "MenuID")]
public partial class sysMenuEntryMode
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public Guid UserID { get; set; }

    [Key]
    public Guid RoleId { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MenuID")]
    [InverseProperty("sysMenuEntryMode")]
    public virtual sysMenu Menu { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("sysMenuEntryMode")]
    public virtual aspnet_Roles Role { get; set; } = null!;

    [ForeignKey("UserID")]
    [InverseProperty("sysMenuEntryMode")]
    public virtual aspnet_Users User { get; set; } = null!;
}
