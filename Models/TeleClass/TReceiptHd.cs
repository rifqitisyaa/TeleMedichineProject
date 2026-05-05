using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TReceiptHd
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    public DateOnly? TransactionDate { get; set; }

    public DateOnly? PaymentDate { get; set; }

    [StringLength(254)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(254)]
    [Unicode(false)]
    public string? PaymentTo { get; set; }

    [StringLength(254)]
    [Unicode(false)]
    public string? Memo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintDate { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? Total { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentBy { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? CashPaymentAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BGNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BGBank { get; set; }

    public DateOnly? BGDate { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? BGAmount { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? ReturnAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ReviewedAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? SettledAmount { get; set; }

    public bool? isApproved { get; set; }

    public bool? isClosed { get; set; }

    public bool? isDeleted { get; set; }

    public DateOnly? CloseDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RevisionBy { get; set; }

    public DateOnly? RevisionDate { get; set; }

    [StringLength(50)]
    public string? ApproveBy { get; set; }

    public DateOnly? ApproveDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SettleBy { get; set; }

    public DateOnly? SettleDate { get; set; }

    public bool? isReviewed { get; set; }

    public bool? IsSettled { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SettlePayBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SettlePayBGNo { get; set; }

    public DateOnly? SettlePayBGDate { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? Debet { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? Kredit { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RequestedCoaCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SettledCoaCode { get; set; }

    public bool? IsReimburse { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    public byte? RevisionNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBSType { get; set; }
}
