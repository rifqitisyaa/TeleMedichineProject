using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("RoleId", "MenuID")]
public partial class sysMenuInRole
{
    [Key]
    public Guid RoleId { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CRUDMode { get; set; } = null!;

    public bool IsMenuFavorite { get; set; }

    public int? FavoriteIndex { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MenuID")]
    [InverseProperty("sysMenuInRole")]
    public virtual sysMenu Menu { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("sysMenuInRole")]
    public virtual aspnet_Roles Role { get; set; } = null!;
}
