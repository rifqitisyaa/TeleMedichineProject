using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class IcuIndicatorHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GcIcuTemplate { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InputDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCStatus { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCStatus")]
    [InverseProperty("IcuIndicatorHdGCStatusNavigation")]
    public virtual sysGeneralCode? GCStatusNavigation { get; set; }

    [ForeignKey("GcIcuTemplate")]
    [InverseProperty("IcuIndicatorHdGcIcuTemplateNavigation")]
    public virtual sysGeneralCode GcIcuTemplateNavigation { get; set; } = null!;

    [InverseProperty("IcuIndicatorHd")]
    public virtual ICollection<IcuIndicatorDt> IcuIndicatorDt { get; set; } = new List<IcuIndicatorDt>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("IcuIndicatorHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("IcuIndicatorHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
