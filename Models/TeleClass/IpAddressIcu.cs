using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceUnitId", "IpAdderess")]
public partial class IpAddressIcu
{
    [Key]
    public int ServiceUnitId { get; set; }

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string IpAdderess { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("IpAddressIcu")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;
}
