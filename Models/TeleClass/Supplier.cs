using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Supplier
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSupplierType { get; set; }

    public byte LeadTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankAccountNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankAccountName { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? TaxPercentage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<AccountPayableAccrual> AccountPayableAccrual { get; set; } = new List<AccountPayableAccrual>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<AccountPayableHd> AccountPayableHd { get; set; } = new List<AccountPayableHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<AccountPayablePaymentPlanHd> AccountPayablePaymentPlanHd { get; set; } = new List<AccountPayablePaymentPlanHd>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("Supplier")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<CreditNote> CreditNote { get; set; } = new List<CreditNote>();

    [ForeignKey("GCSupplierType")]
    [InverseProperty("Supplier")]
    public virtual sysGeneralCode? GCSupplierTypeNavigation { get; set; }

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<PurchaseOrderHd> PurchaseOrderHd { get; set; } = new List<PurchaseOrderHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<PurchaseOrderReceiptHd> PurchaseOrderReceiptHd { get; set; } = new List<PurchaseOrderReceiptHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<RequestForProposalDt> RequestForProposalDt { get; set; } = new List<RequestForProposalDt>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<ReturnToSupplierHd> ReturnToSupplierHd { get; set; } = new List<ReturnToSupplierHd>();
}
