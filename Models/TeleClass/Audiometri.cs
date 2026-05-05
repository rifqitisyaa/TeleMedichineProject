using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo", "ItemId")]
public partial class Audiometri
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int ItemId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DiagnosaKlinis { get; set; }

    public bool? Batuk { get; set; }

    public bool? SesakNafas { get; set; }

    public bool? Berdahak { get; set; }

    public bool? RiwayatAsma { get; set; }

    public bool? BunyiNafas { get; set; }

    public bool? RiwayatOat { get; set; }

    public bool? RiwayatInhaler { get; set; }

    public bool? RiwayatMerokok { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Ib { get; set; }

    public bool? RiwayatBiomass { get; set; }

    [Unicode(false)]
    public string? Thorax { get; set; }

    public bool? STRonchi1 { get; set; }

    public bool? STRonchi2 { get; set; }

    public bool? Mengi1 { get; set; }

    public bool? Mengi2 { get; set; }

    public bool? Mengi3 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? NilaiQty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PrediksiQty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PercentageQty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? NilaiFev1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PrediksiFev1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PresentaseFev1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DivideNilaiFev { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DividePrediksiFev { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DividePresentasiFev { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? NilaiFeef25 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PrediksiFeef25 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PresentaseFeef25 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? NilaiFeef50 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PrediksiFeef50 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PresentaseFeef50 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? NilaiFeef75 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PrediksiFeef75 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PresentaseFeef75 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? NilaiFeefTotal { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PrediksiFeefTotal { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PresentaseFeefTotal { get; set; }

    [Unicode(false)]
    public string? Kesan { get; set; }

    [Unicode(false)]
    public string? Assessment { get; set; }

    [Unicode(false)]
    public string? Planning { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool? IsReview { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReviewBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastReviewDateTime { get; set; }

    public bool? IsApprove { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApproveBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastApproveDateTime { get; set; }

    [ForeignKey("JobOrderNo, SequenceNo, ItemId")]
    [InverseProperty("Audiometri")]
    public virtual JobOrderBOMOtherExam JobOrderBOMOtherExam { get; set; } = null!;
}
