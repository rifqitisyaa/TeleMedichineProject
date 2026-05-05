using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("BusinessPartnerID", "RegistrationNo", Name = "IX_AccountReceivableAccrual")]
public partial class AccountReceivableAccrual
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ARAccrualNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    public DateOnly ARAccrualDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SubsidiSurplusAmount { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PendingReason { get; set; }

    public bool? IsPending { get; set; }

    public bool? IsProceed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ARAccrualNoNavigation")]
    public virtual ICollection<AccountReceivableAccrualDt> AccountReceivableAccrualDt { get; set; } = new List<AccountReceivableAccrualDt>();

    [InverseProperty("ARAccrualNoNavigation")]
    public virtual ICollection<AccountReceivableDt> AccountReceivableDt { get; set; } = new List<AccountReceivableDt>();

    [InverseProperty("ARANoNavigation")]
    public virtual ICollection<AccountReceivablePaymentReg> AccountReceivablePaymentReg { get; set; } = new List<AccountReceivablePaymentReg>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("AccountReceivableAccrual")]
    public virtual Customer BusinessPartner { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("AccountReceivableAccrual")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("AccountReceivableAccrual")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("AccountReceivableAccrual")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
