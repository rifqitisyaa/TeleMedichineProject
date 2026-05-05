using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RecalculationHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RecalculationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RecalculationDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public int BusinessPartnerIDBefore { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocumentNoBefore { get; set; }

    public int BusinessPartnerIDAfter { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocumentNoAfter { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CoveredClassCodeBefore { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CoveredClassCodeAfter { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ChargeClassCodeBefore { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ChargeClassCodeAfter { get; set; }

    public bool IsByPayerChanges { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerIDAfter")]
    [InverseProperty("RecalculationHdBusinessPartnerIDAfterNavigation")]
    public virtual BusinessPartner BusinessPartnerIDAfterNavigation { get; set; } = null!;

    [ForeignKey("BusinessPartnerIDBefore")]
    [InverseProperty("RecalculationHdBusinessPartnerIDBeforeNavigation")]
    public virtual BusinessPartner BusinessPartnerIDBeforeNavigation { get; set; } = null!;

    [ForeignKey("ChargeClassCodeAfter")]
    [InverseProperty("RecalculationHdChargeClassCodeAfterNavigation")]
    public virtual Class? ChargeClassCodeAfterNavigation { get; set; }

    [ForeignKey("ChargeClassCodeBefore")]
    [InverseProperty("RecalculationHdChargeClassCodeBeforeNavigation")]
    public virtual Class? ChargeClassCodeBeforeNavigation { get; set; }

    [ForeignKey("CoveredClassCodeAfter")]
    [InverseProperty("RecalculationHdCoveredClassCodeAfterNavigation")]
    public virtual Class? CoveredClassCodeAfterNavigation { get; set; }

    [ForeignKey("CoveredClassCodeBefore")]
    [InverseProperty("RecalculationHdCoveredClassCodeBeforeNavigation")]
    public virtual Class? CoveredClassCodeBeforeNavigation { get; set; }

    [InverseProperty("RecalculationNoNavigation")]
    public virtual ICollection<RecalculationDt> RecalculationDt { get; set; } = new List<RecalculationDt>();

    [InverseProperty("RecalculationNoNavigation")]
    public virtual ICollection<RecalculationDtBom> RecalculationDtBom { get; set; } = new List<RecalculationDtBom>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("RecalculationHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RecalculationHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("RecalculationHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
