using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_FactMedicalRecordFinance
{
    [Key]
    public int ID { get; set; }

    public int DischargeDateID { get; set; }

    public int SiteID { get; set; }

    public int DepartmentID { get; set; }

    public int ServiceUnitID { get; set; }

    public int ClassID { get; set; }

    public int? RoomID { get; set; }

    public int ChargeClassID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public int RegistrationDateID { get; set; }

    public int PatientID { get; set; }

    public int AgeGroupID { get; set; }

    public byte AgeYear { get; set; }

    public byte AgeMonth { get; set; }

    public byte AgeDay { get; set; }

    public int? ParamedicID { get; set; }

    public int? ICD1 { get; set; }

    public int? ICD2 { get; set; }

    public int? ICD3 { get; set; }

    public int? ICD4 { get; set; }

    public int? ICD5 { get; set; }

    public int? ProcedureID1 { get; set; }

    public int? ProcedureID2 { get; set; }

    public int? ProcedureID3 { get; set; }

    public int? ProcedureID4 { get; set; }

    public int? ProcedureID5 { get; set; }

    public int? OriginPatientID { get; set; }

    public int? ReferralTypeFromID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralHealthcareFrom { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralNameFrom { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralSpecialtyFrom { get; set; }

    public int? ReferralTypeToID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralHealthcareTo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralNameTo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralSpecialtyTo { get; set; }

    public int? TriageID { get; set; }

    public int? ERCaseTypeID { get; set; }

    public bool IsClosed { get; set; }

    public int? ClosedDateID { get; set; }

    public int? DischargeMethodID { get; set; }

    public int? DischargeConditionID { get; set; }

    public int? LOSInDay { get; set; }

    public int CustomerID { get; set; }

    public bool IsNewPatient { get; set; }

    public bool IsFromAppointment { get; set; }

    public int VisitSequence { get; set; }

    public int Case { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PharmacyRevenue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LabRevenue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ImagingRevenue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OtherExamRevenue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SurgeryRevenue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ConsultationRevenue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal RoomRevenue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OthersRevenue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PharmacyCost { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LabCost { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ImagingCost { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OtherExamCost { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SurgeryCost { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ConsultationCost { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal RoomCost { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OthersCost { get; set; }

    [ForeignKey("AgeGroupID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimAgeGroup AgeGroup { get; set; } = null!;

    [ForeignKey("ChargeClassID")]
    [InverseProperty("DW_FactMedicalRecordFinanceChargeClass")]
    public virtual DW_DimClass ChargeClass { get; set; } = null!;

    [ForeignKey("ClassID")]
    [InverseProperty("DW_FactMedicalRecordFinanceClass")]
    public virtual DW_DimClass Class { get; set; } = null!;

    [ForeignKey("ClosedDateID")]
    [InverseProperty("DW_FactMedicalRecordFinanceClosedDate")]
    public virtual DW_DimDate? ClosedDate { get; set; }

    [ForeignKey("CustomerID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimCustomer Customer { get; set; } = null!;

    [ForeignKey("DepartmentID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimDepartment Department { get; set; } = null!;

    [ForeignKey("DischargeConditionID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimDischargeCondition? DischargeCondition { get; set; }

    [ForeignKey("DischargeDateID")]
    [InverseProperty("DW_FactMedicalRecordFinanceDischargeDate")]
    public virtual DW_DimDate DischargeDate { get; set; } = null!;

    [ForeignKey("DischargeMethodID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimDischargeMethod? DischargeMethod { get; set; }

    [ForeignKey("ERCaseTypeID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimERCaseType? ERCaseType { get; set; }

    [ForeignKey("ICD1")]
    [InverseProperty("DW_FactMedicalRecordFinanceICD1Navigation")]
    public virtual DW_DimDiagnosis? ICD1Navigation { get; set; }

    [ForeignKey("ICD2")]
    [InverseProperty("DW_FactMedicalRecordFinanceICD2Navigation")]
    public virtual DW_DimDiagnosis? ICD2Navigation { get; set; }

    [ForeignKey("ICD3")]
    [InverseProperty("DW_FactMedicalRecordFinanceICD3Navigation")]
    public virtual DW_DimDiagnosis? ICD3Navigation { get; set; }

    [ForeignKey("ICD4")]
    [InverseProperty("DW_FactMedicalRecordFinanceICD4Navigation")]
    public virtual DW_DimDiagnosis? ICD4Navigation { get; set; }

    [ForeignKey("ICD5")]
    [InverseProperty("DW_FactMedicalRecordFinanceICD5Navigation")]
    public virtual DW_DimDiagnosis? ICD5Navigation { get; set; }

    [ForeignKey("OriginPatientID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimOriginPatient? OriginPatient { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimParamedic? Paramedic { get; set; }

    [ForeignKey("PatientID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimPatient Patient { get; set; } = null!;

    [ForeignKey("ProcedureID1")]
    [InverseProperty("DW_FactMedicalRecordFinanceProcedureID1Navigation")]
    public virtual DW_DimProcedures? ProcedureID1Navigation { get; set; }

    [ForeignKey("ProcedureID2")]
    [InverseProperty("DW_FactMedicalRecordFinanceProcedureID2Navigation")]
    public virtual DW_DimProcedures? ProcedureID2Navigation { get; set; }

    [ForeignKey("ProcedureID3")]
    [InverseProperty("DW_FactMedicalRecordFinanceProcedureID3Navigation")]
    public virtual DW_DimProcedures? ProcedureID3Navigation { get; set; }

    [ForeignKey("ProcedureID4")]
    [InverseProperty("DW_FactMedicalRecordFinanceProcedureID4Navigation")]
    public virtual DW_DimProcedures? ProcedureID4Navigation { get; set; }

    [ForeignKey("ProcedureID5")]
    [InverseProperty("DW_FactMedicalRecordFinanceProcedureID5Navigation")]
    public virtual DW_DimProcedures? ProcedureID5Navigation { get; set; }

    [ForeignKey("ReferralTypeFromID")]
    [InverseProperty("DW_FactMedicalRecordFinanceReferralTypeFrom")]
    public virtual DW_DimReferralType? ReferralTypeFrom { get; set; }

    [ForeignKey("ReferralTypeToID")]
    [InverseProperty("DW_FactMedicalRecordFinanceReferralTypeTo")]
    public virtual DW_DimReferralType? ReferralTypeTo { get; set; }

    [ForeignKey("RegistrationDateID")]
    [InverseProperty("DW_FactMedicalRecordFinanceRegistrationDate")]
    public virtual DW_DimDate RegistrationDate { get; set; } = null!;

    [ForeignKey("RoomID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimServiceRoom? Room { get; set; }

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimSiteCode Site { get; set; } = null!;

    [ForeignKey("TriageID")]
    [InverseProperty("DW_FactMedicalRecordFinance")]
    public virtual DW_DimTriage? Triage { get; set; }
}
