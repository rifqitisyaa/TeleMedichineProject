using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class sysUserAndroid
{
    [Key]
    public int UserId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Unicode(false)]
    public string? FullName { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
