using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class HL7ThirdParty
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string InterfaceEventType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCThirdParty { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string HL7Version { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string MessageType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? StoredProcedureSend { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? StoredProcedureReceived { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string UrlService { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? UrlServiceReceiveResult { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? SperatorChar { get; set; }

    public bool? IsVitalSign { get; set; }

    public bool? IsUseAckHL7 { get; set; }

    public bool IsEnable { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCThirdParty")]
    [InverseProperty("HL7ThirdParty")]
    public virtual sysGeneralCode GCThirdPartyNavigation { get; set; } = null!;
}
