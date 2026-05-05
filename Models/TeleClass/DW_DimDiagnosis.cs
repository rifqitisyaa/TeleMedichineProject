using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimDiagnosis
{
    [Key]
    public int DiagnosisID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string DiagnosisName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? DTDNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DTDName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DTDLabel { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ICDBlockID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ICDBlockName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ICDChapter { get; set; }

    public bool IsDisease { get; set; }

    public bool IsChronicDisease { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("ICD1Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceICD1Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("ICD2Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceICD2Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("ICD3Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceICD3Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("ICD4Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceICD4Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("ICD5Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceICD5Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();
}
