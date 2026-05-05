using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceUnitID", "ItemID")]
public partial class ServiceUnitItem
{
    [Key]
    public int ServiceUnitID { get; set; }

    [Key]
    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ServiceUnitItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ServiceUnitItem")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;
}
