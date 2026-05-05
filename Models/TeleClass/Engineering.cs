using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Engineering
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RequestNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public int? AssetsID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCStatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCIssueType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? RequestBy { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RequestTo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCIssueDescription { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? RemarksAnalysis { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCProblemStatus { get; set; }

    public bool? IsForceClosed { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PhotoBeforeFileName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PhotoAfterFileName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletionDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TakenBy { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InspectBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InspectDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCResult { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RemarksInspection { get; set; }

    public int LocationID { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCIssueDescription")]
    [InverseProperty("EngineeringGCIssueDescriptionNavigation")]
    public virtual sysGeneralCode GCIssueDescriptionNavigation { get; set; } = null!;

    [ForeignKey("GCIssueType")]
    [InverseProperty("EngineeringGCIssueTypeNavigation")]
    public virtual sysGeneralCode GCIssueTypeNavigation { get; set; } = null!;

    [ForeignKey("GCStatus")]
    [InverseProperty("EngineeringGCStatusNavigation")]
    public virtual sysGeneralCode? GCStatusNavigation { get; set; }

    [ForeignKey("LocationID")]
    [InverseProperty("Engineering")]
    public virtual LocationEngineering Location { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("Engineering")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("Engineering")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
