using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AccountReceivablePaymentHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PaymentDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentAmount { get; set; }

    public int BusinessPartnerID { get; set; }

    public bool IsForceClose { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? OnBehalfOf { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("PaymentNoNavigation")]
    public virtual ICollection<AccountReceivablePaymentDt> AccountReceivablePaymentDt { get; set; } = new List<AccountReceivablePaymentDt>();

    [InverseProperty("PaymentNoNavigation")]
    public virtual ICollection<AccountReceivablePaymentReg> AccountReceivablePaymentReg { get; set; } = new List<AccountReceivablePaymentReg>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("AccountReceivablePaymentHd")]
    public virtual Customer BusinessPartner { get; set; } = null!;

    [InverseProperty("PaymentNoNavigation")]
    public virtual ICollection<DiscountPhysicianReverse> DiscountPhysicianReverse { get; set; } = new List<DiscountPhysicianReverse>();

    [ForeignKey("SiteCode")]
    [InverseProperty("AccountReceivablePaymentHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("AccountReceivablePaymentHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
