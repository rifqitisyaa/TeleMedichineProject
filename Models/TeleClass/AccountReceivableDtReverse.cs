using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AccountReceivableDtReverse
{
    [Key]
    public long ARReverseID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ARNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ARReverseAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ARNo")]
    [InverseProperty("AccountReceivableDtReverse")]
    public virtual AccountReceivableHd ARNoNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("AccountReceivableDtReverse")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
