using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ReconciliationNo", "ReferenceNo", "ReferenceSequenceNo")]
public partial class ReconciliationDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReconciliationNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string ReferenceSequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCTransactionType { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BankChargesAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCTransactionType")]
    [InverseProperty("ReconciliationDt")]
    public virtual sysGeneralCode GCTransactionTypeNavigation { get; set; } = null!;

    [ForeignKey("ReconciliationNo")]
    [InverseProperty("ReconciliationDt")]
    public virtual ReconciliationHd ReconciliationNoNavigation { get; set; } = null!;
}
