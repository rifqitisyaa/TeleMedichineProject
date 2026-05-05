using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BankReconcileHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReconNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ReconDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int BankID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CoaCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransferAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ChequeGiroAmount { get; set; }

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
