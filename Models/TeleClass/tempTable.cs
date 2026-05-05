using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tempTable
{
    [StringLength(20)]
    [Unicode(false)]
    public string PurchaseOrderNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PurchaseOrderDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    public int? ServiceUnitId { get; set; }

    public int? LocationId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RFPNo { get; set; }

    public DateOnly? POReleaseDate { get; set; }

    public DateOnly? PODueDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCreditTerms { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? TaxPercentage { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal? POAmount { get; set; }

    public bool IsTaxable { get; set; }

    public byte? RevisionNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Notes { get; set; } = null!;

    public bool? IsCreatedFromMRP { get; set; }

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

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApproveBySecond { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool? IsReceived { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
