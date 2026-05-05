using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReturnToSupplierHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReturnToSupplierNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ReturnDate { get; set; }

    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string POReceiptNo { get; set; } = null!;

    public int LocationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReturnToSupplierType { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    public bool IsTaxable { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TaxPercentage { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Notes { get; set; } = null!;

    public byte? RevisionNo { get; set; }

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
    public DateTime? PreparedDateTime { get; set; }

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

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("ReturnToSupplierHd")]
    public virtual Supplier BusinessPartner { get; set; } = null!;

    [ForeignKey("GCReturnToSupplierType")]
    [InverseProperty("ReturnToSupplierHd")]
    public virtual sysGeneralCode? GCReturnToSupplierTypeNavigation { get; set; }

    [ForeignKey("LocationID")]
    [InverseProperty("ReturnToSupplierHd")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("POReceiptNo")]
    [InverseProperty("ReturnToSupplierHd")]
    public virtual PurchaseOrderReceiptHd POReceiptNoNavigation { get; set; } = null!;

    [InverseProperty("ReturnToSupplierNoNavigation")]
    public virtual ICollection<ReplacementHd> ReplacementHd { get; set; } = new List<ReplacementHd>();

    [InverseProperty("ReturnToSupplierNoNavigation")]
    public virtual ICollection<ReturnToSupplierDt> ReturnToSupplierDt { get; set; } = new List<ReturnToSupplierDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("ReturnToSupplierHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ReturnToSupplierHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
