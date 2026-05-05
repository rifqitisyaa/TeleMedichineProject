using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo")]
public partial class JobOrderDtMonitoring
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDateTime { get; set; }

    public short Interval { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("JobOrderNo")]
    [InverseProperty("JobOrderDtMonitoring")]
    public virtual JobOrderHd JobOrderNoNavigation { get; set; } = null!;

    [InverseProperty("JobOrderDtMonitoring")]
    public virtual ICollection<MonitoringAdministration> MonitoringAdministration { get; set; } = new List<MonitoringAdministration>();

    [ForeignKey("VitalSignCode")]
    [InverseProperty("JobOrderDtMonitoring")]
    public virtual VitalSignType VitalSignCodeNavigation { get; set; } = null!;
}
