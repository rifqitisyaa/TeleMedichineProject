using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class IpAddressMonitoring
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string IpAddress { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCMonitoringType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? JobOrderType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MenuTitle { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ControlUrl { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? DefaultDepartment { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DefaultItemType { get; set; }

    public int? DefaultServiceUnit { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCMonitoringType")]
    [InverseProperty("IpAddressMonitoring")]
    public virtual sysGeneralCode GCMonitoringTypeNavigation { get; set; } = null!;

    [ForeignKey("ItemGroupCode")]
    [InverseProperty("IpAddressMonitoring")]
    public virtual ItemGroup? ItemGroupCodeNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("IpAddressMonitoring")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
