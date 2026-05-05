using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CustomerContract
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    public DateOnly DocumentDate { get; set; }

    public int BusinessPartnerID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ContractNo { get; set; } = null!;

    public DateOnly StartingDate { get; set; }

    public DateOnly EndingDate { get; set; }

    [Unicode(false)]
    public string ContractSummary { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string RevisionNo { get; set; } = null!;

    public int BillToBusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCCoverageType { get; set; } = null!;

    [Column(TypeName = "numeric(6, 2)")]
    public decimal AdministrationFeePercentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal CitoPercentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal ComplicationPercentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal CitoComplicationPercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MinAdministration { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaxAdministration { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? HospitalSigned { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CorporateSigned { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCoverAdministrationType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCoverCitoType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCoverComplicationType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCoverCitoComplicationType { get; set; }

    public bool? IsAdministrationChargesByClass { get; set; }

    public bool? IsDiscountInCorporateInvoice { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? DiscountCorporateInvoice { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BillToBusinessPartnerID")]
    [InverseProperty("CustomerContractBillToBusinessPartner")]
    public virtual Customer BillToBusinessPartner { get; set; } = null!;

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("CustomerContractBusinessPartner")]
    public virtual Customer BusinessPartner { get; set; } = null!;

    [InverseProperty("DocumentNoNavigation")]
    public virtual ICollection<CustomerContractClass> CustomerContractClass { get; set; } = new List<CustomerContractClass>();

    [ForeignKey("GCCoverAdministrationType")]
    [InverseProperty("CustomerContractGCCoverAdministrationTypeNavigation")]
    public virtual sysGeneralCode? GCCoverAdministrationTypeNavigation { get; set; }

    [ForeignKey("GCCoverCitoComplicationType")]
    [InverseProperty("CustomerContractGCCoverCitoComplicationTypeNavigation")]
    public virtual sysGeneralCode? GCCoverCitoComplicationTypeNavigation { get; set; }

    [ForeignKey("GCCoverCitoType")]
    [InverseProperty("CustomerContractGCCoverCitoTypeNavigation")]
    public virtual sysGeneralCode? GCCoverCitoTypeNavigation { get; set; }

    [ForeignKey("GCCoverComplicationType")]
    [InverseProperty("CustomerContractGCCoverComplicationTypeNavigation")]
    public virtual sysGeneralCode? GCCoverComplicationTypeNavigation { get; set; }

    [ForeignKey("GCCoverageType")]
    [InverseProperty("CustomerContractGCCoverageTypeNavigation")]
    public virtual sysGeneralCode GCCoverageTypeNavigation { get; set; } = null!;

    [InverseProperty("DocumentNoNavigation")]
    public virtual ICollection<ProjectMCUCorporate> ProjectMCUCorporate { get; set; } = new List<ProjectMCUCorporate>();

    [InverseProperty("CustomerDocumentNoNavigation")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();

    [ForeignKey("SiteCode")]
    [InverseProperty("CustomerContract")]
    public virtual Site? SiteCodeNavigation { get; set; }

    [ForeignKey("TransactionCode")]
    [InverseProperty("CustomerContract")]
    public virtual sysTransactionCode? TransactionCodeNavigation { get; set; }
}
