using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Finance_DebitNoteCreditNote
{
    [StringLength(20)]
    [Unicode(false)]
    public string DNCNNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? BusinessPartnerCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public DateOnly DNCNDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TermCode { get; set; }

    public DateOnly DNCNDueDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DNCNAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DNCNReverseAmount { get; set; }

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

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string DNCNSequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedByDetil { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTimeDetil { get; set; }
}
