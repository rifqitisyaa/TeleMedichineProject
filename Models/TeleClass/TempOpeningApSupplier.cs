using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class TempOpeningApSupplier
{
    [StringLength(255)]
    public string? APNo { get; set; }

    [StringLength(255)]
    public string? SiteCode { get; set; }

    [StringLength(255)]
    public string? TransactionCode { get; set; }

    [StringLength(255)]
    public string? No { get; set; }

    [StringLength(255)]
    public string? BusinessPartnerID { get; set; }

    [StringLength(255)]
    public string? Source { get; set; }

    [StringLength(255)]
    public string? SupplierInvoiceNo { get; set; }

    [StringLength(255)]
    public string? SupplierInvoiceDate { get; set; }

    [StringLength(255)]
    public string? SupplierTaxNo { get; set; }

    [StringLength(255)]
    public string? SupplierTaxDate { get; set; }

    [StringLength(255)]
    public string? APDate { get; set; }

    [StringLength(255)]
    public string? TermOfPayment { get; set; }

    [StringLength(255)]
    public string? APDueDate { get; set; }

    [StringLength(255)]
    public string? OutstandingAmount { get; set; }

    [StringLength(255)]
    public string? TotalDiscount { get; set; }

    [StringLength(255)]
    public string? TaxAmount { get; set; }

    [StringLength(255)]
    public string? PaymentAmount { get; set; }

    [StringLength(255)]
    public string? TotalAmount { get; set; }

    [StringLength(255)]
    public string? CreditNoteAmount { get; set; }

    [StringLength(255)]
    public string? GCIncomeTaxName { get; set; }

    [StringLength(255)]
    public string? IncomeTaxPercentage { get; set; }

    [StringLength(255)]
    public string? IncomeTaxAmount { get; set; }

    [StringLength(255)]
    public string? IsApproved { get; set; }

    [StringLength(255)]
    public string? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedDateTime { get; set; }
}
