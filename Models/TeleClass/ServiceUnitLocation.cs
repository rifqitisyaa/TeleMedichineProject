using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceUnitID", "LocationID")]
public partial class ServiceUnitLocation
{
    [Key]
    public int ServiceUnitID { get; set; }

    [Key]
    public int LocationID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("LocationID")]
    [InverseProperty("ServiceUnitLocation")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ServiceUnitLocation")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;
}
