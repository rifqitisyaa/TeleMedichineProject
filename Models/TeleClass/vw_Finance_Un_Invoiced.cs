using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Finance_Un_Invoiced
{
    [StringLength(20)]
    [Unicode(false)]
    public string ARAccrualNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? BusinessPartnerCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public DateOnly ARAccrualDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ARNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string IsInvoiced { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal SubsidiSurplusAmount { get; set; }

    public bool? IsProceed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AmountDetail { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedByDetail { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTimeDetail { get; set; }
}
