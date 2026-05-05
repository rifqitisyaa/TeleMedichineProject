using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ReconcileNo", "SequenceNo")]
public partial class BankReconcileARDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReconcileNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ReferenceName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal TransactionAmount { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
