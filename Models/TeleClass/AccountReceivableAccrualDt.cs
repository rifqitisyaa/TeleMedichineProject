using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ARAccrualNo", "TransactionNo")]
public partial class AccountReceivableAccrualDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ARAccrualNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ARAccrualNo")]
    [InverseProperty("AccountReceivableAccrualDt")]
    public virtual AccountReceivableAccrual ARAccrualNoNavigation { get; set; } = null!;

    [ForeignKey("TransactionNo")]
    [InverseProperty("AccountReceivableAccrualDt")]
    public virtual TransactionChargesHd TransactionNoNavigation { get; set; } = null!;
}
