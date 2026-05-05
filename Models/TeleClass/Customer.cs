using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Customer
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCInsuranceType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCustomerType { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CreditLimit { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CreditBalance { get; set; }

    public bool IsBlackList { get; set; }

    [Unicode(false)]
    public string? BlackListReason { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<AccountReceivableAccrual> AccountReceivableAccrual { get; set; } = new List<AccountReceivableAccrual>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<AccountReceivableHd> AccountReceivableHd { get; set; } = new List<AccountReceivableHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<AccountReceivablePaymentHd> AccountReceivablePaymentHd { get; set; } = new List<AccountReceivablePaymentHd>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("Customer")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [InverseProperty("BillToBusinessPartner")]
    public virtual ICollection<CustomerContract> CustomerContractBillToBusinessPartner { get; set; } = new List<CustomerContract>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<CustomerContract> CustomerContractBusinessPartner { get; set; } = new List<CustomerContract>();

    [ForeignKey("GCCustomerType")]
    [InverseProperty("CustomerGCCustomerTypeNavigation")]
    public virtual sysGeneralCode? GCCustomerTypeNavigation { get; set; }

    [ForeignKey("GCInsuranceType")]
    [InverseProperty("CustomerGCInsuranceTypeNavigation")]
    public virtual sysGeneralCode? GCInsuranceTypeNavigation { get; set; }

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<ItemTariffCorporate> ItemTariffCorporate { get; set; } = new List<ItemTariffCorporate>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<PraProcessHd> PraProcessHd { get; set; } = new List<PraProcessHd>();
}
