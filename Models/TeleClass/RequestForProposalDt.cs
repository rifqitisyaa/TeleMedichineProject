using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RFPNo", "SequenceNo", "BusinessPartnerID")]
public partial class RequestForProposalDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RFPNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCreditTerms { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Discount1Percentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Discount2Percentage { get; set; }

    public bool IsTaxable { get; set; }

    public bool IsIncludeTax { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TaxPercentage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("RequestForProposalDt")]
    public virtual Supplier BusinessPartner { get; set; } = null!;

    [ForeignKey("GCCreditTerms")]
    [InverseProperty("RequestForProposalDt")]
    public virtual sysGeneralCode? GCCreditTermsNavigation { get; set; }

    [ForeignKey("RFPNo, SequenceNo")]
    [InverseProperty("RequestForProposalDt")]
    public virtual RequestForProposalSubDt RequestForProposalSubDt { get; set; } = null!;
}
