using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class TempOpeningAR
{
    [StringLength(255)]
    public string? ARNo { get; set; }

    [StringLength(255)]
    public string? SiteCode { get; set; }

    [StringLength(255)]
    public string? TransactionCode { get; set; }

    [StringLength(255)]
    public string? No { get; set; }

    [StringLength(255)]
    public string? BusinessPartnerID { get; set; }

    [StringLength(255)]
    public string? ARDate { get; set; }

    [StringLength(255)]
    public string? TermCode { get; set; }

    [StringLength(255)]
    public string? ARDueDate { get; set; }

    [Column("AR Outstanding Amount")]
    [StringLength(255)]
    public string? AR_Outstanding_Amount { get; set; }

    [StringLength(255)]
    public string? DiscountAmount { get; set; }

    [StringLength(255)]
    public string? ARReverseAmount { get; set; }

    [StringLength(255)]
    public string? GCForceCloseReason { get; set; }

    [StringLength(255)]
    public string? IsForceClose { get; set; }

    [StringLength(255)]
    public string? CloseBy { get; set; }

    [StringLength(255)]
    public string? CloseDateTime { get; set; }

    [StringLength(255)]
    public string? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedDateTime { get; set; }
}
