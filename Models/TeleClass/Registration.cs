using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("MedicalNo", Name = "IX_Registration")]
[Index("IsDeleted", "IsDischarge", "ServiceUnitID", Name = "IX_RegistrationPatientList")]
[Index("MedicalNo", "IsDeleted", Name = "IX_Registration_MedicalNo_IsDeleted")]
[Index("MedicalNo", "RegistrationNo", "IsDeleted", Name = "IX_Registration_medicalNo_reg_delete")]
public partial class Registration
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AppointmentNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialtyCode { get; set; }

    public int? NurseID { get; set; }

    public int? RoomID { get; set; }

    public int? BedID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? VisitTypeCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? WorkStationCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? VisitReasonCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ChargeClassCode { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PayerType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BpjsSepNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPatientInType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCShiftID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPatientCategory { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDependentType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCERCaseType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTriage { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDischargeCondition { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDischargeMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCOriginOfPatientReg { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LinkRegistrationNo { get; set; }

    public int? OriginalServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OriginalClassCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OriginalChargeClassCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OriginalSpecialtyCode { get; set; }

    public int? OriginalBedID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargePlanDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargeDateTime { get; set; }

    [Unicode(false)]
    public string? DischargeMedicalNotes { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DischargeNotes { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal? LOSInDay { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal? LOSInHour { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal? LOSInMinute { get; set; }

    public DateOnly? ResponseDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ResponseTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DischargeOperatorID { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? AccountNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AuthorizedNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizedDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AdministrationAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RoundingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RemainingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AuthorizedAmount { get; set; }

    public bool IsTransferedToInpatient { get; set; }

    public bool IsNewPatient { get; set; }

    public bool IsNewBornInfant { get; set; }

    public bool IsParturition { get; set; }

    public byte RevisionNo { get; set; }

    public bool IsHoldTransactionEntry { get; set; }

    public bool IsPrintingPatientCard { get; set; }

    public bool IsClosed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedDateTime { get; set; }

    public bool IsBackDate { get; set; }

    public bool IsDischargePlan { get; set; }

    public bool IsDischarge { get; set; }

    public bool IsPendingDischarge { get; set; }

    public bool IsInvoiced { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RefreshIndicator { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualVisitDateTime { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Anamnesis { get; set; }

    [Unicode(false)]
    public string? PresentIllnessNotes { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustomerDocumentNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CoveredClassCode { get; set; }

    public int? StatusID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferralNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReferralType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralBy { get; set; }

    public bool IsBedConfirmed { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DischargePlanRemark { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EntryBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EntryDateTime { get; set; }

    public bool IsAttend { get; set; }

    public bool IsNotAttend { get; set; }

    public bool IsWalkIn { get; set; }

    public bool IsRegistrationMcu { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReservationNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Comunity { get; set; }

    public bool? IsUsedAmbulance { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<AccountReceivableAccrual> AccountReceivableAccrual { get; set; } = new List<AccountReceivableAccrual>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<AccountReceivablePaymentReg> AccountReceivablePaymentReg { get; set; } = new List<AccountReceivablePaymentReg>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<AdministrationNotes> AdministrationNotes { get; set; } = new List<AdministrationNotes>();

    [ForeignKey("AppointmentNo")]
    [InverseProperty("Registration")]
    public virtual Appointment? AppointmentNoNavigation { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual BalaiKesejahteraanIbuAnakTable? BalaiKesejahteraanIbuAnakTable { get; set; }

    [ForeignKey("BedID")]
    [InverseProperty("RegistrationBed")]
    public virtual Bed? Bed { get; set; }

    [InverseProperty("RegistrationNewNavigation")]
    public virtual ICollection<BedHistory> BedHistoryRegistrationNewNavigation { get; set; } = new List<BedHistory>();

    [InverseProperty("RegistrationOldNavigation")]
    public virtual ICollection<BedHistory> BedHistoryRegistrationOldNavigation { get; set; } = new List<BedHistory>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<BedTransfer> BedTransfer { get; set; } = new List<BedTransfer>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<BodyPartHd> BodyPartHd { get; set; } = new List<BodyPartHd>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("Registration")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<CensusHistory> CensusHistory { get; set; } = new List<CensusHistory>();

    [ForeignKey("ChargeClassCode")]
    [InverseProperty("RegistrationChargeClassCodeNavigation")]
    public virtual Class ChargeClassCodeNavigation { get; set; } = null!;

    [InverseProperty("RegistrationNoNavigation")]
    public virtual CheckPatientMedicationAndVitamin? CheckPatientMedicationAndVitamin { get; set; }

    [ForeignKey("ClassCode")]
    [InverseProperty("RegistrationClassCodeNavigation")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<ClinicalPathwayHd> ClinicalPathwayHd { get; set; } = new List<ClinicalPathwayHd>();

    [ForeignKey("CoveredClassCode")]
    [InverseProperty("RegistrationCoveredClassCodeNavigation")]
    public virtual Class? CoveredClassCodeNavigation { get; set; }

    [ForeignKey("CustomerDocumentNo")]
    [InverseProperty("Registration")]
    public virtual CustomerContract? CustomerDocumentNoNavigation { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<DebitNoteCreditNoteHd> DebitNoteCreditNoteHd { get; set; } = new List<DebitNoteCreditNoteHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<DepositPaymentHd> DepositPaymentHd { get; set; } = new List<DepositPaymentHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual DietNutrient? DietNutrient { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<DiscountPhysician> DiscountPhysician { get; set; } = new List<DiscountPhysician>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<DrugDispensingHd> DrugDispensingHd { get; set; } = new List<DrugDispensingHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<DrugReturnHd> DrugReturnHd { get; set; } = new List<DrugReturnHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual EmergencyContact? EmergencyContact { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<EmployeeRewardHd> EmployeeRewardHd { get; set; } = new List<EmployeeRewardHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<EpisodeDiagnosis> EpisodeDiagnosis { get; set; } = new List<EpisodeDiagnosis>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual EpisodeEducation? EpisodeEducation { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<EpisodeProcedure> EpisodeProcedure { get; set; } = new List<EpisodeProcedure>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ExportPatientDataStatus? ExportPatientDataStatus { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<FetalMeasurement> FetalMeasurement { get; set; } = new List<FetalMeasurement>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<FetalMeasurementHd> FetalMeasurementHd { get; set; } = new List<FetalMeasurementHd>();

    [ForeignKey("GCDependentType")]
    [InverseProperty("RegistrationGCDependentTypeNavigation")]
    public virtual sysGeneralCode? GCDependentTypeNavigation { get; set; }

    [ForeignKey("GCDischargeCondition")]
    [InverseProperty("RegistrationGCDischargeConditionNavigation")]
    public virtual sysGeneralCode? GCDischargeConditionNavigation { get; set; }

    [ForeignKey("GCDischargeMethod")]
    [InverseProperty("RegistrationGCDischargeMethodNavigation")]
    public virtual sysGeneralCode? GCDischargeMethodNavigation { get; set; }

    [ForeignKey("GCERCaseType")]
    [InverseProperty("RegistrationGCERCaseTypeNavigation")]
    public virtual sysGeneralCode? GCERCaseTypeNavigation { get; set; }

    [ForeignKey("GCOriginOfPatientReg")]
    [InverseProperty("RegistrationGCOriginOfPatientRegNavigation")]
    public virtual sysGeneralCode? GCOriginOfPatientRegNavigation { get; set; }

    [ForeignKey("GCPatientCategory")]
    [InverseProperty("RegistrationGCPatientCategoryNavigation")]
    public virtual sysGeneralCode? GCPatientCategoryNavigation { get; set; }

    [ForeignKey("GCPatientInType")]
    [InverseProperty("RegistrationGCPatientInTypeNavigation")]
    public virtual sysGeneralCode? GCPatientInTypeNavigation { get; set; }

    [ForeignKey("GCReferralType")]
    [InverseProperty("RegistrationGCReferralTypeNavigation")]
    public virtual sysGeneralCode? GCReferralTypeNavigation { get; set; }

    [ForeignKey("GCShiftID")]
    [InverseProperty("RegistrationGCShift")]
    public virtual sysGeneralCode? GCShift { get; set; }

    [ForeignKey("GCTriage")]
    [InverseProperty("RegistrationGCTriageNavigation")]
    public virtual sysGeneralCode? GCTriageNavigation { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual GeneralConsentMCU? GeneralConsentMCU { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual GeneralConsentOutpatient? GeneralConsentOutpatient { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<ICPenundaanPelayanan> ICPenundaanPelayanan { get; set; } = new List<ICPenundaanPelayanan>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<IcuIndicatorHd> IcuIndicatorHd { get; set; } = new List<IcuIndicatorHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<InacbgClaim> InacbgClaim { get; set; } = new List<InacbgClaim>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<InacbgSimulation> InacbgSimulation { get; set; } = new List<InacbgSimulation>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<InfeksiPPI> InfeksiPPI { get; set; } = new List<InfeksiPPI>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<IntakeOutputHd> IntakeOutputHd { get; set; } = new List<IntakeOutputHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<InterimBill> InterimBill { get; set; } = new List<InterimBill>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<ItemServiceMCURealizationHd> ItemServiceMCURealizationHd { get; set; } = new List<ItemServiceMCURealizationHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<ItemTransactionHistoryHd> ItemTransactionHistoryHd { get; set; } = new List<ItemTransactionHistoryHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<ItemTransactionMcuHd> ItemTransactionMcuHd { get; set; } = new List<ItemTransactionMcuHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<JobOrderHd> JobOrderHd { get; set; } = new List<JobOrderHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual KartuPesertaStatusKB? KartuPesertaStatusKB { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<KeluhanPPI> KeluhanPPI { get; set; } = new List<KeluhanPPI>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<LaporanOperasi> LaporanOperasi { get; set; } = new List<LaporanOperasi>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual MCUHealthSummary? MCUHealthSummary { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual McuHealthSummaryPersonal? McuHealthSummaryPersonal { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("Registration")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<MorseFallScore> MorseFallScore { get; set; } = new List<MorseFallScore>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<MultiPayerAuthorized> MultiPayerAuthorized { get; set; } = new List<MultiPayerAuthorized>();

    [ForeignKey("NurseID")]
    [InverseProperty("RegistrationNurse")]
    public virtual Paramedic? Nurse { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<NurseShiftTransferHistoryDt> NurseShiftTransferHistoryDt { get; set; } = new List<NurseShiftTransferHistoryDt>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<NursingCareplan> NursingCareplan { get; set; } = new List<NursingCareplan>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<OdontogramMCU> OdontogramMCU { get; set; } = new List<OdontogramMCU>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<OrderMenuDiitHd> OrderMenuDiitHd { get; set; } = new List<OrderMenuDiitHd>();

    [ForeignKey("OriginalBedID")]
    [InverseProperty("RegistrationOriginalBed")]
    public virtual Bed? OriginalBed { get; set; }

    [ForeignKey("OriginalChargeClassCode")]
    [InverseProperty("RegistrationOriginalChargeClassCodeNavigation")]
    public virtual Class? OriginalChargeClassCodeNavigation { get; set; }

    [ForeignKey("OriginalClassCode")]
    [InverseProperty("RegistrationOriginalClassCodeNavigation")]
    public virtual Class? OriginalClassCodeNavigation { get; set; }

    [ForeignKey("OriginalServiceUnitID")]
    [InverseProperty("RegistrationOriginalServiceUnit")]
    public virtual DepartmentServiceUnit? OriginalServiceUnit { get; set; }

    [ForeignKey("OriginalSpecialtyCode")]
    [InverseProperty("RegistrationOriginalSpecialtyCodeNavigation")]
    public virtual Specialty? OriginalSpecialtyCodeNavigation { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PackageTreatmentHd> PackageTreatmentHd { get; set; } = new List<PackageTreatmentHd>();

    [ForeignKey("ParamedicID")]
    [InverseProperty("RegistrationParamedic")]
    public virtual Paramedic? Paramedic { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientAPGAR> PatientAPGAR { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientBPU> PatientBPU { get; set; } = new List<PatientBPU>();

    [InverseProperty("MotherRegistrationNoNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecordMotherRegistrationNoNavigation { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecordRegistrationNoNavigation { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientCAPPIRO> PatientCAPPIRO { get; set; } = new List<PatientCAPPIRO>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRisk { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual PatientCancel? PatientCancel { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientCorporateEligibility> PatientCorporateEligibility { get; set; } = new List<PatientCorporateEligibility>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientDocument> PatientDocument { get; set; } = new List<PatientDocument>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientFCS> PatientFCS { get; set; } = new List<PatientFCS>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientGCS> PatientGCS { get; set; } = new List<PatientGCS>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientGCSPediatric> PatientGCSPediatric { get; set; } = new List<PatientGCSPediatric>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientMCUCompileHd> PatientMCUCompileHd { get; set; } = new List<PatientMCUCompileHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientNotes> PatientNotes { get; set; } = new List<PatientNotes>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientOdontogram> PatientOdontogram { get; set; } = new List<PatientOdontogram>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientOdontogramNew> PatientOdontogramNew { get; set; } = new List<PatientOdontogramNew>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientOralMucosa> PatientOralMucosa { get; set; } = new List<PatientOralMucosa>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientQuestionaireHd> PatientQuestionaireHd { get; set; } = new List<PatientQuestionaireHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientResponsibleLog> PatientResponsibleLog { get; set; } = new List<PatientResponsibleLog>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientSurvey> PatientSurvey { get; set; } = new List<PatientSurvey>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PatientVision> PatientVision { get; set; } = new List<PatientVision>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PaymentRefund> PaymentRefund { get; set; } = new List<PaymentRefund>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PaymentRefundMedication> PaymentRefundMedication { get; set; } = new List<PaymentRefundMedication>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PediatricChart> PediatricChart { get; set; } = new List<PediatricChart>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual PelayananKerohanian? PelayananKerohanian { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PemeriksaanInfeksi> PemeriksaanInfeksi { get; set; } = new List<PemeriksaanInfeksi>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PemeriksaanInfeksiHd> PemeriksaanInfeksiHd { get; set; } = new List<PemeriksaanInfeksiHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual PermohonanPelayananKontrasepsi? PermohonanPelayananKontrasepsi { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PhysicianBilling> PhysicianBilling { get; set; } = new List<PhysicianBilling>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PhysicianFeeItem> PhysicianFeeItem { get; set; } = new List<PhysicianFeeItem>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PhysicianFeeItemJobOrder> PhysicianFeeItemJobOrder { get; set; } = new List<PhysicianFeeItemJobOrder>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PhysicianTeam> PhysicianTeam { get; set; } = new List<PhysicianTeam>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PrescriptionPayment> PrescriptionPayment { get; set; } = new List<PrescriptionPayment>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<PrintedArchive> PrintedArchive { get; set; } = new List<PrintedArchive>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<ProformaInvoice> ProformaInvoice { get; set; } = new List<ProformaInvoice>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<RecalculationHd> RecalculationHd { get; set; } = new List<RecalculationHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<ReferToConsult> ReferToConsult { get; set; } = new List<ReferToConsult>();

    [ForeignKey("ReferralNo")]
    [InverseProperty("Registration")]
    public virtual ReferralPatient? ReferralNoNavigation { get; set; }

    [InverseProperty("OriginRegistrationNoNavigation")]
    public virtual ICollection<ReferralPatient> ReferralPatient { get; set; } = new List<ReferralPatient>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual RegistrationInformation? RegistrationInformation { get; set; }

    [ForeignKey("ReservationNo")]
    [InverseProperty("Registration")]
    public virtual BedReservation? ReservationNoNavigation { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<RiskFallHd> RiskFallHd { get; set; } = new List<RiskFallHd>();

    [ForeignKey("RoomID")]
    [InverseProperty("Registration")]
    public virtual ServiceRoom? Room { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<SatuSehatRegistration> SatuSehatRegistration { get; set; } = new List<SatuSehatRegistration>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ScreeningPatientHighRisk? ScreeningPatientHighRisk { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual SerahTerimaBarang? SerahTerimaBarang { get; set; }

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("RegistrationServiceUnit")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("Registration")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SpecialtyCode")]
    [InverseProperty("RegistrationSpecialtyCodeNavigation")]
    public virtual Specialty? SpecialtyCodeNavigation { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<SpectaclePrescription> SpectaclePrescription { get; set; } = new List<SpectaclePrescription>();

    [ForeignKey("StatusID")]
    [InverseProperty("Registration")]
    public virtual StatusPriority? Status { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual SuratKetDatangDalamKeadaanMeninggal? SuratKetDatangDalamKeadaanMeninggal { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual SuratKeteranganMeninggal? SuratKeteranganMeninggal { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual SuratKeteranganSakitElisabeth? SuratKeteranganSakitElisabeth { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<SurgeryReservation> SurgeryReservation { get; set; } = new List<SurgeryReservation>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<TatBarcodeScan> TatBarcodeScan { get; set; } = new List<TatBarcodeScan>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<TatReport> TatReport { get; set; } = new List<TatReport>();

    [InverseProperty("FromRegistrationNoNavigation")]
    public virtual ICollection<TransactionChargesDt> TransactionChargesDt { get; set; } = new List<TransactionChargesDt>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<TransactionChargesHd> TransactionChargesHd { get; set; } = new List<TransactionChargesHd>();

    [ForeignKey("TransactionCode")]
    [InverseProperty("Registration")]
    public virtual sysTransactionCode? TransactionCodeNavigation { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<VaccinationShotHd> VaccinationShotHd { get; set; } = new List<VaccinationShotHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<ViewEMRLog> ViewEMRLog { get; set; } = new List<ViewEMRLog>();

    [ForeignKey("VisitReasonCode")]
    [InverseProperty("Registration")]
    public virtual VisitReason? VisitReasonCodeNavigation { get; set; }

    [ForeignKey("VisitTypeCode")]
    [InverseProperty("Registration")]
    public virtual VisitType? VisitTypeCodeNavigation { get; set; }

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<VitalSignHd> VitalSignHd { get; set; } = new List<VitalSignHd>();

    [InverseProperty("RegistrationNoNavigation")]
    public virtual ICollection<VitalSignHdFromVs3> VitalSignHdFromVs3 { get; set; } = new List<VitalSignHdFromVs3>();

    [ForeignKey("WorkStationCode")]
    [InverseProperty("Registration")]
    public virtual WorkStation? WorkStationCodeNavigation { get; set; }
}
