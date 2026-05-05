using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Finance_Invoiced
{
    [StringLength(20)]
    [Unicode(false)]
    public string ARNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? BusinessPartnerCode { get; set; }

    public DateOnly ARDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TermCode { get; set; }

    public DateOnly ARDueDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ARAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ARReverseAmount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ForceCloseReasonName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ForceCloseReasonName2 { get; set; }

    public bool IsForceClose { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CloseBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ARAccrualNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
