using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BankReconcileAPHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReconcileNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ReconcileDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCProvider { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string COACode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CalculatedBankChargesAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ActualBankChargesAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal NetAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CheckGiroAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransferAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
