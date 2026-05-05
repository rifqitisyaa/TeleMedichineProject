using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ReconNo", "SequenceNo")]
public partial class BankReconcileDt
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string ReconNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [Unicode(false)]
    public string? Reference { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PaymentMethod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransactionType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ChequeGiroNo { get; set; }

    [Unicode(false)]
    public string? BankReferenceNo { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Amount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
