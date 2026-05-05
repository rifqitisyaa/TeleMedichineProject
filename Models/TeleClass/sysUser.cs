using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("UserName", Name = "IX_sysUser_UserName", IsUnique = true)]
public partial class sysUser
{
    [Key]
    public Guid UserId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    public bool? IsParamedic { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? LastName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("User")]
    public virtual Table_6? Table_6 { get; set; }

    [InverseProperty("User")]
    public virtual sysUserPIN? sysUserPIN { get; set; }
}
