using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PurchaseOrderHd
{
    [Key]
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

    public int? DefaultReceiptLocation { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? TermOfPayment { get; set; }

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

    public bool? IsTariffChange { get; set; }

    public bool? IsUpdatePrice { get; set; }

    public bool IsPriceApproval { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PriceApprovalBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PriceApprovalDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DownPaymentAmount { get; set; }

    public bool? IsPOConsignment { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("PurchaseOrderHd")]
    public virtual Supplier BusinessPartner { get; set; } = null!;

    [ForeignKey("GCItemType")]
    [InverseProperty("PurchaseOrderHd")]
    public virtual sysGeneralCode GCItemTypeNavigation { get; set; } = null!;

    [ForeignKey("LocationId")]
    [InverseProperty("PurchaseOrderHd")]
    public virtual Location? Location { get; set; }

    [InverseProperty("PurchaseOrderNoNavigation")]
    public virtual ICollection<PurchaseOrderDt> PurchaseOrderDt { get; set; } = new List<PurchaseOrderDt>();

    [InverseProperty("PurchaseOrderNoNavigation")]
    public virtual ICollection<PurchaseOrderReceiptDt> PurchaseOrderReceiptDt { get; set; } = new List<PurchaseOrderReceiptDt>();

    [ForeignKey("RFPNo")]
    [InverseProperty("PurchaseOrderHd")]
    public virtual RequestForProposalHd? RFPNoNavigation { get; set; }

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("PurchaseOrderHd")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PurchaseOrderHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("PurchaseOrderHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
