using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class UploadSupplier
{
    [StringLength(255)]
    public string? BusinessPartnerID { get; set; }

    [StringLength(255)]
    public string? BusinessPartnerCode { get; set; }

    [StringLength(255)]
    public string? ShortName { get; set; }

    [StringLength(255)]
    public string? Initial { get; set; }

    [StringLength(255)]
    public string? BusinessPartnerName { get; set; }

    [StringLength(255)]
    public string? GCSupplierType { get; set; }

    [StringLength(255)]
    public string? Tipe { get; set; }

    [StringLength(255)]
    public string? Remarks { get; set; }

    [StringLength(255)]
    public string? LeadTime { get; set; }

    [StringLength(255)]
    public string? ContactPerson1Name { get; set; }

    [StringLength(255)]
    public string? ContactPerson2Name { get; set; }

    [StringLength(255)]
    public string? ContactPerson1PhoneNo { get; set; }

    [StringLength(255)]
    public string? ContactPerson2PhoneNo { get; set; }

    [StringLength(255)]
    public string? BankName { get; set; }

    [StringLength(255)]
    public string? BankAccountNo { get; set; }

    [StringLength(255)]
    public string? BankAccountName { get; set; }

    [StringLength(255)]
    public string? IsTaxRegistrant { get; set; }

    [StringLength(255)]
    public string? TaxRegistrantNo { get; set; }

    [StringLength(255)]
    public string? TaxPercentage { get; set; }

    [StringLength(255)]
    public string? TermCode { get; set; }

    [StringLength(255)]
    public string? TermName { get; set; }

    [StringLength(255)]
    public string? Line1 { get; set; }

    [StringLength(255)]
    public string? City { get; set; }

    [StringLength(255)]
    public string? PhoneNo1 { get; set; }

    [StringLength(255)]
    public string? PhoneNo2 { get; set; }

    [StringLength(255)]
    public string? Email1 { get; set; }

    [StringLength(255)]
    public string? Email2 { get; set; }

    [StringLength(255)]
    public string? FaxNo1 { get; set; }

    [StringLength(255)]
    public string? FaxNo2 { get; set; }
}
