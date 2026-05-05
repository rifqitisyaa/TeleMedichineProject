using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ReconcileNo", "SequenceNo")]
public partial class BankReconcileAPDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReconcileNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    [StringLength(20)]
    public string? GCTransactionType { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? BankChargesAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
