using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ServiceUnitJobOrderType
{
    [Key]
    public int Id { get; set; }

    public int ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int SiteDepartmentID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IpAddressMonitoring { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemGroupCode")]
    [InverseProperty("ServiceUnitJobOrderType")]
    public virtual ItemGroup? ItemGroupCodeNavigation { get; set; }

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ServiceUnitJobOrderType")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ServiceUnitJobOrderType")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteDepartmentID")]
    [InverseProperty("ServiceUnitJobOrderType")]
    public virtual SiteDepartment SiteDepartment { get; set; } = null!;
}
