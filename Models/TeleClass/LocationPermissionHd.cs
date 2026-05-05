using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LocationPermissionHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string PermissionCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PermissionName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("PermissionCodeNavigation")]
    public virtual ICollection<Location> Location { get; set; } = new List<Location>();
}
