using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PettyCashHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReimburseNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ReimburseDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentMethod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ChequeNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    public int? BankID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankReference { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankReferenceAccountNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankReferenceAccountName { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CashAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ReimburseAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ApprovalAmount { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool? IsReconcile { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
