using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimProcedures
{
    [Key]
    public int ProcedureID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ProcedureCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string ProcedureName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ICDCMBlockID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ICDCMBlockName { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("ProcedureID1Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceProcedureID1Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("ProcedureID2Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceProcedureID2Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("ProcedureID3Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceProcedureID3Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("ProcedureID4Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceProcedureID4Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("ProcedureID5Navigation")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceProcedureID5Navigation { get; set; } = new List<DW_FactMedicalRecordFinance>();
}
