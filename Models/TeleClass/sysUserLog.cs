using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("ModuleSessionID", Name = "IX_sysUserLog")]
public partial class sysUserLog
{
    [Key]
    public long LogID { get; set; }

    public Guid UserId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public Guid RoleId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ModuleID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? HostName { get; set; }

    [StringLength(24)]
    [Unicode(false)]
    public string? ModuleSessionID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LogInDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LogOutDateTime { get; set; }

    public bool IsLogOut { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCLogOutType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BrowserName { get; set; }

    public bool? IsMobileDevice { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? BrowserUserAgent { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BrowserPlatform { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
