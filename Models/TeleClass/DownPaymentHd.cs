using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DownPaymentHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DownPaymentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DownPaymentDateTime { get; set; }

    public int BusinessPartnerID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Source { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? SupplierInvoiceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SupplierInvoiceDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SupplierTaxNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SupplierTaxDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DownPaymentAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DownPaymentTaxAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ReverseAmount { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? TaxPercentage { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PaymentMethod { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsUsedIncomingTax { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("DownPaymentHd")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [InverseProperty("DownPaymentNoNavigation")]
    public virtual ICollection<DownPaymentDt> DownPaymentDt { get; set; } = new List<DownPaymentDt>();

    [InverseProperty("DownPaymentNoNavigation")]
    public virtual ICollection<DownPaymentReverse> DownPaymentReverse { get; set; } = new List<DownPaymentReverse>();

    [ForeignKey("SiteCode")]
    [InverseProperty("DownPaymentHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("DownPaymentHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
