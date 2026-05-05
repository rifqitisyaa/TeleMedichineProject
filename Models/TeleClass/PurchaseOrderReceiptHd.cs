using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PurchaseOrderReceiptHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string POReceiptNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly POReceiptDate { get; set; }

    public byte? RevisionNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShipmentNo { get; set; }

    public int BusinessPartnerID { get; set; }

    public int LocationID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrepareddateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool? IsClosed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? InvoicedAmount { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("PurchaseOrderReceiptHd")]
    public virtual Supplier BusinessPartner { get; set; } = null!;

    [ForeignKey("LocationID")]
    [InverseProperty("PurchaseOrderReceiptHd")]
    public virtual Location Location { get; set; } = null!;

    [InverseProperty("POReceiptNoNavigation")]
    public virtual ICollection<PurchaseOrderReceiptDt> PurchaseOrderReceiptDt { get; set; } = new List<PurchaseOrderReceiptDt>();

    [InverseProperty("POReceiptNoNavigation")]
    public virtual ICollection<ReturnToSupplierHd> ReturnToSupplierHd { get; set; } = new List<ReturnToSupplierHd>();

    [ForeignKey("SiteCode")]
    [InverseProperty("PurchaseOrderReceiptHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("PurchaseOrderReceiptHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
