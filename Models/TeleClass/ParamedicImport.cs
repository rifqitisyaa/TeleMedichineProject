using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ParamedicImport
{
    public double? ParamedicID { get; set; }

    [StringLength(255)]
    public string? ParamedicCode { get; set; }

    [StringLength(255)]
    public string? ParamedicInitial { get; set; }

    [StringLength(255)]
    public string? Title { get; set; }

    [StringLength(255)]
    public string? FirstName { get; set; }

    [StringLength(255)]
    public string? MiddleName { get; set; }

    [StringLength(255)]
    public string? LastName { get; set; }

    [StringLength(255)]
    public string? Suffix { get; set; }

    [StringLength(255)]
    public string? ParamedicName { get; set; }

    [StringLength(255)]
    public string? IsHasPhysicianRole { get; set; }

    [StringLength(255)]
    public string? IsAnesthetist { get; set; }

    [StringLength(255)]
    public string? RuangLingkup { get; set; }

    [StringLength(255)]
    public string? Line1 { get; set; }

    [StringLength(255)]
    public string? City { get; set; }

    [StringLength(255)]
    public string? PhoneNo1 { get; set; }

    [StringLength(255)]
    public string? PhoneNo2 { get; set; }

    public double? SpecialtyCode { get; set; }

    [StringLength(255)]
    public string? Specialty { get; set; }

    [StringLength(255)]
    public string? FeePercentage { get; set; }

    [StringLength(255)]
    public string? DateOfBirth { get; set; }

    [StringLength(255)]
    public string? GCSex { get; set; }

    [StringLength(255)]
    public string? Sex { get; set; }

    [StringLength(255)]
    public string? GCParamedicType { get; set; }

    [StringLength(255)]
    public string? Tipe { get; set; }

    [StringLength(255)]
    public string? GCEmploymentStatus { get; set; }

    [StringLength(255)]
    public string? Employee_Status { get; set; }

    [StringLength(255)]
    public string? GCReligion { get; set; }

    [StringLength(255)]
    public string? Religion { get; set; }

    [StringLength(255)]
    public string? Start_Experience_Date { get; set; }

    [StringLength(255)]
    public string? IsTaxRegistrant { get; set; }

    [StringLength(255)]
    public string? TaxRegistrantNo { get; set; }

    [StringLength(255)]
    public string? LicenseNo { get; set; }

    [StringLength(255)]
    public string? LicenseExpiredDate { get; set; }

    [StringLength(255)]
    public string? BankName { get; set; }

    [StringLength(255)]
    public string? BankAccountNo { get; set; }

    [StringLength(255)]
    public string? BankAccountName { get; set; }

    [StringLength(255)]
    public string? Remarks { get; set; }
}
