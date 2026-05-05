using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ApprovalLevel
{
    [Key]
    public int ApprovalID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCApprovalLevel { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string OnBehalfOf { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCApprovalLevel")]
    [InverseProperty("ApprovalLevel")]
    public virtual sysGeneralCode GCApprovalLevelNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ApprovalLevel")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ApprovalLevel")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
