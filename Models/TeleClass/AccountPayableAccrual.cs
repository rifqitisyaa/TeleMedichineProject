using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AccountPayableAccrual
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string APAccrualNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string POReceiptNo { get; set; } = null!;

    public DateOnly APAccrualDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TaxAmount { get; set; }

    public bool? IsProceed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("APAccrualNoNavigation")]
    public virtual ICollection<AccountPayableDtAccrual> AccountPayableDtAccrual { get; set; } = new List<AccountPayableDtAccrual>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("AccountPayableAccrual")]
    public virtual Supplier BusinessPartner { get; set; } = null!;

    [InverseProperty("APAccrualNoNavigation")]
    public virtual ICollection<DownPaymentReverse> DownPaymentReverse { get; set; } = new List<DownPaymentReverse>();

    [ForeignKey("SiteCode")]
    [InverseProperty("AccountPayableAccrual")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("AccountPayableAccrual")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
