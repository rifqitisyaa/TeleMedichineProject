using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Index("ApplicationId", "LastActivityDate", Name = "aspnet_Users_Index2")]
public partial class aspnet_Users
{
    public Guid ApplicationId { get; set; }

    [Key]
    public Guid UserId { get; set; }

    [StringLength(256)]
    public string UserName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredUserName { get; set; } = null!;

    [StringLength(16)]
    public string? MobileAlias { get; set; }

    public bool IsAnonymous { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastActivityDate { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("aspnet_Users")]
    public virtual aspnet_Applications Application { get; set; } = null!;

    [InverseProperty("User")]
    public virtual aspnet_Membership? aspnet_Membership { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; } = new List<aspnet_PersonalizationPerUser>();

    [InverseProperty("User")]
    public virtual aspnet_Profile? aspnet_Profile { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<sysMenuEntryMode> sysMenuEntryMode { get; set; } = new List<sysMenuEntryMode>();

    [InverseProperty("User")]
    public virtual ICollection<sysMenuFavorite> sysMenuFavorite { get; set; } = new List<sysMenuFavorite>();

    [InverseProperty("User")]
    public virtual ICollection<sysMenuInUser> sysMenuInUser { get; set; } = new List<sysMenuInUser>();

    [ForeignKey("UserId")]
    [InverseProperty("User")]
    public virtual ICollection<aspnet_Roles> Role { get; set; } = new List<aspnet_Roles>();
}
