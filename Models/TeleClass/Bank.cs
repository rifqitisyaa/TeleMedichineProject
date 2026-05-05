using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("BankAccountNo", Name = "UNIQUE_IX_Bank_BankAccountNo", IsUnique = true)]
[Index("BankCode", Name = "UNIQUE_IX_Bank_BankCode", IsUnique = true)]
public partial class Bank
{
    [Key]
    public int BankID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    /// <summary>
    /// Bank Code
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string BankCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BankName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCShortName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCProvider { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string BankAccountNo { get; set; } = null!;

    /// <summary>
    /// Bank Account Name
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string BankAccountName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Bank")]
    public virtual ICollection<AccountPayablePaymentPlanHd> AccountPayablePaymentPlanHd { get; set; } = new List<AccountPayablePaymentPlanHd>();

    [InverseProperty("Bank")]
    public virtual ICollection<AccountReceivablePaymentDt> AccountReceivablePaymentDt { get; set; } = new List<AccountReceivablePaymentDt>();

    [InverseProperty("Bank")]
    public virtual ICollection<CustomerBank> CustomerBank { get; set; } = new List<CustomerBank>();

    [InverseProperty("Bank")]
    public virtual ICollection<DepositPaymentDt> DepositPaymentDt { get; set; } = new List<DepositPaymentDt>();

    [ForeignKey("GCProvider")]
    [InverseProperty("BankGCProviderNavigation")]
    public virtual sysGeneralCode? GCProviderNavigation { get; set; }

    [ForeignKey("GCShortName")]
    [InverseProperty("BankGCShortNameNavigation")]
    public virtual sysGeneralCode? GCShortNameNavigation { get; set; }

    [InverseProperty("Bank")]
    public virtual ICollection<PaymentRefund> PaymentRefund { get; set; } = new List<PaymentRefund>();

    [InverseProperty("Bank")]
    public virtual ICollection<PaymentRefundMedication> PaymentRefundMedication { get; set; } = new List<PaymentRefundMedication>();

    [InverseProperty("Bank")]
    public virtual ICollection<PhysicianFeePaymentPlanHd> PhysicianFeePaymentPlanHd { get; set; } = new List<PhysicianFeePaymentPlanHd>();

    [ForeignKey("SiteCode")]
    [InverseProperty("Bank")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
