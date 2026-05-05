using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysRolePersonalization
{
    [Key]
    public Guid RoleID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string DefaultUrl { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RoleID")]
    [InverseProperty("sysRolePersonalization")]
    public virtual aspnet_Roles Role { get; set; } = null!;
}
