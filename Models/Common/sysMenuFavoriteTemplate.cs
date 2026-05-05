using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("SiteCode", "RoleId", "MenuID")]
public partial class sysMenuFavoriteTemplate
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public Guid RoleId { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    public int FavoriteIndex { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
