using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Index("LoweredApplicationName", Name = "UQ__aspnet_A__17477DE40CBAE877", IsUnique = true)]
[Index("ApplicationName", Name = "UQ__aspnet_A__3091033109DE7BCC", IsUnique = true)]
public partial class aspnet_Applications
{
    [StringLength(256)]
    public string ApplicationName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredApplicationName { get; set; } = null!;

    [Key]
    public Guid ApplicationId { get; set; }

    [StringLength(256)]
    public string? Description { get; set; }

    [InverseProperty("Application")]
    public virtual ICollection<aspnet_Membership> aspnet_Membership { get; set; } = new List<aspnet_Membership>();

    [InverseProperty("Application")]
    public virtual ICollection<aspnet_Paths> aspnet_Paths { get; set; } = new List<aspnet_Paths>();

    [InverseProperty("Application")]
    public virtual ICollection<aspnet_Roles> aspnet_Roles { get; set; } = new List<aspnet_Roles>();

    [InverseProperty("Application")]
    public virtual ICollection<aspnet_Users> aspnet_Users { get; set; } = new List<aspnet_Users>();
}
