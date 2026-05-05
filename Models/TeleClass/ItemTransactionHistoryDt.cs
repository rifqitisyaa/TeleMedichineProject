using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionHistoryID", "SequenceNo")]
public partial class ItemTransactionHistoryDt
{
    [Key]
    public long TransactionHistoryID { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string? JournalSequenceNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string COACode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DebitAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CreditAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GLReference { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("COACode")]
    [InverseProperty("ItemTransactionHistoryDt")]
    public virtual ChartOfAccount COACodeNavigation { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("ItemTransactionHistoryDt")]
    public virtual Department DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ItemTransactionHistoryDt")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("ItemTransactionHistoryDt")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemTransactionHistoryDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionHistoryID")]
    [InverseProperty("ItemTransactionHistoryDt")]
    public virtual ItemTransactionHistoryHd TransactionHistory { get; set; } = null!;
}
