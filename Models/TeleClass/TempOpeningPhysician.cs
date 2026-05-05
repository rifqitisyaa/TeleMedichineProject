using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class TempOpeningPhysician
{
    [StringLength(255)]
    public string? VerificationNo { get; set; }

    [StringLength(255)]
    public string? TransactionCode { get; set; }

    [StringLength(255)]
    public string? SiteCode { get; set; }

    [StringLength(255)]
    public string? VerificationDate { get; set; }

    [StringLength(255)]
    public string? No { get; set; }

    [StringLength(255)]
    public string? ParamedicID { get; set; }

    [StringLength(255)]
    public string? DueDate { get; set; }

    [StringLength(255)]
    public string? TotalChargesAmount { get; set; }

    [StringLength(255)]
    public string? FeeAmount { get; set; }

    [StringLength(255)]
    public string? DiscountAmount { get; set; }

    [StringLength(255)]
    public string? TotalPhysicianTax { get; set; }

    [StringLength(255)]
    public string? DPPAmount { get; set; }

    [StringLength(255)]
    public string? IsReviewed { get; set; }

    [StringLength(255)]
    public string? ReviewedByUserID { get; set; }

    [StringLength(255)]
    public string? ReviewedDateTime { get; set; }

    [StringLength(255)]
    public string? IsApproved { get; set; }

    [StringLength(255)]
    public string? ApprovedByUserID { get; set; }

    [StringLength(255)]
    public string? ApprovedDateTime { get; set; }

    [StringLength(255)]
    public string? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedDateTime { get; set; }
}
