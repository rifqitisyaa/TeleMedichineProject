using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RequestForProposalHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RFPNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly RFPDate { get; set; }

    public DateOnly ReplayDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    public byte? RevisionNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCItemType")]
    [InverseProperty("RequestForProposalHd")]
    public virtual sysGeneralCode GCItemTypeNavigation { get; set; } = null!;

    [InverseProperty("RFPNoNavigation")]
    public virtual ICollection<PurchaseOrderHd> PurchaseOrderHd { get; set; } = new List<PurchaseOrderHd>();

    [InverseProperty("RFPNoNavigation")]
    public virtual ICollection<RequestForProposalSubDt> RequestForProposalSubDt { get; set; } = new List<RequestForProposalSubDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("RequestForProposalHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("RequestForProposalHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
