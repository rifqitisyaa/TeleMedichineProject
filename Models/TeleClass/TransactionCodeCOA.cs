using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionCode", "SequenceNo")]
public partial class TransactionCodeCOA
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string WhereClause { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DebetCredit { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? AGCGroup { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AGCItemCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? COACode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Source { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AGCItemCode")]
    [InverseProperty("TransactionCodeCOA")]
    public virtual AGCItem? AGCItemCodeNavigation { get; set; }

    [ForeignKey("COACode")]
    [InverseProperty("TransactionCodeCOA")]
    public virtual ChartOfAccount? COACodeNavigation { get; set; }

    [ForeignKey("TransactionCode")]
    [InverseProperty("TransactionCodeCOA")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
