using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PurchaseRequestCompletionHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PRCompletionNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly PRCompletionDate { get; set; }

    public int FromServiceUnitId { get; set; }

    public int ToServiceUnitId { get; set; }

    public int FromLocationId { get; set; }

    public int ToLocationId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCPRComplitionType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCItemType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CoaCodeDebit { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReason { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    public byte RevisionNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
