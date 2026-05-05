using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Table_6
{
    [Key]
    public Guid UserId { get; set; }

    [StringLength(128)]
    public string PIN { get; set; } = null!;

    [StringLength(128)]
    public string PINSalt { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Table_6")]
    public virtual sysUser User { get; set; } = null!;
}
