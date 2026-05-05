using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Patient_DiscountPhysician
{
    [StringLength(20)]
    [Unicode(false)]
    public string DiscountPhysicianNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DiscountPhysicianDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ParamedicCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ServiceUnitCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountReverseAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VerificationNo { get; set; }

    public bool? IsReviewedDiscountPhysician { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedByDiscountPhysician { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTimeDiscountPhysician { get; set; }

    public bool IsDeletedDiscountPhysician { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedByDiscountPhysician { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTimeDiscountPhysician { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PaymentNo { get; set; }

    public bool? IsDeletedPayement { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedByPayment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTimePayment { get; set; }
}
