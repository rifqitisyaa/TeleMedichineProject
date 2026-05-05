using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetsDisposalHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AssetsDisposalNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AssetsDisposalDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string GCPaymentType { get; set; } = null!;

    public int? BankID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCodeBank { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string GCDisposalMethode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DisposalAmount { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalAcquistionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalCostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalDepreciationAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Profit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
