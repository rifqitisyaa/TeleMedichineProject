using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AccountReceivableHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ARNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    public DateOnly ARDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TermCode { get; set; }

    public DateOnly ARDueDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ARAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ARReverseAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCForceCloseReason { get; set; }

    public bool IsForceClose { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CloseBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDateTime { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ARNoNavigation")]
    public virtual ICollection<AccountReceivableDt> AccountReceivableDt { get; set; } = new List<AccountReceivableDt>();

    [InverseProperty("ARNoNavigation")]
    public virtual ICollection<AccountReceivableDtReverse> AccountReceivableDtReverse { get; set; } = new List<AccountReceivableDtReverse>();

    [InverseProperty("ARNoNavigation")]
    public virtual ICollection<AccountReceivablePaymentReg> AccountReceivablePaymentReg { get; set; } = new List<AccountReceivablePaymentReg>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("AccountReceivableHd")]
    public virtual Customer BusinessPartner { get; set; } = null!;

    [ForeignKey("GCForceCloseReason")]
    [InverseProperty("AccountReceivableHd")]
    public virtual sysGeneralCode? GCForceCloseReasonNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("AccountReceivableHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TermCode")]
    [InverseProperty("AccountReceivableHd")]
    public virtual Term? TermCodeNavigation { get; set; }

    [ForeignKey("TransactionCode")]
    [InverseProperty("AccountReceivableHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
