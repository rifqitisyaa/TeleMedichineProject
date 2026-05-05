using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ServiceOrderRequestHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ServiceOrderRequestNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ServiceOrderRequestDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ServiceOrderRequestDueDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal TaxPercentage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TermOfPayment { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public bool? IsReferal { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public byte? RevisionNo { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBySecond { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DownPaymentAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("PurchaseOrderNoNavigation")]
    public virtual ICollection<Assets> Assets { get; set; } = new List<Assets>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("ServiceOrderRequestHd")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("GCItemType")]
    [InverseProperty("ServiceOrderRequestHd")]
    public virtual sysGeneralCode GCItemTypeNavigation { get; set; } = null!;

    [InverseProperty("ServiceOrderRequestNoNavigation")]
    public virtual ICollection<ServiceOrderRequestDt> ServiceOrderRequestDt { get; set; } = new List<ServiceOrderRequestDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("ServiceOrderRequestHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ServiceOrderRequestHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
