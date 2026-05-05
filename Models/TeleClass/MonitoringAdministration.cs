using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo", "VitalSignCode", "AdministrationDateTime")]
public partial class MonitoringAdministration
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime AdministrationDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VitalSignValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Examiner { get; set; }

    public bool IsCompleted { get; set; }

    public bool IsCancel { get; set; }

    public bool IsDiscontinue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("JobOrderNo, SequenceNo")]
    [InverseProperty("MonitoringAdministration")]
    public virtual JobOrderDtMonitoring JobOrderDtMonitoring { get; set; } = null!;

    [ForeignKey("VitalSignCode")]
    [InverseProperty("MonitoringAdministration")]
    public virtual VitalSignType VitalSignCodeNavigation { get; set; } = null!;
}
