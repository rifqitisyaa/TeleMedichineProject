using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Keyless]
public partial class _bak_sysMenuInUser
{
    [StringLength(3)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public Guid UserID { get; set; }

    public Guid RoleId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CRUDMode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
