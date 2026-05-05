using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MCUHealthSummary
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCHealthStatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCHealthRisk { get; set; }

    public int? RiskQty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCHealthStatusGenerated { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OtherCondition { get; set; }

    [Unicode(false)]
    public string? NoteOtherCondition { get; set; }

    [Unicode(false)]
    public string? PhysicianNotes { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCHealthStatusGenerated")]
    [InverseProperty("MCUHealthSummaryGCHealthStatusGeneratedNavigation")]
    public virtual sysGeneralCode? GCHealthStatusGeneratedNavigation { get; set; }

    [ForeignKey("GCHealthStatus")]
    [InverseProperty("MCUHealthSummaryGCHealthStatusNavigation")]
    public virtual sysGeneralCode? GCHealthStatusNavigation { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("MCUHealthSummary")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
