using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionCode", "Source")]
public partial class TransactionCodeSource
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Source { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string WhereClause { get; set; } = null!;

    public bool IsUsingStock { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastupdatedDateTime { get; set; }

    [ForeignKey("TransactionCode")]
    [InverseProperty("TransactionCodeSource")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
