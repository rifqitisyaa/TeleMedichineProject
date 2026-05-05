using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReconciliationHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReconciliationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ReconciliationDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCProvider { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CoaCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? PostingSiteCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CalculatedBankChargesAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ActualBankChargesAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal NetAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DebitAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CreditAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransferAmount { get; set; }

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

    [ForeignKey("CoaCode")]
    [InverseProperty("ReconciliationHd")]
    public virtual ChartOfAccount CoaCodeNavigation { get; set; } = null!;

    [ForeignKey("GCProvider")]
    [InverseProperty("ReconciliationHd")]
    public virtual sysGeneralCode GCProviderNavigation { get; set; } = null!;

    [InverseProperty("ReconciliationNoNavigation")]
    public virtual ICollection<ReconciliationDt> ReconciliationDt { get; set; } = new List<ReconciliationDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("ReconciliationHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ReconciliationHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
