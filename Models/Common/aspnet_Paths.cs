using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class aspnet_Paths
{
    public Guid ApplicationId { get; set; }

    [Key]
    public Guid PathId { get; set; }

    [StringLength(256)]
    public string Path { get; set; } = null!;

    [StringLength(256)]
    public string LoweredPath { get; set; } = null!;

    [ForeignKey("ApplicationId")]
    [InverseProperty("aspnet_Paths")]
    public virtual aspnet_Applications Application { get; set; } = null!;

    [InverseProperty("Path")]
    public virtual aspnet_PersonalizationAllUsers? aspnet_PersonalizationAllUsers { get; set; }

    [InverseProperty("Path")]
    public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; } = new List<aspnet_PersonalizationPerUser>();
}
