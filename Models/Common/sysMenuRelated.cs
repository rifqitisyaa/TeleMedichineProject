using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("MenuID", "ParentMenuID")]
public partial class sysMenuRelated
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ParentMenuID { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
