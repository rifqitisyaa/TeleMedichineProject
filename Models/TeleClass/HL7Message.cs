using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class HL7Message
{
    [Key]
    public long MessageID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime MessageDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCSendingApplication { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCReceivingApplication { get; set; } = null!;

    [Unicode(false)]
    public string MessageText { get; set; } = null!;

    public bool IsSended { get; set; }

    public bool IsReceived { get; set; }

    public bool IsCanceled { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [ForeignKey("GCReceivingApplication")]
    [InverseProperty("HL7MessageGCReceivingApplicationNavigation")]
    public virtual sysGeneralCode GCReceivingApplicationNavigation { get; set; } = null!;

    [ForeignKey("GCSendingApplication")]
    [InverseProperty("HL7MessageGCSendingApplicationNavigation")]
    public virtual sysGeneralCode GCSendingApplicationNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("HL7Message")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
