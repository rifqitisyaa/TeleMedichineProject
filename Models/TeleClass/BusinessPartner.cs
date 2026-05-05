using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("BusinessPartnerCode", Name = "IX_BusinessPartner_BussinessPartnerCode", IsUnique = true)]
public partial class BusinessPartner
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string BusinessPartnerCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessPartnerName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    public byte BusinessPartnerType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ContactPerson1Name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ContactPerson2Name { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ContactPerson1PhoneNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ContactPerson2PhoneNo { get; set; } = null!;

    public bool IsTaxRegistrant { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TaxRegistrantNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? TermCode { get; set; }

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

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<AccountReceivableWriteOffPlanHd> AccountReceivableWriteOffPlanHd { get; set; } = new List<AccountReceivableWriteOffPlanHd>();

    [InverseProperty("Businesspartner")]
    public virtual ICollection<Assets> Assets { get; set; } = new List<Assets>();

    [InverseProperty("BusinessParter")]
    public virtual ICollection<CorporateItem> CorporateItem { get; set; } = new List<CorporateItem>();

    [InverseProperty("BusinessPartner")]
    public virtual Customer? Customer { get; set; }

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<CustomerAkomodasiKamar> CustomerAkomodasiKamar { get; set; } = new List<CustomerAkomodasiKamar>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<CustomerBank> CustomerBank { get; set; } = new List<CustomerBank>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<CustomerClass> CustomerClass { get; set; } = new List<CustomerClass>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<CustomerItem> CustomerItem { get; set; } = new List<CustomerItem>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<CustomerParamedic> CustomerParamedic { get; set; } = new List<CustomerParamedic>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<CustomerReferal> CustomerReferal { get; set; } = new List<CustomerReferal>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<CustomerServiceUnit> CustomerServiceUnit { get; set; } = new List<CustomerServiceUnit>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<DebitNoteCreditNoteHd> DebitNoteCreditNoteHd { get; set; } = new List<DebitNoteCreditNoteHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<DownPaymentHd> DownPaymentHd { get; set; } = new List<DownPaymentHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<GuidelineInclusionHd> GuidelineInclusionHd { get; set; } = new List<GuidelineInclusionHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<ItemPlanning> ItemPlanning { get; set; } = new List<ItemPlanning>();

    [InverseProperty("BussinessPartner")]
    public virtual ICollection<MultiPayerAuthorized> MultiPayerAuthorized { get; set; } = new List<MultiPayerAuthorized>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<PatientCorporateEligibility> PatientCorporateEligibility { get; set; } = new List<PatientCorporateEligibility>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<PatientPayerCard> PatientPayerCard { get; set; } = new List<PatientPayerCard>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<PrescriptionPayment> PrescriptionPayment { get; set; } = new List<PrescriptionPayment>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<ProjectMCUCorporate> ProjectMCUCorporate { get; set; } = new List<ProjectMCUCorporate>();

    [InverseProperty("BusinessPartnerIDAfterNavigation")]
    public virtual ICollection<RecalculationHd> RecalculationHdBusinessPartnerIDAfterNavigation { get; set; } = new List<RecalculationHd>();

    [InverseProperty("BusinessPartnerIDBeforeNavigation")]
    public virtual ICollection<RecalculationHd> RecalculationHdBusinessPartnerIDBeforeNavigation { get; set; } = new List<RecalculationHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<ReplacementHd> ReplacementHd { get; set; } = new List<ReplacementHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<ServiceOrderHd> ServiceOrderHd { get; set; } = new List<ServiceOrderHd>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<ServiceOrderRequestHd> ServiceOrderRequestHd { get; set; } = new List<ServiceOrderRequestHd>();

    [InverseProperty("BusinessPartner")]
    public virtual Supplier? Supplier { get; set; }

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<SupplierItem> SupplierItem { get; set; } = new List<SupplierItem>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<SupplierItemPrice> SupplierItemPrice { get; set; } = new List<SupplierItemPrice>();

    [InverseProperty("BusinessPartner")]
    public virtual ICollection<TemplateTariffHd> TemplateTariffHd { get; set; } = new List<TemplateTariffHd>();
}
