using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimReferralType
{
    [Key]
    public int ReferralTypeID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReferralTypeCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ReferralTypeName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("ReferralTypeFrom")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceReferralTypeFrom { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("ReferralTypeTo")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceReferralTypeTo { get; set; } = new List<DW_FactMedicalRecordFinance>();
}
