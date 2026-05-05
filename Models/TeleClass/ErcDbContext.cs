using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ErcDbContext : DbContext
{
    public ErcDbContext()
    {
    }

    public ErcDbContext(DbContextOptions<ErcDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AGCGroup> AGCGroup { get; set; }

    public virtual DbSet<AGCItem> AGCItem { get; set; }

    public virtual DbSet<ATCClass> ATCClass { get; set; }

    public virtual DbSet<AbcClass> AbcClass { get; set; }

    public virtual DbSet<Abex> Abex { get; set; }

    public virtual DbSet<AccountAccrualReset> AccountAccrualReset { get; set; }

    public virtual DbSet<AccountPayableAccrual> AccountPayableAccrual { get; set; }

    public virtual DbSet<AccountPayableDtAccrual> AccountPayableDtAccrual { get; set; }

    public virtual DbSet<AccountPayableDtCreditNote> AccountPayableDtCreditNote { get; set; }

    public virtual DbSet<AccountPayableHd> AccountPayableHd { get; set; }

    public virtual DbSet<AccountPayableHistory> AccountPayableHistory { get; set; }

    public virtual DbSet<AccountPayableHistoryByPeriod> AccountPayableHistoryByPeriod { get; set; }

    public virtual DbSet<AccountPayablePaymentPlanDt> AccountPayablePaymentPlanDt { get; set; }

    public virtual DbSet<AccountPayablePaymentPlanDtCreditNote> AccountPayablePaymentPlanDtCreditNote { get; set; }

    public virtual DbSet<AccountPayablePaymentPlanHd> AccountPayablePaymentPlanHd { get; set; }

    public virtual DbSet<AccountPayableTransactionDt> AccountPayableTransactionDt { get; set; }

    public virtual DbSet<AccountPayableTransactionHd> AccountPayableTransactionHd { get; set; }

    public virtual DbSet<AccountPeriod> AccountPeriod { get; set; }

    public virtual DbSet<AccountPeriodInProcess> AccountPeriodInProcess { get; set; }

    public virtual DbSet<AccountPeriodLastPosting> AccountPeriodLastPosting { get; set; }

    public virtual DbSet<AccountReceivableAccrual> AccountReceivableAccrual { get; set; }

    public virtual DbSet<AccountReceivableAccrualDt> AccountReceivableAccrualDt { get; set; }

    public virtual DbSet<AccountReceivableAccrualVoid> AccountReceivableAccrualVoid { get; set; }

    public virtual DbSet<AccountReceivableDt> AccountReceivableDt { get; set; }

    public virtual DbSet<AccountReceivableDtReverse> AccountReceivableDtReverse { get; set; }

    public virtual DbSet<AccountReceivableHd> AccountReceivableHd { get; set; }

    public virtual DbSet<AccountReceivableHistoryByPeriod> AccountReceivableHistoryByPeriod { get; set; }

    public virtual DbSet<AccountReceivablePaymentDt> AccountReceivablePaymentDt { get; set; }

    public virtual DbSet<AccountReceivablePaymentHd> AccountReceivablePaymentHd { get; set; }

    public virtual DbSet<AccountReceivablePaymentReg> AccountReceivablePaymentReg { get; set; }

    public virtual DbSet<AccountReceivableTransactionDt> AccountReceivableTransactionDt { get; set; }

    public virtual DbSet<AccountReceivableTransactionHd> AccountReceivableTransactionHd { get; set; }

    public virtual DbSet<AccountReceivableWriteOffPlanDt> AccountReceivableWriteOffPlanDt { get; set; }

    public virtual DbSet<AccountReceivableWriteOffPlanHd> AccountReceivableWriteOffPlanHd { get; set; }

    public virtual DbSet<AccountReceiveableHistory> AccountReceiveableHistory { get; set; }

    public virtual DbSet<Address> Address { get; set; }

    public virtual DbSet<AdministrationNotes> AdministrationNotes { get; set; }

    public virtual DbSet<AirConduction> AirConduction { get; set; }

    public virtual DbSet<AldretteScoreDewasa> AldretteScoreDewasa { get; set; }

    public virtual DbSet<Allergen> Allergen { get; set; }

    public virtual DbSet<AllergenKfa> AllergenKfa { get; set; }

    public virtual DbSet<AllergenSct> AllergenSct { get; set; }

    public virtual DbSet<AllocationCodeDt> AllocationCodeDt { get; set; }

    public virtual DbSet<AllocationCodeHd> AllocationCodeHd { get; set; }

    public virtual DbSet<AnalisaHasilMCU> AnalisaHasilMCU { get; set; }

    public virtual DbSet<AnalisaLab> AnalisaLab { get; set; }

    public virtual DbSet<AnalyzeOfCensus> AnalyzeOfCensus { get; set; }

    public virtual DbSet<AnalyzeOfCensusTotalBed> AnalyzeOfCensusTotalBed { get; set; }

    public virtual DbSet<AnalyzeOfCensusTotalBedClass> AnalyzeOfCensusTotalBedClass { get; set; }

    public virtual DbSet<AnnualMCUCorporateDt> AnnualMCUCorporateDt { get; set; }

    public virtual DbSet<AnnualMCUCorporateHd> AnnualMCUCorporateHd { get; set; }

    public virtual DbSet<AnswerSct> AnswerSct { get; set; }

    public virtual DbSet<AntibiotikProfilaksis> AntibiotikProfilaksis { get; set; }

    public virtual DbSet<AntreanPanggilJKN> AntreanPanggilJKN { get; set; }

    public virtual DbSet<AntrianPanggilRegistrasi> AntrianPanggilRegistrasi { get; set; }

    public virtual DbSet<Appointment> Appointment { get; set; }

    public virtual DbSet<AppointmentDriveThru> AppointmentDriveThru { get; set; }

    public virtual DbSet<AppointmentHemo> AppointmentHemo { get; set; }

    public virtual DbSet<AppointmentUser> AppointmentUser { get; set; }

    public virtual DbSet<ApprovalLevel> ApprovalLevel { get; set; }

    public virtual DbSet<AreaCleaning> AreaCleaning { get; set; }

    public virtual DbSet<AsNutMST> AsNutMST { get; set; }

    public virtual DbSet<AsUlCPOT> AsUlCPOT { get; set; }

    public virtual DbSet<AsesmenAwalNyeriFLACCS> AsesmenAwalNyeriFLACCS { get; set; }

    public virtual DbSet<AssessmentUlangNyeri> AssessmentUlangNyeri { get; set; }

    public virtual DbSet<AssetAdjustment> AssetAdjustment { get; set; }

    public virtual DbSet<AssetBook> AssetBook { get; set; }

    public virtual DbSet<AssetCalendarDt> AssetCalendarDt { get; set; }

    public virtual DbSet<AssetCalendarHd> AssetCalendarHd { get; set; }

    public virtual DbSet<AssetClassDt> AssetClassDt { get; set; }

    public virtual DbSet<AssetClassHd> AssetClassHd { get; set; }

    public virtual DbSet<AssetComponent> AssetComponent { get; set; }

    public virtual DbSet<AssetDepreciation> AssetDepreciation { get; set; }

    public virtual DbSet<AssetDepreciationMethod> AssetDepreciationMethod { get; set; }

    public virtual DbSet<AssetDepreciationParameter> AssetDepreciationParameter { get; set; }

    public virtual DbSet<AssetExpense> AssetExpense { get; set; }

    public virtual DbSet<AssetInspectionDt> AssetInspectionDt { get; set; }

    public virtual DbSet<AssetInspectionHd> AssetInspectionHd { get; set; }

    public virtual DbSet<AssetMeter> AssetMeter { get; set; }

    public virtual DbSet<AssetModule> AssetModule { get; set; }

    public virtual DbSet<Assets> Assets { get; set; }

    public virtual DbSet<AssetsBook> AssetsBook { get; set; }

    public virtual DbSet<AssetsCalibrationSummary> AssetsCalibrationSummary { get; set; }

    public virtual DbSet<AssetsDepreciation> AssetsDepreciation { get; set; }

    public virtual DbSet<AssetsDisposalDt> AssetsDisposalDt { get; set; }

    public virtual DbSet<AssetsDisposalHd> AssetsDisposalHd { get; set; }

    public virtual DbSet<AssetsGroup> AssetsGroup { get; set; }

    public virtual DbSet<AssetsTransfers> AssetsTransfers { get; set; }

    public virtual DbSet<Atc> Atc { get; set; }

    public virtual DbSet<Attendance> Attendance { get; set; }

    public virtual DbSet<AttendanceDt> AttendanceDt { get; set; }

    public virtual DbSet<AttendanceHd> AttendanceHd { get; set; }

    public virtual DbSet<Audiometri> Audiometri { get; set; }

    public virtual DbSet<AuditCuciTanganAdministration> AuditCuciTanganAdministration { get; set; }

    public virtual DbSet<AuditLogTemp> AuditLogTemp { get; set; }

    public virtual DbSet<AutoChargeItem> AutoChargeItem { get; set; }

    public virtual DbSet<AutomationChargesItem> AutomationChargesItem { get; set; }

    public virtual DbSet<AverageCost> AverageCost { get; set; }

    public virtual DbSet<AverageCostBySystem> AverageCostBySystem { get; set; }

    public virtual DbSet<AverageCostExcludePPN> AverageCostExcludePPN { get; set; }

    public virtual DbSet<BUItemDrugDisplay> BUItemDrugDisplay { get; set; }

    public virtual DbSet<BUItemInventoryLive> BUItemInventoryLive { get; set; }

    public virtual DbSet<BUItemInventoryLiveInject> BUItemInventoryLiveInject { get; set; }

    public virtual DbSet<BUItemTransactionHistoryDtLive> BUItemTransactionHistoryDtLive { get; set; }

    public virtual DbSet<BUItemTransactionHistoryHdLive> BUItemTransactionHistoryHdLive { get; set; }

    public virtual DbSet<BUTHLeherMCU251025> BUTHLeherMCU251025 { get; set; }

    public virtual DbSet<BUTHTHidungMCU251025> BUTHTHidungMCU251025 { get; set; }

    public virtual DbSet<BUTHTTelingaMCU251025> BUTHTTelingaMCU251025 { get; set; }

    public virtual DbSet<BUTHTTenggorokanMCU251025> BUTHTTenggorokanMCU251025 { get; set; }

    public virtual DbSet<BU_TMPRL2KETENAGAAN_20230731> BU_TMPRL2KETENAGAAN_20230731 { get; set; }

    public virtual DbSet<BUsysGrowthChartPoint> BUsysGrowthChartPoint { get; set; }

    public virtual DbSet<BackPaySalary> BackPaySalary { get; set; }

    public virtual DbSet<BackupItemCompileMCU> BackupItemCompileMCU { get; set; }

    public virtual DbSet<BackupMCUOdontogram> BackupMCUOdontogram { get; set; }

    public virtual DbSet<BackupPatient20240906> BackupPatient20240906 { get; set; }

    public virtual DbSet<BackupPatientLookUp> BackupPatientLookUp { get; set; }

    public virtual DbSet<BackupQueuingReference> BackupQueuingReference { get; set; }

    public virtual DbSet<BackupQueuingTVGeneralCode> BackupQueuingTVGeneralCode { get; set; }

    public virtual DbSet<BackupRulesMCUhd20250930> BackupRulesMCUhd20250930 { get; set; }

    public virtual DbSet<BalaiKesejahteraanIbuAnak> BalaiKesejahteraanIbuAnak { get; set; }

    public virtual DbSet<BalaiKesejahteraanIbuAnakTable> BalaiKesejahteraanIbuAnakTable { get; set; }

    public virtual DbSet<BalanceSheetReport> BalanceSheetReport { get; set; }

    public virtual DbSet<Bank> Bank { get; set; }

    public virtual DbSet<BankChargesDt> BankChargesDt { get; set; }

    public virtual DbSet<BankChargesHd> BankChargesHd { get; set; }

    public virtual DbSet<BankReconcileAPDt> BankReconcileAPDt { get; set; }

    public virtual DbSet<BankReconcileAPHd> BankReconcileAPHd { get; set; }

    public virtual DbSet<BankReconcileARDt> BankReconcileARDt { get; set; }

    public virtual DbSet<BankReconcileARHd> BankReconcileARHd { get; set; }

    public virtual DbSet<BankReconcileDt> BankReconcileDt { get; set; }

    public virtual DbSet<BankReconcileHd> BankReconcileHd { get; set; }

    public virtual DbSet<BannerImage> BannerImage { get; set; }

    public virtual DbSet<BarcodeSettingDt> BarcodeSettingDt { get; set; }

    public virtual DbSet<BarcodeSettingHd> BarcodeSettingHd { get; set; }

    public virtual DbSet<BaseDataAnalisaMCU> BaseDataAnalisaMCU { get; set; }

    public virtual DbSet<Bed> Bed { get; set; }

    public virtual DbSet<BedCencusDt> BedCencusDt { get; set; }

    public virtual DbSet<BedCencusHd> BedCencusHd { get; set; }

    public virtual DbSet<BedCleaning> BedCleaning { get; set; }

    public virtual DbSet<BedHistory> BedHistory { get; set; }

    public virtual DbSet<BedItemChargesCustom> BedItemChargesCustom { get; set; }

    public virtual DbSet<BedReservation> BedReservation { get; set; }

    public virtual DbSet<BedSummary> BedSummary { get; set; }

    public virtual DbSet<BedTransfer> BedTransfer { get; set; }

    public virtual DbSet<BillingComparisonDt> BillingComparisonDt { get; set; }

    public virtual DbSet<BillingComparisonHd> BillingComparisonHd { get; set; }

    public virtual DbSet<BodyPartDt> BodyPartDt { get; set; }

    public virtual DbSet<BodyPartDtPoint> BodyPartDtPoint { get; set; }

    public virtual DbSet<BodyPartHd> BodyPartHd { get; set; }

    public virtual DbSet<BodyPartSpecialty> BodyPartSpecialty { get; set; }

    public virtual DbSet<BoneConduction> BoneConduction { get; set; }

    public virtual DbSet<BpjsInformation> BpjsInformation { get; set; }

    public virtual DbSet<BpjsVerification> BpjsVerification { get; set; }

    public virtual DbSet<BuAuditLogHistoryHdDt> BuAuditLogHistoryHdDt { get; set; }

    public virtual DbSet<BuPatientYankes2> BuPatientYankes2 { get; set; }

    public virtual DbSet<Bu_RL52KunjunganRajalDt_20230724> Bu_RL52KunjunganRajalDt_20230724 { get; set; }

    public virtual DbSet<Bu_RL52KunjunganRajalHD_20230724> Bu_RL52KunjunganRajalHD_20230724 { get; set; }

    public virtual DbSet<Bu_RLTemplateDtRL52_20230724> Bu_RLTemplateDtRL52_20230724 { get; set; }

    public virtual DbSet<Bu_sysGeneralCodeHTKP_20230630> Bu_sysGeneralCodeHTKP_20230630 { get; set; }

    public virtual DbSet<Bu_sysGeneralCodeTelaahObat_20230630> Bu_sysGeneralCodeTelaahObat_20230630 { get; set; }

    public virtual DbSet<Bu_sysGeneralCodeTelaahResep_20230630> Bu_sysGeneralCodeTelaahResep_20230630 { get; set; }

    public virtual DbSet<BudgetDt> BudgetDt { get; set; }

    public virtual DbSet<BudgetDtHistory> BudgetDtHistory { get; set; }

    public virtual DbSet<BudgetHd> BudgetHd { get; set; }

    public virtual DbSet<BudgetRealization> BudgetRealization { get; set; }

    public virtual DbSet<BudgetRealizationNewTable> BudgetRealizationNewTable { get; set; }

    public virtual DbSet<BudgetRealizationTableAttachment> BudgetRealizationTableAttachment { get; set; }

    public virtual DbSet<BudgetSubDt> BudgetSubDt { get; set; }

    public virtual DbSet<BuktiSerahTerimaBayi> BuktiSerahTerimaBayi { get; set; }

    public virtual DbSet<BusinessPartner> BusinessPartner { get; set; }

    public virtual DbSet<CHDAge> CHDAge { get; set; }

    public virtual DbSet<CHDBloodPressure> CHDBloodPressure { get; set; }

    public virtual DbSet<CHDPredictor> CHDPredictor { get; set; }

    public virtual DbSet<CHDRisk> CHDRisk { get; set; }

    public virtual DbSet<CalenderDt> CalenderDt { get; set; }

    public virtual DbSet<CalenderHd> CalenderHd { get; set; }

    public virtual DbSet<Callibrations> Callibrations { get; set; }

    public virtual DbSet<CancelPatientVisit> CancelPatientVisit { get; set; }

    public virtual DbSet<CancelledInpatient> CancelledInpatient { get; set; }

    public virtual DbSet<CancelledSOAPTHS> CancelledSOAPTHS { get; set; }

    public virtual DbSet<CashFlowStatement> CashFlowStatement { get; set; }

    public virtual DbSet<CashFlowStatementDt> CashFlowStatementDt { get; set; }

    public virtual DbSet<CatheterAdministrationRev> CatheterAdministrationRev { get; set; }

    public virtual DbSet<CensusHistory> CensusHistory { get; set; }

    public virtual DbSet<ChangeChargeClass> ChangeChargeClass { get; set; }

    public virtual DbSet<ChartOfAccount> ChartOfAccount { get; set; }

    public virtual DbSet<CheckPatientMedicationAndVitamin> CheckPatientMedicationAndVitamin { get; set; }

    public virtual DbSet<ChecklistPersiapanPasienRujukan> ChecklistPersiapanPasienRujukan { get; set; }

    public virtual DbSet<CirculationChart> CirculationChart { get; set; }

    public virtual DbSet<CityLookUp> CityLookUp { get; set; }

    public virtual DbSet<Class> Class { get; set; }

    public virtual DbSet<ClassCategory> ClassCategory { get; set; }

    public virtual DbSet<ClinicalPathwayDt> ClinicalPathwayDt { get; set; }

    public virtual DbSet<ClinicalPathwayHd> ClinicalPathwayHd { get; set; }

    public virtual DbSet<CoaByUnits> CoaByUnits { get; set; }

    public virtual DbSet<CommunityPatient> CommunityPatient { get; set; }

    public virtual DbSet<Company> Company { get; set; }

    public virtual DbSet<CompoundTemplateDt> CompoundTemplateDt { get; set; }

    public virtual DbSet<CompoundTemplateHd> CompoundTemplateHd { get; set; }

    public virtual DbSet<CopyResepImage> CopyResepImage { get; set; }

    public virtual DbSet<Corporate> Corporate { get; set; }

    public virtual DbSet<CorporateInvoiceVerified> CorporateInvoiceVerified { get; set; }

    public virtual DbSet<CorporateItem> CorporateItem { get; set; }

    public virtual DbSet<CorporateReference> CorporateReference { get; set; }

    public virtual DbSet<CovidRoom> CovidRoom { get; set; }

    public virtual DbSet<CreditNote> CreditNote { get; set; }

    public virtual DbSet<CriticalResultReport> CriticalResultReport { get; set; }

    public virtual DbSet<CurrentPregnancy> CurrentPregnancy { get; set; }

    public virtual DbSet<Customer> Customer { get; set; }

    public virtual DbSet<CustomerAkomodasiKamar> CustomerAkomodasiKamar { get; set; }

    public virtual DbSet<CustomerBank> CustomerBank { get; set; }

    public virtual DbSet<CustomerClass> CustomerClass { get; set; }

    public virtual DbSet<CustomerContract> CustomerContract { get; set; }

    public virtual DbSet<CustomerContractClass> CustomerContractClass { get; set; }

    public virtual DbSet<CustomerContractConsidalition> CustomerContractConsidalition { get; set; }

    public virtual DbSet<CustomerContractConsidalitionDt> CustomerContractConsidalitionDt { get; set; }

    public virtual DbSet<CustomerDt> CustomerDt { get; set; }

    public virtual DbSet<CustomerHd> CustomerHd { get; set; }

    public virtual DbSet<CustomerItem> CustomerItem { get; set; }

    public virtual DbSet<CustomerItemPRB> CustomerItemPRB { get; set; }

    public virtual DbSet<CustomerKabupaten> CustomerKabupaten { get; set; }

    public virtual DbSet<CustomerKecamatan> CustomerKecamatan { get; set; }

    public virtual DbSet<CustomerParamedic> CustomerParamedic { get; set; }

    public virtual DbSet<CustomerParamedicSpeciality> CustomerParamedicSpeciality { get; set; }

    public virtual DbSet<CustomerPointDt> CustomerPointDt { get; set; }

    public virtual DbSet<CustomerPointHd> CustomerPointHd { get; set; }

    public virtual DbSet<CustomerProvinsi> CustomerProvinsi { get; set; }

    public virtual DbSet<CustomerReferal> CustomerReferal { get; set; }

    public virtual DbSet<CustomerServiceUnit> CustomerServiceUnit { get; set; }

    public virtual DbSet<CustomerSpeciality> CustomerSpeciality { get; set; }

    public virtual DbSet<DTD> DTD { get; set; }

    public virtual DbSet<DW_DimABCClass> DW_DimABCClass { get; set; }

    public virtual DbSet<DW_DimAgeGroup> DW_DimAgeGroup { get; set; }

    public virtual DbSet<DW_DimBed> DW_DimBed { get; set; }

    public virtual DbSet<DW_DimBedStatus> DW_DimBedStatus { get; set; }

    public virtual DbSet<DW_DimClass> DW_DimClass { get; set; }

    public virtual DbSet<DW_DimCustomer> DW_DimCustomer { get; set; }

    public virtual DbSet<DW_DimCustomerType> DW_DimCustomerType { get; set; }

    public virtual DbSet<DW_DimDate> DW_DimDate { get; set; }

    public virtual DbSet<DW_DimDepartment> DW_DimDepartment { get; set; }

    public virtual DbSet<DW_DimDiagnosis> DW_DimDiagnosis { get; set; }

    public virtual DbSet<DW_DimDischargeCondition> DW_DimDischargeCondition { get; set; }

    public virtual DbSet<DW_DimDischargeMethod> DW_DimDischargeMethod { get; set; }

    public virtual DbSet<DW_DimERCaseType> DW_DimERCaseType { get; set; }

    public virtual DbSet<DW_DimEducation> DW_DimEducation { get; set; }

    public virtual DbSet<DW_DimEmploymentStatus> DW_DimEmploymentStatus { get; set; }

    public virtual DbSet<DW_DimItem> DW_DimItem { get; set; }

    public virtual DbSet<DW_DimItemGroup> DW_DimItemGroup { get; set; }

    public virtual DbSet<DW_DimItemPlanning> DW_DimItemPlanning { get; set; }

    public virtual DbSet<DW_DimItemType> DW_DimItemType { get; set; }

    public virtual DbSet<DW_DimItemUnit> DW_DimItemUnit { get; set; }

    public virtual DbSet<DW_DimLocation> DW_DimLocation { get; set; }

    public virtual DbSet<DW_DimMaritalStatus> DW_DimMaritalStatus { get; set; }

    public virtual DbSet<DW_DimNationality> DW_DimNationality { get; set; }

    public virtual DbSet<DW_DimOccupation> DW_DimOccupation { get; set; }

    public virtual DbSet<DW_DimOriginPatient> DW_DimOriginPatient { get; set; }

    public virtual DbSet<DW_DimParamedic> DW_DimParamedic { get; set; }

    public virtual DbSet<DW_DimParamedicType> DW_DimParamedicType { get; set; }

    public virtual DbSet<DW_DimPatient> DW_DimPatient { get; set; }

    public virtual DbSet<DW_DimProcedures> DW_DimProcedures { get; set; }

    public virtual DbSet<DW_DimRace> DW_DimRace { get; set; }

    public virtual DbSet<DW_DimReferralType> DW_DimReferralType { get; set; }

    public virtual DbSet<DW_DimReligion> DW_DimReligion { get; set; }

    public virtual DbSet<DW_DimServiceRoom> DW_DimServiceRoom { get; set; }

    public virtual DbSet<DW_DimServiceUnit> DW_DimServiceUnit { get; set; }

    public virtual DbSet<DW_DimSex> DW_DimSex { get; set; }

    public virtual DbSet<DW_DimSiteCode> DW_DimSiteCode { get; set; }

    public virtual DbSet<DW_DimSpecialty> DW_DimSpecialty { get; set; }

    public virtual DbSet<DW_DimSpecialtyGroup> DW_DimSpecialtyGroup { get; set; }

    public virtual DbSet<DW_DimSupplier> DW_DimSupplier { get; set; }

    public virtual DbSet<DW_DimSupplierType> DW_DimSupplierType { get; set; }

    public virtual DbSet<DW_DimTime> DW_DimTime { get; set; }

    public virtual DbSet<DW_DimTriage> DW_DimTriage { get; set; }

    public virtual DbSet<DW_DimWeek> DW_DimWeek { get; set; }

    public virtual DbSet<DW_FactAPMovement> DW_FactAPMovement { get; set; }

    public virtual DbSet<DW_FactBalanceStock> DW_FactBalanceStock { get; set; }

    public virtual DbSet<DW_FactBedCensus> DW_FactBedCensus { get; set; }

    public virtual DbSet<DW_FactFEFOIn> DW_FactFEFOIn { get; set; }

    public virtual DbSet<DW_FactFEFOInPeriode> DW_FactFEFOInPeriode { get; set; }

    public virtual DbSet<DW_FactFEFOOut> DW_FactFEFOOut { get; set; }

    public virtual DbSet<DW_FactFIFOIn> DW_FactFIFOIn { get; set; }

    public virtual DbSet<DW_FactFIFOInPeriode> DW_FactFIFOInPeriode { get; set; }

    public virtual DbSet<DW_FactFIFOOut> DW_FactFIFOOut { get; set; }

    public virtual DbSet<DW_FactMaterialCost> DW_FactMaterialCost { get; set; }

    public virtual DbSet<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinance { get; set; }

    public virtual DbSet<DW_FactPharmacySales> DW_FactPharmacySales { get; set; }

    public virtual DbSet<DW_JobHistory> DW_JobHistory { get; set; }

    public virtual DbSet<DailyCensus> DailyCensus { get; set; }

    public virtual DbSet<DaySubstitute> DaySubstitute { get; set; }

    public virtual DbSet<DebitNoteCreditNoteDt> DebitNoteCreditNoteDt { get; set; }

    public virtual DbSet<DebitNoteCreditNoteHd> DebitNoteCreditNoteHd { get; set; }

    public virtual DbSet<DebitNoteCreditNoteHdReverse> DebitNoteCreditNoteHdReverse { get; set; }

    public virtual DbSet<DedikasiDataPengukuran> DedikasiDataPengukuran { get; set; }

    public virtual DbSet<DedikasiDataPertanyaan> DedikasiDataPertanyaan { get; set; }

    public virtual DbSet<DedikasiDataTindakLanjut> DedikasiDataTindakLanjut { get; set; }

    public virtual DbSet<Department> Department { get; set; }

    public virtual DbSet<DepartmentServiceUnit> DepartmentServiceUnit { get; set; }

    public virtual DbSet<DepartmentServiceUnitParameterDt> DepartmentServiceUnitParameterDt { get; set; }

    public virtual DbSet<DepartmentServiceUnitParameterHd> DepartmentServiceUnitParameterHd { get; set; }

    public virtual DbSet<DepositByTransactionDt> DepositByTransactionDt { get; set; }

    public virtual DbSet<DepositByTransactionHd> DepositByTransactionHd { get; set; }

    public virtual DbSet<DepositPaymentDt> DepositPaymentDt { get; set; }

    public virtual DbSet<DepositPaymentDtReverse> DepositPaymentDtReverse { get; set; }

    public virtual DbSet<DepositPaymentHd> DepositPaymentHd { get; set; }

    public virtual DbSet<DetailDataPMKP> DetailDataPMKP { get; set; }

    public virtual DbSet<Diagnosis> Diagnosis { get; set; }

    public virtual DbSet<DiagnosisCategory> DiagnosisCategory { get; set; }

    public virtual DbSet<DiagnosisMostFrequent> DiagnosisMostFrequent { get; set; }

    public virtual DbSet<DiagnosisTB> DiagnosisTB { get; set; }

    public virtual DbSet<DietMonitoringDt> DietMonitoringDt { get; set; }

    public virtual DbSet<DietMonitoringHd> DietMonitoringHd { get; set; }

    public virtual DbSet<DietNutrient> DietNutrient { get; set; }

    public virtual DbSet<DietNutrientHistory> DietNutrientHistory { get; set; }

    public virtual DbSet<DigikesRegistration> DigikesRegistration { get; set; }

    public virtual DbSet<DirectPurchaseDt> DirectPurchaseDt { get; set; }

    public virtual DbSet<DirectPurchaseHd> DirectPurchaseHd { get; set; }

    public virtual DbSet<DiscountPhysician> DiscountPhysician { get; set; }

    public virtual DbSet<DiscountPhysicianReverse> DiscountPhysicianReverse { get; set; }

    public virtual DbSet<DistributionOrderDt> DistributionOrderDt { get; set; }

    public virtual DbSet<DistributionOrderHd> DistributionOrderHd { get; set; }

    public virtual DbSet<DistributionOrderLocationTemplate> DistributionOrderLocationTemplate { get; set; }

    public virtual DbSet<DistributionOrderPlanned> DistributionOrderPlanned { get; set; }

    public virtual DbSet<DocumentLibraryAdmin> DocumentLibraryAdmin { get; set; }

    public virtual DbSet<DocumentationTable> DocumentationTable { get; set; }

    public virtual DbSet<DocumentationTableFile> DocumentationTableFile { get; set; }

    public virtual DbSet<DownPaymentDt> DownPaymentDt { get; set; }

    public virtual DbSet<DownPaymentHd> DownPaymentHd { get; set; }

    public virtual DbSet<DownPaymentReverse> DownPaymentReverse { get; set; }

    public virtual DbSet<DrugAdminSignature> DrugAdminSignature { get; set; }

    public virtual DbSet<DrugAdministration> DrugAdministration { get; set; }

    public virtual DbSet<DrugDispensingDt> DrugDispensingDt { get; set; }

    public virtual DbSet<DrugDispensingHd> DrugDispensingHd { get; set; }

    public virtual DbSet<DrugInfoDt> DrugInfoDt { get; set; }

    public virtual DbSet<DrugInfoHd> DrugInfoHd { get; set; }

    public virtual DbSet<DrugInteraction> DrugInteraction { get; set; }

    public virtual DbSet<DrugReturnDt> DrugReturnDt { get; set; }

    public virtual DbSet<DrugReturnHd> DrugReturnHd { get; set; }

    public virtual DbSet<DrugReturnNHTemp> DrugReturnNHTemp { get; set; }

    public virtual DbSet<DynamicRopFormula> DynamicRopFormula { get; set; }

    public virtual DbSet<EDCMachine> EDCMachine { get; set; }

    public virtual DbSet<EMRInacbgMonitoring> EMRInacbgMonitoring { get; set; }

    public virtual DbSet<EarlyWarningScore> EarlyWarningScore { get; set; }

    public virtual DbSet<EcgMCU> EcgMCU { get; set; }

    public virtual DbSet<Echocardiografi> Echocardiografi { get; set; }

    public virtual DbSet<EffectiveCommunicationHd> EffectiveCommunicationHd { get; set; }

    public virtual DbSet<EffectiveCommunicationHd2> EffectiveCommunicationHd2 { get; set; }

    public virtual DbSet<ElectricityBills> ElectricityBills { get; set; }

    public virtual DbSet<EmbalaceDt> EmbalaceDt { get; set; }

    public virtual DbSet<EmbalaceHd> EmbalaceHd { get; set; }

    public virtual DbSet<EmergencyContact> EmergencyContact { get; set; }

    public virtual DbSet<Employee> Employee { get; set; }

    public virtual DbSet<EmployeeDisiplinaryDt> EmployeeDisiplinaryDt { get; set; }

    public virtual DbSet<EmployeeDisiplinaryHd> EmployeeDisiplinaryHd { get; set; }

    public virtual DbSet<EmployeeFamily> EmployeeFamily { get; set; }

    public virtual DbSet<EmployeeGroupDt> EmployeeGroupDt { get; set; }

    public virtual DbSet<EmployeeGroupHd> EmployeeGroupHd { get; set; }

    public virtual DbSet<EmployeeLeave> EmployeeLeave { get; set; }

    public virtual DbSet<EmployeeLoanDt> EmployeeLoanDt { get; set; }

    public virtual DbSet<EmployeeLoanHd> EmployeeLoanHd { get; set; }

    public virtual DbSet<EmployeeLoanProcessDt> EmployeeLoanProcessDt { get; set; }

    public virtual DbSet<EmployeeLoanProcessHd> EmployeeLoanProcessHd { get; set; }

    public virtual DbSet<EmployeeMedical> EmployeeMedical { get; set; }

    public virtual DbSet<EmployeeMedicalAdjustmentDt> EmployeeMedicalAdjustmentDt { get; set; }

    public virtual DbSet<EmployeeMedicalAdjustmentHd> EmployeeMedicalAdjustmentHd { get; set; }

    public virtual DbSet<EmployeeMedicalClaim> EmployeeMedicalClaim { get; set; }

    public virtual DbSet<EmployeeRewardDt> EmployeeRewardDt { get; set; }

    public virtual DbSet<EmployeeRewardHd> EmployeeRewardHd { get; set; }

    public virtual DbSet<EmployeeSPT> EmployeeSPT { get; set; }

    public virtual DbSet<EmployeeScheduleDt> EmployeeScheduleDt { get; set; }

    public virtual DbSet<EmployeeScheduleHd> EmployeeScheduleHd { get; set; }

    public virtual DbSet<EmployeeTerminate> EmployeeTerminate { get; set; }

    public virtual DbSet<EmployeeTimeAttendance> EmployeeTimeAttendance { get; set; }

    public virtual DbSet<EmployeeWorkingHistory> EmployeeWorkingHistory { get; set; }

    public virtual DbSet<Engineering> Engineering { get; set; }

    public virtual DbSet<EpisodeDiagnosis> EpisodeDiagnosis { get; set; }

    public virtual DbSet<EpisodeDiagnosisSummary> EpisodeDiagnosisSummary { get; set; }

    public virtual DbSet<EpisodeDokterGigi> EpisodeDokterGigi { get; set; }

    public virtual DbSet<EpisodeEducation> EpisodeEducation { get; set; }

    public virtual DbSet<EpisodeIDNT> EpisodeIDNT { get; set; }

    public virtual DbSet<EpisodeNutritionalStatus> EpisodeNutritionalStatus { get; set; }

    public virtual DbSet<EpisodeProcedure> EpisodeProcedure { get; set; }

    public virtual DbSet<EtVisumRepertum> EtVisumRepertum { get; set; }

    public virtual DbSet<EvaluasiFlaccBayi> EvaluasiFlaccBayi { get; set; }

    public virtual DbSet<EvaluasiIntensitasNyeri> EvaluasiIntensitasNyeri { get; set; }

    public virtual DbSet<EvaluasiNyeri> EvaluasiNyeri { get; set; }

    public virtual DbSet<EvaluasiNyeriBayi> EvaluasiNyeriBayi { get; set; }

    public virtual DbSet<EvaluasiNyeriDewasa> EvaluasiNyeriDewasa { get; set; }

    public virtual DbSet<ExaminationReference> ExaminationReference { get; set; }

    public virtual DbSet<ExpiredDateSimulation> ExpiredDateSimulation { get; set; }

    public virtual DbSet<ExportPatientDataStatus> ExportPatientDataStatus { get; set; }

    public virtual DbSet<FaktorPengurangInacbg> FaktorPengurangInacbg { get; set; }

    public virtual DbSet<FamilyAppointment> FamilyAppointment { get; set; }

    public virtual DbSet<FarmacyReportDt> FarmacyReportDt { get; set; }

    public virtual DbSet<FarmacyReportHd> FarmacyReportHd { get; set; }

    public virtual DbSet<FarmacyReportTemplate> FarmacyReportTemplate { get; set; }

    public virtual DbSet<FaskesReferralSisruteHd> FaskesReferralSisruteHd { get; set; }

    public virtual DbSet<FetalMeasurement> FetalMeasurement { get; set; }

    public virtual DbSet<FetalMeasurementDt> FetalMeasurementDt { get; set; }

    public virtual DbSet<FetalMeasurementHd> FetalMeasurementHd { get; set; }

    public virtual DbSet<FilterMCUItem> FilterMCUItem { get; set; }

    public virtual DbSet<FiscalPeriodDt> FiscalPeriodDt { get; set; }

    public virtual DbSet<FiscalPeriodHd> FiscalPeriodHd { get; set; }

    public virtual DbSet<FisikMCU> FisikMCU { get; set; }

    public virtual DbSet<FisioterapiNotes> FisioterapiNotes { get; set; }

    public virtual DbSet<FlipBookData> FlipBookData { get; set; }

    public virtual DbSet<ForecastDt> ForecastDt { get; set; }

    public virtual DbSet<ForecastHd> ForecastHd { get; set; }

    public virtual DbSet<ForecastSubDt> ForecastSubDt { get; set; }

    public virtual DbSet<FormPasienBPJSRajal> FormPasienBPJSRajal { get; set; }

    public virtual DbSet<FormPasienBPJSRajalSignature> FormPasienBPJSRajalSignature { get; set; }

    public virtual DbSet<FotoSelfie> FotoSelfie { get; set; }

    public virtual DbSet<General> General { get; set; }

    public virtual DbSet<GeneralConsentMCU> GeneralConsentMCU { get; set; }

    public virtual DbSet<GeneralConsentOutpatient> GeneralConsentOutpatient { get; set; }

    public virtual DbSet<Geriatri> Geriatri { get; set; }

    public virtual DbSet<Gift> Gift { get; set; }

    public virtual DbSet<GiroListDt> GiroListDt { get; set; }

    public virtual DbSet<GiroListHd> GiroListHd { get; set; }

    public virtual DbSet<GiroReplacement> GiroReplacement { get; set; }

    public virtual DbSet<GroupLabImport> GroupLabImport { get; set; }

    public virtual DbSet<GuidelineDt> GuidelineDt { get; set; }

    public virtual DbSet<GuidelineDtItem> GuidelineDtItem { get; set; }

    public virtual DbSet<GuidelineHd> GuidelineHd { get; set; }

    public virtual DbSet<GuidelineInclusion> GuidelineInclusion { get; set; }

    public virtual DbSet<GuidelineInclusionHd> GuidelineInclusionHd { get; set; }

    public virtual DbSet<GuidelineSummary> GuidelineSummary { get; set; }

    public virtual DbSet<HL7Message> HL7Message { get; set; }

    public virtual DbSet<HL7ThirdParty> HL7ThirdParty { get; set; }

    public virtual DbSet<HL7_PID> HL7_PID { get; set; }

    public virtual DbSet<HasilPapSmearMCU> HasilPapSmearMCU { get; set; }

    public virtual DbSet<HemoTube> HemoTube { get; set; }

    public virtual DbSet<HistoryCloseOutstandingPharmacy> HistoryCloseOutstandingPharmacy { get; set; }

    public virtual DbSet<HistoryDt> HistoryDt { get; set; }

    public virtual DbSet<HistoryHD> HistoryHD { get; set; }

    public virtual DbSet<HistoryOpenInvoice> HistoryOpenInvoice { get; set; }

    public virtual DbSet<HistoryPosting> HistoryPosting { get; set; }

    public virtual DbSet<HistoryRegistrationChangesDate> HistoryRegistrationChangesDate { get; set; }

    public virtual DbSet<HospitalMembership> HospitalMembership { get; set; }

    public virtual DbSet<ICD10_> ICD10_ { get; set; }

    public virtual DbSet<ICDBlock> ICDBlock { get; set; }

    public virtual DbSet<ICDCMBlock> ICDCMBlock { get; set; }

    public virtual DbSet<ICDNew2025> ICDNew2025 { get; set; }

    public virtual DbSet<ICPenundaanPelayanan> ICPenundaanPelayanan { get; set; }

    public virtual DbSet<ICSuratKeteranganHamil> ICSuratKeteranganHamil { get; set; }

    public virtual DbSet<ICSuratPerjalananHamil> ICSuratPerjalananHamil { get; set; }

    public virtual DbSet<IDNT> IDNT { get; set; }

    public virtual DbSet<IDNTChecklist> IDNTChecklist { get; set; }

    public virtual DbSet<IDNTDtEtiology> IDNTDtEtiology { get; set; }

    public virtual DbSet<IDNTDtSymptom> IDNTDtSymptom { get; set; }

    public virtual DbSet<IDNTEtiology> IDNTEtiology { get; set; }

    public virtual DbSet<IDNTHd> IDNTHd { get; set; }

    public virtual DbSet<INACBGItemGroupHd> INACBGItemGroupHd { get; set; }

    public virtual DbSet<IPAddressQueue> IPAddressQueue { get; set; }

    public virtual DbSet<ITEMSCTUPLOAD> ITEMSCTUPLOAD { get; set; }

    public virtual DbSet<IVAdministration> IVAdministration { get; set; }

    public virtual DbSet<IVAdministrationRev> IVAdministrationRev { get; set; }

    public virtual DbSet<IadpAdministration> IadpAdministration { get; set; }

    public virtual DbSet<IadpAdministrationRev> IadpAdministrationRev { get; set; }

    public virtual DbSet<IcuIndicatorDt> IcuIndicatorDt { get; set; }

    public virtual DbSet<IcuIndicatorHd> IcuIndicatorHd { get; set; }

    public virtual DbSet<IcuTemplate> IcuTemplate { get; set; }

    public virtual DbSet<ImageDocument> ImageDocument { get; set; }

    public virtual DbSet<ImagingExamAdministration> ImagingExamAdministration { get; set; }

    public virtual DbSet<ImagingStudySingleImage> ImagingStudySingleImage { get; set; }

    public virtual DbSet<ImportClocking> ImportClocking { get; set; }

    public virtual DbSet<ImportMCUCorporate> ImportMCUCorporate { get; set; }

    public virtual DbSet<InacbgCOB> InacbgCOB { get; set; }

    public virtual DbSet<InacbgClaim> InacbgClaim { get; set; }

    public virtual DbSet<InacbgGrouper> InacbgGrouper { get; set; }

    public virtual DbSet<InacbgSimulation> InacbgSimulation { get; set; }

    public virtual DbSet<InacbgSimulationDiagnose> InacbgSimulationDiagnose { get; set; }

    public virtual DbSet<InacbgSimulationProcedure> InacbgSimulationProcedure { get; set; }

    public virtual DbSet<InacbgSpecialCMG> InacbgSpecialCMG { get; set; }

    public virtual DbSet<IncentiveCalculation> IncentiveCalculation { get; set; }

    public virtual DbSet<IncentiveMedication> IncentiveMedication { get; set; }

    public virtual DbSet<IncomeStatementReport> IncomeStatementReport { get; set; }

    public virtual DbSet<IncomeTaxByDepartment> IncomeTaxByDepartment { get; set; }

    public virtual DbSet<IndexBarthel> IndexBarthel { get; set; }

    public virtual DbSet<IndikasiAntibiotik> IndikasiAntibiotik { get; set; }

    public virtual DbSet<IndikatorPelayanan> IndikatorPelayanan { get; set; }

    public virtual DbSet<InfectiousDisease> InfectiousDisease { get; set; }

    public virtual DbSet<InfeksiPPI> InfeksiPPI { get; set; }

    public virtual DbSet<InformasiAnasthesiDanSedasi> InformasiAnasthesiDanSedasi { get; set; }

    public virtual DbSet<InformedConsentConfig> InformedConsentConfig { get; set; }

    public virtual DbSet<InformedConsentHistory> InformedConsentHistory { get; set; }

    public virtual DbSet<InhealthClaimFlag> InhealthClaimFlag { get; set; }

    public virtual DbSet<InstrumentalActivity> InstrumentalActivity { get; set; }

    public virtual DbSet<IntakeOutputDt> IntakeOutputDt { get; set; }

    public virtual DbSet<IntakeOutputHd> IntakeOutputHd { get; set; }

    public virtual DbSet<InterimBill> InterimBill { get; set; }

    public virtual DbSet<InterimBillLimit> InterimBillLimit { get; set; }

    public virtual DbSet<InventoryAmountHistory> InventoryAmountHistory { get; set; }

    public virtual DbSet<InventoryMovementStock> InventoryMovementStock { get; set; }

    public virtual DbSet<InventoryRevaluationDt> InventoryRevaluationDt { get; set; }

    public virtual DbSet<InventoryRevaluationHd> InventoryRevaluationHd { get; set; }

    public virtual DbSet<IpAddressIcu> IpAddressIcu { get; set; }

    public virtual DbSet<IpAddressMonitoring> IpAddressMonitoring { get; set; }

    public virtual DbSet<IpAddressPrinter> IpAddressPrinter { get; set; }

    public virtual DbSet<IssueUnplannedSignature> IssueUnplannedSignature { get; set; }

    public virtual DbSet<IssuedUnplannedDt> IssuedUnplannedDt { get; set; }

    public virtual DbSet<IssuedUnplannedHd> IssuedUnplannedHd { get; set; }

    public virtual DbSet<Item> Item { get; set; }

    public virtual DbSet<ItemBarcode> ItemBarcode { get; set; }

    public virtual DbSet<ItemBomDt> ItemBomDt { get; set; }

    public virtual DbSet<ItemBomHd> ItemBomHd { get; set; }

    public virtual DbSet<ItemBrand> ItemBrand { get; set; }

    public virtual DbSet<ItemBrandGeneric> ItemBrandGeneric { get; set; }

    public virtual DbSet<ItemBrandGeneric2> ItemBrandGeneric2 { get; set; }

    public virtual DbSet<ItemCompileMCU> ItemCompileMCU { get; set; }

    public virtual DbSet<ItemCost> ItemCost { get; set; }

    public virtual DbSet<ItemCostExcludePPN> ItemCostExcludePPN { get; set; }

    public virtual DbSet<ItemDrug> ItemDrug { get; set; }

    public virtual DbSet<ItemDrugDisplay> ItemDrugDisplay { get; set; }

    public virtual DbSet<ItemDrugStopOrder> ItemDrugStopOrder { get; set; }

    public virtual DbSet<ItemGeneric> ItemGeneric { get; set; }

    public virtual DbSet<ItemGroup> ItemGroup { get; set; }

    public virtual DbSet<ItemGroupRadiologi> ItemGroupRadiologi { get; set; }

    public virtual DbSet<ItemGroupReference> ItemGroupReference { get; set; }

    public virtual DbSet<ItemGroupTransaction> ItemGroupTransaction { get; set; }

    public virtual DbSet<ItemHPPBPJS> ItemHPPBPJS { get; set; }

    public virtual DbSet<ItemInGroup> ItemInGroup { get; set; }

    public virtual DbSet<ItemInjectMCU> ItemInjectMCU { get; set; }

    public virtual DbSet<ItemInjectMCUHD> ItemInjectMCUHD { get; set; }

    public virtual DbSet<ItemInventory> ItemInventory { get; set; }

    public virtual DbSet<ItemInventoryExpired> ItemInventoryExpired { get; set; }

    public virtual DbSet<ItemInventoryHistory> ItemInventoryHistory { get; set; }

    public virtual DbSet<ItemLabDisplay> ItemLabDisplay { get; set; }

    public virtual DbSet<ItemLaboratory> ItemLaboratory { get; set; }

    public virtual DbSet<ItemLaboratoryKSO> ItemLaboratoryKSO { get; set; }

    public virtual DbSet<ItemLoinc> ItemLoinc { get; set; }

    public virtual DbSet<ItemLoincGolonganDarah> ItemLoincGolonganDarah { get; set; }

    public virtual DbSet<ItemLoincRhesus> ItemLoincRhesus { get; set; }

    public virtual DbSet<ItemLoincUpload_> ItemLoincUpload_ { get; set; }

    public virtual DbSet<ItemMasterIncentive> ItemMasterIncentive { get; set; }

    public virtual DbSet<ItemMasterLaboratory> ItemMasterLaboratory { get; set; }

    public virtual DbSet<ItemMasterLaboratoryDt> ItemMasterLaboratoryDt { get; set; }

    public virtual DbSet<ItemMostFrequent> ItemMostFrequent { get; set; }

    public virtual DbSet<ItemOAT> ItemOAT { get; set; }

    public virtual DbSet<ItemPlanning> ItemPlanning { get; set; }

    public virtual DbSet<ItemPlanningByLocation> ItemPlanningByLocation { get; set; }

    public virtual DbSet<ItemPlanningDO> ItemPlanningDO { get; set; }

    public virtual DbSet<ItemPurchasePrice> ItemPurchasePrice { get; set; }

    public virtual DbSet<ItemReference> ItemReference { get; set; }

    public virtual DbSet<ItemRujukBalik> ItemRujukBalik { get; set; }

    public virtual DbSet<ItemSct> ItemSct { get; set; }

    public virtual DbSet<ItemServiceMCURealizationDt> ItemServiceMCURealizationDt { get; set; }

    public virtual DbSet<ItemServiceMCURealizationHd> ItemServiceMCURealizationHd { get; set; }

    public virtual DbSet<ItemTariffCorporate> ItemTariffCorporate { get; set; }

    public virtual DbSet<ItemTariffMCU> ItemTariffMCU { get; set; }

    public virtual DbSet<ItemTariffStandard> ItemTariffStandard { get; set; }

    public virtual DbSet<ItemTax> ItemTax { get; set; }

    public virtual DbSet<ItemTemplate> ItemTemplate { get; set; }

    public virtual DbSet<ItemTransactionHistoryDt> ItemTransactionHistoryDt { get; set; }

    public virtual DbSet<ItemTransactionHistoryDtPosting> ItemTransactionHistoryDtPosting { get; set; }

    public virtual DbSet<ItemTransactionHistoryHd> ItemTransactionHistoryHd { get; set; }

    public virtual DbSet<ItemTransactionHistoryHdPosting> ItemTransactionHistoryHdPosting { get; set; }

    public virtual DbSet<ItemTransactionMcuDt> ItemTransactionMcuDt { get; set; }

    public virtual DbSet<ItemTransactionMcuDtBom> ItemTransactionMcuDtBom { get; set; }

    public virtual DbSet<ItemTransactionMcuHd> ItemTransactionMcuHd { get; set; }

    public virtual DbSet<ItemTransactionTemplateDt> ItemTransactionTemplateDt { get; set; }

    public virtual DbSet<ItemTransactionTemplateHd> ItemTransactionTemplateHd { get; set; }

    public virtual DbSet<ItemTypeByMenuId> ItemTypeByMenuId { get; set; }

    public virtual DbSet<ItemTypeMaster> ItemTypeMaster { get; set; }

    public virtual DbSet<ItemUnit> ItemUnit { get; set; }

    public virtual DbSet<ItemUnitConversion> ItemUnitConversion { get; set; }

    public virtual DbSet<ItemVaccination> ItemVaccination { get; set; }

    public virtual DbSet<ItemVerified> ItemVerified { get; set; }

    public virtual DbSet<JasaPelayananGroup> JasaPelayananGroup { get; set; }

    public virtual DbSet<JobOrderBOMImaging> JobOrderBOMImaging { get; set; }

    public virtual DbSet<JobOrderBOMLaboratory> JobOrderBOMLaboratory { get; set; }

    public virtual DbSet<JobOrderBOMLaboratoryBackup> JobOrderBOMLaboratoryBackup { get; set; }

    public virtual DbSet<JobOrderBOMOtherExam> JobOrderBOMOtherExam { get; set; }

    public virtual DbSet<JobOrderDt> JobOrderDt { get; set; }

    public virtual DbSet<JobOrderDtBackup> JobOrderDtBackup { get; set; }

    public virtual DbSet<JobOrderDtDiagnose> JobOrderDtDiagnose { get; set; }

    public virtual DbSet<JobOrderDtKso> JobOrderDtKso { get; set; }

    public virtual DbSet<JobOrderDtMedicalSuppiles> JobOrderDtMedicalSuppiles { get; set; }

    public virtual DbSet<JobOrderDtMedication> JobOrderDtMedication { get; set; }

    public virtual DbSet<JobOrderDtMonitoring> JobOrderDtMonitoring { get; set; }

    public virtual DbSet<JobOrderHd> JobOrderHd { get; set; }

    public virtual DbSet<JobOrderHdAutoVerified> JobOrderHdAutoVerified { get; set; }

    public virtual DbSet<JobOrderHdPaymentType> JobOrderHdPaymentType { get; set; }

    public virtual DbSet<JobOrderImagingReference> JobOrderImagingReference { get; set; }

    public virtual DbSet<JobOrderLaboratoryReference> JobOrderLaboratoryReference { get; set; }

    public virtual DbSet<JobOrderMultiSignature> JobOrderMultiSignature { get; set; }

    public virtual DbSet<JobOrderOtherExamReference> JobOrderOtherExamReference { get; set; }

    public virtual DbSet<JobOrderSignature> JobOrderSignature { get; set; }

    public virtual DbSet<JournalCashBankDt> JournalCashBankDt { get; set; }

    public virtual DbSet<JournalCashBankHd> JournalCashBankHd { get; set; }

    public virtual DbSet<JournalDt> JournalDt { get; set; }

    public virtual DbSet<JournalHd> JournalHd { get; set; }

    public virtual DbSet<KartuPesertaStatusKB> KartuPesertaStatusKB { get; set; }

    public virtual DbSet<KateterAdministration> KateterAdministration { get; set; }

    public virtual DbSet<KateterAdministrationREV> KateterAdministrationREV { get; set; }

    public virtual DbSet<KegiatanAlatKelengkapanDewan> KegiatanAlatKelengkapanDewan { get; set; }

    public virtual DbSet<KegiatanAlatKelengkapanDewanDt> KegiatanAlatKelengkapanDewanDt { get; set; }

    public virtual DbSet<KegiatanAlatKelengkapanDewanDtKolesterol> KegiatanAlatKelengkapanDewanDtKolesterol { get; set; }

    public virtual DbSet<KeluargaBerencana> KeluargaBerencana { get; set; }

    public virtual DbSet<KeluargaBerencanaKB> KeluargaBerencanaKB { get; set; }

    public virtual DbSet<KeluargaBerencanaKBHd> KeluargaBerencanaKBHd { get; set; }

    public virtual DbSet<KeluhanPPI> KeluhanPPI { get; set; }

    public virtual DbSet<KeluhanUtamaPasien> KeluhanUtamaPasien { get; set; }

    public virtual DbSet<Kesimpulan> Kesimpulan { get; set; }

    public virtual DbSet<KesimpulanDanSaranMCU> KesimpulanDanSaranMCU { get; set; }

    public virtual DbSet<KetersediaanKebutuhanAlkes> KetersediaanKebutuhanAlkes { get; set; }

    public virtual DbSet<KetersediaanKebutuhanSdm> KetersediaanKebutuhanSdm { get; set; }

    public virtual DbSet<Kfa> Kfa { get; set; }

    public virtual DbSet<KfaIngredients> KfaIngredients { get; set; }

    public virtual DbSet<KfaInject> KfaInject { get; set; }

    public virtual DbSet<KiosEducation> KiosEducation { get; set; }

    public virtual DbSet<KuisionerMentalPegawai> KuisionerMentalPegawai { get; set; }

    public virtual DbSet<KunjunganUlangan> KunjunganUlangan { get; set; }

    public virtual DbSet<LOINC> LOINC { get; set; }

    public virtual DbSet<LabImport> LabImport { get; set; }

    public virtual DbSet<LabSummaryProbelm> LabSummaryProbelm { get; set; }

    public virtual DbSet<LaboratoryAdministration> LaboratoryAdministration { get; set; }

    public virtual DbSet<LaboratoryExamAdministration> LaboratoryExamAdministration { get; set; }

    public virtual DbSet<LaboratoryRecommendation> LaboratoryRecommendation { get; set; }

    public virtual DbSet<LaboratoryResultIndicator> LaboratoryResultIndicator { get; set; }

    public virtual DbSet<LaboratorySummaryMCU> LaboratorySummaryMCU { get; set; }

    public virtual DbSet<LaporanBulananPasienPoliGizi> LaporanBulananPasienPoliGizi { get; set; }

    public virtual DbSet<LaporanIGD> LaporanIGD { get; set; }

    public virtual DbSet<LaporanKantinBulanan> LaporanKantinBulanan { get; set; }

    public virtual DbSet<LaporanKegiatanAlatKelengkapanDewan> LaporanKegiatanAlatKelengkapanDewan { get; set; }

    public virtual DbSet<LaporanKegiatanAlatKelengkapanDewanDtKalori> LaporanKegiatanAlatKelengkapanDewanDtKalori { get; set; }

    public virtual DbSet<LaporanKegiatanAlatKelengkapanDewanDtKolesterol> LaporanKegiatanAlatKelengkapanDewanDtKolesterol { get; set; }

    public virtual DbSet<LaporanOperasi> LaporanOperasi { get; set; }

    public virtual DbSet<LaporanOperasiSignature> LaporanOperasiSignature { get; set; }

    public virtual DbSet<LaporanPelayananResepEntry> LaporanPelayananResepEntry { get; set; }

    public virtual DbSet<LaporanPengecekanKantinDt1> LaporanPengecekanKantinDt1 { get; set; }

    public virtual DbSet<LaporanPengecekanKantinDt2> LaporanPengecekanKantinDt2 { get; set; }

    public virtual DbSet<LaporanPengecekanKantinOther1> LaporanPengecekanKantinOther1 { get; set; }

    public virtual DbSet<LaporanPengecekanKantinOther2> LaporanPengecekanKantinOther2 { get; set; }

    public virtual DbSet<LaporanPengecekanKantinTable> LaporanPengecekanKantinTable { get; set; }

    public virtual DbSet<LeaveAdjustmentDt> LeaveAdjustmentDt { get; set; }

    public virtual DbSet<LeaveAdjustmentHd> LeaveAdjustmentHd { get; set; }

    public virtual DbSet<LeaveCashable> LeaveCashable { get; set; }

    public virtual DbSet<LeaveHistory> LeaveHistory { get; set; }

    public virtual DbSet<LeaveRequest> LeaveRequest { get; set; }

    public virtual DbSet<LeaveType> LeaveType { get; set; }

    public virtual DbSet<LembarPoliklinikMataEntry> LembarPoliklinikMataEntry { get; set; }

    public virtual DbSet<ListAdvanceMasterCheck> ListAdvanceMasterCheck { get; set; }

    public virtual DbSet<ListIndexNh> ListIndexNh { get; set; }

    public virtual DbSet<ListofContraBS> ListofContraBS { get; set; }

    public virtual DbSet<ListofTransferAPBySupplier> ListofTransferAPBySupplier { get; set; }

    public virtual DbSet<ListofTransferBS> ListofTransferBS { get; set; }

    public virtual DbSet<ListofTransferGenerateCGAP> ListofTransferGenerateCGAP { get; set; }

    public virtual DbSet<ListofTransferGenerateCGAPHd> ListofTransferGenerateCGAPHd { get; set; }

    public virtual DbSet<Location> Location { get; set; }

    public virtual DbSet<LocationEngineering> LocationEngineering { get; set; }

    public virtual DbSet<LocationItemRack> LocationItemRack { get; set; }

    public virtual DbSet<LocationPermissionHd> LocationPermissionHd { get; set; }

    public virtual DbSet<LogPrintMCUResult> LogPrintMCUResult { get; set; }

    public virtual DbSet<LoopTest> LoopTest { get; set; }

    public virtual DbSet<MCUElektrokardiogram> MCUElektrokardiogram { get; set; }

    public virtual DbSet<MCUHealthItemGroup> MCUHealthItemGroup { get; set; }

    public virtual DbSet<MCUHealthSummary> MCUHealthSummary { get; set; }

    public virtual DbSet<MCUOdontogram> MCUOdontogram { get; set; }

    public virtual DbSet<MEOWS> MEOWS { get; set; }

    public virtual DbSet<METargetDt> METargetDt { get; set; }

    public virtual DbSet<METargetHd> METargetHd { get; set; }

    public virtual DbSet<MIMSClass> MIMSClass { get; set; }

    public virtual DbSet<MRPHistoryDt> MRPHistoryDt { get; set; }

    public virtual DbSet<MRPHistoryHd> MRPHistoryHd { get; set; }

    public virtual DbSet<MRPHistorySubDt> MRPHistorySubDt { get; set; }

    public virtual DbSet<MachineHD> MachineHD { get; set; }

    public virtual DbSet<MappingBrmRules> MappingBrmRules { get; set; }

    public virtual DbSet<MarkUpPrice> MarkUpPrice { get; set; }

    public virtual DbSet<MassLeaveDt> MassLeaveDt { get; set; }

    public virtual DbSet<MassLeaveHd> MassLeaveHd { get; set; }

    public virtual DbSet<MasterEmployee> MasterEmployee { get; set; }

    public virtual DbSet<MasterPointReward> MasterPointReward { get; set; }

    public virtual DbSet<MasterQoS> MasterQoS { get; set; }

    public virtual DbSet<MasterReferensiSdm> MasterReferensiSdm { get; set; }

    public virtual DbSet<MasterRevenueSharing> MasterRevenueSharing { get; set; }

    public virtual DbSet<MataAnggaran> MataAnggaran { get; set; }

    public virtual DbSet<MaterialEngineering> MaterialEngineering { get; set; }

    public virtual DbSet<MaterialRequestCompletionDt> MaterialRequestCompletionDt { get; set; }

    public virtual DbSet<MaterialRequestCompletionHd> MaterialRequestCompletionHd { get; set; }

    public virtual DbSet<MaterialRequestDt> MaterialRequestDt { get; set; }

    public virtual DbSet<MaterialRequestHd> MaterialRequestHd { get; set; }

    public virtual DbSet<McuDateMaster> McuDateMaster { get; set; }

    public virtual DbSet<McuHealthSummaryPersonal> McuHealthSummaryPersonal { get; set; }

    public virtual DbSet<MedicalBenefitType> MedicalBenefitType { get; set; }

    public virtual DbSet<MedicalRecordDailyReport> MedicalRecordDailyReport { get; set; }

    public virtual DbSet<MedicalRecordList> MedicalRecordList { get; set; }

    public virtual DbSet<MedicalRecordLog> MedicalRecordLog { get; set; }

    public virtual DbSet<MedicalRecordReconcileHistory> MedicalRecordReconcileHistory { get; set; }

    public virtual DbSet<MedicalResumeSignature> MedicalResumeSignature { get; set; }

    public virtual DbSet<MedicalSuppliesReturnDt> MedicalSuppliesReturnDt { get; set; }

    public virtual DbSet<MedicalSuppliesReturnHd> MedicalSuppliesReturnHd { get; set; }

    public virtual DbSet<MedicationConsumUnit> MedicationConsumUnit { get; set; }

    public virtual DbSet<MedicationForm> MedicationForm { get; set; }

    public virtual DbSet<MedicationReconciliationAdministration> MedicationReconciliationAdministration { get; set; }

    public virtual DbSet<MedicationReconciliationDtNew> MedicationReconciliationDtNew { get; set; }

    public virtual DbSet<MedicationReconciliationHd> MedicationReconciliationHd { get; set; }

    public virtual DbSet<MedicationReconciliationHdNew> MedicationReconciliationHdNew { get; set; }

    public virtual DbSet<MenuCycleSchedule> MenuCycleSchedule { get; set; }

    public virtual DbSet<MenuDiet> MenuDiet { get; set; }

    public virtual DbSet<MimsImport> MimsImport { get; set; }

    public virtual DbSet<MimsImportDt> MimsImportDt { get; set; }

    public virtual DbSet<MobileJKNKodeBooking> MobileJKNKodeBooking { get; set; }

    public virtual DbSet<MobileJKNMembership> MobileJKNMembership { get; set; }

    public virtual DbSet<MobileMembership> MobileMembership { get; set; }

    public virtual DbSet<ModifikasiIndexBarthel> ModifikasiIndexBarthel { get; set; }

    public virtual DbSet<MonitoringAdministration> MonitoringAdministration { get; set; }

    public virtual DbSet<MonitoringKantin> MonitoringKantin { get; set; }

    public virtual DbSet<MonitoringKantinOther> MonitoringKantinOther { get; set; }

    public virtual DbSet<MonitoringKantinOther2> MonitoringKantinOther2 { get; set; }

    public virtual DbSet<MonitoringKantinOther3> MonitoringKantinOther3 { get; set; }

    public virtual DbSet<MonitoringSignMCU> MonitoringSignMCU { get; set; }

    public virtual DbSet<MonitoringStatusFisiologisDt> MonitoringStatusFisiologisDt { get; set; }

    public virtual DbSet<MonitoringStatusFisiologisHd> MonitoringStatusFisiologisHd { get; set; }

    public virtual DbSet<MonthlyHospitalPerformance> MonthlyHospitalPerformance { get; set; }

    public virtual DbSet<Morphology> Morphology { get; set; }

    public virtual DbSet<MorseFallScore> MorseFallScore { get; set; }

    public virtual DbSet<MovementStockInvent> MovementStockInvent { get; set; }

    public virtual DbSet<MultiPayerAuthorized> MultiPayerAuthorized { get; set; }

    public virtual DbSet<NameFound> NameFound { get; set; }

    public virtual DbSet<NameNotFound> NameNotFound { get; set; }

    public virtual DbSet<Nanda> Nanda { get; set; }

    public virtual DbSet<NandaAssement> NandaAssement { get; set; }

    public virtual DbSet<NandaCharacteristic> NandaCharacteristic { get; set; }

    public virtual DbSet<NandaCharacteristicGroup> NandaCharacteristicGroup { get; set; }

    public virtual DbSet<NandaClass> NandaClass { get; set; }

    public virtual DbSet<NandaDomain> NandaDomain { get; set; }

    public virtual DbSet<NandaNicAdditional> NandaNicAdditional { get; set; }

    public virtual DbSet<NandaNicPriority> NandaNicPriority { get; set; }

    public virtual DbSet<NandaNicSuggested> NandaNicSuggested { get; set; }

    public virtual DbSet<NandaNocAdditional> NandaNocAdditional { get; set; }

    public virtual DbSet<NandaNocSuggested> NandaNocSuggested { get; set; }

    public virtual DbSet<NandaRelatedFactor> NandaRelatedFactor { get; set; }

    public virtual DbSet<NandaRelatedFactorGroup> NandaRelatedFactorGroup { get; set; }

    public virtual DbSet<NandaRiskFactor> NandaRiskFactor { get; set; }

    public virtual DbSet<NandaRiskFactorGroup> NandaRiskFactorGroup { get; set; }

    public virtual DbSet<NandaTemplateDt> NandaTemplateDt { get; set; }

    public virtual DbSet<NandaTemplateHd> NandaTemplateHd { get; set; }

    public virtual DbSet<Nic> Nic { get; set; }

    public virtual DbSet<NicActivity> NicActivity { get; set; }

    public virtual DbSet<NicClass> NicClass { get; set; }

    public virtual DbSet<NicDomain> NicDomain { get; set; }

    public virtual DbSet<Noc> Noc { get; set; }

    public virtual DbSet<NocClass> NocClass { get; set; }

    public virtual DbSet<NocDomain> NocDomain { get; set; }

    public virtual DbSet<NocIndicator> NocIndicator { get; set; }

    public virtual DbSet<NocScale> NocScale { get; set; }

    public virtual DbSet<NotaDinasFile> NotaDinasFile { get; set; }

    public virtual DbSet<NotaDinasKeluarFile> NotaDinasKeluarFile { get; set; }

    public virtual DbSet<NotaDinasTable> NotaDinasTable { get; set; }

    public virtual DbSet<NotulenRapat> NotulenRapat { get; set; }

    public virtual DbSet<NotulenRapatFile> NotulenRapatFile { get; set; }

    public virtual DbSet<NotulenRapatFileBackup> NotulenRapatFileBackup { get; set; }

    public virtual DbSet<NsDrugAdministration> NsDrugAdministration { get; set; }

    public virtual DbSet<NsJobOrderBOMImaging> NsJobOrderBOMImaging { get; set; }

    public virtual DbSet<NsJobOrderBOMLaboratory> NsJobOrderBOMLaboratory { get; set; }

    public virtual DbSet<NsJobOrderBOMOtherExam> NsJobOrderBOMOtherExam { get; set; }

    public virtual DbSet<NsJobOrderDt> NsJobOrderDt { get; set; }

    public virtual DbSet<NsJobOrderDtDiagnose> NsJobOrderDtDiagnose { get; set; }

    public virtual DbSet<NsJobOrderDtMedication> NsJobOrderDtMedication { get; set; }

    public virtual DbSet<NsJobOrderDtMonitoring> NsJobOrderDtMonitoring { get; set; }

    public virtual DbSet<NsJobOrderHd> NsJobOrderHd { get; set; }

    public virtual DbSet<NsMonitoringAdministration> NsMonitoringAdministration { get; set; }

    public virtual DbSet<NsNursingCareplan> NsNursingCareplan { get; set; }

    public virtual DbSet<NsNursingCareplanCharacteristic> NsNursingCareplanCharacteristic { get; set; }

    public virtual DbSet<NsNursingCareplanIntervention> NsNursingCareplanIntervention { get; set; }

    public virtual DbSet<NsNursingCareplanInterventionActivity> NsNursingCareplanInterventionActivity { get; set; }

    public virtual DbSet<NsNursingCareplanOutcome> NsNursingCareplanOutcome { get; set; }

    public virtual DbSet<NsNursingCareplanOutcomeResult> NsNursingCareplanOutcomeResult { get; set; }

    public virtual DbSet<NsNursingCareplanRelatedFactor> NsNursingCareplanRelatedFactor { get; set; }

    public virtual DbSet<NsNursingCareplanRiskFactor> NsNursingCareplanRiskFactor { get; set; }

    public virtual DbSet<NsOtherExamResultAttachment> NsOtherExamResultAttachment { get; set; }

    public virtual DbSet<NurseShiftTransferHistoryDt> NurseShiftTransferHistoryDt { get; set; }

    public virtual DbSet<NurseShiftTransferHistoryHd> NurseShiftTransferHistoryHd { get; set; }

    public virtual DbSet<NursingActivityGroup> NursingActivityGroup { get; set; }

    public virtual DbSet<NursingCarePlanTemplateDt> NursingCarePlanTemplateDt { get; set; }

    public virtual DbSet<NursingCarePlanTemplateHd> NursingCarePlanTemplateHd { get; set; }

    public virtual DbSet<NursingCareplan> NursingCareplan { get; set; }

    public virtual DbSet<NursingCareplanCharacteristic> NursingCareplanCharacteristic { get; set; }

    public virtual DbSet<NursingCareplanIntervention> NursingCareplanIntervention { get; set; }

    public virtual DbSet<NursingCareplanInterventionActivity> NursingCareplanInterventionActivity { get; set; }

    public virtual DbSet<NursingCareplanOutcome> NursingCareplanOutcome { get; set; }

    public virtual DbSet<NursingCareplanOutcomeResult> NursingCareplanOutcomeResult { get; set; }

    public virtual DbSet<NursingCareplanRelatedFactor> NursingCareplanRelatedFactor { get; set; }

    public virtual DbSet<NursingCareplanRiskFactor> NursingCareplanRiskFactor { get; set; }

    public virtual DbSet<NutritionConsultation> NutritionConsultation { get; set; }

    public virtual DbSet<NutritionistOpinion> NutritionistOpinion { get; set; }

    public virtual DbSet<OTProgressInformation> OTProgressInformation { get; set; }

    public virtual DbSet<OTReportAlatMedis> OTReportAlatMedis { get; set; }

    public virtual DbSet<OTReportConfiguration> OTReportConfiguration { get; set; }

    public virtual DbSet<OTReportTindakan> OTReportTindakan { get; set; }

    public virtual DbSet<OTReports> OTReports { get; set; }

    public virtual DbSet<ObatPengadaan> ObatPengadaan { get; set; }

    public virtual DbSet<OdontogramMCU> OdontogramMCU { get; set; }

    public virtual DbSet<OpenAdministrationDischarge> OpenAdministrationDischarge { get; set; }

    public virtual DbSet<OrderMenuDiitDt> OrderMenuDiitDt { get; set; }

    public virtual DbSet<OrderMenuDiitHd> OrderMenuDiitHd { get; set; }

    public virtual DbSet<OrderableDrugFormV3> OrderableDrugFormV3 { get; set; }

    public virtual DbSet<Organization> Organization { get; set; }

    public virtual DbSet<OtherExamResultAttachment> OtherExamResultAttachment { get; set; }

    public virtual DbSet<OutDataMerge> OutDataMerge { get; set; }

    public virtual DbSet<OutstandingDODt> OutstandingDODt { get; set; }

    public virtual DbSet<OutstandingDOHd> OutstandingDOHd { get; set; }

    public virtual DbSet<OvertimeWorkOrder> OvertimeWorkOrder { get; set; }

    public virtual DbSet<OvertimeWorkOrderDt> OvertimeWorkOrderDt { get; set; }

    public virtual DbSet<PEWS> PEWS { get; set; }

    public virtual DbSet<PKRSTargetDt> PKRSTargetDt { get; set; }

    public virtual DbSet<PMKPGrouping> PMKPGrouping { get; set; }

    public virtual DbSet<PMKPIndicator> PMKPIndicator { get; set; }

    public virtual DbSet<PMKPMasterIndicatorDt> PMKPMasterIndicatorDt { get; set; }

    public virtual DbSet<PMKPMasterIndicatorHd> PMKPMasterIndicatorHd { get; set; }

    public virtual DbSet<PMKPMasterRealisasi> PMKPMasterRealisasi { get; set; }

    public virtual DbSet<PMKPNumDenum> PMKPNumDenum { get; set; }

    public virtual DbSet<PMKPTargetDt> PMKPTargetDt { get; set; }

    public virtual DbSet<PMKPTargetHd> PMKPTargetHd { get; set; }

    public virtual DbSet<PMKPTargetSubDt> PMKPTargetSubDt { get; set; }

    public virtual DbSet<POR_Reference> POR_Reference { get; set; }

    public virtual DbSet<PPITargetDt> PPITargetDt { get; set; }

    public virtual DbSet<PPITargetHd> PPITargetHd { get; set; }

    public virtual DbSet<PTKPStatus> PTKPStatus { get; set; }

    public virtual DbSet<PackageTreatmentDt> PackageTreatmentDt { get; set; }

    public virtual DbSet<PackageTreatmentHd> PackageTreatmentHd { get; set; }

    public virtual DbSet<PanelNominalLaboratory> PanelNominalLaboratory { get; set; }

    public virtual DbSet<PanelOrdinalLaboratory> PanelOrdinalLaboratory { get; set; }

    public virtual DbSet<PapsMearResult> PapsMearResult { get; set; }

    public virtual DbSet<Paramedic> Paramedic { get; set; }

    public virtual DbSet<ParamedicAutoBill> ParamedicAutoBill { get; set; }

    public virtual DbSet<ParamedicCertificate> ParamedicCertificate { get; set; }

    public virtual DbSet<ParamedicImport> ParamedicImport { get; set; }

    public virtual DbSet<ParamedicItemMcu> ParamedicItemMcu { get; set; }

    public virtual DbSet<ParamedicSignature> ParamedicSignature { get; set; }

    public virtual DbSet<ParamedicTypeNote> ParamedicTypeNote { get; set; }

    public virtual DbSet<ParamedicVisitType> ParamedicVisitType { get; set; }

    public virtual DbSet<ParameterGroupKuesioner> ParameterGroupKuesioner { get; set; }

    public virtual DbSet<ParameterMcuGrouping> ParameterMcuGrouping { get; set; }

    public virtual DbSet<Partograf> Partograf { get; set; }

    public virtual DbSet<PartografHd> PartografHd { get; set; }

    public virtual DbSet<PasienRujukBalik> PasienRujukBalik { get; set; }

    public virtual DbSet<PasienRujukBalikHistory> PasienRujukBalikHistory { get; set; }

    public virtual DbSet<Patient> Patient { get; set; }

    public virtual DbSet<Patient23> Patient23 { get; set; }

    public virtual DbSet<PatientAPGAR> PatientAPGAR { get; set; }

    public virtual DbSet<PatientAllergy> PatientAllergy { get; set; }

    public virtual DbSet<PatientAntibiotik> PatientAntibiotik { get; set; }

    public virtual DbSet<PatientApgarRsse> PatientApgarRsse { get; set; }

    public virtual DbSet<PatientAppointmentVsAdmission> PatientAppointmentVsAdmission { get; set; }

    public virtual DbSet<PatientAppointmentVsAdmissionY> PatientAppointmentVsAdmissionY { get; set; }

    public virtual DbSet<PatientAttendance> PatientAttendance { get; set; }

    public virtual DbSet<PatientBPU> PatientBPU { get; set; }

    public virtual DbSet<PatientBackup20240130> PatientBackup20240130 { get; set; }

    public virtual DbSet<PatientBirthRecord> PatientBirthRecord { get; set; }

    public virtual DbSet<PatientBlackList> PatientBlackList { get; set; }

    public virtual DbSet<PatientCAPPIRO> PatientCAPPIRO { get; set; }

    public virtual DbSet<PatientCHDRisk> PatientCHDRisk { get; set; }

    public virtual DbSet<PatientCancel> PatientCancel { get; set; }

    public virtual DbSet<PatientCorporateEligibility> PatientCorporateEligibility { get; set; }

    public virtual DbSet<PatientDocument> PatientDocument { get; set; }

    public virtual DbSet<PatientDocumentDetail> PatientDocumentDetail { get; set; }

    public virtual DbSet<PatientEktpReader> PatientEktpReader { get; set; }

    public virtual DbSet<PatientFCS> PatientFCS { get; set; }

    public virtual DbSet<PatientFamily> PatientFamily { get; set; }

    public virtual DbSet<PatientGCS> PatientGCS { get; set; }

    public virtual DbSet<PatientGCSPediatric> PatientGCSPediatric { get; set; }

    public virtual DbSet<PatientGuideLines> PatientGuideLines { get; set; }

    public virtual DbSet<PatientImport> PatientImport { get; set; }

    public virtual DbSet<PatientImport1> PatientImport1 { get; set; }

    public virtual DbSet<PatientImport2> PatientImport2 { get; set; }

    public virtual DbSet<PatientImport3> PatientImport3 { get; set; }

    public virtual DbSet<PatientInfectiousDisease> PatientInfectiousDisease { get; set; }

    public virtual DbSet<PatientInjectDetail> PatientInjectDetail { get; set; }

    public virtual DbSet<PatientLive> PatientLive { get; set; }

    public virtual DbSet<PatientLookUp> PatientLookUp { get; set; }

    public virtual DbSet<PatientMCUCompileDt> PatientMCUCompileDt { get; set; }

    public virtual DbSet<PatientMCUCompileDtRecommendation> PatientMCUCompileDtRecommendation { get; set; }

    public virtual DbSet<PatientMCUCompileHd> PatientMCUCompileHd { get; set; }

    public virtual DbSet<PatientMergeHd> PatientMergeHd { get; set; }

    public virtual DbSet<PatientMergeLog> PatientMergeLog { get; set; }

    public virtual DbSet<PatientMonitoringIPAddress> PatientMonitoringIPAddress { get; set; }

    public virtual DbSet<PatientNotes> PatientNotes { get; set; }

    public virtual DbSet<PatientNotesSignature> PatientNotesSignature { get; set; }

    public virtual DbSet<PatientOdontogram> PatientOdontogram { get; set; }

    public virtual DbSet<PatientOdontogramNew> PatientOdontogramNew { get; set; }

    public virtual DbSet<PatientOralMucosa> PatientOralMucosa { get; set; }

    public virtual DbSet<PatientPPAInstruction> PatientPPAInstruction { get; set; }

    public virtual DbSet<PatientPayerCard> PatientPayerCard { get; set; }

    public virtual DbSet<PatientProblem> PatientProblem { get; set; }

    public virtual DbSet<PatientProblemGenerated> PatientProblemGenerated { get; set; }

    public virtual DbSet<PatientQuestionaireDt> PatientQuestionaireDt { get; set; }

    public virtual DbSet<PatientQuestionaireHd> PatientQuestionaireHd { get; set; }

    public virtual DbSet<PatientResponsibleLog> PatientResponsibleLog { get; set; }

    public virtual DbSet<PatientResumeDtCPOE> PatientResumeDtCPOE { get; set; }

    public virtual DbSet<PatientResumeDtNotes> PatientResumeDtNotes { get; set; }

    public virtual DbSet<PatientResumeHd> PatientResumeHd { get; set; }

    public virtual DbSet<PatientResumeKeadaanPulang> PatientResumeKeadaanPulang { get; set; }

    public virtual DbSet<PatientSatuSehatConsent> PatientSatuSehatConsent { get; set; }

    public virtual DbSet<PatientSummaryControl> PatientSummaryControl { get; set; }

    public virtual DbSet<PatientSummaryControlParamedicType> PatientSummaryControlParamedicType { get; set; }

    public virtual DbSet<PatientSummaryParamedicType> PatientSummaryParamedicType { get; set; }

    public virtual DbSet<PatientSurgeryStatus> PatientSurgeryStatus { get; set; }

    public virtual DbSet<PatientSurvey> PatientSurvey { get; set; }

    public virtual DbSet<PatientTagField> PatientTagField { get; set; }

    public virtual DbSet<PatientVaccination> PatientVaccination { get; set; }

    public virtual DbSet<PatientVision> PatientVision { get; set; }

    public virtual DbSet<PatientVisitItem> PatientVisitItem { get; set; }

    public virtual DbSet<PatientYankes> PatientYankes { get; set; }

    public virtual DbSet<PatientYankes2> PatientYankes2 { get; set; }

    public virtual DbSet<PatientYankes223> PatientYankes223 { get; set; }

    public virtual DbSet<PayerInvoice> PayerInvoice { get; set; }

    public virtual DbSet<PaymentPlanAPGiro> PaymentPlanAPGiro { get; set; }

    public virtual DbSet<PaymentPlanRSGiro> PaymentPlanRSGiro { get; set; }

    public virtual DbSet<PaymentReceiptDt> PaymentReceiptDt { get; set; }

    public virtual DbSet<PaymentReceiptHd> PaymentReceiptHd { get; set; }

    public virtual DbSet<PaymentReceiptHistory> PaymentReceiptHistory { get; set; }

    public virtual DbSet<PaymentReceiptResetHistory> PaymentReceiptResetHistory { get; set; }

    public virtual DbSet<PaymentRefund> PaymentRefund { get; set; }

    public virtual DbSet<PaymentRefundCashierHd> PaymentRefundCashierHd { get; set; }

    public virtual DbSet<PaymentRefundDt> PaymentRefundDt { get; set; }

    public virtual DbSet<PaymentRefundMedication> PaymentRefundMedication { get; set; }

    public virtual DbSet<PaymentRefundMedicationDt> PaymentRefundMedicationDt { get; set; }

    public virtual DbSet<PayrollPaymentPlanDt> PayrollPaymentPlanDt { get; set; }

    public virtual DbSet<PayrollPaymentPlanHd> PayrollPaymentPlanHd { get; set; }

    public virtual DbSet<PayrollPeriodDt> PayrollPeriodDt { get; set; }

    public virtual DbSet<PayrollPeriodHd> PayrollPeriodHd { get; set; }

    public virtual DbSet<PayrollProcessDt> PayrollProcessDt { get; set; }

    public virtual DbSet<PayrollProcessHd> PayrollProcessHd { get; set; }

    public virtual DbSet<PayrollProcessSubDt> PayrollProcessSubDt { get; set; }

    public virtual DbSet<PediatricChart> PediatricChart { get; set; }

    public virtual DbSet<PediatricEarlyWarningScore> PediatricEarlyWarningScore { get; set; }

    public virtual DbSet<PelayananKerohanian> PelayananKerohanian { get; set; }

    public virtual DbSet<PelayananResepObat> PelayananResepObat { get; set; }

    public virtual DbSet<PemberitahuanPenderitaDemamBerdarahDengue> PemberitahuanPenderitaDemamBerdarahDengue { get; set; }

    public virtual DbSet<PemeriksaanFisikMCU> PemeriksaanFisikMCU { get; set; }

    public virtual DbSet<PemeriksaanFisikOHIS> PemeriksaanFisikOHIS { get; set; }

    public virtual DbSet<PemeriksaanInfeksi> PemeriksaanInfeksi { get; set; }

    public virtual DbSet<PemeriksaanInfeksiHd> PemeriksaanInfeksiHd { get; set; }

    public virtual DbSet<PemeriksaanMataMCU> PemeriksaanMataMCU { get; set; }

    public virtual DbSet<PemeriksaanOperasiHd> PemeriksaanOperasiHd { get; set; }

    public virtual DbSet<PencegahanPasienJatuhRisikoT> PencegahanPasienJatuhRisikoT { get; set; }

    public virtual DbSet<PencegahanPasienJatuhRisikoTDetail> PencegahanPasienJatuhRisikoTDetail { get; set; }

    public virtual DbSet<PencegahanStandarJatuhDetail> PencegahanStandarJatuhDetail { get; set; }

    public virtual DbSet<PencegahanStandarJatuhHeader> PencegahanStandarJatuhHeader { get; set; }

    public virtual DbSet<PengunjungRS> PengunjungRS { get; set; }

    public virtual DbSet<PenolakanTindakanKedokteran> PenolakanTindakanKedokteran { get; set; }

    public virtual DbSet<PermohonanPelayananKontrasepsi> PermohonanPelayananKontrasepsi { get; set; }

    public virtual DbSet<PersetujuanTindakanKedokteran> PersetujuanTindakanKedokteran { get; set; }

    public virtual DbSet<PersetujuanTindakanKedokteranMedis> PersetujuanTindakanKedokteranMedis { get; set; }

    public virtual DbSet<PersetujuanTreadmillTest> PersetujuanTreadmillTest { get; set; }

    public virtual DbSet<PerubahanResep> PerubahanResep { get; set; }

    public virtual DbSet<PettyCashDt> PettyCashDt { get; set; }

    public virtual DbSet<PettyCashHd> PettyCashHd { get; set; }

    public virtual DbSet<PharmacyVerificationByDepartment> PharmacyVerificationByDepartment { get; set; }

    public virtual DbSet<PhotoPatientYankes> PhotoPatientYankes { get; set; }

    public virtual DbSet<PhysicalExamReport> PhysicalExamReport { get; set; }

    public virtual DbSet<PhysicianBilling> PhysicianBilling { get; set; }

    public virtual DbSet<PhysicianBillingTemplateDt> PhysicianBillingTemplateDt { get; set; }

    public virtual DbSet<PhysicianBillingTemplateHd> PhysicianBillingTemplateHd { get; set; }

    public virtual DbSet<PhysicianChargesByClass> PhysicianChargesByClass { get; set; }

    public virtual DbSet<PhysicianControlSchedule> PhysicianControlSchedule { get; set; }

    public virtual DbSet<PhysicianDPJP> PhysicianDPJP { get; set; }

    public virtual DbSet<PhysicianFeeAdditionalFee> PhysicianFeeAdditionalFee { get; set; }

    public virtual DbSet<PhysicianFeeItem> PhysicianFeeItem { get; set; }

    public virtual DbSet<PhysicianFeeItemJobOrder> PhysicianFeeItemJobOrder { get; set; }

    public virtual DbSet<PhysicianFeePaymentPlanDt> PhysicianFeePaymentPlanDt { get; set; }

    public virtual DbSet<PhysicianFeePaymentPlanHd> PhysicianFeePaymentPlanHd { get; set; }

    public virtual DbSet<PhysicianFeeVerification> PhysicianFeeVerification { get; set; }

    public virtual DbSet<PhysicianItem> PhysicianItem { get; set; }

    public virtual DbSet<PhysicianRMO> PhysicianRMO { get; set; }

    public virtual DbSet<PhysicianRevenue> PhysicianRevenue { get; set; }

    public virtual DbSet<PhysicianTaxSummaryDt> PhysicianTaxSummaryDt { get; set; }

    public virtual DbSet<PhysicianTaxSummaryHd> PhysicianTaxSummaryHd { get; set; }

    public virtual DbSet<PhysicianTeam> PhysicianTeam { get; set; }

    public virtual DbSet<PhysicianTeamNH> PhysicianTeamNH { get; set; }

    public virtual DbSet<PhysicianTeamSurgery> PhysicianTeamSurgery { get; set; }

    public virtual DbSet<PhysicianWorkStationCapacity> PhysicianWorkStationCapacity { get; set; }

    public virtual DbSet<PointRewardRedeemDt> PointRewardRedeemDt { get; set; }

    public virtual DbSet<PointRewardRedeemHD> PointRewardRedeemHD { get; set; }

    public virtual DbSet<Position> Position { get; set; }

    public virtual DbSet<PostingHistory> PostingHistory { get; set; }

    public virtual DbSet<PostingProfitMonthlyClosing> PostingProfitMonthlyClosing { get; set; }

    public virtual DbSet<PostingProfitMonthlyClosingDt> PostingProfitMonthlyClosingDt { get; set; }

    public virtual DbSet<PraCommand> PraCommand { get; set; }

    public virtual DbSet<PraProcessDt> PraProcessDt { get; set; }

    public virtual DbSet<PraProcessHd> PraProcessHd { get; set; }

    public virtual DbSet<PregnancyStatus> PregnancyStatus { get; set; }

    public virtual DbSet<PrescriptionCronic> PrescriptionCronic { get; set; }

    public virtual DbSet<PrescriptionIterationDt> PrescriptionIterationDt { get; set; }

    public virtual DbSet<PrescriptionIterationHd> PrescriptionIterationHd { get; set; }

    public virtual DbSet<PrescriptionPayment> PrescriptionPayment { get; set; }

    public virtual DbSet<PrescriptionSignature> PrescriptionSignature { get; set; }

    public virtual DbSet<PrescriptionTemplateDt> PrescriptionTemplateDt { get; set; }

    public virtual DbSet<PrescriptionTemplateHd> PrescriptionTemplateHd { get; set; }

    public virtual DbSet<PrintedArchive> PrintedArchive { get; set; }

    public virtual DbSet<PrintedArchiveMCUCorporate> PrintedArchiveMCUCorporate { get; set; }

    public virtual DbSet<ProblemValue> ProblemValue { get; set; }

    public virtual DbSet<Procedures> Procedures { get; set; }

    public virtual DbSet<ProceduresMostFrequent> ProceduresMostFrequent { get; set; }

    public virtual DbSet<ProductLine> ProductLine { get; set; }

    public virtual DbSet<ProductionDt> ProductionDt { get; set; }

    public virtual DbSet<ProductionHd> ProductionHd { get; set; }

    public virtual DbSet<ProformaInvoice> ProformaInvoice { get; set; }

    public virtual DbSet<Prognisis> Prognisis { get; set; }

    public virtual DbSet<PrognosisPasien> PrognosisPasien { get; set; }

    public virtual DbSet<ProgressiveTaxRate> ProgressiveTaxRate { get; set; }

    public virtual DbSet<ProjectDocument> ProjectDocument { get; set; }

    public virtual DbSet<ProjectMCUCorporate> ProjectMCUCorporate { get; set; }

    public virtual DbSet<Promo> Promo { get; set; }

    public virtual DbSet<PurchaseOrderDt> PurchaseOrderDt { get; set; }

    public virtual DbSet<PurchaseOrderHd> PurchaseOrderHd { get; set; }

    public virtual DbSet<PurchaseOrderPlanned> PurchaseOrderPlanned { get; set; }

    public virtual DbSet<PurchaseOrderPlannedByLocation> PurchaseOrderPlannedByLocation { get; set; }

    public virtual DbSet<PurchaseOrderReceiptDt> PurchaseOrderReceiptDt { get; set; }

    public virtual DbSet<PurchaseOrderReceiptHd> PurchaseOrderReceiptHd { get; set; }

    public virtual DbSet<PurchaseRequestCompletionDt> PurchaseRequestCompletionDt { get; set; }

    public virtual DbSet<PurchaseRequestCompletionHd> PurchaseRequestCompletionHd { get; set; }

    public virtual DbSet<PurchaseRequestDt> PurchaseRequestDt { get; set; }

    public virtual DbSet<PurchaseRequestHd> PurchaseRequestHd { get; set; }

    public virtual DbSet<Question> Question { get; set; }

    public virtual DbSet<QuestionAnswer> QuestionAnswer { get; set; }

    public virtual DbSet<QuestionBRM> QuestionBRM { get; set; }

    public virtual DbSet<QuestionGroup> QuestionGroup { get; set; }

    public virtual DbSet<QuestionGroupInForm> QuestionGroupInForm { get; set; }

    public virtual DbSet<QuestionaireForm> QuestionaireForm { get; set; }

    public virtual DbSet<QueueDefaultSlot> QueueDefaultSlot { get; set; }

    public virtual DbSet<QueueGelang> QueueGelang { get; set; }

    public virtual DbSet<QueuePharmacyByServiceUnit> QueuePharmacyByServiceUnit { get; set; }

    public virtual DbSet<Queuing> Queuing { get; set; }

    public virtual DbSet<QueuingJKN> QueuingJKN { get; set; }

    public virtual DbSet<QueuingOperasi> QueuingOperasi { get; set; }

    public virtual DbSet<QueuingParameter> QueuingParameter { get; set; }

    public virtual DbSet<QueuingReference> QueuingReference { get; set; }

    public virtual DbSet<QueuingSlot> QueuingSlot { get; set; }

    public virtual DbSet<QueuingTVGeneralCode> QueuingTVGeneralCode { get; set; }

    public virtual DbSet<RL1BayiTabung> RL1BayiTabung { get; set; }

    public virtual DbSet<RL1CaraPembayaran> RL1CaraPembayaran { get; set; }

    public virtual DbSet<RL1KebidananPerinatologi> RL1KebidananPerinatologi { get; set; }

    public virtual DbSet<RL1KegiatanFarmasi> RL1KegiatanFarmasi { get; set; }

    public virtual DbSet<RL1KegiatanPelayananKhusus> RL1KegiatanPelayananKhusus { get; set; }

    public virtual DbSet<RL1KegiatanRadiologi> RL1KegiatanRadiologi { get; set; }

    public virtual DbSet<RL1KegiatanRujukan> RL1KegiatanRujukan { get; set; }

    public virtual DbSet<RL1KeluargaBerencana> RL1KeluargaBerencana { get; set; }

    public virtual DbSet<RL1KesehatanGigiMulut> RL1KesehatanGigiMulut { get; set; }

    public virtual DbSet<RL1KesehatanJiwa> RL1KesehatanJiwa { get; set; }

    public virtual DbSet<RL1KunjunganRJ> RL1KunjunganRJ { get; set; }

    public virtual DbSet<RL1KunjunganRumah> RL1KunjunganRumah { get; set; }

    public virtual DbSet<RL1PelayananRD> RL1PelayananRD { get; set; }

    public virtual DbSet<RL1PelayananRI> RL1PelayananRI { get; set; }

    public virtual DbSet<RL1PemantauanDokter> RL1PemantauanDokter { get; set; }

    public virtual DbSet<RL1Pembedahan> RL1Pembedahan { get; set; }

    public virtual DbSet<RL1PembedahanMata> RL1PembedahanMata { get; set; }

    public virtual DbSet<RL1PemeriksaanLaboratorium> RL1PemeriksaanLaboratorium { get; set; }

    public virtual DbSet<RL1Pengunjung> RL1Pengunjung { get; set; }

    public virtual DbSet<RL1PenyalahgunaanNAPZA> RL1PenyalahgunaanNAPZA { get; set; }

    public virtual DbSet<RL1PenyuluhanKesehatan> RL1PenyuluhanKesehatan { get; set; }

    public virtual DbSet<RL1RehabilitasiMedik> RL1RehabilitasiMedik { get; set; }

    public virtual DbSet<RL1Training> RL1Training { get; set; }

    public virtual DbSet<RL1TranfusiDarah> RL1TranfusiDarah { get; set; }

    public virtual DbSet<RL2Imunisasi> RL2Imunisasi { get; set; }

    public virtual DbSet<RL2Morbiditas> RL2Morbiditas { get; set; }

    public virtual DbSet<RL310PelayananKhususDt> RL310PelayananKhususDt { get; set; }

    public virtual DbSet<RL310PelayananKhususHd> RL310PelayananKhususHd { get; set; }

    public virtual DbSet<RL311JiwaDt> RL311JiwaDt { get; set; }

    public virtual DbSet<RL311JiwaHD> RL311JiwaHD { get; set; }

    public virtual DbSet<RL314MasterData> RL314MasterData { get; set; }

    public virtual DbSet<RL314RujukanDt> RL314RujukanDt { get; set; }

    public virtual DbSet<RL314RujukanHd> RL314RujukanHd { get; set; }

    public virtual DbSet<RL33GigiDt> RL33GigiDt { get; set; }

    public virtual DbSet<RL33GigiHd> RL33GigiHd { get; set; }

    public virtual DbSet<RL34KebidananDt> RL34KebidananDt { get; set; }

    public virtual DbSet<RL34KebidananHd> RL34KebidananHd { get; set; }

    public virtual DbSet<RL34MasterData> RL34MasterData { get; set; }

    public virtual DbSet<RL35MasterData> RL35MasterData { get; set; }

    public virtual DbSet<RL35PerinatologiDt> RL35PerinatologiDt { get; set; }

    public virtual DbSet<RL35PerinatologiHd> RL35PerinatologiHd { get; set; }

    public virtual DbSet<RL37RadiologiDt> RL37RadiologiDt { get; set; }

    public virtual DbSet<RL37RadiologiHd> RL37RadiologiHd { get; set; }

    public virtual DbSet<RL39RehabilitasiMedikDt> RL39RehabilitasiMedikDt { get; set; }

    public virtual DbSet<RL39RehabilitasiMedikHd> RL39RehabilitasiMedikHd { get; set; }

    public virtual DbSet<RL3DataDasarRumahSakit> RL3DataDasarRumahSakit { get; set; }

    public virtual DbSet<RL4DataKetenagaan> RL4DataKetenagaan { get; set; }

    public virtual DbSet<RL51MasterData> RL51MasterData { get; set; }

    public virtual DbSet<RL52KunjunganRajalDt> RL52KunjunganRajalDt { get; set; }

    public virtual DbSet<RL52KunjunganRajalHD> RL52KunjunganRajalHD { get; set; }

    public virtual DbSet<RL5DataKesehatan> RL5DataKesehatan { get; set; }

    public virtual DbSet<RL5DataPeralatanMedik> RL5DataPeralatanMedik { get; set; }

    public virtual DbSet<RL6InfeksiNosokomial> RL6InfeksiNosokomial { get; set; }

    public virtual DbSet<RLData> RLData { get; set; }

    public virtual DbSet<RLReportTemplate> RLReportTemplate { get; set; }

    public virtual DbSet<RLTemplateDt> RLTemplateDt { get; set; }

    public virtual DbSet<RLTemplateHd> RLTemplateHd { get; set; }

    public virtual DbSet<RLTemplateSubDt> RLTemplateSubDt { get; set; }

    public virtual DbSet<ROPHistoryDt> ROPHistoryDt { get; set; }

    public virtual DbSet<ROPHistoryHd> ROPHistoryHd { get; set; }

    public virtual DbSet<ROPHistorySubDt> ROPHistorySubDt { get; set; }

    public virtual DbSet<Radiologi> Radiologi { get; set; }

    public virtual DbSet<RawatInap> RawatInap { get; set; }

    public virtual DbSet<RealizationFood> RealizationFood { get; set; }

    public virtual DbSet<ReasonPatientDischarge> ReasonPatientDischarge { get; set; }

    public virtual DbSet<RecalculationDt> RecalculationDt { get; set; }

    public virtual DbSet<RecalculationDtBom> RecalculationDtBom { get; set; }

    public virtual DbSet<RecalculationHd> RecalculationHd { get; set; }

    public virtual DbSet<RecalculationItemInventoryDt> RecalculationItemInventoryDt { get; set; }

    public virtual DbSet<RecalculationItemInventoryHd> RecalculationItemInventoryHd { get; set; }

    public virtual DbSet<ReceivedUnplannedDt> ReceivedUnplannedDt { get; set; }

    public virtual DbSet<ReceivedUnplannedDt_Radiology> ReceivedUnplannedDt_Radiology { get; set; }

    public virtual DbSet<ReceivedUnplannedHd> ReceivedUnplannedHd { get; set; }

    public virtual DbSet<ReconciliationDt> ReconciliationDt { get; set; }

    public virtual DbSet<ReconciliationHd> ReconciliationHd { get; set; }

    public virtual DbSet<RecuringDt> RecuringDt { get; set; }

    public virtual DbSet<RecuringHd> RecuringHd { get; set; }

    public virtual DbSet<RecuringSubDt> RecuringSubDt { get; set; }

    public virtual DbSet<ReferToConsult> ReferToConsult { get; set; }

    public virtual DbSet<ReferToSisruteHd> ReferToSisruteHd { get; set; }

    public virtual DbSet<ReferencePanelKuantitatifLaboratory> ReferencePanelKuantitatifLaboratory { get; set; }

    public virtual DbSet<ReferensiDokter> ReferensiDokter { get; set; }

    public virtual DbSet<ReferensiPoli> ReferensiPoli { get; set; }

    public virtual DbSet<Referral> Referral { get; set; }

    public virtual DbSet<ReferralAproved> ReferralAproved { get; set; }

    public virtual DbSet<ReferralNotesTemplate> ReferralNotesTemplate { get; set; }

    public virtual DbSet<ReferralPatient> ReferralPatient { get; set; }

    public virtual DbSet<RegionSITB> RegionSITB { get; set; }

    public virtual DbSet<Registration> Registration { get; set; }

    public virtual DbSet<RegistrationCancelReason> RegistrationCancelReason { get; set; }

    public virtual DbSet<RegistrationHemodialisaDt> RegistrationHemodialisaDt { get; set; }

    public virtual DbSet<RegistrationInformation> RegistrationInformation { get; set; }

    public virtual DbSet<RegistrationMCUDataList> RegistrationMCUDataList { get; set; }

    public virtual DbSet<RegistrationMultiPayer> RegistrationMultiPayer { get; set; }

    public virtual DbSet<RegistrationRecapitulationReference> RegistrationRecapitulationReference { get; set; }

    public virtual DbSet<RegistrationReference> RegistrationReference { get; set; }

    public virtual DbSet<RegistrationSpecialNotes> RegistrationSpecialNotes { get; set; }

    public virtual DbSet<RekapDataHarianPasienDirawatKomorBid> RekapDataHarianPasienDirawatKomorBid { get; set; }

    public virtual DbSet<RekapDataHarianPasienDirawatTanpaKomorBid> RekapDataHarianPasienDirawatTanpaKomorBid { get; set; }

    public virtual DbSet<RekapDataHarianPasienKeluar> RekapDataHarianPasienKeluar { get; set; }

    public virtual DbSet<RekapDataHarianPasienMasuk> RekapDataHarianPasienMasuk { get; set; }

    public virtual DbSet<RekapDataHarianPasienMasukEntry> RekapDataHarianPasienMasukEntry { get; set; }

    public virtual DbSet<RekapDataHarianPasienTanpaDirawatKomorBid> RekapDataHarianPasienTanpaDirawatKomorBid { get; set; }

    public virtual DbSet<RekeningAir> RekeningAir { get; set; }

    public virtual DbSet<RekeningListrik> RekeningListrik { get; set; }

    public virtual DbSet<RencanaKontrol> RencanaKontrol { get; set; }

    public virtual DbSet<ReplacementDt> ReplacementDt { get; set; }

    public virtual DbSet<ReplacementHd> ReplacementHd { get; set; }

    public virtual DbSet<ReportDelivery> ReportDelivery { get; set; }

    public virtual DbSet<ReportDictionary> ReportDictionary { get; set; }

    public virtual DbSet<ReportHistoryPatient> ReportHistoryPatient { get; set; }

    public virtual DbSet<ReportHistoryPatientY> ReportHistoryPatientY { get; set; }

    public virtual DbSet<ReportNumberPrint> ReportNumberPrint { get; set; }

    public virtual DbSet<ReportSignParameter> ReportSignParameter { get; set; }

    public virtual DbSet<ReportedMedication> ReportedMedication { get; set; }

    public virtual DbSet<RequestForProposalDt> RequestForProposalDt { get; set; }

    public virtual DbSet<RequestForProposalHd> RequestForProposalHd { get; set; }

    public virtual DbSet<RequestForProposalSubDt> RequestForProposalSubDt { get; set; }

    public virtual DbSet<ResikoJatuh> ResikoJatuh { get; set; }

    public virtual DbSet<ResikoJatuhAnak> ResikoJatuhAnak { get; set; }

    public virtual DbSet<ResikoJatuhDewasa> ResikoJatuhDewasa { get; set; }

    public virtual DbSet<ResponseRujukanSisrute> ResponseRujukanSisrute { get; set; }

    public virtual DbSet<ResumeMedisSisrute> ResumeMedisSisrute { get; set; }

    public virtual DbSet<ReturnToSupplierDt> ReturnToSupplierDt { get; set; }

    public virtual DbSet<ReturnToSupplierHd> ReturnToSupplierHd { get; set; }

    public virtual DbSet<RevenueByAnciliariesSupport> RevenueByAnciliariesSupport { get; set; }

    public virtual DbSet<RevenueByAnciliariesSupportY> RevenueByAnciliariesSupportY { get; set; }

    public virtual DbSet<RevenueByDepartmentCommunity> RevenueByDepartmentCommunity { get; set; }

    public virtual DbSet<RevenueByDepartmentCommunityY> RevenueByDepartmentCommunityY { get; set; }

    public virtual DbSet<RevenueByDepartmentServiceUnit> RevenueByDepartmentServiceUnit { get; set; }

    public virtual DbSet<RevenueByDepartmentServiceUnitY> RevenueByDepartmentServiceUnitY { get; set; }

    public virtual DbSet<RevenueByItemType> RevenueByItemType { get; set; }

    public virtual DbSet<RevenueByPayerType> RevenueByPayerType { get; set; }

    public virtual DbSet<RevenueByPayerTypePeriode> RevenueByPayerTypePeriode { get; set; }

    public virtual DbSet<RevenueByPayerTypeY> RevenueByPayerTypeY { get; set; }

    public virtual DbSet<RevenueByServiceUnitItem> RevenueByServiceUnitItem { get; set; }

    public virtual DbSet<RevenueByServiceUnitItemY> RevenueByServiceUnitItemY { get; set; }

    public virtual DbSet<RevenueBySpecialistPhysician> RevenueBySpecialistPhysician { get; set; }

    public virtual DbSet<RevenueBySpecialistPhysicianY> RevenueBySpecialistPhysicianY { get; set; }

    public virtual DbSet<RevenueSharing> RevenueSharing { get; set; }

    public virtual DbSet<RevenueSharingJO> RevenueSharingJO { get; set; }

    public virtual DbSet<ReviewPharOrder> ReviewPharOrder { get; set; }

    public virtual DbSet<RiskFactorCategory> RiskFactorCategory { get; set; }

    public virtual DbSet<RiskFactorType> RiskFactorType { get; set; }

    public virtual DbSet<RiskFallDt> RiskFallDt { get; set; }

    public virtual DbSet<RiskFallHd> RiskFallHd { get; set; }

    public virtual DbSet<RiwayatKesehatanMCUDataList> RiwayatKesehatanMCUDataList { get; set; }

    public virtual DbSet<RiwayatPengobatanPasien> RiwayatPengobatanPasien { get; set; }

    public virtual DbSet<RiwayatPenyakitKeluargaPasien> RiwayatPenyakitKeluargaPasien { get; set; }

    public virtual DbSet<RiwayatPenyakitPribadiPasien> RiwayatPenyakitPribadiPasien { get; set; }

    public virtual DbSet<Rl31MasterData> Rl31MasterData { get; set; }

    public virtual DbSet<RujukBalikBPJSDT> RujukBalikBPJSDT { get; set; }

    public virtual DbSet<RujukBalikBPJSHD> RujukBalikBPJSHD { get; set; }

    public virtual DbSet<RuleLabDashboard> RuleLabDashboard { get; set; }

    public virtual DbSet<RulesMCUHd> RulesMCUHd { get; set; }

    public virtual DbSet<RulesMCUParameterDt> RulesMCUParameterDt { get; set; }

    public virtual DbSet<RulesMCURecommendationDt> RulesMCURecommendationDt { get; set; }

    public virtual DbSet<SITB> SITB { get; set; }

    public virtual DbSet<SSIAdministration> SSIAdministration { get; set; }

    public virtual DbSet<SalaryAdjustment> SalaryAdjustment { get; set; }

    public virtual DbSet<SalaryComponent> SalaryComponent { get; set; }

    public virtual DbSet<SalaryComponentEmployee> SalaryComponentEmployee { get; set; }

    public virtual DbSet<Sample> Sample { get; set; }

    public virtual DbSet<SatuSehatAnamnesisGolonganDarah> SatuSehatAnamnesisGolonganDarah { get; set; }

    public virtual DbSet<SatuSehatAnamnesisResus> SatuSehatAnamnesisResus { get; set; }

    public virtual DbSet<SatuSehatAnamnesisStatusKehamilan> SatuSehatAnamnesisStatusKehamilan { get; set; }

    public virtual DbSet<SatuSehatCompositDiet> SatuSehatCompositDiet { get; set; }

    public virtual DbSet<SatuSehatConditionStabil> SatuSehatConditionStabil { get; set; }

    public virtual DbSet<SatuSehatDepartmentServiceUnit> SatuSehatDepartmentServiceUnit { get; set; }

    public virtual DbSet<SatuSehatDiagnosticReport> SatuSehatDiagnosticReport { get; set; }

    public virtual DbSet<SatuSehatDiagnosticReportRadiology> SatuSehatDiagnosticReportRadiology { get; set; }

    public virtual DbSet<SatuSehatDietInstruction> SatuSehatDietInstruction { get; set; }

    public virtual DbSet<SatuSehatDischargeCondition> SatuSehatDischargeCondition { get; set; }

    public virtual DbSet<SatuSehatEpisodeDiagnosis> SatuSehatEpisodeDiagnosis { get; set; }

    public virtual DbSet<SatuSehatEpisodeOfCare1> SatuSehatEpisodeOfCare1 { get; set; }

    public virtual DbSet<SatuSehatEpisodeProcedure> SatuSehatEpisodeProcedure { get; set; }

    public virtual DbSet<SatuSehatImagingSingleImage> SatuSehatImagingSingleImage { get; set; }

    public virtual DbSet<SatuSehatImagingStudyRadiology> SatuSehatImagingStudyRadiology { get; set; }

    public virtual DbSet<SatuSehatInstruksiMedikDanKeperawatanPasien> SatuSehatInstruksiMedikDanKeperawatanPasien { get; set; }

    public virtual DbSet<SatuSehatKeluhanUtama> SatuSehatKeluhanUtama { get; set; }

    public virtual DbSet<SatuSehatMedicationAdministration> SatuSehatMedicationAdministration { get; set; }

    public virtual DbSet<SatuSehatMedicationCreate> SatuSehatMedicationCreate { get; set; }

    public virtual DbSet<SatuSehatMedicationCreateExp> SatuSehatMedicationCreateExp { get; set; }

    public virtual DbSet<SatuSehatMedicationCreateOne> SatuSehatMedicationCreateOne { get; set; }

    public virtual DbSet<SatuSehatMedicationDispense> SatuSehatMedicationDispense { get; set; }

    public virtual DbSet<SatuSehatMedicationRequest> SatuSehatMedicationRequest { get; set; }

    public virtual DbSet<SatuSehatMedicationVariasiDt> SatuSehatMedicationVariasiDt { get; set; }

    public virtual DbSet<SatuSehatMedicationVariasiHd> SatuSehatMedicationVariasiHd { get; set; }

    public virtual DbSet<SatuSehatMedicationVariasiResepRequestDt> SatuSehatMedicationVariasiResepRequestDt { get; set; }

    public virtual DbSet<SatuSehatMedicationVariasiResepRequestHd> SatuSehatMedicationVariasiResepRequestHd { get; set; }

    public virtual DbSet<SatuSehatObservasiKesadaran> SatuSehatObservasiKesadaran { get; set; }

    public virtual DbSet<SatuSehatObservation> SatuSehatObservation { get; set; }

    public virtual DbSet<SatuSehatObservationRadiology> SatuSehatObservationRadiology { get; set; }

    public virtual DbSet<SatuSehatParamedic> SatuSehatParamedic { get; set; }

    public virtual DbSet<SatuSehatPatient> SatuSehatPatient { get; set; }

    public virtual DbSet<SatuSehatPatientAllergy> SatuSehatPatientAllergy { get; set; }

    public virtual DbSet<SatuSehatPemeriksaanAntropometri> SatuSehatPemeriksaanAntropometri { get; set; }

    public virtual DbSet<SatuSehatPemeriksaanFisik> SatuSehatPemeriksaanFisik { get; set; }

    public virtual DbSet<SatuSehatPemeriksaanOHIS> SatuSehatPemeriksaanOHIS { get; set; }

    public virtual DbSet<SatuSehatPemeriksaanPsikologis> SatuSehatPemeriksaanPsikologis { get; set; }

    public virtual DbSet<SatuSehatPengkajianResep> SatuSehatPengkajianResep { get; set; }

    public virtual DbSet<SatuSehatProcedureEdukasi> SatuSehatProcedureEdukasi { get; set; }

    public virtual DbSet<SatuSehatPrognosis> SatuSehatPrognosis { get; set; }

    public virtual DbSet<SatuSehatReferralPatient> SatuSehatReferralPatient { get; set; }

    public virtual DbSet<SatuSehatRegistration> SatuSehatRegistration { get; set; }

    public virtual DbSet<SatuSehatRencanaRawatPasien> SatuSehatRencanaRawatPasien { get; set; }

    public virtual DbSet<SatuSehatRiwayatPengobatan> SatuSehatRiwayatPengobatan { get; set; }

    public virtual DbSet<SatuSehatRiwayatPenyakit> SatuSehatRiwayatPenyakit { get; set; }

    public virtual DbSet<SatuSehatServiceRequest> SatuSehatServiceRequest { get; set; }

    public virtual DbSet<SatuSehatServiceRequestPulangKontrol> SatuSehatServiceRequestPulangKontrol { get; set; }

    public virtual DbSet<SatuSehatServiceRequestRadiology> SatuSehatServiceRequestRadiology { get; set; }

    public virtual DbSet<SatuSehatServiceRequestRujukanAmbulance> SatuSehatServiceRequestRujukanAmbulance { get; set; }

    public virtual DbSet<SatuSehatServiceUnitRoom> SatuSehatServiceUnitRoom { get; set; }

    public virtual DbSet<SatuSehatSiteDepartment> SatuSehatSiteDepartment { get; set; }

    public virtual DbSet<SatuSehatSpecimen> SatuSehatSpecimen { get; set; }

    public virtual DbSet<SatuSehatTerminologiGigiMapping> SatuSehatTerminologiGigiMapping { get; set; }

    public virtual DbSet<SatuSehatUpdateEncounterPulangKontrol> SatuSehatUpdateEncounterPulangKontrol { get; set; }

    public virtual DbSet<SatuSehatVitalSign> SatuSehatVitalSign { get; set; }

    public virtual DbSet<ScreeningAdult> ScreeningAdult { get; set; }

    public virtual DbSet<ScreeningChild> ScreeningChild { get; set; }

    public virtual DbSet<ScreeningPatientHighRisk> ScreeningPatientHighRisk { get; set; }

    public virtual DbSet<Sct> Sct { get; set; }

    public virtual DbSet<SendToAutopackHistoryDt> SendToAutopackHistoryDt { get; set; }

    public virtual DbSet<SendToAutopackHistoryHd> SendToAutopackHistoryHd { get; set; }

    public virtual DbSet<SendToWaData> SendToWaData { get; set; }

    public virtual DbSet<SendToWaDataGigi> SendToWaDataGigi { get; set; }

    public virtual DbSet<SendWaMessage> SendWaMessage { get; set; }

    public virtual DbSet<SerahTerimaBarang> SerahTerimaBarang { get; set; }

    public virtual DbSet<SerahTerimaBayi> SerahTerimaBayi { get; set; }

    public virtual DbSet<ServiceOrderDt> ServiceOrderDt { get; set; }

    public virtual DbSet<ServiceOrderHd> ServiceOrderHd { get; set; }

    public virtual DbSet<ServiceOrderRequestDt> ServiceOrderRequestDt { get; set; }

    public virtual DbSet<ServiceOrderRequestHd> ServiceOrderRequestHd { get; set; }

    public virtual DbSet<ServiceRoom> ServiceRoom { get; set; }

    public virtual DbSet<ServiceUnit> ServiceUnit { get; set; }

    public virtual DbSet<ServiceUnitItem> ServiceUnitItem { get; set; }

    public virtual DbSet<ServiceUnitItemMcu> ServiceUnitItemMcu { get; set; }

    public virtual DbSet<ServiceUnitJobOrderType> ServiceUnitJobOrderType { get; set; }

    public virtual DbSet<ServiceUnitLocation> ServiceUnitLocation { get; set; }

    public virtual DbSet<ServiceUnitOutpatient> ServiceUnitOutpatient { get; set; }

    public virtual DbSet<ServiceUnitParamedic> ServiceUnitParamedic { get; set; }

    public virtual DbSet<ServiceUnitPrinter> ServiceUnitPrinter { get; set; }

    public virtual DbSet<ServiceUnitRoom> ServiceUnitRoom { get; set; }

    public virtual DbSet<ServiceUnitSiRajin> ServiceUnitSiRajin { get; set; }

    public virtual DbSet<SewaAlat> SewaAlat { get; set; }

    public virtual DbSet<SewaAlatFee> SewaAlatFee { get; set; }

    public virtual DbSet<Sheet1_> Sheet1_ { get; set; }

    public virtual DbSet<ShiftHours> ShiftHours { get; set; }

    public virtual DbSet<SiRajinData> SiRajinData { get; set; }

    public virtual DbSet<SignatureEffectiveCommunication> SignatureEffectiveCommunication { get; set; }

    public virtual DbSet<SignaturePatientRegistration> SignaturePatientRegistration { get; set; }

    public virtual DbSet<SignatureRegistrationHakKewajiban> SignatureRegistrationHakKewajiban { get; set; }

    public virtual DbSet<SignatureRegistrationMCUHakKewajiban> SignatureRegistrationMCUHakKewajiban { get; set; }

    public virtual DbSet<SiklusMenuDt> SiklusMenuDt { get; set; }

    public virtual DbSet<SiklusMenuHd> SiklusMenuHd { get; set; }

    public virtual DbSet<SirsRoom> SirsRoom { get; set; }

    public virtual DbSet<SirsRoomVsServiceUnitRoom> SirsRoomVsServiceUnitRoom { get; set; }

    public virtual DbSet<SisaObat> SisaObat { get; set; }

    public virtual DbSet<Site> Site { get; set; }

    public virtual DbSet<SiteDepartment> SiteDepartment { get; set; }

    public virtual DbSet<SkalaNyeriDibawah6Tahun> SkalaNyeriDibawah6Tahun { get; set; }

    public virtual DbSet<SkalaNyeriMenangisCPS> SkalaNyeriMenangisCPS { get; set; }

    public virtual DbSet<SkriningGiziAnak> SkriningGiziAnak { get; set; }

    public virtual DbSet<Sm_ItemVitalSign> Sm_ItemVitalSign { get; set; }

    public virtual DbSet<Sm_Speciality> Sm_Speciality { get; set; }

    public virtual DbSet<SnomedKeluhanUtama> SnomedKeluhanUtama { get; set; }

    public virtual DbSet<SnomedRiwayatPenyakitKeluarga> SnomedRiwayatPenyakitKeluarga { get; set; }

    public virtual DbSet<SnomedRiwayatPenyakitPribadi> SnomedRiwayatPenyakitPribadi { get; set; }

    public virtual DbSet<SpecialNotes> SpecialNotes { get; set; }

    public virtual DbSet<SpecialityChartCategoryHd> SpecialityChartCategoryHd { get; set; }

    public virtual DbSet<Specialty> Specialty { get; set; }

    public virtual DbSet<SpecialtyChartCategoryDt> SpecialtyChartCategoryDt { get; set; }

    public virtual DbSet<SpecialtyImage> SpecialtyImage { get; set; }

    public virtual DbSet<SpecialtyVitalSign> SpecialtyVitalSign { get; set; }

    public virtual DbSet<SpectaclePrescription> SpectaclePrescription { get; set; }

    public virtual DbSet<SphairaTable> SphairaTable { get; set; }

    public virtual DbSet<SplitBillInpatient> SplitBillInpatient { get; set; }

    public virtual DbSet<StandardCostVsActualCost> StandardCostVsActualCost { get; set; }

    public virtual DbSet<StandartFilterMCU> StandartFilterMCU { get; set; }

    public virtual DbSet<StaticticMedicalRecord> StaticticMedicalRecord { get; set; }

    public virtual DbSet<StatusPriority> StatusPriority { get; set; }

    public virtual DbSet<StewardScoreAnak> StewardScoreAnak { get; set; }

    public virtual DbSet<StockAdjustmentDt> StockAdjustmentDt { get; set; }

    public virtual DbSet<StockAdjustmentHd> StockAdjustmentHd { get; set; }

    public virtual DbSet<StockInformationAccess> StockInformationAccess { get; set; }

    public virtual DbSet<StockTakingDt> StockTakingDt { get; set; }

    public virtual DbSet<StockTakingDtExpired> StockTakingDtExpired { get; set; }

    public virtual DbSet<StockTakingHd> StockTakingHd { get; set; }

    public virtual DbSet<StockTakingQR> StockTakingQR { get; set; }

    public virtual DbSet<Supplier> Supplier { get; set; }

    public virtual DbSet<SupplierItem> SupplierItem { get; set; }

    public virtual DbSet<SupplierItemPrice> SupplierItemPrice { get; set; }

    public virtual DbSet<SupplierItemPriceDt> SupplierItemPriceDt { get; set; }

    public virtual DbSet<SuratKetDatangDalamKeadaanMeninggal> SuratKetDatangDalamKeadaanMeninggal { get; set; }

    public virtual DbSet<SuratKeteranganButaWarna> SuratKeteranganButaWarna { get; set; }

    public virtual DbSet<SuratKeteranganCutiHamilKebidanan> SuratKeteranganCutiHamilKebidanan { get; set; }

    public virtual DbSet<SuratKeteranganDiagnosa> SuratKeteranganDiagnosa { get; set; }

    public virtual DbSet<SuratKeteranganDokter> SuratKeteranganDokter { get; set; }

    public virtual DbSet<SuratKeteranganDokterSenayan> SuratKeteranganDokterSenayan { get; set; }

    public virtual DbSet<SuratKeteranganDokterSenayanNew> SuratKeteranganDokterSenayanNew { get; set; }

    public virtual DbSet<SuratKeteranganHamilKebidanan> SuratKeteranganHamilKebidanan { get; set; }

    public virtual DbSet<SuratKeteranganIstirahatRI> SuratKeteranganIstirahatRI { get; set; }

    public virtual DbSet<SuratKeteranganLayakTerbangNewTabel> SuratKeteranganLayakTerbangNewTabel { get; set; }

    public virtual DbSet<SuratKeteranganLayakTerbangTabel> SuratKeteranganLayakTerbangTabel { get; set; }

    public virtual DbSet<SuratKeteranganMeninggal> SuratKeteranganMeninggal { get; set; }

    public virtual DbSet<SuratKeteranganPasien> SuratKeteranganPasien { get; set; }

    public virtual DbSet<SuratKeteranganPasienConsent> SuratKeteranganPasienConsent { get; set; }

    public virtual DbSet<SuratKeteranganPenerbangan> SuratKeteranganPenerbangan { get; set; }

    public virtual DbSet<SuratKeteranganPerjalan> SuratKeteranganPerjalan { get; set; }

    public virtual DbSet<SuratKeteranganPerjalanan> SuratKeteranganPerjalanan { get; set; }

    public virtual DbSet<SuratKeteranganSakitElisabeth> SuratKeteranganSakitElisabeth { get; set; }

    public virtual DbSet<SuratKeteranganSenayanNew> SuratKeteranganSenayanNew { get; set; }

    public virtual DbSet<SuratPenolakanTindakanKedokteran> SuratPenolakanTindakanKedokteran { get; set; }

    public virtual DbSet<SuratPernyataanPulangAtasPermintaanSendiri> SuratPernyataanPulangAtasPermintaanSendiri { get; set; }

    public virtual DbSet<SuratPernyataanRujukan> SuratPernyataanRujukan { get; set; }

    public virtual DbSet<SuratPersetujuanTindakanTreadmillTest> SuratPersetujuanTindakanTreadmillTest { get; set; }

    public virtual DbSet<SuratRujukanKeluar> SuratRujukanKeluar { get; set; }

    public virtual DbSet<SuratRujukanRadiologiGigi> SuratRujukanRadiologiGigi { get; set; }

    public virtual DbSet<SurgeryCategory> SurgeryCategory { get; set; }

    public virtual DbSet<SurgeryReportDiagnosisEMR> SurgeryReportDiagnosisEMR { get; set; }

    public virtual DbSet<SurgeryReservation> SurgeryReservation { get; set; }

    public virtual DbSet<SurgeryTeamTemplateDt> SurgeryTeamTemplateDt { get; set; }

    public virtual DbSet<SurgeryTeamTemplateHd> SurgeryTeamTemplateHd { get; set; }

    public virtual DbSet<SysPatientMergeDt> SysPatientMergeDt { get; set; }

    public virtual DbSet<SysPatientMergeHd> SysPatientMergeHd { get; set; }

    public virtual DbSet<THTHidungMCU> THTHidungMCU { get; set; }

    public virtual DbSet<THTLeherMCU> THTLeherMCU { get; set; }

    public virtual DbSet<THTTelingaMCU> THTTelingaMCU { get; set; }

    public virtual DbSet<THTTenggorokanMCU> THTTenggorokanMCU { get; set; }

    public virtual DbSet<TMPRL13FASILITASTEMPATTIDURDT> TMPRL13FASILITASTEMPATTIDURDT { get; set; }

    public virtual DbSet<TMPRL13FASILITASTEMPATTIDURHD> TMPRL13FASILITASTEMPATTIDURHD { get; set; }

    public virtual DbSet<TMPRL2KETENAGAAN> TMPRL2KETENAGAAN { get; set; }

    public virtual DbSet<TReceiptDt> TReceiptDt { get; set; }

    public virtual DbSet<TReceiptHd> TReceiptHd { get; set; }

    public virtual DbSet<TReceiptRequestDt> TReceiptRequestDt { get; set; }

    public virtual DbSet<TReceiptRequestHd> TReceiptRequestHd { get; set; }

    public virtual DbSet<TableBKIA> TableBKIA { get; set; }

    public virtual DbSet<TableHasilSmearPapSenayan> TableHasilSmearPapSenayan { get; set; }

    public virtual DbSet<TableSuratPernyataanSenayan> TableSuratPernyataanSenayan { get; set; }

    public virtual DbSet<Table_1> Table_1 { get; set; }

    public virtual DbSet<Table_2> Table_2 { get; set; }

    public virtual DbSet<Table_3> Table_3 { get; set; }

    public virtual DbSet<Table_4> Table_4 { get; set; }

    public virtual DbSet<Table_5> Table_5 { get; set; }

    public virtual DbSet<Table_6> Table_6 { get; set; }

    public virtual DbSet<Table_WA_Contacts> Table_WA_Contacts { get; set; }

    public virtual DbSet<Table_WA_Log> Table_WA_Log { get; set; }

    public virtual DbSet<TakenBy> TakenBy { get; set; }

    public virtual DbSet<TariffAir> TariffAir { get; set; }

    public virtual DbSet<TariffListrik> TariffListrik { get; set; }

    public virtual DbSet<TaskMobileJKN> TaskMobileJKN { get; set; }

    public virtual DbSet<TatBarcodeScan> TatBarcodeScan { get; set; }

    public virtual DbSet<TatReport> TatReport { get; set; }

    public virtual DbSet<TaxCategory> TaxCategory { get; set; }

    public virtual DbSet<TelaahResep> TelaahResep { get; set; }

    public virtual DbSet<TelaahResepDetail> TelaahResepDetail { get; set; }

    public virtual DbSet<TempGuidelineSummary> TempGuidelineSummary { get; set; }

    public virtual DbSet<TempItemTemplateLab> TempItemTemplateLab { get; set; }

    public virtual DbSet<TempOpeningAR> TempOpeningAR { get; set; }

    public virtual DbSet<TempOpeningApSupplier> TempOpeningApSupplier { get; set; }

    public virtual DbSet<TempOpeningBalance> TempOpeningBalance { get; set; }

    public virtual DbSet<TempOpeningPhysician> TempOpeningPhysician { get; set; }

    public virtual DbSet<Temp_Address> Temp_Address { get; set; }

    public virtual DbSet<Temp_BackupPatientFamily> Temp_BackupPatientFamily { get; set; }

    public virtual DbSet<Temp_Patient> Temp_Patient { get; set; }

    public virtual DbSet<Tempcount> Tempcount { get; set; }

    public virtual DbSet<TemplateConsumeMethod> TemplateConsumeMethod { get; set; }

    public virtual DbSet<TemplateOtherExam> TemplateOtherExam { get; set; }

    public virtual DbSet<TemplatePhysicalExamDt> TemplatePhysicalExamDt { get; set; }

    public virtual DbSet<TemplatePhysicalExamHd> TemplatePhysicalExamHd { get; set; }

    public virtual DbSet<TemplateProductionDt> TemplateProductionDt { get; set; }

    public virtual DbSet<TemplateProductionHd> TemplateProductionHd { get; set; }

    public virtual DbSet<TemplateRadiology> TemplateRadiology { get; set; }

    public virtual DbSet<TemplateRevenueSharing> TemplateRevenueSharing { get; set; }

    public virtual DbSet<TemplateTariffDt> TemplateTariffDt { get; set; }

    public virtual DbSet<TemplateTariffHd> TemplateTariffHd { get; set; }

    public virtual DbSet<TemplateText> TemplateText { get; set; }

    public virtual DbSet<TemplateTingkatKepuasanPelanggan> TemplateTingkatKepuasanPelanggan { get; set; }

    public virtual DbSet<Term> Term { get; set; }

    public virtual DbSet<TestEncounterJobs> TestEncounterJobs { get; set; }

    public virtual DbSet<TestHl7Message> TestHl7Message { get; set; }

    public virtual DbSet<TimeAttendanceRecapDetailDt> TimeAttendanceRecapDetailDt { get; set; }

    public virtual DbSet<TimeAttendanceRecapDetailHd> TimeAttendanceRecapDetailHd { get; set; }

    public virtual DbSet<TimeAttendanceRecapDt> TimeAttendanceRecapDt { get; set; }

    public virtual DbSet<TimeAttendanceRecapHd> TimeAttendanceRecapHd { get; set; }

    public virtual DbSet<TingkatKesadaranMapping> TingkatKesadaranMapping { get; set; }

    public virtual DbSet<TingkatkepuasanPelanggan> TingkatkepuasanPelanggan { get; set; }

    public virtual DbSet<TmpRevenuepasienSaabit> TmpRevenuepasienSaabit { get; set; }

    public virtual DbSet<TmpVitalsignType> TmpVitalsignType { get; set; }

    public virtual DbSet<Tmp_InacbgClaim> Tmp_InacbgClaim { get; set; }

    public virtual DbSet<Tmp_PemeriksaanOperasiHd> Tmp_PemeriksaanOperasiHd { get; set; }

    public virtual DbSet<Tmp_QueuingTVGeneralCode> Tmp_QueuingTVGeneralCode { get; set; }

    public virtual DbSet<TokenTable> TokenTable { get; set; }

    public virtual DbSet<ToothStatusRule> ToothStatusRule { get; set; }

    public virtual DbSet<TransactionChargesDt> TransactionChargesDt { get; set; }

    public virtual DbSet<TransactionChargesDtBOM> TransactionChargesDtBOM { get; set; }

    public virtual DbSet<TransactionChargesHd> TransactionChargesHd { get; set; }

    public virtual DbSet<TransactionCodeCOA> TransactionCodeCOA { get; set; }

    public virtual DbSet<TransactionCodeSource> TransactionCodeSource { get; set; }

    public virtual DbSet<TransactionConsilidationDt> TransactionConsilidationDt { get; set; }

    public virtual DbSet<TransactionConsilidationHd> TransactionConsilidationHd { get; set; }

    public virtual DbSet<TransactionConsolidationReference> TransactionConsolidationReference { get; set; }

    public virtual DbSet<TransactionNonCPOEServiceUnit> TransactionNonCPOEServiceUnit { get; set; }

    public virtual DbSet<TransaksiPMKP> TransaksiPMKP { get; set; }

    public virtual DbSet<TransferOrderDt> TransferOrderDt { get; set; }

    public virtual DbSet<TransferOrderHd> TransferOrderHd { get; set; }

    public virtual DbSet<TreadmilTest> TreadmilTest { get; set; }

    public virtual DbSet<UangDuduk> UangDuduk { get; set; }

    public virtual DbSet<UangDudukFee> UangDudukFee { get; set; }

    public virtual DbSet<UnfitRulesMCUCorporate> UnfitRulesMCUCorporate { get; set; }

    public virtual DbSet<UnitDoseStatus> UnitDoseStatus { get; set; }

    public virtual DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }

    public virtual DbSet<UnitOfMeasureBackup> UnitOfMeasureBackup { get; set; }

    public virtual DbSet<UpdateApplication> UpdateApplication { get; set; }

    public virtual DbSet<UpdateJadwalDokterBPJS> UpdateJadwalDokterBPJS { get; set; }

    public virtual DbSet<UploadDocumentInacbgCovid> UploadDocumentInacbgCovid { get; set; }

    public virtual DbSet<UploadItemAlkes> UploadItemAlkes { get; set; }

    public virtual DbSet<UploadItemAlkes20230731> UploadItemAlkes20230731 { get; set; }

    public virtual DbSet<UploadItemBrandGeneric> UploadItemBrandGeneric { get; set; }

    public virtual DbSet<UploadItemGigi> UploadItemGigi { get; set; }

    public virtual DbSet<UploadItemLab> UploadItemLab { get; set; }

    public virtual DbSet<UploadItemObat> UploadItemObat { get; set; }

    public virtual DbSet<UploadSupplier> UploadSupplier { get; set; }

    public virtual DbSet<UserNotificationStatus> UserNotificationStatus { get; set; }

    public virtual DbSet<UtilizationMachineHD> UtilizationMachineHD { get; set; }

    public virtual DbSet<VAPAdministration> VAPAdministration { get; set; }

    public virtual DbSet<VAPAdministrationRev> VAPAdministrationRev { get; set; }

    public virtual DbSet<Vaccination> Vaccination { get; set; }

    public virtual DbSet<VaccinationShotDt> VaccinationShotDt { get; set; }

    public virtual DbSet<VaccinationShotHd> VaccinationShotHd { get; set; }

    public virtual DbSet<VaccinationShotSubDt> VaccinationShotSubDt { get; set; }

    public virtual DbSet<VaccinationType> VaccinationType { get; set; }

    public virtual DbSet<ValueColumnLAB> ValueColumnLAB { get; set; }

    public virtual DbSet<ValueColumnPE> ValueColumnPE { get; set; }

    public virtual DbSet<ViewEMRLog> ViewEMRLog { get; set; }

    public virtual DbSet<ViolationType> ViolationType { get; set; }

    public virtual DbSet<VisitReason> VisitReason { get; set; }

    public virtual DbSet<VisitType> VisitType { get; set; }

    public virtual DbSet<VitalSignCodeVs3> VitalSignCodeVs3 { get; set; }

    public virtual DbSet<VitalSignDt> VitalSignDt { get; set; }

    public virtual DbSet<VitalSignDtFromVs3> VitalSignDtFromVs3 { get; set; }

    public virtual DbSet<VitalSignExaminationResult> VitalSignExaminationResult { get; set; }

    public virtual DbSet<VitalSignHd> VitalSignHd { get; set; }

    public virtual DbSet<VitalSignHdFromVs3> VitalSignHdFromVs3 { get; set; }

    public virtual DbSet<VitalSignMachineDt> VitalSignMachineDt { get; set; }

    public virtual DbSet<VitalSignMachineHd> VitalSignMachineHd { get; set; }

    public virtual DbSet<VitalSignMachineMapping> VitalSignMachineMapping { get; set; }

    public virtual DbSet<VitalSignMachineMessageHd> VitalSignMachineMessageHd { get; set; }

    public virtual DbSet<VitalSignMcuSignature> VitalSignMcuSignature { get; set; }

    public virtual DbSet<VitalSignType> VitalSignType { get; set; }

    public virtual DbSet<VitalSignValueVs3> VitalSignValueVs3 { get; set; }

    public virtual DbSet<VoidTransaction> VoidTransaction { get; set; }

    public virtual DbSet<WaBlastMessage> WaBlastMessage { get; set; }

    public virtual DbSet<Waste> Waste { get; set; }

    public virtual DbSet<WasteProcess> WasteProcess { get; set; }

    public virtual DbSet<WaterConsumption> WaterConsumption { get; set; }

    public virtual DbSet<WhatsappContact> WhatsappContact { get; set; }

    public virtual DbSet<WhatsappLog> WhatsappLog { get; set; }

    public virtual DbSet<WordBank> WordBank { get; set; }

    public virtual DbSet<WordPattern> WordPattern { get; set; }

    public virtual DbSet<WordPatternFinishState> WordPatternFinishState { get; set; }

    public virtual DbSet<WordRelated> WordRelated { get; set; }

    public virtual DbSet<WorkCycleDt> WorkCycleDt { get; set; }

    public virtual DbSet<WorkCycleHd> WorkCycleHd { get; set; }

    public virtual DbSet<WorkOffPermission> WorkOffPermission { get; set; }

    public virtual DbSet<WorkShift> WorkShift { get; set; }

    public virtual DbSet<WorkShiftHrd> WorkShiftHrd { get; set; }

    public virtual DbSet<WorkStation> WorkStation { get; set; }

    public virtual DbSet<ZipCodes> ZipCodes { get; set; }

    public virtual DbSet<_LoadTestRegistration> _LoadTestRegistration { get; set; }

    public virtual DbSet<_SearchWordDiagnose> _SearchWordDiagnose { get; set; }

    public virtual DbSet<_imp_mims_ATCClass> _imp_mims_ATCClass { get; set; }

    public virtual DbSet<_imp_mims_DrugInteraction> _imp_mims_DrugInteraction { get; set; }

    public virtual DbSet<_imp_mims_Item> _imp_mims_Item { get; set; }

    public virtual DbSet<_imp_mims_ItemBrand> _imp_mims_ItemBrand { get; set; }

    public virtual DbSet<_imp_mims_ItemBrandGeneric> _imp_mims_ItemBrandGeneric { get; set; }

    public virtual DbSet<_imp_mims_ItemDrug> _imp_mims_ItemDrug { get; set; }

    public virtual DbSet<_imp_mims_ItemGeneric> _imp_mims_ItemGeneric { get; set; }

    public virtual DbSet<_imp_mims_ItemUnitConversion> _imp_mims_ItemUnitConversion { get; set; }

    public virtual DbSet<_mims_DrugInteraction> _mims_DrugInteraction { get; set; }

    public virtual DbSet<_mims_ItemBrand> _mims_ItemBrand { get; set; }

    public virtual DbSet<_mims_ItemBrandGeneric> _mims_ItemBrandGeneric { get; set; }

    public virtual DbSet<_mims_ItemDrug> _mims_ItemDrug { get; set; }

    public virtual DbSet<_mims_ItemGeneric> _mims_ItemGeneric { get; set; }

    public virtual DbSet<_mims_MissingMaster> _mims_MissingMaster { get; set; }

    public virtual DbSet<_mims_MoleculeVsGenericItem> _mims_MoleculeVsGenericItem { get; set; }

    public virtual DbSet<_mims_Product> _mims_Product { get; set; }

    public virtual DbSet<_mims_Product_bak> _mims_Product_bak { get; set; }

    public virtual DbSet<_tmp_ICD2008> _tmp_ICD2008 { get; set; }

    public virtual DbSet<_tmp_ICD2010> _tmp_ICD2010 { get; set; }

    public virtual DbSet<_tmp_ImportDiagnosis> _tmp_ImportDiagnosis { get; set; }

    public virtual DbSet<auditlogNH> auditlogNH { get; set; }

    public virtual DbSet<backupPatientFam> backupPatientFam { get; set; }

    public virtual DbSet<backupRegisMalam> backupRegisMalam { get; set; }

    public virtual DbSet<backupSatuSehatServiceUnitRoom> backupSatuSehatServiceUnitRoom { get; set; }

    public virtual DbSet<backupSysparSatuSehat> backupSysparSatuSehat { get; set; }

    public virtual DbSet<bahanDecrypt> bahanDecrypt { get; set; }

    public virtual DbSet<bu_RLTemplateDt_20230710> bu_RLTemplateDt_20230710 { get; set; }

    public virtual DbSet<id> id { get; set; }

    public virtual DbSet<jobdate> jobdate { get; set; }

    public virtual DbSet<joborderbomRolliawatiBackup> joborderbomRolliawatiBackup { get; set; }

    public virtual DbSet<joborderhdBackup> joborderhdBackup { get; set; }

    public virtual DbSet<lioncupload2> lioncupload2 { get; set; }

    public virtual DbSet<printedarchiveIndrani> printedarchiveIndrani { get; set; }

    public virtual DbSet<registrationDischargeTemp> registrationDischargeTemp { get; set; }

    public virtual DbSet<sm_Paramedic> sm_Paramedic { get; set; }

    public virtual DbSet<surtrujukankeluarbackup> surtrujukankeluarbackup { get; set; }

    public virtual DbSet<sysAuditLog> sysAuditLog { get; set; }

    public virtual DbSet<sysCHDRiskChart> sysCHDRiskChart { get; set; }

    public virtual DbSet<sysGeneralCode> sysGeneralCode { get; set; }

    public virtual DbSet<sysGrowthChartPoint> sysGrowthChartPoint { get; set; }

    public virtual DbSet<sysGrowthChartPointBackUp> sysGrowthChartPointBackUp { get; set; }

    public virtual DbSet<sysObstetricChartPoint> sysObstetricChartPoint { get; set; }

    public virtual DbSet<sysParamedicNameFormat> sysParamedicNameFormat { get; set; }

    public virtual DbSet<sysParameter> sysParameter { get; set; }

    public virtual DbSet<sysParameterPerSite> sysParameterPerSite { get; set; }

    public virtual DbSet<sysParameterReport> sysParameterReport { get; set; }

    public virtual DbSet<sysPatientNameFormat> sysPatientNameFormat { get; set; }

    public virtual DbSet<sysRecordEdited> sysRecordEdited { get; set; }

    public virtual DbSet<sysRecordEditedLog> sysRecordEditedLog { get; set; }

    public virtual DbSet<sysTable> sysTable { get; set; }

    public virtual DbSet<sysTagField> sysTagField { get; set; }

    public virtual DbSet<sysTransactionCode> sysTransactionCode { get; set; }

    public virtual DbSet<sysTrigger> sysTrigger { get; set; }

    public virtual DbSet<sysUser> sysUser { get; set; }

    public virtual DbSet<sysUserAndroid> sysUserAndroid { get; set; }

    public virtual DbSet<sysUserLog> sysUserLog { get; set; }

    public virtual DbSet<sysUserPIN> sysUserPIN { get; set; }

    public virtual DbSet<sysUserThemes> sysUserThemes { get; set; }

    public virtual DbSet<temCaseTypeRegistration> temCaseTypeRegistration { get; set; }

    public virtual DbSet<tempAPDes> tempAPDes { get; set; }

    public virtual DbSet<tempARpribadirudy> tempARpribadirudy { get; set; }

    public virtual DbSet<tempAppayment> tempAppayment { get; set; }

    public virtual DbSet<tempDiagnosisHapusAkreditasi> tempDiagnosisHapusAkreditasi { get; set; }

    public virtual DbSet<tempItemBrandGenericrudy> tempItemBrandGenericrudy { get; set; }

    public virtual DbSet<tempListIndex> tempListIndex { get; set; }

    public virtual DbSet<tempListStockAdjustment> tempListStockAdjustment { get; set; }

    public virtual DbSet<tempMaterialCost_Hero> tempMaterialCost_Hero { get; set; }

    public virtual DbSet<tempMaterialCost_RecallPwa> tempMaterialCost_RecallPwa { get; set; }

    public virtual DbSet<tempMessageHL7> tempMessageHL7 { get; set; }

    public virtual DbSet<tempReg> tempReg { get; set; }

    public virtual DbSet<tempTable> tempTable { get; set; }

    public virtual DbSet<tempTableReg> tempTableReg { get; set; }

    public virtual DbSet<tempUploadSirsRoom> tempUploadSirsRoom { get; set; }

    public virtual DbSet<tmp> tmp { get; set; }

    public virtual DbSet<tmpAccountReceivableHistoryByPeriod> tmpAccountReceivableHistoryByPeriod { get; set; }

    public virtual DbSet<tmpCaleder> tmpCaleder { get; set; }

    public virtual DbSet<tmpDokterAll> tmpDokterAll { get; set; }

    public virtual DbSet<tmpDoubleUpdate> tmpDoubleUpdate { get; set; }

    public virtual DbSet<tmpItemTransactionHistoryDt> tmpItemTransactionHistoryDt { get; set; }

    public virtual DbSet<tmpMasteObatLive> tmpMasteObatLive { get; set; }

    public virtual DbSet<tmpMasterColumnLAB> tmpMasterColumnLAB { get; set; }

    public virtual DbSet<tmpMasterColumnPE> tmpMasterColumnPE { get; set; }

    public virtual DbSet<tmpMasterColumnVS> tmpMasterColumnVS { get; set; }

    public virtual DbSet<tmpNicNew> tmpNicNew { get; set; }

    public virtual DbSet<tmpNocNew> tmpNocNew { get; set; }

    public virtual DbSet<tmpObatBaru0802> tmpObatBaru0802 { get; set; }

    public virtual DbSet<tmpPiutangPribadiRudy> tmpPiutangPribadiRudy { get; set; }

    public virtual DbSet<tmpRL52KunjunganRajalDt> tmpRL52KunjunganRajalDt { get; set; }

    public virtual DbSet<tmpReadyDischargeReg> tmpReadyDischargeReg { get; set; }

    public virtual DbSet<tmpResultLab> tmpResultLab { get; set; }

    public virtual DbSet<tmpResultPE> tmpResultPE { get; set; }

    public virtual DbSet<tmpResultVS> tmpResultVS { get; set; }

    public virtual DbSet<tmpStockApotekFix> tmpStockApotekFix { get; set; }

    public virtual DbSet<tmpStockApotekFixBaru> tmpStockApotekFixBaru { get; set; }

    public virtual DbSet<tmpStockLab> tmpStockLab { get; set; }

    public virtual DbSet<tmpStockLive> tmpStockLive { get; set; }

    public virtual DbSet<tmpStockLiveApotek> tmpStockLiveApotek { get; set; }

    public virtual DbSet<tmpStockLiveGudang> tmpStockLiveGudang { get; set; }

    public virtual DbSet<tmpStockLiveGudang0801> tmpStockLiveGudang0801 { get; set; }

    public virtual DbSet<tmpStockLiveGudangDrive> tmpStockLiveGudangDrive { get; set; }

    public virtual DbSet<tmpStockLiveGudangFix> tmpStockLiveGudangFix { get; set; }

    public virtual DbSet<tmpUploud> tmpUploud { get; set; }

    public virtual DbSet<tmpYankesICD10> tmpYankesICD10 { get; set; }

    public virtual DbSet<tmpYankesICD10GigiNew> tmpYankesICD10GigiNew { get; set; }

    public virtual DbSet<tmpZipCode> tmpZipCode { get; set; }

    public virtual DbSet<tmpstockAwalsalah> tmpstockAwalsalah { get; set; }

    public virtual DbSet<unitofmUpload> unitofmUpload { get; set; }

    public virtual DbSet<uvwRegistration> uvwRegistration { get; set; }

    public virtual DbSet<vitalsignintypeBackup> vitalsignintypeBackup { get; set; }

    public virtual DbSet<vw_AccountReceivable> vw_AccountReceivable { get; set; }

    public virtual DbSet<vw_Bed> vw_Bed { get; set; }

    public virtual DbSet<vw_BedTransfer> vw_BedTransfer { get; set; }

    public virtual DbSet<vw_CycleCounting> vw_CycleCounting { get; set; }

    public virtual DbSet<vw_Finance_DebitNoteCreditNote> vw_Finance_DebitNoteCreditNote { get; set; }

    public virtual DbSet<vw_Finance_Invoiced> vw_Finance_Invoiced { get; set; }

    public virtual DbSet<vw_Finance_Journal> vw_Finance_Journal { get; set; }

    public virtual DbSet<vw_Finance_Un_Invoiced> vw_Finance_Un_Invoiced { get; set; }

    public virtual DbSet<vw_Finance_WriteOff> vw_Finance_WriteOff { get; set; }

    public virtual DbSet<vw_Inventory_PurchaseOrderReceipt> vw_Inventory_PurchaseOrderReceipt { get; set; }

    public virtual DbSet<vw_InvoicePayment> vw_InvoicePayment { get; set; }

    public virtual DbSet<vw_Item> vw_Item { get; set; }

    public virtual DbSet<vw_ItemTransactionHistory> vw_ItemTransactionHistory { get; set; }

    public virtual DbSet<vw_MasterAddress> vw_MasterAddress { get; set; }

    public virtual DbSet<vw_MasterBed> vw_MasterBed { get; set; }

    public virtual DbSet<vw_MasterBusinessPartner> vw_MasterBusinessPartner { get; set; }

    public virtual DbSet<vw_MasterClass> vw_MasterClass { get; set; }

    public virtual DbSet<vw_MasterCorporate> vw_MasterCorporate { get; set; }

    public virtual DbSet<vw_MasterDepartmentServiceUnit> vw_MasterDepartmentServiceUnit { get; set; }

    public virtual DbSet<vw_MasterItem> vw_MasterItem { get; set; }

    public virtual DbSet<vw_MasterLocation> vw_MasterLocation { get; set; }

    public virtual DbSet<vw_MasterParamedic> vw_MasterParamedic { get; set; }

    public virtual DbSet<vw_MasterPatient> vw_MasterPatient { get; set; }

    public virtual DbSet<vw_MasterRoom> vw_MasterRoom { get; set; }

    public virtual DbSet<vw_MasterSite> vw_MasterSite { get; set; }

    public virtual DbSet<vw_Master_ChartOfAccount> vw_Master_ChartOfAccount { get; set; }

    public virtual DbSet<vw_OtherExamTransaction> vw_OtherExamTransaction { get; set; }

    public virtual DbSet<vw_Patient_Deposit> vw_Patient_Deposit { get; set; }

    public virtual DbSet<vw_Patient_DiscountPhysician> vw_Patient_DiscountPhysician { get; set; }

    public virtual DbSet<vw_Patient_Payment> vw_Patient_Payment { get; set; }

    public virtual DbSet<vw_Patient_Registration> vw_Patient_Registration { get; set; }

    public virtual DbSet<vw_Patient_TransactionCharges> vw_Patient_TransactionCharges { get; set; }

    public virtual DbSet<vw_Patient_TransactionCharges_Hero> vw_Patient_TransactionCharges_Hero { get; set; }

    public virtual DbSet<vw_PhysicianItem> vw_PhysicianItem { get; set; }

    public virtual DbSet<vw_PurchaseOrder> vw_PurchaseOrder { get; set; }

    public virtual DbSet<vw_Registration> vw_Registration { get; set; }

    public virtual DbSet<vw_RegistrationInvoice> vw_RegistrationInvoice { get; set; }

    public virtual DbSet<vw_RegistrationOutstanding> vw_RegistrationOutstanding { get; set; }

    public virtual DbSet<vw_RegistrationReferral> vw_RegistrationReferral { get; set; }

    public virtual DbSet<vw_SiencePatientRegistration> vw_SiencePatientRegistration { get; set; }

    public virtual DbSet<vw_Transaction> vw_Transaction { get; set; }

    public virtual DbSet<vw_TransactionCharges> vw_TransactionCharges { get; set; }

    public virtual DbSet<vw_TransactionMCU> vw_TransactionMCU { get; set; }

    public virtual DbSet<vw_address> vw_address { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.80.212;Database=YANKES_DPR;User Id=sa;Password=p455w0rd.;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AGCGroup>(entity =>
        {
            entity.HasOne(d => d.AGCItemCodeNavigation).WithMany(p => p.AGCGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGCGroup_AGCItem");

            entity.HasOne(d => d.COACodeNavigation).WithMany(p => p.AGCGroup).HasConstraintName("FK_AGCGroup_ChartOfAccount");

            entity.HasOne(d => d.GCAGCGroupTypeNavigation).WithMany(p => p.AGCGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AGCGroup_sysGeneralCode_GcAgcGroupType");
        });

        modelBuilder.Entity<ATCClass>(entity =>
        {
            entity.Property(e => e.ATCClassName).HasDefaultValue("", "DF_ATCClass_ATCClassName");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_ATCClass_IsDeleted");

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation).HasConstraintName("FK_ATCClass_ATCClass");
        });

        modelBuilder.Entity<AbcClass>(entity =>
        {
            entity.Property(e => e.AbcClass1).IsFixedLength();
        });

        modelBuilder.Entity<AccountAccrualReset>(entity =>
        {
            entity.HasOne(d => d.CoaCodeNavigation).WithMany(p => p.AccountAccrualReset)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountAccrualReset_ChartOfAccount");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.AccountAccrualReset)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountAccrualReset_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AccountAccrualReset)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountAccrualReset_Site");
        });

        modelBuilder.Entity<AccountPayableAccrual>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.AccountPayableAccrual)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableAccrual_Supplier");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AccountPayableAccrual)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableAccrual_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.AccountPayableAccrual)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableAccrual_sysTransactionCode");
        });

        modelBuilder.Entity<AccountPayableDtAccrual>(entity =>
        {
            entity.HasOne(d => d.APAccrualNoNavigation).WithMany(p => p.AccountPayableDtAccrual)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableDtAccrual_AccountPayableAccrual");

            entity.HasOne(d => d.APNoNavigation).WithMany(p => p.AccountPayableDtAccrual)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableDtAccrual_AccountPayableHd");
        });

        modelBuilder.Entity<AccountPayableDtCreditNote>(entity =>
        {
            entity.HasKey(e => new { e.APNo, e.CreditNoteNo }).HasName("PK_AccountPayableDt");

            entity.HasOne(d => d.APNoNavigation).WithMany(p => p.AccountPayableDtCreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableDt_AccountPayableHd");

            entity.HasOne(d => d.CreditNoteNoNavigation).WithMany(p => p.AccountPayableDtCreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableDt_CreditNote");
        });

        modelBuilder.Entity<AccountPayableHd>(entity =>
        {
            entity.Property(e => e.IncomeTaxAmount).HasDefaultValue(0m, "DF_AccountPayableHd_IncomeTaxAmount");

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.AccountPayableHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableHd_Supplier");

            entity.HasOne(d => d.GCIncomeTaxNameNavigation).WithMany(p => p.AccountPayableHd).HasConstraintName("FK_AccountPayableHd_sysGeneralCode_IncomeTaxName");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AccountPayableHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableHd_Site");

            entity.HasOne(d => d.TermOfPaymentNavigation).WithMany(p => p.AccountPayableHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableHd_Term");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.AccountPayableHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableHd_sysTransactionCode");
        });

        modelBuilder.Entity<AccountPayableHistory>(entity =>
        {
            entity.HasKey(e => new { e.APNo, e.BusinessPartnerId, e.PONo }).HasName("PK_AccountPayableHistory_1");
        });

        modelBuilder.Entity<AccountPayablePaymentPlanDt>(entity =>
        {
            entity.HasOne(d => d.APNoNavigation).WithMany(p => p.AccountPayablePaymentPlanDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayablePaymentPlanDt_AccountPayableHd");

            entity.HasOne(d => d.PaymentPlanNoNavigation).WithMany(p => p.AccountPayablePaymentPlanDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayablePaymentPlanDt_AccountPayablePaymentPlanHd");
        });

        modelBuilder.Entity<AccountPayablePaymentPlanDtCreditNote>(entity =>
        {
            entity.HasOne(d => d.CreditNoteNoNavigation).WithMany(p => p.AccountPayablePaymentPlanDtCreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayablePaymentPlanDtCreditNote_CreditNote1");

            entity.HasOne(d => d.AccountPayablePaymentPlanDt).WithMany(p => p.AccountPayablePaymentPlanDtCreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayablePaymentPlanDtCreditNote_CreditNote");
        });

        modelBuilder.Entity<AccountPayablePaymentPlanHd>(entity =>
        {
            entity.HasOne(d => d.Bank).WithMany(p => p.AccountPayablePaymentPlanHd).HasConstraintName("FK_AccountPayablePaymentPlanHd_Bank");

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.AccountPayablePaymentPlanHd).HasConstraintName("FK_AccountPayablePaymentPlanHd_Supplier");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AccountPayablePaymentPlanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayablePaymentPlanHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.AccountPayablePaymentPlanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayablePaymentPlanHd_sysTransactionCode");
        });

        modelBuilder.Entity<AccountPayableTransactionDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.AccountPayableTransactionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableTransactionDt_Item");

            entity.HasOne(d => d.TransactionNoNavigation).WithMany(p => p.AccountPayableTransactionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPayableTransactionDt_AccountPayableTransactionHd");
        });

        modelBuilder.Entity<AccountPeriod>(entity =>
        {
            entity.HasOne(d => d.CoaCodeNavigation).WithMany(p => p.AccountPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPeriod_ChartOfAccount");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.AccountPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPeriod_Department");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.AccountPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPeriod_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.AccountPeriod).HasConstraintName("FK_AccountPeriod_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AccountPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPeriod_Site");

            entity.HasOne(d => d.FiscalPeriodDt).WithMany(p => p.AccountPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountPeriod_FiscalPeriodDt");
        });

        modelBuilder.Entity<AccountReceivableAccrual>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.AccountReceivableAccrual)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableAccrual_Customer");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.AccountReceivableAccrual).HasConstraintName("FK_AccountReceivableAccrual_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AccountReceivableAccrual)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableAccrual_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.AccountReceivableAccrual)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableAccrual_sysTransactionCode");
        });

        modelBuilder.Entity<AccountReceivableAccrualDt>(entity =>
        {
            entity.HasOne(d => d.ARAccrualNoNavigation).WithMany(p => p.AccountReceivableAccrualDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableAccrualDt_AccountReceivableAccrual");

            entity.HasOne(d => d.TransactionNoNavigation).WithMany(p => p.AccountReceivableAccrualDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableAccrualDt_TransactionChargesHd");
        });

        modelBuilder.Entity<AccountReceivableAccrualVoid>(entity =>
        {
            entity.HasKey(e => e.ARAccrualNo).HasName("PK_AccountReceivableAccrualVoid_2");
        });

        modelBuilder.Entity<AccountReceivableDt>(entity =>
        {
            entity.HasIndex(e => e.ARAccrualNo, "IX_AccountReceivableDt").HasFillFactor(90);

            entity.HasOne(d => d.ARAccrualNoNavigation).WithMany(p => p.AccountReceivableDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableDt_AccountReceivableAccrual");

            entity.HasOne(d => d.ARNoNavigation).WithMany(p => p.AccountReceivableDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableDt_AccountReceivableHd");
        });

        modelBuilder.Entity<AccountReceivableDtReverse>(entity =>
        {
            entity.HasOne(d => d.ARNoNavigation).WithMany(p => p.AccountReceivableDtReverse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableDtReverse_AccountReceivableHd");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.AccountReceivableDtReverse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableDtReverse_sysTransactionCode");
        });

        modelBuilder.Entity<AccountReceivableHd>(entity =>
        {
            entity.HasKey(e => e.ARNo).HasName("PK_AccountReceivable");

            entity.Property(e => e.DiscountAmount).HasDefaultValue(0m, "DF_AccountReceivableHd_DiscountAmount");

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.AccountReceivableHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableHd_Customer");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AccountReceivableHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableHd_Site");

            entity.HasOne(d => d.TermCodeNavigation).WithMany(p => p.AccountReceivableHd).HasConstraintName("FK_AccountReceivableHd_Term");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.AccountReceivableHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableHd_sysTransactionCode");
        });

        modelBuilder.Entity<AccountReceivablePaymentDt>(entity =>
        {
            entity.HasOne(d => d.Bank).WithMany(p => p.AccountReceivablePaymentDt).HasConstraintName("FK_AccountReceivablePaymentDt_Bank");

            entity.HasOne(d => d.EDCMachineCodeNavigation).WithMany(p => p.AccountReceivablePaymentDt).HasConstraintName("FK_AccountReceivablePaymentDt_EDCMachine");

            entity.HasOne(d => d.GCCardProviderNavigation).WithMany(p => p.AccountReceivablePaymentDtGCCardProviderNavigation).HasConstraintName("FK_AccountReceivablePaymentDt_sysGeneralCode_CardProvider");

            entity.HasOne(d => d.GCCardTypeNavigation).WithMany(p => p.AccountReceivablePaymentDtGCCardTypeNavigation).HasConstraintName("FK_AccountReceivablePaymentDt_sysGeneralCode_CardType");

            entity.HasOne(d => d.GCPaymentMethodNavigation).WithMany(p => p.AccountReceivablePaymentDtGCPaymentMethodNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivablePaymentDt_sysGeneralCode_PaymentMethod");

            entity.HasOne(d => d.PaymentNoNavigation).WithMany(p => p.AccountReceivablePaymentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivablePaymentDt_AccountReceivablePaymentHd");
        });

        modelBuilder.Entity<AccountReceivablePaymentHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.AccountReceivablePaymentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivablePaymentHd_Customer");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AccountReceivablePaymentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivablePaymentHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.AccountReceivablePaymentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivablePaymentHd_sysTransactionCode");
        });

        modelBuilder.Entity<AccountReceivablePaymentReg>(entity =>
        {
            entity.HasOne(d => d.ARANoNavigation).WithMany(p => p.AccountReceivablePaymentReg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivablePaymentReg_AccountReceivableAccrual");

            entity.HasOne(d => d.ARNoNavigation).WithMany(p => p.AccountReceivablePaymentReg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivablePaymentReg_AccountReceivableHd");

            entity.HasOne(d => d.PaymentNoNavigation).WithMany(p => p.AccountReceivablePaymentReg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivablePaymentReg_AccountReceivablePaymentHd");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.AccountReceivablePaymentReg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivablePaymentReg_Registration");
        });

        modelBuilder.Entity<AccountReceivableTransactionDt>(entity =>
        {
            entity.HasOne(d => d.TransactionNoNavigation).WithMany(p => p.AccountReceivableTransactionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableTransactionDt_AccountReceivableTransactionHd");
        });

        modelBuilder.Entity<AccountReceivableWriteOffPlanDt>(entity =>
        {
            entity.HasOne(d => d.WriteOffPlanNoNavigation).WithMany(p => p.AccountReceivableWriteOffPlanDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableWriteOffPlanDt_AccountReceivableWriteOffPlanHd");
        });

        modelBuilder.Entity<AccountReceivableWriteOffPlanHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.AccountReceivableWriteOffPlanHd).HasConstraintName("FK_AccountReceivableWriteOffPlanHd_BusinessPartner");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AccountReceivableWriteOffPlanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableWriteOffPlanHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.AccountReceivableWriteOffPlanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountReceivableWriteOffPlanHd_sysTransactionCode");
        });

        modelBuilder.Entity<AccountReceiveableHistory>(entity =>
        {
            entity.HasKey(e => new { e.ARNo, e.BusinessPartnerId, e.RegistrationNo }).HasName("PK_AccountReceiveableHistory_1");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => new { e.EntityClassName, e.EntityRecordID, e.GCAddressType }).HasName("PK_Address_1");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tr_PatientLookupAddress");
                    tb.HasTrigger("tr_ValidateAddress");
                });

            entity.Property(e => e.City).HasDefaultValue("", "DF_Address_City");
            entity.Property(e => e.Country).HasDefaultValue("", "DF_Address_County");
            entity.Property(e => e.District).HasDefaultValue("", "DF_Address_District");
            entity.Property(e => e.FaxNo1).HasDefaultValue("", "DF_Address_FaxNo1");
            entity.Property(e => e.FaxNo2).HasDefaultValue("", "DF_Address_FaxNo2");
            entity.Property(e => e.Line2).HasDefaultValue("", "DF_Address_Line2");
            entity.Property(e => e.PhoneNo1).HasDefaultValue("", "DF_Address_PhoneNo1");
            entity.Property(e => e.PhoneNo2).HasDefaultValue("", "DF_Address_PhoneNo2");

            entity.HasOne(d => d.GCAddressTypeNavigation).WithMany(p => p.AddressGCAddressTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_sysGeneralCode_AddressType");

            entity.HasOne(d => d.GCProvinceNavigation).WithMany(p => p.AddressGCProvinceNavigation).HasConstraintName("FK_Address_sysGeneralCode_Province");

            entity.HasOne(d => d.ZipCode).WithMany(p => p.Address).HasConstraintName("FK_Address_ZipCodes");
        });

        modelBuilder.Entity<AdministrationNotes>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.AdministrationNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdministrationNotes_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AdministrationNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdministrationNotes_Site");
        });

        modelBuilder.Entity<AldretteScoreDewasa>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK__aldrtett__B79FCF9E16F7E47D");
        });

        modelBuilder.Entity<Allergen>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Allergen_IsActive");

            entity.HasOne(d => d.GCAllergenTypeNavigation).WithMany(p => p.Allergen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Allergen_sysGeneralCode_AllergenType");
        });

        modelBuilder.Entity<AllocationCodeDt>(entity =>
        {
            entity.HasOne(d => d.Allocation).WithMany(p => p.AllocationCodeDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AllocationCodeDt_AllocationCodeHd");

            entity.HasOne(d => d.CoaCodeNavigation).WithMany(p => p.AllocationCodeDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AllocationCodeDt_ChartOfAccount");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.AllocationCodeDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AllocationCodeDt_Department");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.AllocationCodeDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AllocationCodeDt_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.AllocationCodeDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AllocationCodeDt_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AllocationCodeDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AllocationCodeDt_Site");
        });

        modelBuilder.Entity<AnalyzeOfCensus>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.CensusDateTime, e.ServiceUnitID, e.ClassCode }).HasName("PK_AnalyzeOfCensus_1");

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.AnalyzeOfCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalyzeOfCensus_Class");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.AnalyzeOfCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalyzeOfCensus_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AnalyzeOfCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalyzeOfCensus_Site");
        });

        modelBuilder.Entity<AnalyzeOfCensusTotalBed>(entity =>
        {
            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.AnalyzeOfCensusTotalBed)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalyzeOfCensusTotalBed_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AnalyzeOfCensusTotalBed)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnalyzeOfCensusTotalBed_Site");
        });

        modelBuilder.Entity<AnnualMCUCorporateDt>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<AnnualMCUCorporateHd>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<AnswerSct>(entity =>
        {
            entity.HasKey(e => new { e.SctCode, e.AnswerID }).HasName("PK_Table_7");
        });

        modelBuilder.Entity<AntreanPanggilJKN>(entity =>
        {
            entity.HasKey(e => e.ParamedicID).HasName("PK_AntreanPanggilJKN_2");

            entity.Property(e => e.ParamedicID).ValueGeneratedNever();
        });

        modelBuilder.Entity<AntrianPanggilRegistrasi>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.Appointment).HasConstraintName("FK_Appointment_Patient");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.Appointment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Appointment_Site");

            entity.HasOne(d => d.Status).WithMany(p => p.Appointment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Appointment_StatusPriority");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.Appointment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Appointment_sysTransactionCode");

            entity.HasOne(d => d.VisitTypeCodeNavigation).WithMany(p => p.Appointment).HasConstraintName("FK_Appointment_VisitType");

            entity.HasOne(d => d.WorkStationCodeNavigation).WithMany(p => p.Appointment).HasConstraintName("FK_Appointment_WorkStation");
        });

        modelBuilder.Entity<AppointmentDriveThru>(entity =>
        {
            entity.HasKey(e => e.AppointmentNo).HasName("PK_AppointmentDriveThru_1");
        });

        modelBuilder.Entity<ApprovalLevel>(entity =>
        {
            entity.HasOne(d => d.GCApprovalLevelNavigation).WithMany(p => p.ApprovalLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalLevel_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ApprovalLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalLevel_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ApprovalLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalLevel_sysTransactionCode");
        });

        modelBuilder.Entity<AssetAdjustment>(entity =>
        {
            entity.HasKey(e => e.AdjustmentNo).HasName("PK_AssetAdjustment_1");

            entity.HasOne(d => d.Assets).WithMany(p => p.AssetAdjustment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAdjustment_Assets");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AssetAdjustment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAdjustment_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.AssetAdjustment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetAdjustment_sysTransactionCode");
        });

        modelBuilder.Entity<AssetBook>(entity =>
        {
            entity.HasKey(e => new { e.BookCode, e.SequenceNo }).HasName("PK_AssetBook_1");

            entity.HasOne(d => d.CalendarCodeNavigation).WithMany(p => p.AssetBook).HasConstraintName("FK_AssetBook_AssetCalendarHd");
        });

        modelBuilder.Entity<AssetCalendarDt>(entity =>
        {
            entity.HasOne(d => d.CalendarCodeNavigation).WithMany(p => p.AssetCalendarDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetCalendarDt_AssetCalendarHd");
        });

        modelBuilder.Entity<AssetClassDt>(entity =>
        {
            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.AssetClassDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetClassDt_AssetClassHd");

            entity.HasOne(d => d.Method).WithMany(p => p.AssetClassDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetClassDt_AssetDepreciationMethod");

            entity.HasOne(d => d.AssetBook).WithMany(p => p.AssetClassDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetClassDt_AssetBook");
        });

        modelBuilder.Entity<AssetComponent>(entity =>
        {
            entity.HasOne(d => d.Assets).WithMany(p => p.AssetComponent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetComponent_Assets");
        });

        modelBuilder.Entity<AssetDepreciation>(entity =>
        {
            entity.HasOne(d => d.Assets).WithMany(p => p.AssetDepreciation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciation_Assets");

            entity.HasOne(d => d.FiscalPeriodDt).WithMany(p => p.AssetDepreciation).HasConstraintName("FK_AssetDepreciation_FiscalPeriodDt");
        });

        modelBuilder.Entity<AssetDepreciationMethod>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_AssetDepreciationMethod_IsActive");

            entity.HasOne(d => d.GCConventionMethodNavigation).WithMany(p => p.AssetDepreciationMethodGCConventionMethodNavigation).HasConstraintName("FK_AssetDepreciationMethod_sysGeneralCode");

            entity.HasOne(d => d.GCDepreciationMethodNavigation).WithMany(p => p.AssetDepreciationMethodGCDepreciationMethodNavigation).HasConstraintName("FK_AssetDepreciationMethod_sysGeneralCode1");
        });

        modelBuilder.Entity<AssetDepreciationParameter>(entity =>
        {
            entity.HasKey(e => new { e.AssetID, e.BookCode, e.BookSequenceNo }).HasName("PK_AssetDepreciationParameter_1");

            entity.HasOne(d => d.Method).WithMany(p => p.AssetDepreciationParameter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciationParameter_AssetDepreciationMethod");

            entity.HasOne(d => d.AssetBook).WithMany(p => p.AssetDepreciationParameter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciationParameter_AssetBook");
        });

        modelBuilder.Entity<AssetExpense>(entity =>
        {
            entity.HasOne(d => d.ServiceOrderDt).WithMany(p => p.AssetExpense)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetExpense_ServiceOrderDt");
        });

        modelBuilder.Entity<AssetInspectionDt>(entity =>
        {
            entity.HasKey(e => new { e.AssetsCode, e.SequenceNo }).HasName("PK_AssetInspection");
        });

        modelBuilder.Entity<AssetMeter>(entity =>
        {
            entity.HasOne(d => d.Asset).WithMany(p => p.AssetMeter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetMeter_Assets");

            entity.HasOne(d => d.FiscalPeriodDt).WithMany(p => p.AssetMeter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetMeter_FiscalPeriodDt");
        });

        modelBuilder.Entity<AssetModule>(entity =>
        {
            entity.HasOne(d => d.Assets).WithMany(p => p.AssetModule)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetModule_Assets");
        });

        modelBuilder.Entity<Assets>(entity =>
        {
            entity.HasOne(d => d.AccumulatedExpenseNavigation).WithMany(p => p.AssetsAccumulatedExpenseNavigation).HasConstraintName("FK_Assets_ChartOfAccount_AccumulateExpense");

            entity.HasOne(d => d.AssetAccountNavigation).WithMany(p => p.AssetsAssetAccountNavigation).HasConstraintName("FK_Assets_ChartOfAccount");

            entity.HasOne(d => d.Businesspartner).WithMany(p => p.Assets).HasConstraintName("FK_Assets_BusinessPartner");

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.Assets).HasConstraintName("FK_Assets_AssetClassHd");

            entity.HasOne(d => d.LinkItem).WithMany(p => p.Assets).HasConstraintName("FK_Assets_Item");

            entity.HasOne(d => d.POReceiptNoNavigation).WithMany(p => p.Assets).HasConstraintName("FK_Assets_PurchaseOrderReceiptHd");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_Assets_Assets1");

            entity.HasOne(d => d.PurchaseOrderNoNavigation).WithMany(p => p.Assets).HasConstraintName("FK_Assets_PurchaseOrderHd");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.Assets).HasConstraintName("FK_Assets_DepartmentServiceUnit");

            entity.HasOne(d => d.AssetBook).WithMany(p => p.Assets).HasConstraintName("FK_Assets_AssetBook");
        });

        modelBuilder.Entity<AssetsBook>(entity =>
        {
            entity.HasKey(e => e.AssetsBookID).HasName("PK_AssetBook");

            entity.HasOne(d => d.ExpenseCoaCodeNavigation).WithMany(p => p.AssetsBookExpenseCoaCodeNavigation).HasConstraintName("FK_AssetsBook_ChartOfAccount_ExpenceCoaCode");
        });

        modelBuilder.Entity<AssetsCalibrationSummary>(entity =>
        {
            entity.Property(e => e.AssetsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<AssetsDepreciation>(entity =>
        {
            entity.HasOne(d => d.Assets).WithMany(p => p.AssetsDepreciation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetsDepreciation_Assets");
        });

        modelBuilder.Entity<AssetsGroup>(entity =>
        {
            entity.HasKey(e => e.AssetsGroupID).HasName("PK_AssetGroup");
        });

        modelBuilder.Entity<AssetsTransfers>(entity =>
        {
            entity.Property(e => e.AssetsTransferId).ValueGeneratedNever();

            entity.HasOne(d => d.Assets).WithMany(p => p.AssetsTransfers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetsTransfers_Assets");
        });

        modelBuilder.Entity<Audiometri>(entity =>
        {
            entity.HasOne(d => d.JobOrderBOMOtherExam).WithOne(p => p.Audiometri)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Audiometri_JobOrderBOMOtherExam");
        });

        modelBuilder.Entity<AutomationChargesItem>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.AutomationChargesItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomationChargesItem_Item");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.AutomationChargesItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AutomationChargesItem_DepartmentServiceUnit");
        });

        modelBuilder.Entity<AverageCost>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.AverageCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AverageCost_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AverageCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AverageCost_Site");

            entity.HasOne(d => d.FiscalPeriodDt).WithMany(p => p.AverageCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AverageCost_FiscalPeriodDt");
        });

        modelBuilder.Entity<AverageCostBySystem>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.AverageCostBySystem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AverageCostBySystem_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.AverageCostBySystem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AverageCostBySystem_Site");

            entity.HasOne(d => d.FiscalPeriodDt).WithMany(p => p.AverageCostBySystem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AverageCostBySystem_FiscalPeriodDt");
        });

        modelBuilder.Entity<AverageCostExcludePPN>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.Year, e.Period, e.CalculatedDateTime, e.ItemID }).HasName("PK_AverageCostExcludePPN_1");
        });

        modelBuilder.Entity<BUItemTransactionHistoryHdLive>(entity =>
        {
            entity.Property(e => e.TransactionHistoryID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BackPaySalary>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.BackPaySalary)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BackPaySalary_Employee");
        });

        modelBuilder.Entity<BackupPatient20240906>(entity =>
        {
            entity.Property(e => e.BloodRhesus).IsFixedLength();
        });

        modelBuilder.Entity<BackupRulesMCUhd20250930>(entity =>
        {
            entity.Property(e => e.RulesID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BalaiKesejahteraanIbuAnakTable>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.BalaiKesejahteraanIbuAnakTable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BalaiKesejahteraanIbuAnakTable_Registration");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.Property(e => e.BankAccountName).HasComment("Bank Account Name");
            entity.Property(e => e.BankCode).HasComment("Bank Code");
            entity.Property(e => e.Initial).HasDefaultValue("", "DF_Bank_Initial");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Bank_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_Bank_Remarks");

            entity.HasOne(d => d.GCProviderNavigation).WithMany(p => p.BankGCProviderNavigation).HasConstraintName("FK_Bank_sysGeneralCode1");

            entity.HasOne(d => d.GCShortNameNavigation).WithMany(p => p.BankGCShortNameNavigation).HasConstraintName("FK_Bank_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.Bank)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bank_Site");
        });

        modelBuilder.Entity<BankChargesDt>(entity =>
        {
            entity.HasOne(d => d.GCCardProviderNavigation).WithMany(p => p.BankChargesDtGCCardProviderNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankChargesDt_sysGeneralCode");

            entity.HasOne(d => d.GCCardTypeNavigation).WithMany(p => p.BankChargesDtGCCardTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankChargesDt_sysGeneralCode1");

            entity.HasOne(d => d.GCProviderNavigation).WithMany(p => p.BankChargesDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankChargesDt_BankChargesHd");
        });

        modelBuilder.Entity<BankChargesHd>(entity =>
        {
            entity.HasOne(d => d.GCProviderNavigation).WithOne(p => p.BankChargesHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankChargesHd_sysGeneralCode");
        });

        modelBuilder.Entity<BankReconcileHd>(entity =>
        {
            entity.HasKey(e => e.ReconNo).HasName("PK__BankReco__096D7D874DDA15D1");
        });

        modelBuilder.Entity<BarcodeSettingDt>(entity =>
        {
            entity.HasOne(d => d.CodeNavigation).WithMany(p => p.BarcodeSettingDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BarcodeSettingDt_BarcodeSettingHd");
        });

        modelBuilder.Entity<Bed>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tr_BedHistory");
                    tb.HasTrigger("tr_ValidateBedStatus");
                });

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Bed_IsActive");
            entity.Property(e => e.IsBPJSEnabled).HasDefaultValue(true, "DF_Bed_IsBPJSEnabled");

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.Bed)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bed_Class");

            entity.HasOne(d => d.GCBedStatusNavigation).WithMany(p => p.BedGCBedStatusNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bed_sysGeneralCode_BedStatus");

            entity.HasOne(d => d.GCTypeOfBedNavigation).WithMany(p => p.BedGCTypeOfBedNavigation).HasConstraintName("FK_Bed_sysGeneralCode_TypeOfBed");

            entity.HasOne(d => d.ItemIdAutomationChargesNavigation).WithMany(p => p.Bed).HasConstraintName("FK_Bed_Item");

            entity.HasOne(d => d.Room).WithMany(p => p.Bed)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bed_ServiceRoom");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.Bed).HasConstraintName("FK_Bed_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.Bed).HasConstraintName("FK_Bed_Site");
        });

        modelBuilder.Entity<BedCleaning>(entity =>
        {
            entity.HasOne(d => d.Bed).WithMany(p => p.BedCleaning)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedCleaning_Bed");

            entity.HasOne(d => d.GCCleaningMethodNavigation).WithMany(p => p.BedCleaningGCCleaningMethodNavigation).HasConstraintName("FK_BedCleaning_sysGeneralCode");

            entity.HasOne(d => d.GCResultNavigation).WithMany(p => p.BedCleaningGCResultNavigation).HasConstraintName("FK_BedCleaning_sysGeneralCode1");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.BedCleaning).HasConstraintName("FK_BedCleaning_Patient");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.BedCleaning)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedCleaning_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.BedCleaning)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedCleaning_sysTransactionCode");
        });

        modelBuilder.Entity<BedHistory>(entity =>
        {
            entity.HasOne(d => d.Bed).WithMany(p => p.BedHistory).HasConstraintName("FK_BedHistory_Bed");

            entity.HasOne(d => d.GCBedStatusNewNavigation).WithMany(p => p.BedHistoryGCBedStatusNewNavigation).HasConstraintName("FK_BedHistory_sysGeneralCode_BedStatusNew");

            entity.HasOne(d => d.GCBedStatusOldNavigation).WithMany(p => p.BedHistoryGCBedStatusOldNavigation).HasConstraintName("FK_BedHistory_sysGeneralCode_BedStatusOld");

            entity.HasOne(d => d.RegistrationNewNavigation).WithMany(p => p.BedHistoryRegistrationNewNavigation).HasConstraintName("FK_BedHistory_RegistrationNew");

            entity.HasOne(d => d.RegistrationOldNavigation).WithMany(p => p.BedHistoryRegistrationOldNavigation).HasConstraintName("FK_BedHistory_RegistrationOld");
        });

        modelBuilder.Entity<BedItemChargesCustom>(entity =>
        {
            entity.Property(e => e.BedId).ValueGeneratedNever();
        });

        modelBuilder.Entity<BedReservation>(entity =>
        {
            entity.HasOne(d => d.Bed).WithMany(p => p.BedReservation).HasConstraintName("FK_BedReservation_Bed");

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.BedReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedReservation_Class");

            entity.HasOne(d => d.GCReservationStatusNavigation).WithMany(p => p.BedReservationGCReservationStatusNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedReservation_sysGeneralCode");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.BedReservationGCSexNavigation).HasConstraintName("FK_BedReservation_sysGeneralCode1");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.BedReservation).HasConstraintName("FK_BedReservation_Patient");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.BedReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedReservation_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.BedReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedReservation_sysTransactionCode");
        });

        modelBuilder.Entity<BedTransfer>(entity =>
        {
            entity.HasOne(d => d.FromBed).WithMany(p => p.BedTransferFromBed).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromChargeClassCodeNavigation).WithMany(p => p.BedTransferFromChargeClassCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromClassCodeNavigation).WithMany(p => p.BedTransferFromClassCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromRoom).WithMany(p => p.BedTransferFromRoom).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromServiceUnit).WithMany(p => p.BedTransferFromServiceUnit).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromSpecialtyCodeNavigation).WithMany(p => p.BedTransferFromSpecialtyCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.BedTransfer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedTransfer_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.BedTransfer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedTransfer_Site");

            entity.HasOne(d => d.ToBed).WithMany(p => p.BedTransferToBed).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToChargeClassCodeNavigation).WithMany(p => p.BedTransferToChargeClassCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToClassCodeNavigation).WithMany(p => p.BedTransferToClassCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToRoom).WithMany(p => p.BedTransferToRoom).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToServiceUnit).WithMany(p => p.BedTransferToServiceUnit).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToSpecialtyCodeNavigation).WithMany(p => p.BedTransferToSpecialtyCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.BedTransfer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BedTransfer_sysTransactionCode");
        });

        modelBuilder.Entity<BodyPartDt>(entity =>
        {
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_BodyPartDt_Remarks");

            entity.HasOne(d => d.GCDiagramTypeNavigation).WithMany(p => p.BodyPartDt).HasConstraintName("FK_BodyPartDt_SysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.BodyPartDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BodyPartDt_Site");

            entity.HasOne(d => d.BodyPartHd).WithMany(p => p.BodyPartDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BodyPartDt_BodyPartHd");
        });

        modelBuilder.Entity<BodyPartDtPoint>(entity =>
        {
            entity.HasOne(d => d.BodyPartDt).WithMany(p => p.BodyPartDtPoint)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BodyPartDtPoint_BodyPartDt");
        });

        modelBuilder.Entity<BodyPartHd>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.BodyPartHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BodyPartHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.BodyPartHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BodyPartHd_Site");
        });

        modelBuilder.Entity<BodyPartSpecialty>(entity =>
        {
            entity.HasOne(d => d.GCImageUrlNavigation).WithMany(p => p.BodyPartSpecialty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BodyPartSpecialty_sysGeneralCode");

            entity.HasOne(d => d.SpecialtyCodeNavigation).WithMany(p => p.BodyPartSpecialty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BodyPartSpecialty_Specialty");
        });

        modelBuilder.Entity<BpjsInformation>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_BpjsInformation_IsDeleted");
        });

        modelBuilder.Entity<Bu_RLTemplateDtRL52_20230724>(entity =>
        {
            entity.Property(e => e.RowId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BudgetDt>(entity =>
        {
            entity.HasOne(d => d.BudgetSubDt).WithMany(p => p.BudgetDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetDt_BudgetSubDt");
        });

        modelBuilder.Entity<BudgetHd>(entity =>
        {
            entity.HasOne(d => d.BudgetYearNavigation).WithMany(p => p.BudgetHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetHd_FiscalPeriodHd");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.BudgetHd).HasConstraintName("FK_BudgetHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.BudgetHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetHd_Site");

            entity.HasOne(d => d.SiteDepartment).WithMany(p => p.BudgetHd).HasConstraintName("FK_BudgetHd_SiteDepartment");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.BudgetHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetHd_sysTransactionCode");
        });

        modelBuilder.Entity<BudgetSubDt>(entity =>
        {
            entity.HasOne(d => d.BudgetNoNavigation).WithMany(p => p.BudgetSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetSubDt_BudgetHd");
        });

        modelBuilder.Entity<BusinessPartner>(entity =>
        {
            entity.Property(e => e.BusinessPartnerName).HasDefaultValue("", "DF_BusinessPartner_BusinessPartnerName");
            entity.Property(e => e.ContactPerson1Name).HasDefaultValue("", "DF_BusinessPartner_ContactPerson1Name");
            entity.Property(e => e.ContactPerson1PhoneNo).HasDefaultValue("", "DF_BusinessPartner_ContactPerson1PhoneNo");
            entity.Property(e => e.ContactPerson2Name).HasDefaultValue("", "DF_BusinessPartner_ContactPerson2Name");
            entity.Property(e => e.ContactPerson2PhoneNo).HasDefaultValue("", "DF_BusinessPartner_ContactPerson2PhoneNo");
            entity.Property(e => e.Initial).HasDefaultValue("", "DF_BusinessPartner_Initial");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_BusinessPartner_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_BusinessPartner_Remarks");
            entity.Property(e => e.ShortName).HasDefaultValue("", "DF_BusinessPartner_ShortName");
            entity.Property(e => e.TaxRegistrantNo).HasDefaultValue("", "DF_BusinessPartner_TaxRegistrantNo");
        });

        modelBuilder.Entity<CHDAge>(entity =>
        {
            entity.HasKey(e => e.CHDAgeID).HasName("PK_CHDAge_1");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.CHDAge)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHDAge_sysGeneralCode");
        });

        modelBuilder.Entity<CHDBloodPressure>(entity =>
        {
            entity.HasOne(d => d.GCCHDBloodPressureValueNavigation).WithMany(p => p.CHDBloodPressureGCCHDBloodPressureValueNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHDBloodPressure_sysGeneralCode_BloodPressureValue");

            entity.HasOne(d => d.GCDiastolicValueNavigation).WithMany(p => p.CHDBloodPressureGCDiastolicValueNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHDBloodPressure_sysGeneralCode_DiastolicValue");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.CHDBloodPressureGCSexNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHDBloodPressure_sysGeneralCode_Sex");

            entity.HasOne(d => d.GCSystolicValueNavigation).WithMany(p => p.CHDBloodPressureGCSystolicValueNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHDBloodPressure_sysGeneralCode_SystolicValue");
        });

        modelBuilder.Entity<CHDPredictor>(entity =>
        {
            entity.HasKey(e => e.CHDPredictorID).HasName("PK_CHDPredictor_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_CHDPredictor_IsDeleted");

            entity.HasOne(d => d.GCCHDPredictorTypeNavigation).WithMany(p => p.CHDPredictorGCCHDPredictorTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHDPredictor_sysGeneralCode");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.CHDPredictorGCSexNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHDPredictor_sysGeneralCode1");
        });

        modelBuilder.Entity<CHDRisk>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_CHDRisk_IsDeleted");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.CHDRisk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHDRisk_sysGeneralCode");
        });

        modelBuilder.Entity<CalenderDt>(entity =>
        {
            entity.HasOne(d => d.Calender).WithMany(p => p.CalenderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CalenderDt_CalenderHd");

            entity.HasOne(d => d.WorkStationCodeNavigation).WithMany(p => p.CalenderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CalenderDt_WorkStation");
        });

        modelBuilder.Entity<CalenderHd>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.CalenderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CalenderHd_Site");
        });

        modelBuilder.Entity<Callibrations>(entity =>
        {
            entity.HasOne(d => d.Asset).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Callibrations_Assets");
        });

        modelBuilder.Entity<CancelPatientVisit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CancelPa__3214EC0714E37B5A");

            entity.HasOne(d => d.GCReasonNavigation).WithMany(p => p.CancelPatientVisit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CancelPat__GCRea__2649DACD");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.CancelPatientVisit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CancelPat__Param__2832233F");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.CancelPatientVisit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CancelPat__Servi__273DFF06");
        });

        modelBuilder.Entity<CashFlowStatement>(entity =>
        {
            entity.HasOne(d => d.CoaCodeNavigation).WithMany(p => p.CashFlowStatement).HasConstraintName("FK_CashFlowStatement_ChartOfAccount");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.CashFlowStatement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashFlowStatement_Site");

            entity.HasOne(d => d.FiscalPeriodDt).WithMany(p => p.CashFlowStatement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashFlowStatement_FiscalPeriodDt");
        });

        modelBuilder.Entity<CashFlowStatementDt>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.CashFlowStatementDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashFlowStatementDt_Site");

            entity.HasOne(d => d.FiscalPeriodDt).WithMany(p => p.CashFlowStatementDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CashFlowStatementDt_FiscalPeriodDt");
        });

        modelBuilder.Entity<CensusHistory>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.CensusDateTime, e.RegistrationNo, e.SequenceNo }).HasName("PK_Table_1");

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.CensusHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CensusHistory_Class");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.CensusHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CensusHistory_Registration");

            entity.HasOne(d => d.Room).WithMany(p => p.CensusHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CensusHistory_ServiceRoom");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.CensusHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CensusHistory_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.CensusHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CensusHistory_Site");

            entity.HasOne(d => d.SpecialityCodeNavigation).WithMany(p => p.CensusHistory).HasConstraintName("FK_CensusHistory_Specialty");
        });

        modelBuilder.Entity<ChartOfAccount>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ChartOfAccount_IsActive");
            entity.Property(e => e.IsCashFlow).HasDefaultValue(false, "DF_ChartOfAccount_IsCashFlow");
            entity.Property(e => e.NormalPosition).IsFixedLength();

            entity.HasOne(d => d.CoaHeaderCodeNavigation).WithMany(p => p.InverseCoaHeaderCodeNavigation).HasConstraintName("FK_ChartOfAccount_ChartOfAccount");

            entity.HasOne(d => d.GCAccountRecordGroupNavigation).WithMany(p => p.ChartOfAccountGCAccountRecordGroupNavigation).HasConstraintName("FK_ChartOfAccount_sysGeneralCode");

            entity.HasOne(d => d.GCAccountTypeNavigation).WithMany(p => p.ChartOfAccountGCAccountTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChartOfAccount_sysGeneralCode1");
        });

        modelBuilder.Entity<CheckPatientMedicationAndVitamin>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.CheckPatientMedicationAndVitamin).HasConstraintName("FK_CheckPatientMedicationAndVitamin_Registration");
        });

        modelBuilder.Entity<ChecklistPersiapanPasienRujukan>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_ChecklistPersiapanPasienRujukan_1");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.Property(e => e.Initial).HasDefaultValue("", "DF_Class_Initial");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Class_IsActive");

            entity.HasOne(d => d.ClassCategoryCodeNavigation).WithMany(p => p.Class)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Class_ClassCategory");

            entity.HasOne(d => d.GCClassRLNavigation).WithMany(p => p.Class).HasConstraintName("FK_Class_sysGeneralCode");

            entity.HasOne(d => d.PhysicianChargesItem).WithMany(p => p.Class).HasConstraintName("FK_Class_Item");
        });

        modelBuilder.Entity<ClassCategory>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ClassCategory_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_ClassCategory_Remarks");
        });

        modelBuilder.Entity<ClinicalPathwayDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ClinicalPathwayDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClinicalPathwayDt_Item");

            entity.HasOne(d => d.ClinicalPathwayHd).WithMany(p => p.ClinicalPathwayDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClinicalPathwayDt_ClinicalPathwayHd");
        });

        modelBuilder.Entity<ClinicalPathwayHd>(entity =>
        {
            entity.HasOne(d => d.GCGuidelineTypeNavigation).WithMany(p => p.ClinicalPathwayHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClinicalPathwayHd_sysGeneralCode");

            entity.HasOne(d => d.Guideline).WithMany(p => p.ClinicalPathwayHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClinicalPathwayHd_GuidelineHd");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.ClinicalPathwayHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClinicalPathwayHd_Registration");
        });

        modelBuilder.Entity<CoaByUnits>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_CoaByUnits_1");

            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<CompoundTemplateDt>(entity =>
        {
            entity.Property(e => e.RFlag).IsFixedLength();

            entity.HasOne(d => d.Item).WithMany(p => p.CompoundTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompoundTemplateDt_Item");

            entity.HasOne(d => d.TemplateCodeNavigation).WithMany(p => p.CompoundTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompoundTemplateDt_CompoundTemplateHd");
        });

        modelBuilder.Entity<CompoundTemplateHd>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_CompoundTemplateHd_IsActive");

            entity.HasOne(d => d.Embalace).WithMany(p => p.CompoundTemplateHd).HasConstraintName("FK_CompoundTemplateHd_EmbalaceHd");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.CompoundTemplateHd).HasConstraintName("FK_CompoundTemplateHd_Paramedic");
        });

        modelBuilder.Entity<Corporate>(entity =>
        {
            entity.Property(e => e.ContactPerson1).HasDefaultValue("", "DF_Corporate_ContactPerson1");
            entity.Property(e => e.ContactPerson2).HasDefaultValue("", "DF_Corporate_ContactPerson2");
            entity.Property(e => e.Initial).HasDefaultValue("", "DF_Corporate_Initial");
            entity.Property(e => e.ShortName).HasDefaultValue("", "DF_Corporate_ShortName");
            entity.Property(e => e.TaxRegistrantNo).HasDefaultValue("", "DF_Corporate_TaxRegistrantNo");
        });

        modelBuilder.Entity<CorporateItem>(entity =>
        {
            entity.HasOne(d => d.BusinessParter).WithMany(p => p.CorporateItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorporateItem_BusinessPartner");

            entity.HasOne(d => d.ItemIdHospitalNavigation).WithMany(p => p.CorporateItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorporateItem_Item");
        });

        modelBuilder.Entity<CorporateReference>(entity =>
        {
            entity.HasKey(e => e.CorporateReferenceID).HasName("PK_Table_5");

            entity.Property(e => e.CorporateReferenceID).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Table_5_IsActive");
        });

        modelBuilder.Entity<CreditNote>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.CreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNote_Supplier");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.CreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNote_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.CreditNote)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditNote_sysTransactionCode");
        });

        modelBuilder.Entity<CurrentPregnancy>(entity =>
        {
            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.CurrentPregnancy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrentPregnancy_Patient");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.BusinessPartnerID).ValueGeneratedNever();

            entity.HasOne(d => d.BusinessPartner).WithOne(p => p.Customer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_BusinessPartner");

            entity.HasOne(d => d.GCCustomerTypeNavigation).WithMany(p => p.CustomerGCCustomerTypeNavigation).HasConstraintName("FK_Customer_sysGeneralCode");

            entity.HasOne(d => d.GCInsuranceTypeNavigation).WithMany(p => p.CustomerGCInsuranceTypeNavigation).HasConstraintName("FK_Customer_sysGeneralCode1");
        });

        modelBuilder.Entity<CustomerAkomodasiKamar>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.CustomerAkomodasiKamar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerAkomodasiKamar_BusinessPartner");

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.CustomerAkomodasiKamar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerAkomodasiKamar_Class");

            entity.HasOne(d => d.Item).WithMany(p => p.CustomerAkomodasiKamar).HasConstraintName("FK_CustomerAkomodasiKamar_Item");
        });

        modelBuilder.Entity<CustomerBank>(entity =>
        {
            entity.HasKey(e => e.CustomerBankId).HasName("PK__Customer__2F647FFE35AFC157");

            entity.HasOne(d => d.Bank).WithMany(p => p.CustomerBank)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CustomerB__BankI__7E11CC41");

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.CustomerBank)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CustomerB__Busin__7D1DA808");
        });

        modelBuilder.Entity<CustomerClass>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.CustomerClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerClass_BusinessPartner");

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.CustomerClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerClass_Class");
        });

        modelBuilder.Entity<CustomerContract>(entity =>
        {
            entity.Property(e => e.RevisionNo).IsFixedLength();

            entity.HasOne(d => d.BillToBusinessPartner).WithMany(p => p.CustomerContractBillToBusinessPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerContract_Customer1");

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.CustomerContractBusinessPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerContract_Customer");

            entity.HasOne(d => d.GCCoverageTypeNavigation).WithMany(p => p.CustomerContractGCCoverageTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerContract_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.CustomerContract).HasConstraintName("FK_CustomerContract_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.CustomerContract).HasConstraintName("FK_CustomerContract_sysTransactionCode");
        });

        modelBuilder.Entity<CustomerContractClass>(entity =>
        {
            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.CustomerContractClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerContractClass_Class");

            entity.HasOne(d => d.DocumentNoNavigation).WithMany(p => p.CustomerContractClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerContractClass_CustomerContract");
        });

        modelBuilder.Entity<CustomerHd>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CustomerItem>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.CustomerItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerItem_BusinessPartner");

            entity.HasOne(d => d.Item).WithMany(p => p.CustomerItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerItem_Item");
        });

        modelBuilder.Entity<CustomerItemPRB>(entity =>
        {
            entity.HasKey(e => new { e.BusinessPartnerID, e.ItemID }).HasName("PK_CustomerItemPRB_2");
        });

        modelBuilder.Entity<CustomerParamedic>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.CustomerParamedic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerParamedic_BusinessPartner");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.CustomerParamedic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerParamedic_Paramedic");
        });

        modelBuilder.Entity<CustomerReferal>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.CustomerReferal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerReferal_BusinessPartner");

            entity.HasOne(d => d.Referral).WithMany(p => p.CustomerReferal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerReferal_Referral");
        });

        modelBuilder.Entity<CustomerServiceUnit>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.CustomerServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerServiceUnit_BusinessPartner");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.CustomerServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerServiceUnit_ServiceUnit");
        });

        modelBuilder.Entity<CustomerSpeciality>(entity =>
        {
            entity.HasKey(e => new { e.BusinessPartnerID, e.SpecialtyCode }).HasName("PK_CustomerSpeciality_1");
        });

        modelBuilder.Entity<DTD>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_DTD_IsActive");
        });

        modelBuilder.Entity<DW_DimABCClass>(entity =>
        {
            entity.Property(e => e.ABCClass).IsFixedLength();
        });

        modelBuilder.Entity<DW_DimCustomer>(entity =>
        {
            entity.HasOne(d => d.CustomerType).WithMany(p => p.DW_DimCustomer).HasConstraintName("FK_DW_DimCustomer_DW_DimCustomerType");
        });

        modelBuilder.Entity<DW_DimDate>(entity =>
        {
            entity.HasKey(e => e.DateID).HasName("PK_DW_MasterDate");

            entity.Property(e => e.DateID).ValueGeneratedNever();
        });

        modelBuilder.Entity<DW_DimItem>(entity =>
        {
            entity.HasOne(d => d.ABCClass).WithMany(p => p.DW_DimItem).HasConstraintName("FK_DW_DimItem_DW_DimABCClass");

            entity.HasOne(d => d.ItemGroup).WithMany(p => p.DW_DimItem).HasConstraintName("FK_DW_DimItem_DW_DimItemGroup");

            entity.HasOne(d => d.ItemType).WithMany(p => p.DW_DimItem).HasConstraintName("FK_DW_DimItem_DW_DimItemType");
        });

        modelBuilder.Entity<DW_DimParamedic>(entity =>
        {
            entity.HasOne(d => d.EmploymentStatus).WithMany(p => p.DW_DimParamedic).HasConstraintName("FK_DW_DimParamedic_DW_DimEmploymentStatus");

            entity.HasOne(d => d.Nationality).WithMany(p => p.DW_DimParamedic).HasConstraintName("FK_DW_DimParamedic_DW_DimNationality");

            entity.HasOne(d => d.ParamedicType).WithMany(p => p.DW_DimParamedic).HasConstraintName("FK_DW_DimParamedic_DW_DimParamedicType");

            entity.HasOne(d => d.Sex).WithMany(p => p.DW_DimParamedic).HasConstraintName("FK_DW_DimParamedic_DW_DimSex");

            entity.HasOne(d => d.Specialty).WithMany(p => p.DW_DimParamedic).HasConstraintName("FK_DW_DimParamedic_DW_DimSpecialty");
        });

        modelBuilder.Entity<DW_DimPatient>(entity =>
        {
            entity.HasOne(d => d.DateOfDeath).WithMany(p => p.DW_DimPatient).HasConstraintName("FK_DW_DimPatient_DW_DimDate");

            entity.HasOne(d => d.Education).WithMany(p => p.DW_DimPatient).HasConstraintName("FK_DW_DimPatient_DW_DimEducation");

            entity.HasOne(d => d.MaritalStatus).WithMany(p => p.DW_DimPatient).HasConstraintName("FK_DW_DimPatient_DW_DimMaritalStatus");

            entity.HasOne(d => d.Nationality).WithMany(p => p.DW_DimPatient).HasConstraintName("FK_DW_DimPatient_DW_DimNationality");

            entity.HasOne(d => d.Occupation).WithMany(p => p.DW_DimPatient).HasConstraintName("FK_DW_DimPatient_DW_DimOccupation");

            entity.HasOne(d => d.Race).WithMany(p => p.DW_DimPatient).HasConstraintName("FK_DW_DimPatient_DW_DimRace");

            entity.HasOne(d => d.Religion).WithMany(p => p.DW_DimPatient).HasConstraintName("FK_DW_DimPatient_DW_DimReligion");

            entity.HasOne(d => d.Sex).WithMany(p => p.DW_DimPatient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_DimPatient_DW_DimSex");

            entity.HasOne(d => d.TimeOfDeath).WithMany(p => p.DW_DimPatient).HasConstraintName("FK_DW_DimPatient_DW_DimTime");
        });

        modelBuilder.Entity<DW_DimSpecialty>(entity =>
        {
            entity.HasOne(d => d.SpecialtyGroup).WithMany(p => p.DW_DimSpecialty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_DimSpecialty_DW_DimSpecialtyGroup");
        });

        modelBuilder.Entity<DW_DimSupplier>(entity =>
        {
            entity.HasOne(d => d.SupplierType).WithMany(p => p.DW_DimSupplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_DimSupplier_DW_DimSupplierType");
        });

        modelBuilder.Entity<DW_DimTime>(entity =>
        {
            entity.HasKey(e => e.TimeID).HasName("PK_DimTime_TimeKey");

            entity.Property(e => e.TimeID).ValueGeneratedNever();
            entity.Property(e => e.AMPM).IsFixedLength();
        });

        modelBuilder.Entity<DW_FactAPMovement>(entity =>
        {
            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactAPMovement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactAPMovement_DW_DimSiteCode");

            entity.HasOne(d => d.Supplier).WithMany(p => p.DW_FactAPMovement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactAPMovement_DW_DimSupplier");

            entity.HasOne(d => d.TransactionDate).WithMany(p => p.DW_FactAPMovement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactAPMovement_DW_DimDate");

            entity.HasOne(d => d.TransactionDateTime).WithMany(p => p.DW_FactAPMovement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactAPMovement_DW_DimTime");
        });

        modelBuilder.Entity<DW_FactBalanceStock>(entity =>
        {
            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactBalanceStock)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBalanceStock_DW_DimDate");

            entity.HasOne(d => d.Item).WithMany(p => p.DW_FactBalanceStock)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBalanceStock_DW_DimItem");

            entity.HasOne(d => d.ItemUnit).WithMany(p => p.DW_FactBalanceStock)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBalanceStock_DW_DimItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.DW_FactBalanceStock)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBalanceStock_DW_DimLocation");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactBalanceStock)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBalanceStock_DW_DimSiteCode");
        });

        modelBuilder.Entity<DW_FactBedCensus>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_DW_BedCencus");

            entity.HasOne(d => d.Bed).WithMany(p => p.DW_FactBedCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBedCensus_DW_DimBed");

            entity.HasOne(d => d.BedStatus).WithMany(p => p.DW_FactBedCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBedCensus_DW_DimBedStatus");

            entity.HasOne(d => d.Class).WithMany(p => p.DW_FactBedCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBedCensus_DW_DimClass");

            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactBedCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_BedCencus_DW_MasterDate");

            entity.HasOne(d => d.Department).WithMany(p => p.DW_FactBedCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBedCensus_DW_DimDepartment");

            entity.HasOne(d => d.Room).WithMany(p => p.DW_FactBedCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBedCensus_DW_DimServiceRoom");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.DW_FactBedCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBedCensus_DW_DimServiceUnit");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactBedCensus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactBedCensus_DW_DimSiteCode");
        });

        modelBuilder.Entity<DW_FactFEFOIn>(entity =>
        {
            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactFEFOInDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOIn_DW_DimDate");

            entity.HasOne(d => d.Item).WithMany(p => p.DW_FactFEFOIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOIn_DW_DimItem");

            entity.HasOne(d => d.ItemUnit).WithMany(p => p.DW_FactFEFOIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOIn_DW_DimItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.DW_FactFEFOIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOIn_DW_DimLocation");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactFEFOIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOIn_DW_DimSiteCode");

            entity.HasOne(d => d.TransactionDate).WithMany(p => p.DW_FactFEFOInTransactionDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOIn_DW_DimDate1");

            entity.HasOne(d => d.TransactionDateTime).WithMany(p => p.DW_FactFEFOIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOIn_DW_DimTime");
        });

        modelBuilder.Entity<DW_FactFEFOInPeriode>(entity =>
        {
            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactFEFOInPeriodeDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOInPeriode_DW_DimDate");

            entity.HasOne(d => d.Item).WithMany(p => p.DW_FactFEFOInPeriode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOInPeriode_DW_DimItem");

            entity.HasOne(d => d.ItemUnit).WithMany(p => p.DW_FactFEFOInPeriode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOInPeriode_DW_DimItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.DW_FactFEFOInPeriode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOInPeriode_DW_DimLocation");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactFEFOInPeriode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOInPeriode_DW_DimSiteCode");

            entity.HasOne(d => d.TransactionDate).WithMany(p => p.DW_FactFEFOInPeriodeTransactionDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOInPeriode_DW_DimDate1");

            entity.HasOne(d => d.TransactionDateTime).WithMany(p => p.DW_FactFEFOInPeriode).HasConstraintName("FK_DW_FactFEFOInPeriode_DW_DimTime");
        });

        modelBuilder.Entity<DW_FactFEFOOut>(entity =>
        {
            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactFEFOOutDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOOut_DW_DimDate");

            entity.HasOne(d => d.Item).WithMany(p => p.DW_FactFEFOOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOOut_DW_DimItem");

            entity.HasOne(d => d.ItemUnit).WithMany(p => p.DW_FactFEFOOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOOut_DW_DimItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.DW_FactFEFOOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOOut_DW_DimLocation");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactFEFOOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOOut_DW_DimSiteCode");

            entity.HasOne(d => d.TransactionDate).WithMany(p => p.DW_FactFEFOOutTransactionDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFEFOOut_DW_DimDate1");

            entity.HasOne(d => d.TransactionDateTime).WithMany(p => p.DW_FactFEFOOut).HasConstraintName("FK_DW_FactFEFOOut_DW_DimTime");
        });

        modelBuilder.Entity<DW_FactFIFOIn>(entity =>
        {
            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactFIFOInDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOIn_DW_DimDate");

            entity.HasOne(d => d.Item).WithMany(p => p.DW_FactFIFOIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOIn_DW_DimItem");

            entity.HasOne(d => d.ItemUnit).WithMany(p => p.DW_FactFIFOIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOIn_DW_DimItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.DW_FactFIFOIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOIn_DW_DimLocation");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactFIFOIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOIn_DW_DimSiteCode");

            entity.HasOne(d => d.TransactionDate).WithMany(p => p.DW_FactFIFOInTransactionDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOIn_DW_DimDate1");

            entity.HasOne(d => d.TransactionDateTime).WithMany(p => p.DW_FactFIFOIn).HasConstraintName("FK_DW_FactFIFOIn_DW_DimTime");
        });

        modelBuilder.Entity<DW_FactFIFOInPeriode>(entity =>
        {
            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactFIFOInPeriodeDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOInPeriode_DW_DimDate");

            entity.HasOne(d => d.Item).WithMany(p => p.DW_FactFIFOInPeriode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOInPeriode_DW_DimItem");

            entity.HasOne(d => d.ItemUnit).WithMany(p => p.DW_FactFIFOInPeriode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOInPeriode_DW_DimItemUnit");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactFIFOInPeriode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOInPeriode_DW_DimSite");

            entity.HasOne(d => d.TransactionDate).WithMany(p => p.DW_FactFIFOInPeriodeTransactionDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOInPeriode_DW_DimTransactionDateID");

            entity.HasOne(d => d.TransactionDateTime).WithMany(p => p.DW_FactFIFOInPeriode).HasConstraintName("FK_DW_FactFIFOInPeriode_DW_DimTime");
        });

        modelBuilder.Entity<DW_FactFIFOOut>(entity =>
        {
            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactFIFOOutDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOOut_DW_DimDate");

            entity.HasOne(d => d.Item).WithMany(p => p.DW_FactFIFOOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOOut_DW_DimItem");

            entity.HasOne(d => d.ItemUnit).WithMany(p => p.DW_FactFIFOOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOOut_DW_DimItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.DW_FactFIFOOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOOut_DW_DimLocation");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactFIFOOut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOOut_DW_DimSiteCode");

            entity.HasOne(d => d.TransactionDate).WithMany(p => p.DW_FactFIFOOutTransactionDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactFIFOOut_DW_DimDate1");

            entity.HasOne(d => d.TransactionDateTime).WithMany(p => p.DW_FactFIFOOut).HasConstraintName("FK_DW_FactFIFOOut_DW_DimTime");
        });

        modelBuilder.Entity<DW_FactMaterialCost>(entity =>
        {
            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactMaterialCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMaterialCost_DW_DimDate");

            entity.HasOne(d => d.Item).WithMany(p => p.DW_FactMaterialCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMaterialCost_DW_DimItem");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactMaterialCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMaterialCost_DW_DimSiteCode");

            entity.HasOne(d => d.Time).WithMany(p => p.DW_FactMaterialCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMaterialCost_DW_DimTime");
        });

        modelBuilder.Entity<DW_FactMedicalRecordFinance>(entity =>
        {
            entity.Property(e => e.Case).HasDefaultValue(1, "DF_DW_FactMedicalRecordFinance_Case");

            entity.HasOne(d => d.AgeGroup).WithMany(p => p.DW_FactMedicalRecordFinance)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimAgeGroup");

            entity.HasOne(d => d.ChargeClass).WithMany(p => p.DW_FactMedicalRecordFinanceChargeClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimClass1");

            entity.HasOne(d => d.Class).WithMany(p => p.DW_FactMedicalRecordFinanceClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimClass");

            entity.HasOne(d => d.ClosedDate).WithMany(p => p.DW_FactMedicalRecordFinanceClosedDate).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDate2");

            entity.HasOne(d => d.Customer).WithMany(p => p.DW_FactMedicalRecordFinance)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimCustomer");

            entity.HasOne(d => d.Department).WithMany(p => p.DW_FactMedicalRecordFinance)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDepartment");

            entity.HasOne(d => d.DischargeCondition).WithMany(p => p.DW_FactMedicalRecordFinance).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDischargeCondition");

            entity.HasOne(d => d.DischargeDate).WithMany(p => p.DW_FactMedicalRecordFinanceDischargeDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDate");

            entity.HasOne(d => d.DischargeMethod).WithMany(p => p.DW_FactMedicalRecordFinance).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDischargeMethod");

            entity.HasOne(d => d.ERCaseType).WithMany(p => p.DW_FactMedicalRecordFinance).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimERCaseType");

            entity.HasOne(d => d.ICD1Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceICD1Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDiagnosis");

            entity.HasOne(d => d.ICD2Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceICD2Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDiagnosis1");

            entity.HasOne(d => d.ICD3Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceICD3Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDiagnosis2");

            entity.HasOne(d => d.ICD4Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceICD4Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDiagnosis3");

            entity.HasOne(d => d.ICD5Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceICD5Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDiagnosis4");

            entity.HasOne(d => d.OriginPatient).WithMany(p => p.DW_FactMedicalRecordFinance).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimOriginPatient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.DW_FactMedicalRecordFinance).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimParamedic");

            entity.HasOne(d => d.Patient).WithMany(p => p.DW_FactMedicalRecordFinance)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimPatient");

            entity.HasOne(d => d.ProcedureID1Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceProcedureID1Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimProcedures");

            entity.HasOne(d => d.ProcedureID2Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceProcedureID2Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimProcedures1");

            entity.HasOne(d => d.ProcedureID3Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceProcedureID3Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimProcedures2");

            entity.HasOne(d => d.ProcedureID4Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceProcedureID4Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimProcedures3");

            entity.HasOne(d => d.ProcedureID5Navigation).WithMany(p => p.DW_FactMedicalRecordFinanceProcedureID5Navigation).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimProcedures4");

            entity.HasOne(d => d.ReferralTypeFrom).WithMany(p => p.DW_FactMedicalRecordFinanceReferralTypeFrom).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimReferralType");

            entity.HasOne(d => d.ReferralTypeTo).WithMany(p => p.DW_FactMedicalRecordFinanceReferralTypeTo).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimReferralType1");

            entity.HasOne(d => d.RegistrationDate).WithMany(p => p.DW_FactMedicalRecordFinanceRegistrationDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimDate1");

            entity.HasOne(d => d.Room).WithMany(p => p.DW_FactMedicalRecordFinance).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimServiceRoom");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.DW_FactMedicalRecordFinance)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimServiceUnit");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactMedicalRecordFinance)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimSiteCode");

            entity.HasOne(d => d.Triage).WithMany(p => p.DW_FactMedicalRecordFinance).HasConstraintName("FK_DW_FactMedicalRecordFinance_DW_DimTriage");
        });

        modelBuilder.Entity<DW_FactPharmacySales>(entity =>
        {
            entity.HasOne(d => d.Date).WithMany(p => p.DW_FactPharmacySales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactPharmacySales_DW_DimDate");

            entity.HasOne(d => d.Item).WithMany(p => p.DW_FactPharmacySales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactPharmacySales_DW_DimItem");

            entity.HasOne(d => d.ItemPlanning).WithMany(p => p.DW_FactPharmacySales).HasConstraintName("FK_DW_FactPharmacySales_DW_DimItemPlanning");

            entity.HasOne(d => d.ItemUnit).WithMany(p => p.DW_FactPharmacySales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactPharmacySales_DW_DimItemUnit");

            entity.HasOne(d => d.Site).WithMany(p => p.DW_FactPharmacySales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DW_FactPharmacySales_DW_DimSiteCode");
        });

        modelBuilder.Entity<DW_JobHistory>(entity =>
        {
            entity.HasKey(e => new { e.PackageName, e.ExecuteDateTime }).HasName("PK_DW_JobHistory_1");
        });

        modelBuilder.Entity<DaySubstitute>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.DaySubstitute)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DaySubstitute_Employee");

            entity.HasOne(d => d.ScheduleShiftCodeNavigation).WithMany(p => p.DaySubstituteScheduleShiftCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DaySubstitute_WorkShiftHrd");

            entity.HasOne(d => d.SubstituteShiftCodeNavigation).WithMany(p => p.DaySubstituteSubstituteShiftCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DaySubstitute_WorkShiftHrd1");
        });

        modelBuilder.Entity<DebitNoteCreditNoteDt>(entity =>
        {
            entity.HasKey(e => new { e.DNCNNo, e.DNCNSequenceNo }).HasName("PK_DebitNoteCreditNoteDt_1");

            entity.HasOne(d => d.DNCNNoNavigation).WithMany(p => p.DebitNoteCreditNoteDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCreditNoteDt_DebitNoteCreditNoteHd");

            entity.HasOne(d => d.Item).WithMany(p => p.DebitNoteCreditNoteDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCreditNoteDt_Item");

            entity.HasOne(d => d.TransactionChargesDt).WithMany(p => p.DebitNoteCreditNoteDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCreditNoteDt_TransactionChargesDt");
        });

        modelBuilder.Entity<DebitNoteCreditNoteHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.DebitNoteCreditNoteHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCreditNoteHd_BusinessPartner");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.DebitNoteCreditNoteHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCreditNoteHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.DebitNoteCreditNoteHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCreditNoteHd_Site");

            entity.HasOne(d => d.TermCodeNavigation).WithMany(p => p.DebitNoteCreditNoteHd).HasConstraintName("FK_DebitNoteCreditNoteHd_Term");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DebitNoteCreditNoteHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCreditNoteHd_sysTransactionCode");
        });

        modelBuilder.Entity<DebitNoteCreditNoteHdReverse>(entity =>
        {
            entity.HasOne(d => d.DNCNNoNavigation).WithMany(p => p.DebitNoteCreditNoteHdReverse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCreditNoteHdReverse_DebitNoteCreditNoteHd");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DebitNoteCreditNoteHdReverse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitNoteCreditNoteHdReverse_sysTransactionCode");
        });

        modelBuilder.Entity<DedikasiDataPengukuran>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_DedikasiDataPengukuran_IsDeleted");
        });

        modelBuilder.Entity<DedikasiDataPertanyaan>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_DedikasiDataPertanyaan_IsDeleted");
        });

        modelBuilder.Entity<DedikasiDataTindakLanjut>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_DedikasiDataTindakLanjut_IsDeleted");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tr_Department_InitialNotEmpty");
                    tb.HasTrigger("tr_Department_InitialNotEmpty2");
                });

            entity.Property(e => e.Initial).HasDefaultValue("", "DF_Department_Initial");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Table_1_IsDeleted");
            entity.Property(e => e.ShortName).HasDefaultValue("", "DF_Department_ShortName");
        });

        modelBuilder.Entity<DepartmentServiceUnit>(entity =>
        {
            entity.Property(e => e.ContactPerson1).HasDefaultValue("", "DF_DepartmentServiceUnit_ContactPerson1");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_DepartmentServiceUnit_IsActive");

            entity.HasOne(d => d.GcDefaultOrderTypeNavigation).WithMany(p => p.DepartmentServiceUnit).HasConstraintName("FK_DepartmentServiceUnit_sysGeneralCode");

            entity.HasOne(d => d.Location).WithMany(p => p.DepartmentServiceUnit).HasConstraintName("FK_DepartmentServiceUnit_Location");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.DepartmentServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartmentServiceUnit_ServiceUnit");

            entity.HasOne(d => d.SiteDepartment).WithMany(p => p.DepartmentServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartmentServiceUnit_SiteDepartment");
        });

        modelBuilder.Entity<DepartmentServiceUnitParameterDt>(entity =>
        {
            entity.HasOne(d => d.ParameterCodeNavigation).WithMany(p => p.DepartmentServiceUnitParameterDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartmentServiceUnitParameterDt_DepartmentServiceUnitParameterHd");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.DepartmentServiceUnitParameterDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartmentServiceUnitParameterDt_DepartmentServiceUnit");
        });

        modelBuilder.Entity<DepositPaymentDt>(entity =>
        {
            entity.HasOne(d => d.Bank).WithMany(p => p.DepositPaymentDt).HasConstraintName("FK_DepositPaymentDt_Bank");

            entity.HasOne(d => d.DepositNoNavigation).WithMany(p => p.DepositPaymentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepositPaymentDt_DepositPaymentHd");

            entity.HasOne(d => d.GCCardProviderNavigation).WithMany(p => p.DepositPaymentDtGCCardProviderNavigation).HasConstraintName("FK_DepositPaymentDt_sysGeneralCode_CardProvider");

            entity.HasOne(d => d.GCCardTypeNavigation).WithMany(p => p.DepositPaymentDtGCCardTypeNavigation).HasConstraintName("FK_DepositPaymentDt_sysGeneralCode_CardType");

            entity.HasOne(d => d.GCPaymentMethodNavigation).WithMany(p => p.DepositPaymentDtGCPaymentMethodNavigation).HasConstraintName("FK_DepositPaymentDt_sysGeneralCode_PaymentMethod");
        });

        modelBuilder.Entity<DepositPaymentDtReverse>(entity =>
        {
            entity.HasOne(d => d.DepositNoNavigation).WithMany(p => p.DepositPaymentDtReverse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepositPaymentDtReverse_DepositPaymentHd");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DepositPaymentDtReverse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepositPaymentDtReverse_sysTransactionCode");
        });

        modelBuilder.Entity<DepositPaymentHd>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.DepositPaymentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepositPaymentHd_Registration");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.DepositPaymentHd).HasConstraintName("FK_DepositPaymentHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.DepositPaymentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepositPaymentHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DepositPaymentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepositPaymentHd_sysTransactionCode");
        });

        modelBuilder.Entity<DetailDataPMKP>(entity =>
        {
            entity.Property(e => e.Deminator).IsFixedLength();
            entity.Property(e => e.DeminatorName).IsFixedLength();
            entity.Property(e => e.GroupType).IsFixedLength();
            entity.Property(e => e.IndikatorName).IsFixedLength();
            entity.Property(e => e.NominatorName).IsFixedLength();
            entity.Property(e => e.RealisasiBy).IsFixedLength();
            entity.Property(e => e.TargetBy).IsFixedLength();
        });

        modelBuilder.Entity<Diagnosis>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Diagnosis_IsActive");

            entity.HasOne(d => d.DTDNoNavigation).WithMany(p => p.Diagnosis).HasConstraintName("FK_Diagnosis_DTD");

            entity.HasOne(d => d.ICDBlock).WithMany(p => p.Diagnosis).HasConstraintName("FK_Diagnosis_ICDBlock");

            entity.HasOne(d => d.InfectiousDiseaseCodeNavigation).WithMany(p => p.Diagnosis).HasConstraintName("FK_Diagnosis_InfectiousDisease");
        });

        modelBuilder.Entity<DiagnosisMostFrequent>(entity =>
        {
            entity.HasOne(d => d.DiagnosisCodeNavigation).WithMany(p => p.DiagnosisMostFrequent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiagnosisMostFrequent_Diagnosis");
        });

        modelBuilder.Entity<DiagnosisTB>(entity =>
        {
            entity.HasOne(d => d.DTDNoNavigation).WithMany(p => p.DiagnosisTB).HasConstraintName("FK_DiagnosisTB_DTD");

            entity.HasOne(d => d.ICDBlock).WithMany(p => p.DiagnosisTB).HasConstraintName("FK_DiagnosisTB_ICDBlock");

            entity.HasOne(d => d.InfectiousDiseaseCodeNavigation).WithMany(p => p.DiagnosisTB).HasConstraintName("FK_DiagnosisTB_InfectiousDisease");
        });

        modelBuilder.Entity<DietMonitoringDt>(entity =>
        {
            entity.HasKey(e => new { e.DietMonitoringId, e.SequenceNo }).HasName("PK_DietMonitoringDt_1");
        });

        modelBuilder.Entity<DietNutrient>(entity =>
        {
            entity.HasOne(d => d.GCCoffeeConsumptionNavigation).WithMany(p => p.DietNutrientGCCoffeeConsumptionNavigation).HasConstraintName("FK_DietNutrient_sysGeneralCode_GCCoffeConsumption");

            entity.HasOne(d => d.GCMilkConsumptionNavigation).WithMany(p => p.DietNutrientGCMilkConsumptionNavigation).HasConstraintName("FK_DietNutrient_sysGeneralCode_MilkConsumption");

            entity.HasOne(d => d.GCTeaConsumptionNavigation).WithMany(p => p.DietNutrientGCTeaConsumptionNavigation).HasConstraintName("FK_DietNutrient_sysGeneralCode_TeaConsumption");

            entity.HasOne(d => d.GCVegetarianNavigation).WithMany(p => p.DietNutrientGCVegetarianNavigation).HasConstraintName("FK_DietNutrient_sysGeneralCode_Vegetarian");

            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.DietNutrient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DietNutrient_Registration");
        });

        modelBuilder.Entity<DietNutrientHistory>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_Table_4_1");
        });

        modelBuilder.Entity<DirectPurchaseDt>(entity =>
        {
            entity.HasOne(d => d.DirectPurchaseNoNavigation).WithMany(p => p.DirectPurchaseDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DirectPurchaseDt_DirectPurchaseHd");

            entity.HasOne(d => d.Item).WithMany(p => p.DirectPurchaseDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DirectPurchaseDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.DirectPurchaseDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DirectPurchaseDt_ItemUnit");
        });

        modelBuilder.Entity<DirectPurchaseHd>(entity =>
        {
            entity.Property(e => e.Supplier).HasDefaultValue("", "DF_DirectPurchaseHd_Supplier");

            entity.HasOne(d => d.Location).WithMany(p => p.DirectPurchaseHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DirectPurchaseHd_Location");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.DirectPurchaseHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DirectPurchaseHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.DirectPurchaseHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DirectPurchaseHd_Site");

            entity.HasOne(d => d.SiteDepartment).WithMany(p => p.DirectPurchaseHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DirectPurchaseHd_SiteDepartment");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DirectPurchaseHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DirectPurchaseHd_sysTransactionCode");
        });

        modelBuilder.Entity<DiscountPhysician>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.DiscountPhysician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountPhysician_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.DiscountPhysician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountPhysician_Registration");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.DiscountPhysician).HasConstraintName("FK_DiscountPhysician_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.DiscountPhysician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountPhysician_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DiscountPhysician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountPhysician_sysTransactionCode");
        });

        modelBuilder.Entity<DiscountPhysicianReverse>(entity =>
        {
            entity.HasOne(d => d.DiscountPhysicianNoNavigation).WithMany(p => p.DiscountPhysicianReverse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountPhysicianReverse_DiscountPhysician");

            entity.HasOne(d => d.PaymentNoNavigation).WithMany(p => p.DiscountPhysicianReverse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountPhysicianReverse_AccountReceivablePaymentHd");
        });

        modelBuilder.Entity<DistributionOrderDt>(entity =>
        {
            entity.HasOne(d => d.DistributionOrderNoNavigation).WithMany(p => p.DistributionOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderDt_DistributionOrderHd");

            entity.HasOne(d => d.Item).WithMany(p => p.DistributionOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.DistributionOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderDt_ItemUnit");
        });

        modelBuilder.Entity<DistributionOrderHd>(entity =>
        {
            entity.Property(e => e.IsReviewed).HasDefaultValue(false, "DF_DistributionOrderHd_IsReviewed");

            entity.HasOne(d => d.FromLocation).WithMany(p => p.DistributionOrderHdFromLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderHd_Location");

            entity.HasOne(d => d.FromServiceUnit).WithMany(p => p.DistributionOrderHdFromServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderHd_DepartmentServiceUnit_FromServiceUnit");

            entity.HasOne(d => d.FromSiteCodeNavigation).WithMany(p => p.DistributionOrderHdFromSiteCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderHd_Site_FromSite");

            entity.HasOne(d => d.FromSiteDepartment).WithMany(p => p.DistributionOrderHdFromSiteDepartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderHd_SiteDepartment_FromSiteDepartment");

            entity.HasOne(d => d.GCDistributionOrderTypeNavigation).WithMany(p => p.DistributionOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderHd_sysGeneralCode");

            entity.HasOne(d => d.ToLocation).WithMany(p => p.DistributionOrderHdToLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderHd_Location1");

            entity.HasOne(d => d.ToServiceUnit).WithMany(p => p.DistributionOrderHdToServiceUnit).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToSiteCodeNavigation).WithMany(p => p.DistributionOrderHdToSiteCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToSiteDepartment).WithMany(p => p.DistributionOrderHdToSiteDepartment).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DistributionOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderHd_sysTransactionCode");
        });

        modelBuilder.Entity<DistributionOrderLocationTemplate>(entity =>
        {
            entity.HasOne(d => d.FromLocation).WithMany(p => p.DistributionOrderLocationTemplateFromLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderLocationTemplate_Location");

            entity.HasOne(d => d.ToLocation).WithMany(p => p.DistributionOrderLocationTemplateToLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderLocationTemplate_Location1");
        });

        modelBuilder.Entity<DistributionOrderPlanned>(entity =>
        {
            entity.HasOne(d => d.FromLocation).WithMany(p => p.DistributionOrderPlannedFromLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderPlanned_Location_FromLocation");

            entity.HasOne(d => d.FromServiceUnit).WithMany(p => p.DistributionOrderPlannedFromServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderPlanned_DepartmentServiceUnit_FromServiceUnit");

            entity.HasOne(d => d.FromSiteCodeNavigation).WithMany(p => p.DistributionOrderPlannedFromSiteCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromSiteDepartment).WithMany(p => p.DistributionOrderPlannedFromSiteDepartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderPlanned_DepartmentServiceUnit_FromSiteDepartmentID");

            entity.HasOne(d => d.Item).WithMany(p => p.DistributionOrderPlanned)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderPlanned_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.DistributionOrderPlanned)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DistributionOrderPlanned_ItemUnit");

            entity.HasOne(d => d.ToServiceUnit).WithMany(p => p.DistributionOrderPlannedToServiceUnit).HasConstraintName("FK_DistributionOrderPlanned_DepartmentServiceUnit_ToServiceUnit");
        });

        modelBuilder.Entity<DownPaymentDt>(entity =>
        {
            entity.HasOne(d => d.DownPaymentNoNavigation).WithMany(p => p.DownPaymentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DownPaymentDt_DownPaymentHd");
        });

        modelBuilder.Entity<DownPaymentHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.DownPaymentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DownPaymentHd_BusinessPartner");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.DownPaymentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DownPaymentHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DownPaymentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DownPaymentHd_sysTransactionCode");
        });

        modelBuilder.Entity<DownPaymentReverse>(entity =>
        {
            entity.HasOne(d => d.APAccrualNoNavigation).WithMany(p => p.DownPaymentReverse).HasConstraintName("FK_DownPaymentReverse_AccountPayableAccrual");

            entity.HasOne(d => d.APNoNavigation).WithMany(p => p.DownPaymentReverse).HasConstraintName("FK_DownPaymentReverse_AccountPayableHd");

            entity.HasOne(d => d.DownPaymentNoNavigation).WithMany(p => p.DownPaymentReverse).HasConstraintName("FK_DownPaymentReverse_DownPaymentHd");
        });

        modelBuilder.Entity<DrugAdministration>(entity =>
        {
            entity.HasKey(e => new { e.JobOrderNo, e.SequenceNo, e.ItemID, e.AdministrationDateTime }).HasName("PK_DrugAdministration_1");

            entity.Property(e => e.IsContinueUDD).HasDefaultValue(false, "DF_DrugAdministration_IsContinueUDD");

            entity.HasOne(d => d.GCDrugStatusNavigation).WithMany(p => p.DrugAdministration).HasConstraintName("FK_DrugAdministration_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.DrugAdministration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugAdministration_Item");

            entity.HasOne(d => d.JobOrderDtMedication).WithMany(p => p.DrugAdministration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugAdministration_JobOrderDtMedication");
        });

        modelBuilder.Entity<DrugDispensingDt>(entity =>
        {
            entity.Property(e => e.RFlag).IsFixedLength();

            entity.HasOne(d => d.ConsumeUnitNavigation).WithMany(p => p.DrugDispensingDt).HasConstraintName("FK_DrugDispensingDt_ItemUnit");

            entity.HasOne(d => d.DrugDispensingNoNavigation).WithMany(p => p.DrugDispensingDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugDispensingDt_DrugDispensingHd");

            entity.HasOne(d => d.Embalace).WithMany(p => p.DrugDispensingDt).HasConstraintName("FK_DrugDispensingDt_EmbalaceHd");

            entity.HasOne(d => d.GCDrugTypeNavigation).WithMany(p => p.DrugDispensingDtGCDrugTypeNavigation).HasConstraintName("FK_DrugDispensingDt_sysGeneralCode1");

            entity.HasOne(d => d.GCRouteNavigation).WithMany(p => p.DrugDispensingDtGCRouteNavigation).HasConstraintName("FK_DrugDispensingDt_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.DrugDispensingDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugDispensingDt_Item");

            entity.HasOne(d => d.Location).WithMany(p => p.DrugDispensingDt).HasConstraintName("FK_DrugDispensingDt_Location");
        });

        modelBuilder.Entity<DrugDispensingHd>(entity =>
        {
            entity.HasOne(d => d.Location).WithMany(p => p.DrugDispensingHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugDispensingHd_Location");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.DrugDispensingHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugDispensingHd_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.DrugDispensingHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugDispensingHd_Registration");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.DrugDispensingHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugDispensingHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.DrugDispensingHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugDispensingHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DrugDispensingHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugDispensingHd_sysTransactionCode");
        });

        modelBuilder.Entity<DrugInfoDt>(entity =>
        {
            entity.HasKey(e => e.DetailId).HasName("PK_DrugInfoDt_1");

            entity.HasOne(d => d.SequenceNoNavigation).WithMany(p => p.DrugInfoDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugInfoDt_DrugInfoHd");
        });

        modelBuilder.Entity<DrugInteraction>(entity =>
        {
            entity.HasKey(e => e.DrugInteractionID).HasName("PK_DrugInteraction_1");

            entity.Property(e => e.ActionsToBeTaken).HasDefaultValue("", "DF_DrugInteraction_ActionsToBeTaken");
            entity.Property(e => e.AdverseEffect).HasDefaultValue("", "DF_DrugInteraction_AdverseEffect");
            entity.Property(e => e.ProbableMechanism).HasDefaultValue("", "DF_DrugInteraction_ProbableMechanism");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_DrugInteraction_Remarks");

            entity.HasOne(d => d.GCDrugInteractionDocumentationNavigation).WithMany(p => p.DrugInteractionGCDrugInteractionDocumentationNavigation).HasConstraintName("FK_DrugInteraction_sysGeneralCode_DrugInteractionDocumentation");

            entity.HasOne(d => d.GCDrugInteractionSeverityNavigation).WithMany(p => p.DrugInteractionGCDrugInteractionSeverityNavigation).HasConstraintName("FK_DrugInteraction_sysGeneralCode_DrugInteractionSeverity");

            entity.HasOne(d => d.Generic).WithMany(p => p.DrugInteractionGeneric)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugInteraction_ItemGeneric");

            entity.HasOne(d => d.InteractingGeneric).WithMany(p => p.DrugInteractionInteractingGeneric)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugInteraction_ItemGeneric_Interacting");
        });

        modelBuilder.Entity<DrugReturnDt>(entity =>
        {
            entity.HasOne(d => d.DrugReturnNoNavigation).WithMany(p => p.DrugReturnDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugReturnDt_DrugReturnHd");

            entity.HasOne(d => d.Item).WithMany(p => p.DrugReturnDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugReturnDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.DrugReturnDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugReturnDt_ItemUnit");
        });

        modelBuilder.Entity<DrugReturnHd>(entity =>
        {
            entity.HasOne(d => d.GCDrugReturnReasonNavigation).WithMany(p => p.DrugReturnHd).HasConstraintName("FK_DrugReturnHd_sysGeneralCode");

            entity.HasOne(d => d.Location).WithMany(p => p.DrugReturnHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugReturnHd_Location");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.DrugReturnHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugReturnHd_Registration");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.DrugReturnHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugReturnHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.DrugReturnHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugReturnHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.DrugReturnHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrugReturnHd_sysTransactionCode");
        });

        modelBuilder.Entity<DynamicRopFormula>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_DynamicRopFormula_IsActive");
        });

        modelBuilder.Entity<EDCMachine>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_EDCMachine_IsActive");
        });

        modelBuilder.Entity<EcgMCU>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_EcgMCU_IsDeleted");
        });

        modelBuilder.Entity<EffectiveCommunicationHd2>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EmbalaceDt>(entity =>
        {
            entity.HasOne(d => d.Embalace).WithMany(p => p.EmbalaceDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmbalaceDt_EmbalaceHd");
        });

        modelBuilder.Entity<EmbalaceHd>(entity =>
        {
            entity.HasOne(d => d.GCEmbalaceLabelNavigation).WithMany(p => p.EmbalaceHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmbalaceHd_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.EmbalaceHd).HasConstraintName("FK_EmbalaceHd_Item");
        });

        modelBuilder.Entity<EmergencyContact>(entity =>
        {
            entity.HasOne(d => d.GCOccupationNavigation).WithMany(p => p.EmergencyContactGCOccupationNavigation).HasConstraintName("FK_EmergencyContact_sysGeneralCode_Occupation");

            entity.HasOne(d => d.GCRelationshipNavigation).WithMany(p => p.EmergencyContactGCRelationshipNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmergencyContact_sysGeneralCode");

            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.EmergencyContact)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmergencyContact_Registration");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.BloodRhesus).IsFixedLength();

            entity.HasOne(d => d.CompanyCodeNavigation).WithMany(p => p.Employee).HasConstraintName("FK_Employee_Company");

            entity.HasOne(d => d.CostServiceUnit).WithMany(p => p.Employee).HasConstraintName("FK_Employee_DepartmentServiceUnit");

            entity.HasOne(d => d.GCBloodTypeNavigation).WithMany(p => p.EmployeeGCBloodTypeNavigation).HasConstraintName("FK_Employee_sysGeneralCode3_BloodType");

            entity.HasOne(d => d.GCEmployeeStatusNavigation).WithMany(p => p.EmployeeGCEmployeeStatusNavigation).HasConstraintName("FK_Employee_sysGeneralCode_EmployeeStatus");

            entity.HasOne(d => d.GCGolonganNavigation).WithMany(p => p.EmployeeGCGolonganNavigation).HasConstraintName("FK_Employee_sysGeneralCode1");

            entity.HasOne(d => d.GCMaritalStatusNavigation).WithMany(p => p.EmployeeGCMaritalStatusNavigation).HasConstraintName("FK_Employee_sysGeneralCode2_MaritalStatus");

            entity.HasOne(d => d.GCNationalityNavigation).WithMany(p => p.EmployeeGCNationalityNavigation).HasConstraintName("FK_Employee_sysGeneralCode4_Nationality");

            entity.HasOne(d => d.GCPayrollPeriodTypeNavigation).WithMany(p => p.EmployeeGCPayrollPeriodTypeNavigation).HasConstraintName("FK_Employee_sysGeneralCode");

            entity.HasOne(d => d.GCPerfomanceNavigation).WithMany(p => p.EmployeeGCPerfomanceNavigation).HasConstraintName("FK_Employee_sysGeneralCode_PERFOMANCE");

            entity.HasOne(d => d.GCReligionNavigation).WithMany(p => p.EmployeeGCReligionNavigation).HasConstraintName("FK_Employee_sysGeneralCode1_Religion");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.EmployeeGCSexNavigation).HasConstraintName("FK_Employee_sysGeneralCode_Sex");

            entity.HasOne(d => d.GCTaxStatusNavigation).WithMany(p => p.EmployeeGCTaxStatusNavigation).HasConstraintName("FK_Employee_sysGeneralCode_TaxStatus");

            entity.HasOne(d => d.GcAgcEmployeeNavigation).WithMany(p => p.EmployeeGcAgcEmployeeNavigation).HasConstraintName("FK_Employee_sysGeneralCode_AGCEMPLOYEE");

            entity.HasOne(d => d.GcRlKualifikasiPendidikanNavigation).WithMany(p => p.EmployeeGcRlKualifikasiPendidikanNavigation).HasConstraintName("FK_Employee_sysGeneralCode_RLKualifikasiPendidikan");

            entity.HasOne(d => d.OrganizationCodeNavigation).WithMany(p => p.Employee).HasConstraintName("FK_Employee_Organization");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.Employee).HasConstraintName("FK_Employee_Position");

            entity.HasOne(d => d.PtkpStatus).WithMany(p => p.Employee).HasConstraintName("FK_Employee_PTKPStatus");
        });

        modelBuilder.Entity<EmployeeDisiplinaryDt>(entity =>
        {
            entity.HasOne(d => d.DocumentNoNavigation).WithMany(p => p.EmployeeDisiplinaryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeDisiplinaryDt_EmployeeDisiplinaryHd");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeDisiplinaryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeDisiplinaryDt_Employee");

            entity.HasOne(d => d.LastViolationTypeNavigation).WithMany(p => p.EmployeeDisiplinaryDt).HasConstraintName("FK_EmployeeDisiplinaryDt_ViolationType");
        });

        modelBuilder.Entity<EmployeeDisiplinaryHd>(entity =>
        {
            entity.HasOne(d => d.ViolationType).WithMany(p => p.EmployeeDisiplinaryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeDisiplinaryHd_ViolationType");
        });

        modelBuilder.Entity<EmployeeFamily>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_EmployeeFamily_IsActive");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeFamily)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeFamily_Employee");

            entity.HasOne(d => d.GCFamilyRelationNavigation).WithMany(p => p.EmployeeFamily)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeFamily_sysGeneralCode");
        });

        modelBuilder.Entity<EmployeeGroupDt>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeGroupDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeGroupDt_Employee");

            entity.HasOne(d => d.GroupCodeNavigation).WithMany(p => p.EmployeeGroupDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeGroupDt_EmployeeGroupHd");
        });

        modelBuilder.Entity<EmployeeLeave>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeLeave)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLeave_Employee");

            entity.HasOne(d => d.LeaveCodeNavigation).WithMany(p => p.EmployeeLeave)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLeave_LeaveType");
        });

        modelBuilder.Entity<EmployeeLoanDt>(entity =>
        {
            entity.HasOne(d => d.LoanNoNavigation).WithMany(p => p.EmployeeLoanDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLoanDt_EmployeeLoanHd");
        });

        modelBuilder.Entity<EmployeeLoanHd>(entity =>
        {
            entity.HasKey(e => e.LoanNo).HasName("PK_EmployeeLoadHd");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeLoanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLoadHd_Employee");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.EmployeeLoanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLoadHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.EmployeeLoanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLoadHd_sysTransactionCode");
        });

        modelBuilder.Entity<EmployeeLoanProcessDt>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeLoanProcessDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLoanProcessDt_Employee");

            entity.HasOne(d => d.ProcessNoNavigation).WithMany(p => p.EmployeeLoanProcessDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLoanProcessDt_EmployeeLoanProcessHd");

            entity.HasOne(d => d.EmployeeLoanDt).WithMany(p => p.EmployeeLoanProcessDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLoanProcessDt_EmployeeLoanDt");
        });

        modelBuilder.Entity<EmployeeLoanProcessHd>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.EmployeeLoanProcessHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLoanProcessHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.EmployeeLoanProcessHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLoanProcessHd_sysTransactionCode");
        });

        modelBuilder.Entity<EmployeeMedical>(entity =>
        {
            entity.HasOne(d => d.BenefitType).WithMany(p => p.EmployeeMedical)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedical_MedicalBenefitType");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeMedical)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedical_Employee");
        });

        modelBuilder.Entity<EmployeeMedicalAdjustmentDt>(entity =>
        {
            entity.HasOne(d => d.AdjustmentNoNavigation).WithMany(p => p.EmployeeMedicalAdjustmentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedicalAdjustmentDt_EmployeeMedicalAdjustmentHd");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeMedicalAdjustmentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedicalAdjustmentDt_Employee");
        });

        modelBuilder.Entity<EmployeeMedicalAdjustmentHd>(entity =>
        {
            entity.HasOne(d => d.MedicalBenefit).WithMany(p => p.EmployeeMedicalAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedicalAdjustmentHd_MedicalBenefitType");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.EmployeeMedicalAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedicalAdjustmentHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.EmployeeMedicalAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedicalAdjustmentHd_sysTransactionCode");
        });

        modelBuilder.Entity<EmployeeMedicalClaim>(entity =>
        {
            entity.HasOne(d => d.BenefitType).WithMany(p => p.EmployeeMedicalClaim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedicalClaim_MedicalBenefitType");

            entity.HasOne(d => d.EmployeeFamily).WithMany(p => p.EmployeeMedicalClaim).HasConstraintName("FK_EmployeeMedicalClaim_EmployeeFamily");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeMedicalClaim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedicalClaim_Employee");

            entity.HasOne(d => d.EmployeeMedical).WithMany(p => p.EmployeeMedicalClaim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeMedicalClaim_EmployeeMedical");
        });

        modelBuilder.Entity<EmployeeRewardHd>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.EmployeeRewardHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeRewardHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.EmployeeRewardHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeRewardHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.EmployeeRewardHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeRewardHd_sysTransactionCode");
        });

        modelBuilder.Entity<EmployeeSPT>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeSPT)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeSPT_Employee");
        });

        modelBuilder.Entity<EmployeeScheduleDt>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.EmployeeScheduleDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeScheduleDt_EmployeeScheduleHd");

            entity.HasOne(d => d.ShiftCodeNavigation).WithMany(p => p.EmployeeScheduleDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeScheduleDt_WorkShiftHrd");
        });

        modelBuilder.Entity<EmployeeScheduleHd>(entity =>
        {
            entity.HasOne(d => d.CycleCodeNavigation).WithMany(p => p.EmployeeScheduleHd).HasConstraintName("FK_EmployeeScheduleHd_WorkCycleHd");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeScheduleHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeScheduleHd_Employee");

            entity.HasOne(d => d.GroupCodeNavigation).WithMany(p => p.EmployeeScheduleHd).HasConstraintName("FK_EmployeeScheduleHd_EmployeeGroupHd");
        });

        modelBuilder.Entity<EmployeeTerminate>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTerminate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerminate_Employee");

            entity.HasOne(d => d.GCPerfomanceNavigation).WithMany(p => p.EmployeeTerminateGCPerfomanceNavigation).HasConstraintName("FK_EmployeeTerminate_sysGeneralCode_Perfomance");

            entity.HasOne(d => d.GCTerminateTypeNavigation).WithMany(p => p.EmployeeTerminateGCTerminateTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerminate_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.EmployeeTerminate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerminate_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.EmployeeTerminate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerminate_sysTransactionCode");
        });

        modelBuilder.Entity<EmployeeTimeAttendance>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTimeAttendance)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTimeAttendance_Employee");

            entity.HasOne(d => d.Import).WithMany(p => p.EmployeeTimeAttendance).HasConstraintName("FK_EmployeeTimeAttendance_ImportClocking");
        });

        modelBuilder.Entity<EmployeeWorkingHistory>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeWorkingHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_Employee");

            entity.HasOne(d => d.GcEmployeeStatusFromNavigation).WithMany(p => p.EmployeeWorkingHistoryGcEmployeeStatusFromNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_sysGeneralCode_EmployeeStatusFrom");

            entity.HasOne(d => d.GcEmployeeStatusToNavigation).WithMany(p => p.EmployeeWorkingHistoryGcEmployeeStatusToNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_sysGeneralCode_EmployeeStatusTo");

            entity.HasOne(d => d.GcTypeNavigation).WithMany(p => p.EmployeeWorkingHistoryGcTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_sysGeneralCode_GCType");

            entity.HasOne(d => d.OrganitationCodeFromNavigation).WithMany(p => p.EmployeeWorkingHistoryOrganitationCodeFromNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_Organization_From");

            entity.HasOne(d => d.OrganitationCodeToNavigation).WithMany(p => p.EmployeeWorkingHistoryOrganitationCodeToNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_Organization_To");

            entity.HasOne(d => d.PositionCodeFromNavigation).WithMany(p => p.EmployeeWorkingHistoryPositionCodeFromNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_PositionFrom");

            entity.HasOne(d => d.PositionCodeToNavigation).WithMany(p => p.EmployeeWorkingHistoryPositionCodeToNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_PositionTo");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.EmployeeWorkingHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.EmployeeWorkingHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeWorkingHistory_sysTransactionCode");
        });

        modelBuilder.Entity<Engineering>(entity =>
        {
            entity.HasOne(d => d.GCIssueDescriptionNavigation).WithMany(p => p.EngineeringGCIssueDescriptionNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Engineering_sysGeneralCode1_GCIssueDescription");

            entity.HasOne(d => d.GCIssueTypeNavigation).WithMany(p => p.EngineeringGCIssueTypeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.GCStatusNavigation).WithMany(p => p.EngineeringGCStatusNavigation).HasConstraintName("FK_Engineering_sysGeneralCode2_GCStatus");

            entity.HasOne(d => d.Location).WithMany(p => p.Engineering)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Engineering_LocationEngineering");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.Engineering)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Engineering_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.Engineering)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Engineering_sysTransactionCode");
        });

        modelBuilder.Entity<EpisodeDiagnosis>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_EpisodeDiagnosis_1");

            entity.HasOne(d => d.DiagnosisCodeNavigation).WithMany(p => p.EpisodeDiagnosis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeDiagnosis_Diagnosis");

            entity.HasOne(d => d.GCDiagnosisTypeNavigation).WithMany(p => p.EpisodeDiagnosisGCDiagnosisTypeNavigation).HasConstraintName("FK_EpisodeDiagnosis_sysGeneralCode_DiagnosisType");

            entity.HasOne(d => d.GCDifferentialStatusNavigation).WithMany(p => p.EpisodeDiagnosisGCDifferentialStatusNavigation).HasConstraintName("FK_EpisodeDiagnosis_sysGeneralCode_DifferentialStatus");

            entity.HasOne(d => d.GCFinalStatusNavigation).WithMany(p => p.EpisodeDiagnosisGCFinalStatusNavigation).HasConstraintName("FK_EpisodeDiagnosis_sysGeneralCode");

            entity.HasOne(d => d.Morphology).WithMany(p => p.EpisodeDiagnosis).HasConstraintName("FK_EpisodeDiagnosis_Morphology");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.EpisodeDiagnosis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeDiagnosis_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.EpisodeDiagnosis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeDiagnosis_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.EpisodeDiagnosis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeDiagnosis_Site");
        });

        modelBuilder.Entity<EpisodeEducation>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.EpisodeEducation).HasConstraintName("FK_EpisodeEducation_Registration");
        });

        modelBuilder.Entity<EpisodeNutritionalStatus>(entity =>
        {
            entity.HasOne(d => d.VitalSignDt).WithMany(p => p.EpisodeNutritionalStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeNutritionalStatus_VitalSignDt");
        });

        modelBuilder.Entity<EpisodeProcedure>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.EpisodeProcedure)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeProcedure_Paramedic");

            entity.HasOne(d => d.ProcedureCodeNavigation).WithMany(p => p.EpisodeProcedure)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeProcedure_Procedures");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.EpisodeProcedure)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeProcedure_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.EpisodeProcedure)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeProcedure_Site");

            entity.HasOne(d => d.SpecialtyCodeNavigation).WithMany(p => p.EpisodeProcedure)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EpisodeProcedure_Specialty");

            entity.HasOne(d => d.SurgeryTeamCodeNavigation).WithMany(p => p.EpisodeProcedure).HasConstraintName("FK_EpisodeProcedure_SurgeryTeamTemplateHd");
        });

        modelBuilder.Entity<EvaluasiNyeri>(entity =>
        {
            entity.Property(e => e.Kualitas).IsFixedLength();
        });

        modelBuilder.Entity<ExaminationReference>(entity =>
        {
            entity.Property(e => e.IsPregnant).HasDefaultValue(false, "DF_ExaminationReference_IsPregnant");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.ExaminationReference).HasConstraintName("FK_ExaminationReference_sysGeneralCode");
        });

        modelBuilder.Entity<ExpiredDateSimulation>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithOne(p => p.ExpiredDateSimulation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpiredDateSimulation_Item");
        });

        modelBuilder.Entity<ExportPatientDataStatus>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.ExportPatientDataStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExportPatientDataStatus_Registration");
        });

        modelBuilder.Entity<FamilyAppointment>(entity =>
        {
            entity.HasKey(e => e.FamilyId).HasName("PK__FamilyAp__41D82F6B4F8B894E");

            entity.Property(e => e.LastUpdatedDateTime).HasDefaultValueSql("(getdate())", "DF__FamilyApp__LastU__5FAD727C");
        });

        modelBuilder.Entity<FarmacyReportDt>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FetalMeasurement>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.FetalMeasurement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FetalMeasurement_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.FetalMeasurement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FetalMeasurement_Site");

            entity.HasOne(d => d.CurrentPregnancy).WithMany(p => p.FetalMeasurement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FetalMeasurement_CurrentPregnancy");
        });

        modelBuilder.Entity<FetalMeasurementDt>(entity =>
        {
            entity.HasOne(d => d.FetalMeasurementHd).WithMany(p => p.FetalMeasurementDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FetalMeasurementDt_FetalMeasurementHd");
        });

        modelBuilder.Entity<FetalMeasurementHd>(entity =>
        {
            entity.HasOne(d => d.GcAfiStatusNavigation).WithMany(p => p.FetalMeasurementHd).HasConstraintName("FK_FetalMeasurementHd_sysGeneralCode");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.FetalMeasurementHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FetalMeasurementHd_Patient");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.FetalMeasurementHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FetalMeasurementHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.FetalMeasurementHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FetalMeasurementHd_Site");

            entity.HasOne(d => d.CurrentPregnancy).WithMany(p => p.FetalMeasurementHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FetalMeasurementHd_CurrentPregnancy");
        });

        modelBuilder.Entity<FilterMCUItem>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<FiscalPeriodDt>(entity =>
        {
            entity.HasOne(d => d.YearNavigation).WithMany(p => p.FiscalPeriodDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FiscalPeriodDt_FiscalPeriodHd");
        });

        modelBuilder.Entity<FiscalPeriodHd>(entity =>
        {
            entity.Property(e => e.Year).ValueGeneratedNever();
        });

        modelBuilder.Entity<FisikMCU>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_PemeriksaanFisikMCU");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF__Pemeriksa__IsDel__56AE1827");
        });

        modelBuilder.Entity<FlipBookData>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_FlipBookData_RegistrationNo");
        });

        modelBuilder.Entity<ForecastDt>(entity =>
        {
            entity.HasOne(d => d.ForecastSubDt).WithMany(p => p.ForecastDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForecastDt_ForecastSubDt");
        });

        modelBuilder.Entity<ForecastHd>(entity =>
        {
            entity.HasOne(d => d.ForecastYearNavigation).WithMany(p => p.ForecastHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForecastHd_FiscalPeriodHd");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ForecastHd).HasConstraintName("FK_ForecastHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ForecastHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForecastHd_Site");

            entity.HasOne(d => d.SiteDepartment).WithMany(p => p.ForecastHd).HasConstraintName("FK_ForecastHd_SiteDepartment");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ForecastHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForecastHd_sysTransactionCode");
        });

        modelBuilder.Entity<ForecastSubDt>(entity =>
        {
            entity.HasOne(d => d.ForecastNoNavigation).WithMany(p => p.ForecastSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForecastSubDt_ForecastHd");

            entity.HasOne(d => d.Item).WithMany(p => p.ForecastSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForecastSubDt_Item");
        });

        modelBuilder.Entity<FormPasienBPJSRajal>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_FormPasienBPJSRajal_1");
        });

        modelBuilder.Entity<General>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GeneralConsentMCU>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.GeneralConsentMCU).HasConstraintName("FK_GeneralConsentMCU_Registration");
        });

        modelBuilder.Entity<GeneralConsentOutpatient>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.GeneralConsentOutpatient).HasConstraintName("FK_GeneralConsentOutpatient_Registration");
        });

        modelBuilder.Entity<Gift>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<GiroListDt>(entity =>
        {
            entity.Property(e => e.BGAmount).HasDefaultValue(0m, "DF__GiroListD__BGAmo__52BC8E91");
            entity.Property(e => e.VoidReason).HasComment("Void Reason");
        });

        modelBuilder.Entity<GiroListHd>(entity =>
        {
            entity.HasKey(e => e.TransNo).HasName("PK__GiroList__9E5D30C30CD37B12");
        });

        modelBuilder.Entity<GuidelineDt>(entity =>
        {
            entity.HasKey(e => new { e.GuidelineID, e.GCGuidelineType, e.InclusionCode, e.PartName, e.ItemID }).HasName("PK_GuidelineDt_1");

            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.GuidelineDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineDt_sysGeneralCode_ItemType");

            entity.HasOne(d => d.Item).WithMany(p => p.GuidelineDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineDt_Item");

            entity.HasOne(d => d.GuidelineInclusion).WithMany(p => p.GuidelineDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineDt_GuidelineInclusion");
        });

        modelBuilder.Entity<GuidelineDtItem>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_GuidelineDtItem_IsDeleted");

            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.GuidelineDtItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineDtItem_sysGeneralCode");

            entity.HasOne(d => d.GuidelineInclusion).WithMany(p => p.GuidelineDtItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineDtItem_GuidelineInclusionHd");

            entity.HasOne(d => d.Item).WithMany(p => p.GuidelineDtItem).HasConstraintName("FK_GuidelineDtItem_Item");

            entity.HasOne(d => d.VitalSignCodeNavigation).WithMany(p => p.GuidelineDtItem).HasConstraintName("FK_GuidelineDtItem_VitalSignType");
        });

        modelBuilder.Entity<GuidelineHd>(entity =>
        {
            entity.HasKey(e => e.GuildelineID).HasName("PK_Guideline");

            entity.HasOne(d => d.GCPathologyNavigation).WithMany(p => p.GuidelineHd).HasConstraintName("FK_Guideline_sysGeneralCode_Pathology");
        });

        modelBuilder.Entity<GuidelineInclusion>(entity =>
        {
            entity.HasOne(d => d.GCGuidelineTypeNavigation).WithMany(p => p.GuidelineInclusionGCGuidelineTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineInclusion_sysGeneralCode_GuidelineType");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.GuidelineInclusionGCSexNavigation).HasConstraintName("FK_GuidelineInclusion_sysGeneralCode_Sex");

            entity.HasOne(d => d.Guideline).WithMany(p => p.GuidelineInclusion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineInclusion_GuidelineHd");
        });

        modelBuilder.Entity<GuidelineInclusionHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.GuidelineInclusionHd).HasConstraintName("FK_GuidelineInclusionHd_BusinessPartner");

            entity.HasOne(d => d.GCGuidelineTypeNavigation).WithMany(p => p.GuidelineInclusionHdGCGuidelineTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineInclusionHd_sysGeneralCode");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.GuidelineInclusionHdGCSexNavigation).HasConstraintName("FK_GuidelineInclusionHd_sysGeneralCode1");

            entity.HasOne(d => d.Guideline).WithMany(p => p.GuidelineInclusionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineInclusionHd_GuidelineHd");
        });

        modelBuilder.Entity<GuidelineSummary>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("tgrGuidelineSummary"));

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_GuidelineSummary_IsDeleted");

            entity.HasOne(d => d.GuidelineInclusion).WithMany(p => p.GuidelineSummary)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuidelineSummary_GuidelineInclusionHd");
        });

        modelBuilder.Entity<HL7Message>(entity =>
        {
            entity.HasOne(d => d.GCReceivingApplicationNavigation).WithMany(p => p.HL7MessageGCReceivingApplicationNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HL7Message_sysGeneralCode");

            entity.HasOne(d => d.GCSendingApplicationNavigation).WithMany(p => p.HL7MessageGCSendingApplicationNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HL7Message_sysGeneralCode1");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.HL7Message).HasConstraintName("FK_HL7Message_Site");
        });

        modelBuilder.Entity<HL7ThirdParty>(entity =>
        {
            entity.Property(e => e.IsEnable).HasDefaultValue(true, "DF_HL7ThirdParty_IsEnable");
            entity.Property(e => e.MessageType).HasDefaultValue("ORM^O01", "DF_HL7ThirdParty_MessageType");

            entity.HasOne(d => d.GCThirdPartyNavigation).WithMany(p => p.HL7ThirdParty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HL7ThirdParty_sysGeneralCode");
        });

        modelBuilder.Entity<HasilPapSmearMCU>(entity =>
        {
            entity.Property(e => e.LastUpdatedDateTime).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<HistoryCloseOutstandingPharmacy>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<HospitalMembership>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_HospitalMembership_IsActive");
        });

        modelBuilder.Entity<ICDBlock>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ICDBlock_IsActive");

            entity.HasOne(d => d.GCICDChapterNavigation).WithMany(p => p.ICDBlock).HasConstraintName("FK_ICDBlock_sysGeneralCode");
        });

        modelBuilder.Entity<ICDCMBlock>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ICDCMBlock_IsActive");
        });

        modelBuilder.Entity<ICPenundaanPelayanan>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.ICPenundaanPelayanan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ICPenundaanPelayanan_Registration");
        });

        modelBuilder.Entity<ICSuratKeteranganHamil>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_ICSuratKeteranganHamil_IsDeleted");
        });

        modelBuilder.Entity<IDNTChecklist>(entity =>
        {
            entity.HasKey(e => new { e.DomainCode, e.RegistrationNo }).HasName("PK_IDNTChecklist_1");
        });

        modelBuilder.Entity<INACBGItemGroupHd>(entity =>
        {
            entity.HasKey(e => new { e.ItemGroupCode, e.GCItemType, e.ItemID }).HasName("PK_INACBGItemGroup");
        });

        modelBuilder.Entity<IPAddressQueue>(entity =>
        {
            entity.Property(e => e.Initial).IsFixedLength();
            entity.Property(e => e.IsEnabled).HasDefaultValue(true, "DF_IPAddressQueue_IsEnabled");

            entity.HasOne(d => d.Document).WithMany(p => p.IPAddressQueue).HasConstraintName("FK_IPAddressQueue_ImageDocument");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.IPAddressQueue).HasConstraintName("FK_IPAddressQueue_Paramedic");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.IPAddressQueue).HasConstraintName("FK_IPAddressQueue_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.IPAddressQueue).HasConstraintName("FK_IPAddressQueue_Site");
        });

        modelBuilder.Entity<IcuIndicatorDt>(entity =>
        {
            entity.HasOne(d => d.GcIcuIndicatorNavigation).WithMany(p => p.IcuIndicatorDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IcuIndicatorDt_sysGeneralCode");

            entity.HasOne(d => d.IcuIndicatorHd).WithMany(p => p.IcuIndicatorDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IcuIndicatorDt_IcuIndicatorHd");
        });

        modelBuilder.Entity<IcuIndicatorHd>(entity =>
        {
            entity.HasOne(d => d.GcIcuTemplateNavigation).WithMany(p => p.IcuIndicatorHdGcIcuTemplateNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IcuIndicatorHd_sysGeneralCode");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.IcuIndicatorHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IcuIndicatorHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.IcuIndicatorHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IcuIndicatorHd_Site");
        });

        modelBuilder.Entity<IcuTemplate>(entity =>
        {
            entity.HasOne(d => d.GCTemplateTypeNavigation).WithMany(p => p.IcuTemplate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IcuTemplate_sysGeneralCode");
        });

        modelBuilder.Entity<ImagingExamAdministration>(entity =>
        {
            entity.HasOne(d => d.JobOrderBOMImaging).WithMany(p => p.ImagingExamAdministration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImagingExamAdministration_JobOrderBOMImaging");
        });

        modelBuilder.Entity<ImportMCUCorporate>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("tr_PatientListMCUApproved"));

            entity.Property(e => e.BloodRhesus).IsFixedLength();

            entity.HasOne(d => d.GCNationalityNavigation).WithMany(p => p.ImportMCUCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportMCUCorporate_sysGeneralCode2");

            entity.HasOne(d => d.ItemCodeNavigation).WithMany(p => p.ImportMCUCorporate)
                .HasPrincipalKey(p => p.ItemCode)
                .HasForeignKey(d => d.ItemCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportMCUCorporate_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ImportMCUCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportMCUCorporate_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ImportMCUCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImportMCUCorporate_sysTransactionCode");
        });

        modelBuilder.Entity<InacbgClaim>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("trDefaultJenazah"));

            entity.HasOne(d => d.GCStatusNavigation).WithMany(p => p.InacbgClaim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgClaim_sysGeneralCode");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.InacbgClaim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgClaim_Registration");

            entity.HasOne(d => d.UpgradeClassCodeNavigation).WithMany(p => p.InacbgClaim).HasConstraintName("FK_InacbgClaim_Class");
        });

        modelBuilder.Entity<InacbgGrouper>(entity =>
        {
            entity.Property(e => e.DescriptionUpgradeClass).IsFixedLength();

            entity.HasOne(d => d.GCGrouperTitleNavigation).WithMany(p => p.InacbgGrouper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgGrouper_sysGeneralCode");

            entity.HasOne(d => d.InacbgClaim).WithMany(p => p.InacbgGrouper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgGrouper_InacbgClaim");
        });

        modelBuilder.Entity<InacbgSimulation>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.InacbgSimulation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgSimulation_Registration1");
        });

        modelBuilder.Entity<InacbgSimulationDiagnose>(entity =>
        {
            entity.HasOne(d => d.DiagnosisCodeNavigation).WithMany(p => p.InacbgSimulationDiagnose)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgSimulationDiagnose_Diagnosis");

            entity.HasOne(d => d.InacbgSimulation).WithMany(p => p.InacbgSimulationDiagnose)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgSimulationDiagnose_InacbgSimulation");
        });

        modelBuilder.Entity<InacbgSimulationProcedure>(entity =>
        {
            entity.HasOne(d => d.ProcedureCodeNavigation).WithMany(p => p.InacbgSimulationProcedure)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgSimulationProcedure_Procedures");

            entity.HasOne(d => d.InacbgSimulation).WithMany(p => p.InacbgSimulationProcedure)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgSimulationProcedure_InacbgSimulation");
        });

        modelBuilder.Entity<InacbgSpecialCMG>(entity =>
        {
            entity.HasOne(d => d.InacbgGrouper).WithMany(p => p.InacbgSpecialCMG)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InacbgSpecialCMG_InacbgGrouper");
        });

        modelBuilder.Entity<IncentiveCalculation>(entity =>
        {
            entity.HasKey(e => new { e.ProcessDate, e.TransactionNo, e.SquenceNo }).HasName("PK_IncentiveCalculation_1");

            entity.HasOne(d => d.EmployeeRewardDt).WithMany(p => p.IncentiveCalculation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveCalculation_EmployeeRewardDt");
        });

        modelBuilder.Entity<IncentiveMedication>(entity =>
        {
            entity.HasKey(e => new { e.ProcessDate, e.DrugDispensingNo, e.SequenceNo }).HasName("PK_IncentiveMedication_1");

            entity.HasOne(d => d.DrugDispensingNoNavigation).WithMany(p => p.IncentiveMedication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncentiveMedication_DrugDispensingHd1");
        });

        modelBuilder.Entity<IncomeTaxByDepartment>(entity =>
        {
            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.IncomeTaxByDepartment).HasConstraintName("FK_IncomeTaxByDepartment_sysGeneralCode");

            entity.HasOne(d => d.ItemGroupCodeNavigation).WithMany(p => p.IncomeTaxByDepartment).HasConstraintName("FK_IncomeTaxByDepartment_ItemGroup");

            entity.HasOne(d => d.SiteDepartment).WithMany(p => p.IncomeTaxByDepartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncomeTaxByDepartment_SiteDepartment");
        });

        modelBuilder.Entity<IndikatorPelayanan>(entity =>
        {
            entity.HasKey(e => e.Tahun).HasName("PK_IndikatorPelayanan_2");

            entity.Property(e => e.Tahun).ValueGeneratedNever();
        });

        modelBuilder.Entity<InfectiousDisease>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_InfectiousDisease_IsActive");

            entity.HasOne(d => d.GCInfectiousDiseaseCategoryNavigation).WithMany(p => p.InfectiousDiseaseGCInfectiousDiseaseCategoryNavigation).HasConstraintName("FK_InfectiousDisease_sysGeneralCode1");

            entity.HasOne(d => d.GCInfectiousDiseaseTypeNavigation).WithMany(p => p.InfectiousDiseaseGCInfectiousDiseaseTypeNavigation).HasConstraintName("FK_InfectiousDisease_sysGeneralCode");
        });

        modelBuilder.Entity<InfeksiPPI>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.InfeksiPPI)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InfeksiPPI_Registration");
        });

        modelBuilder.Entity<InformedConsentConfig>(entity =>
        {
            entity.HasKey(e => e.MenuID).HasName("PK_InformedConsentConfig_2");
        });

        modelBuilder.Entity<InhealthClaimFlag>(entity =>
        {
            entity.HasKey(e => new { e.TransactionNo, e.SequenceNo }).HasName("PK_InhealthClaimFlag_1");
        });

        modelBuilder.Entity<IntakeOutputDt>(entity =>
        {
            entity.Property(e => e.IsIntake).HasDefaultValue(true, "DF_IntakeOutputDt_IsIntake");

            entity.HasOne(d => d.GCIntakeOutputTypeNavigation).WithMany(p => p.IntakeOutputDt).HasConstraintName("FK_IntakeOutputDt_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.IntakeOutputDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntakeOutputDt_Site");
        });

        modelBuilder.Entity<IntakeOutputHd>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.IntakeOutputHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntakeOutputHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.IntakeOutputHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntakeOutputHd_Site");
        });

        modelBuilder.Entity<InterimBill>(entity =>
        {
            entity.Property(e => e.TransactionCode).IsFixedLength();

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.InterimBill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InterimBill_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.InterimBill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InterimBill_Site");
        });

        modelBuilder.Entity<InterimBillLimit>(entity =>
        {
            entity.HasOne(d => d.ClassCodeNavigation).WithOne(p => p.InterimBillLimit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InterimBillLimit_Class");
        });

        modelBuilder.Entity<InventoryAmountHistory>(entity =>
        {
            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.InventoryAmountHistory).HasConstraintName("FK_InventoryAmountHistory_ItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.InventoryAmountHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryAmountHistory_Location");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.InventoryAmountHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryAmountHistory_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.InventoryAmountHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryAmountHistory_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.InventoryAmountHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryAmountHistory_Site");
        });

        modelBuilder.Entity<InventoryRevaluationDt>(entity =>
        {
            entity.HasOne(d => d.InventoryRevaluationNoNavigation).WithMany(p => p.InventoryRevaluationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryRevaluationDt_InventoryRevaluationHd");

            entity.HasOne(d => d.Item).WithMany(p => p.InventoryRevaluationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryRevaluationDt_Item");
        });

        modelBuilder.Entity<InventoryRevaluationHd>(entity =>
        {
            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.InventoryRevaluationHd).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ItemGroupCodeNavigation).WithMany(p => p.InventoryRevaluationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryRevaluationHd_ItemGroup");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.InventoryRevaluationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryRevaluationHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.InventoryRevaluationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryRevaluationHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.InventoryRevaluationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryRevaluationHd_sysTransactionCode");
        });

        modelBuilder.Entity<IpAddressIcu>(entity =>
        {
            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.IpAddressIcu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IpAddressIcu_DepartmentServiceUnit");
        });

        modelBuilder.Entity<IpAddressMonitoring>(entity =>
        {
            entity.HasOne(d => d.GCMonitoringTypeNavigation).WithMany(p => p.IpAddressMonitoring)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IpAddressMonitoring_sysGeneralCode");

            entity.HasOne(d => d.ItemGroupCodeNavigation).WithMany(p => p.IpAddressMonitoring).HasConstraintName("FK_IpAddressMonitoring_ItemGroup");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.IpAddressMonitoring)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IpAddressMonitoring_Site");
        });

        modelBuilder.Entity<IssuedUnplannedDt>(entity =>
        {
            entity.HasOne(d => d.BaseItemUnitCodeNavigation).WithMany(p => p.IssuedUnplannedDtBaseItemUnitCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedUnplannedDt_ItemUnit_baseItemUnitCode");

            entity.HasOne(d => d.IssuedUnplannedNoNavigation).WithMany(p => p.IssuedUnplannedDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedUnplannedDt_IssuedUnplannedHd");

            entity.HasOne(d => d.Item).WithMany(p => p.IssuedUnplannedDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedUnplannedDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.IssuedUnplannedDtItemUnitCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedUnplannedDt_ItemUnit");
        });

        modelBuilder.Entity<IssuedUnplannedHd>(entity =>
        {
            entity.HasOne(d => d.CoaCodeDebitNavigation).WithMany(p => p.IssuedUnplannedHdCoaCodeDebitNavigation).HasConstraintName("FK_IssuedUnplannedHd_ChartOfAccount_CoaCodeDebet");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.IssuedUnplannedHd).HasConstraintName("FK_IssuedUnplannedHd_Department");

            entity.HasOne(d => d.GCIssuedUnplannedTypeNavigation).WithMany(p => p.IssuedUnplannedHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedUnplannedHd_sysGeneralCode");

            entity.HasOne(d => d.Location).WithMany(p => p.IssuedUnplannedHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedUnplannedHd_Location");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.IssuedUnplannedHd).HasConstraintName("FK_IssuedUnplannedHd_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.IssuedUnplannedHd).HasConstraintName("FK_IssuedUnplannedHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.IssuedUnplannedHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedUnplannedHd_Site");

            entity.HasOne(d => d.SiteDepartment).WithMany(p => p.IssuedUnplannedHd).HasConstraintName("FK_IssuedUnplannedHd_SiteDepartment");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.IssuedUnplannedHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssuedUnplannedHd_sysTransactionCode");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemID).HasFillFactor(90);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tr_ValidateIsActiveItem");
                    tb.HasTrigger("tr_ValidateLeadingSpacesOnItemCode");
                });

            entity.HasIndex(e => e.GCItemType, "IX_Item_ItemType").HasFillFactor(90);

            entity.HasIndex(e => e.ItemCode, "UNIQUE_IX_Item")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.ABCClass).IsFixedLength();
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Item_IsActive");
            entity.Property(e => e.IsAllowOrder).HasDefaultValue(true, "DF_Item_IsAllowOrder");
            entity.Property(e => e.ItemName2).HasDefaultValue("", "DF_Item_ItemName2");
            entity.Property(e => e.ShortName).HasDefaultValue("", "DF_Item_ShortName");

            entity.HasOne(d => d.AssetClassCodeNavigation).WithMany(p => p.Item).HasConstraintName("FK_Item_AssetClassHd");

            entity.HasOne(d => d.AssetsGroup).WithMany(p => p.Item).HasConstraintName("FK_Item_AssetsGroup");

            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.ItemGCItemTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Item_sysGeneralCode_ItemType");

            entity.HasOne(d => d.GCPhysicianFeeItemTypeNavigation).WithMany(p => p.ItemGCPhysicianFeeItemTypeNavigation).HasConstraintName("FK_Item_sysGeneralCode");

            entity.HasOne(d => d.ItemGroupCodeNavigation).WithMany(p => p.Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Item_ItemGroup1");

            entity.HasOne(d => d.ProductLine).WithMany(p => p.Item).HasConstraintName("FK_Item_ProductLine");

            entity.HasOne(d => d.PurchaseUnitCodeNavigation).WithMany(p => p.ItemPurchaseUnitCodeNavigation).HasConstraintName("FK_Item_ItemUnit_PurchaseUnit");
        });

        modelBuilder.Entity<ItemBomDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemBomDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemBomDt_Item");

            entity.HasOne(d => d.ParentItem).WithMany(p => p.ItemBomDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemBomDt_ItemBomHd");
        });

        modelBuilder.Entity<ItemBomHd>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithOne(p => p.ItemBomHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemBomHd_Item");
        });

        modelBuilder.Entity<ItemBrand>(entity =>
        {
            entity.HasKey(e => e.BrandCode).HasName("PK_ItemBrand_1");

            entity.HasOne(d => d.ATCClassCodeNavigation).WithMany(p => p.ItemBrand).HasConstraintName("FK_ItemBrand_ATCClass");

            entity.HasOne(d => d.GCDrugClassNavigation).WithMany(p => p.ItemBrandGCDrugClassNavigation).HasConstraintName("FK_ItemBrand_sysGeneralCode_DrugClass");

            entity.HasOne(d => d.GCPregnancyCategoryNavigation).WithMany(p => p.ItemBrandGCPregnancyCategoryNavigation).HasConstraintName("FK_ItemBrand_sysGeneralCode_PregnancyCategory");

            entity.HasOne(d => d.MIMSClassCodeNavigation).WithMany(p => p.ItemBrand).HasConstraintName("FK_ItemBrand_MIMSClass");
        });

        modelBuilder.Entity<ItemBrandGeneric>(entity =>
        {
            entity.HasKey(e => new { e.BrandCode, e.GenericID }).HasName("PK_ItemBrandGeneric_1");

            entity.HasOne(d => d.BrandCodeNavigation).WithMany(p => p.ItemBrandGeneric)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemBrandGeneric_ItemBrand");

            entity.HasOne(d => d.DosageUnitCodeNavigation).WithMany(p => p.ItemBrandGeneric).HasConstraintName("FK_ItemBrandGeneric_ItemUnit");

            entity.HasOne(d => d.Generic).WithMany(p => p.ItemBrandGeneric)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemBrandGeneric_ItemGeneric");
        });

        modelBuilder.Entity<ItemCompileMCU>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ItemCompileMCU_IsActive");

            entity.HasOne(d => d.GCCompileTypeNavigation).WithMany(p => p.ItemCompileMCU).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation).HasConstraintName("FK_ItemCompileMCU_ItemCompileMCU");
        });

        modelBuilder.Entity<ItemCost>(entity =>
        {
            entity.Property(e => e.Burden).HasComputedColumnSql("([PreviousBurden]+[CurrentBurden])", false);
            entity.Property(e => e.Labor).HasComputedColumnSql("([PreviousLabor]+[CurrentLabor])", true);
            entity.Property(e => e.Material).HasComputedColumnSql("([PreviousMaterial]+[CurrentMaterial])", false);
            entity.Property(e => e.Overhead).HasComputedColumnSql("([PreviousOverhead]+[CurrentOverhead])", false);
            entity.Property(e => e.SubContract).HasComputedColumnSql("([PreviousSubContract]+[CurrentSubContract])", false);

            entity.HasOne(d => d.Item).WithMany(p => p.ItemCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemCost_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemCost_Site");
        });

        modelBuilder.Entity<ItemCostExcludePPN>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.ItemID }).HasName("PK_ItemCostExcludePPN_1");

            entity.Property(e => e.Burden).HasComputedColumnSql("([PreviousBurden]+[CurrentBurden])", false);
            entity.Property(e => e.Labor).HasComputedColumnSql("([PreviousLabor]+[CurrentLabor])", true);
            entity.Property(e => e.Material).HasComputedColumnSql("([PreviousMaterial]+[CurrentMaterial])", false);
            entity.Property(e => e.Overhead).HasComputedColumnSql("([PreviousOverhead]+[CurrentOverhead])", false);
            entity.Property(e => e.SubContract).HasComputedColumnSql("([PreviousSubContract]+[CurrentSubContract])", false);
        });

        modelBuilder.Entity<ItemDrug>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
            entity.Property(e => e.IsNewItem).HasDefaultValue(true, "DF_ItemDrug_IsNewItem");

            entity.HasOne(d => d.BrandCodeNavigation).WithMany(p => p.ItemDrug).HasConstraintName("FK_ItemDrug_ItemBrand");

            entity.HasOne(d => d.DefaultConsumeUnitNavigation).WithMany(p => p.ItemDrugDefaultConsumeUnitNavigation).HasConstraintName("FK_ItemDrug_ItemUnit");

            entity.HasOne(d => d.DosageUnitCodeNavigation).WithMany(p => p.ItemDrugDosageUnitCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.GCDrugTypeNavigation).WithMany(p => p.ItemDrugGCDrugTypeNavigation).HasConstraintName("FK_ItemDrug_sysGeneralCode_DrugType");

            entity.HasOne(d => d.GCNarkotikaNavigation).WithMany(p => p.ItemDrugGCNarkotikaNavigation).HasConstraintName("FK_ItemDrug_sysGeneralCode_Narkotika");

            entity.HasOne(d => d.GCRouteNavigation).WithMany(p => p.ItemDrugGCRouteNavigation).HasConstraintName("FK_ItemDrug_sysGeneralCode_Route");

            entity.HasOne(d => d.Item).WithOne(p => p.ItemDrug)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemDrug_Item");
        });

        modelBuilder.Entity<ItemDrugDisplay>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemDrugStopOrder>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemGroup>(entity =>
        {
            entity.HasKey(e => e.ItemGroupCode).HasFillFactor(90);

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ItemGroup_IsActive");
            entity.Property(e => e.ItemGroupName2).HasDefaultValue("", "DF_ItemGroup_ItemGroupName2");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_ItemGroup_Remarks");

            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.ItemGroup).HasConstraintName("FK_ItemGroup_sysGeneralCode_ItemType");
        });

        modelBuilder.Entity<ItemGroupReference>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_ItemGroupReference_IsDeleted");
        });

        modelBuilder.Entity<ItemHPPBPJS>(entity =>
        {
            entity.HasKey(e => e.ItemID).HasName("PK_ItemHPPBPJS_1");

            entity.Property(e => e.ItemID).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_ItemHPPBPJS_IsDeleted");
        });

        modelBuilder.Entity<ItemInGroup>(entity =>
        {
            entity.HasKey(e => e.RecordCode).HasName("PK_ItemInGroup_1");

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ItemInGroup_IsActive");
            entity.Property(e => e.IsParent).HasDefaultValue(true, "DF_ItemInGroup_IsAlloworder");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemInGroup).HasConstraintName("FK_ItemInGroup_Item");

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation).HasConstraintName("FK_ItemInGroup_ItemInGroup");
        });

        modelBuilder.Entity<ItemInventory>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("tr_CekOAMinus"));

            entity.Property(e => e.QtyOnGIT).HasDefaultValue(0m, "DF_ItemInventory_QtyOnTransfer");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemInventory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemInventory_Item");

            entity.HasOne(d => d.Location).WithMany(p => p.ItemInventory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemInventory_Location");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemInventory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemInventory_Site");
        });

        modelBuilder.Entity<ItemInventoryExpired>(entity =>
        {
            entity.HasKey(e => new { e.LocationID, e.ItemID, e.SiteCode, e.ExpDate }).HasName("PK_ItemInventoryExpired_1");
        });

        modelBuilder.Entity<ItemLabDisplay>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemLaboratory>(entity =>
        {
            entity.HasOne(d => d.ItemCodeNavigation).WithOne(p => p.ItemLaboratoryItemCodeNavigation)
                .HasPrincipalKey<Item>(p => p.ItemCode)
                .HasForeignKey<ItemLaboratory>(d => d.ItemCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemLaboratory_Item");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemLaboratoryItem).HasConstraintName("FK_ItemLaboratory_Item1");
        });

        modelBuilder.Entity<ItemLoinc>(entity =>
        {
            entity.HasKey(e => new { e.ItemID, e.LoincCode }).HasName("PK_ItemLoinc_1");
        });

        modelBuilder.Entity<ItemLoincGolonganDarah>(entity =>
        {
            entity.HasKey(e => e.GCBloodType).HasName("PK_ItemLoincGolonganDarah_1");
        });

        modelBuilder.Entity<ItemLoincRhesus>(entity =>
        {
            entity.HasKey(e => e.BloodRhesus).HasName("PK_ItemLoincRhesus_1");
        });

        modelBuilder.Entity<ItemMasterIncentive>(entity =>
        {
            entity.HasOne(d => d.GCProfileNavigation).WithMany(p => p.ItemMasterIncentive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemMasterIncentive_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemMasterIncentive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemMasterIncentive_Item");
        });

        modelBuilder.Entity<ItemMostFrequent>(entity =>
        {
            entity.HasOne(d => d.GCMostFrequentTypeNavigation).WithMany(p => p.ItemMostFrequent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemMostFrequent_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemMostFrequent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemMostFrequent_Item");
        });

        modelBuilder.Entity<ItemOAT>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemPlanning>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.ItemPlanning).HasConstraintName("FK_ItemPlanning_BusinessPartner");

            entity.HasOne(d => d.GCOrderPolicyNavigation).WithMany(p => p.ItemPlanning)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPlanning_sysGeneralCode_OrderPolicy");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemPlanning)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPlanning_Item");

            entity.HasOne(d => d.PoSiteCodeNavigation).WithMany(p => p.ItemPlanningPoSiteCodeNavigation).HasConstraintName("FK_ItemPlanning_Site1");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemPlanningSiteCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPlanning_Site");
        });

        modelBuilder.Entity<ItemPlanningDO>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemPlanningDO)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPlanningDO_Item");

            entity.HasOne(d => d.Location).WithMany(p => p.ItemPlanningDO)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPlanningDO_Location");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemPlanningDO)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPlanningDO_Site");
        });

        modelBuilder.Entity<ItemPurchasePrice>(entity =>
        {
            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ItemPurchasePrice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPurchasePrice_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemPurchasePrice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPurchasePrice_Site");
        });

        modelBuilder.Entity<ItemReference>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemReference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemReference_Item");
        });

        modelBuilder.Entity<ItemServiceMCURealizationDt>(entity =>
        {
            entity.Property(e => e.IsVerifiedRevenue).HasDefaultValue(false, "DF_ItemServiceMCURealizationDt_IsVerifiedRevenue");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemServiceMCURealizationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemServiceMCURealizationDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ItemServiceMCURealizationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemServiceMCURealizationDt_ItemUnit");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.ItemServiceMCURealizationDt).HasConstraintName("FK_ItemServiceMCURealizationDt_Paramedic");

            entity.HasOne(d => d.TransactionNoNavigation).WithMany(p => p.ItemServiceMCURealizationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemServiceMCURealizationDt_ItemServiceMCURealizationHd");
        });

        modelBuilder.Entity<ItemServiceMCURealizationHd>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.ItemServiceMCURealizationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemServiceMCURealizationHd_Registration");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ItemServiceMCURealizationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemServiceMCURealizationHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemServiceMCURealizationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemServiceMCURealizationHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ItemServiceMCURealizationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemServiceMCURealizationHd_sysTransactionCode");
        });

        modelBuilder.Entity<ItemTariffCorporate>(entity =>
        {
            entity.Property(e => e.MaxVariablePrice).HasDefaultValue(9999999999999.9999m, "DF_ItemTariffCorporate_MaxVariablePrice");

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.ItemTariffCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffCorporate_Customer");

            entity.HasOne(d => d.ClassCategoryCodeNavigation).WithMany(p => p.ItemTariffCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffCorporate_ClassCategory");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemTariffCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffCorporate_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemTariffCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffCorporate_Site");
        });

        modelBuilder.Entity<ItemTariffMCU>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemTariffMCUItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffMCU_Item");

            entity.HasOne(d => d.ParentItem).WithMany(p => p.ItemTariffMCUParentItem).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemTariffMCU)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffMCU_Site");
        });

        modelBuilder.Entity<ItemTariffStandard>(entity =>
        {
            entity.Property(e => e.MaxVariablePrice).HasDefaultValue(9999999999999.9999m, "DF_ItemTariffStandard_MaxVariablePrice");

            entity.HasOne(d => d.ClassCategoryCodeNavigation).WithMany(p => p.ItemTariffStandard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffStandard_ClassCategory");

            entity.HasOne(d => d.GCMemberNavigation).WithMany(p => p.ItemTariffStandard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffStandard_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemTariffStandard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffStandard_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemTariffStandard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTariffStandard_Site");
        });

        modelBuilder.Entity<ItemTax>(entity =>
        {
            entity.HasOne(d => d.ClassCategoryCodeNavigation).WithMany(p => p.ItemTax)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTax_ClassCategory");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemTax)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTax_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemTax)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTax_Site");

            entity.HasOne(d => d.TaxCategoryCodeNavigation).WithMany(p => p.ItemTax)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTax_TaxCategory");
        });

        modelBuilder.Entity<ItemTemplate>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemTemplate).HasConstraintName("FK_ItemTemplate_Item");
        });

        modelBuilder.Entity<ItemTransactionHistoryDt>(entity =>
        {
            entity.HasOne(d => d.COACodeNavigation).WithMany(p => p.ItemTransactionHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryDt_ChartOfAccount");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.ItemTransactionHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryDt_Department");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.ItemTransactionHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryDt_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ItemTransactionHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryDt_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemTransactionHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryDt_Site");

            entity.HasOne(d => d.TransactionHistory).WithMany(p => p.ItemTransactionHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryDt_ItemTransactionHistoryHd");
        });

        modelBuilder.Entity<ItemTransactionHistoryHd>(entity =>
        {
            entity.HasKey(e => e.TransactionHistoryID).HasName("PK_TransactionHistoryHd");

            entity.HasIndex(e => new { e.LocationID, e.ItemID, e.TransactionDateTime, e.QuantityChange }, "IX_ItemTransactionHistoryHd_LocID_ItemID_TransactionDate_QChange").HasFillFactor(90);

            entity.HasIndex(e => e.TransactionDateTime, "IX_ItemTransactionHistoryHd_TranDate").HasFillFactor(90);

            entity.HasIndex(e => new { e.TransactionDateTime, e.TransactionSource, e.IsPosting }, "IX_ItemTransactionHistoryHd_TranDate_TranCode_IsPosting").HasFillFactor(90);

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.ItemTransactionHistoryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryHd_Department");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemTransactionHistoryHd).HasConstraintName("FK_ItemTransactionHistoryHd_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ItemTransactionHistoryHd).HasConstraintName("FK_ItemTransactionHistoryHd_ItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.ItemTransactionHistoryHd).HasConstraintName("FK_ItemTransactionHistoryHd_Location");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.ItemTransactionHistoryHd).HasConstraintName("FK_ItemTransactionHistoryHd_Registration");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.ItemTransactionHistoryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryHd_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ItemTransactionHistoryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemTransactionHistoryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionHistoryHd_Site");
        });

        modelBuilder.Entity<ItemTransactionMcuDt>(entity =>
        {
            entity.HasKey(e => new { e.TransactionNo, e.SequenceNo }).HasName("PK_ItemTransactionMcuDt_1");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemTransactionMcuDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionMcuDt_Item");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.ItemTransactionMcuDt).HasConstraintName("FK_ItemTransactionMcuDt_Paramedic");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ItemTransactionMcuDt).HasConstraintName("FK_ItemTransactionMcuDt_DepartmentServiceUnit");

            entity.HasOne(d => d.TransactionNoNavigation).WithMany(p => p.ItemTransactionMcuDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionMcuDt_ItemTransactionMcuHd");
        });

        modelBuilder.Entity<ItemTransactionMcuHd>(entity =>
        {
            entity.HasOne(d => d.ParentItem).WithMany(p => p.ItemTransactionMcuHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionMcuHd_Item");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.ItemTransactionMcuHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionMcuHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ItemTransactionMcuHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionMcuHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ItemTransactionMcuHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTransactionMcuHd_sysTransactionCode");
        });

        modelBuilder.Entity<ItemTypeMaster>(entity =>
        {
            entity.HasOne(d => d.GCItemMasterNavigation).WithMany(p => p.ItemTypeMasterGCItemMasterNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTypeMaster_sysGeneralCode_ItemMaster");

            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.ItemTypeMasterGCItemTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemTypeMaster_sysGeneralCode_ItemType");
        });

        modelBuilder.Entity<ItemUnit>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ItemUnit_IsActive");
            entity.Property(e => e.ShortName).HasDefaultValue("", "DF_ItemUnit_ShortName");
        });

        modelBuilder.Entity<ItemUnitConversion>(entity =>
        {
            entity.HasKey(e => new { e.ItemID, e.AlternateItemUnit }).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("tr_ValidateItemUnitConversion"));

            entity.HasIndex(e => e.ItemID, "IX_ItemUnitConversion_ItemID").HasFillFactor(90);

            entity.HasOne(d => d.AlternateItemUnitNavigation).WithMany(p => p.ItemUnitConversion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemUnitConversion_ItemUnit");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemUnitConversion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemUnitConversion_Item");
        });

        modelBuilder.Entity<ItemVaccination>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ItemVaccination)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemVaccination_Item");

            entity.HasOne(d => d.VaccinationCodeNavigation).WithMany(p => p.ItemVaccination)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemVaccination_Vaccination");
        });

        modelBuilder.Entity<ItemVerified>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<JasaPelayananGroup>(entity =>
        {
            entity.HasKey(e => e.GroupCode).HasName("PK_GroupJasaPelayanan");
        });

        modelBuilder.Entity<JobOrderBOMImaging>(entity =>
        {
            entity.HasOne(d => d.Assets).WithMany(p => p.JobOrderBOMImaging).HasConstraintName("FK_JobOrderBOMImaging_Assets");

            entity.HasOne(d => d.Item).WithMany(p => p.JobOrderBOMImagingItem).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ReviewByParamedicNavigation).WithMany(p => p.JobOrderBOMImaging).HasConstraintName("FK_JobOrderBOMImaging_Paramedic");

            entity.HasOne(d => d.JobOrderDt).WithMany(p => p.JobOrderBOMImaging)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderBOMImaging_JobOrderDt");
        });

        modelBuilder.Entity<JobOrderBOMLaboratory>(entity =>
        {
            entity.HasOne(d => d.Assets).WithMany(p => p.JobOrderBOMLaboratory).HasConstraintName("FK_JobOrderBOMLaboratory_Assets");

            entity.HasOne(d => d.Item).WithMany(p => p.JobOrderBOMLaboratoryItem).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.JobOrderDt).WithMany(p => p.JobOrderBOMLaboratory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderBOMLaboratory_JobOrderDt");
        });

        modelBuilder.Entity<JobOrderBOMOtherExam>(entity =>
        {
            entity.HasOne(d => d.Assets).WithMany(p => p.JobOrderBOMOtherExam).HasConstraintName("FK_JobOrderBOMOtherExam_Assets");

            entity.HasOne(d => d.AutorizedBy).WithMany(p => p.JobOrderBOMOtherExam).HasConstraintName("FK_JobOrderBOMOtherExam_Paramedic");

            entity.HasOne(d => d.Item).WithMany(p => p.JobOrderBOMOtherExamItem).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.JobOrderDt).WithMany(p => p.JobOrderBOMOtherExam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderBOMOtherExam_JobOrderDt");
        });

        modelBuilder.Entity<JobOrderDt>(entity =>
        {
            entity.Property(e => e.CostPrice).HasDefaultValue(0m, "DF_JobOrderDt_CostPrice");
            entity.Property(e => e.CustomerCitoCompPrice).HasDefaultValue(0m, "DF_JobOrderDt_CustomerCitoCompPrice");
            entity.Property(e => e.CustomerPrice).HasDefaultValue(0m, "DF_JobOrderDt_CustomerPrice");
            entity.Property(e => e.DiscountPrice).HasDefaultValue(0m, "DF_JobOrderDt_DiscountPrice");
            entity.Property(e => e.OrderNotes).HasDefaultValue("", "DF_JobOrderDt_OrderNotes");
            entity.Property(e => e.PersonalCitoCompPrice).HasDefaultValue(0m, "DF_JobOrderDt_PersonalCitoCompPrice");
            entity.Property(e => e.PersonalPrice).HasDefaultValue(0m, "DF_JobOrderDt_PersonalPrice");
            entity.Property(e => e.StandartPrice).HasDefaultValue(0m, "DF_JobOrderDt_StandartPrice");
            entity.Property(e => e.TotalCustomer).HasDefaultValue(0m, "DF_JobOrderDt_TotalCustomer");
            entity.Property(e => e.TotalPersonal).HasDefaultValue(0m, "DF_JobOrderDt_TotalPersonal");

            entity.HasOne(d => d.GCJobOrderStatusNavigation).WithMany(p => p.JobOrderDtGCJobOrderStatusNavigation).HasConstraintName("FK_JobOrderDt_sysGeneralCode_JobOrderStatus");

            entity.HasOne(d => d.GCOrderTypeNavigation).WithMany(p => p.JobOrderDtGCOrderTypeNavigation).HasConstraintName("FK_JobOrderDt_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.JobOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDt_Item");

            entity.HasOne(d => d.JobOrderNoNavigation).WithMany(p => p.JobOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDt_JobOrderHd");
        });

        modelBuilder.Entity<JobOrderDtDiagnose>(entity =>
        {
            entity.HasOne(d => d.DiagnosisCodeNavigation).WithMany(p => p.JobOrderDtDiagnose)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDtDiagnose_Diagnosis");

            entity.HasOne(d => d.JobOrderDt).WithMany(p => p.JobOrderDtDiagnose)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDtDiagnose_JobOrderDt");
        });

        modelBuilder.Entity<JobOrderDtMedicalSuppiles>(entity =>
        {
            entity.HasKey(e => new { e.JobOrderNo, e.SequenceNo }).HasName("PK_JobOrderDtMedicalSuppile");

            entity.Property(e => e.CostPrice).HasDefaultValue(0m, "DF_JobOrderDtMedicalSuppile_CostPrice");
            entity.Property(e => e.CustomerCitoCompPrice).HasDefaultValue(0m, "DF_JobOrderDtMedicalSuppile_CustomerCitoCompPrice");
            entity.Property(e => e.CustomerPrice).HasDefaultValue(0m, "DF_JobOrderDtMedicalSuppile_CustomerPrice");
            entity.Property(e => e.DiscountPrice).HasDefaultValue(0m, "DF_JobOrderDtMedicalSuppile_DiscountPrice");
            entity.Property(e => e.OrderNotes).HasDefaultValue("", "DF_JobOrderDtMedicalSuppile_OrderNotes");
            entity.Property(e => e.PersonalCitoCompPrice).HasDefaultValue(0m, "DF_JobOrderDtMedicalSuppile_PersonalCitoCompPrice");
            entity.Property(e => e.PersonalPrice).HasDefaultValue(0m, "DF_JobOrderDtMedicalSuppile_PersonalPrice");
            entity.Property(e => e.StandartPrice).HasDefaultValue(0m, "DF_JobOrderDtMedicalSuppile_StandartPrice");
            entity.Property(e => e.TotalCustomer).HasDefaultValue(0m, "DF_JobOrderDtMedicalSuppile_TotalCustomer");
            entity.Property(e => e.TotalPersonal).HasDefaultValue(0m, "DF_JobOrderDtMedicalSuppile_TotalPersonal");

            entity.HasOne(d => d.BaseUnitCodeNavigation).WithMany(p => p.JobOrderDtMedicalSuppiles).HasConstraintName("FK_JobOrderDtMedicalSuppile_ItemUnit");

            entity.HasOne(d => d.GCJobOrderStatusNavigation).WithMany(p => p.JobOrderDtMedicalSuppilesGCJobOrderStatusNavigation).HasConstraintName("FK_JobOrderDtMedicalSuppile_sysGeneralCode1");

            entity.HasOne(d => d.GCOrderTypeNavigation).WithMany(p => p.JobOrderDtMedicalSuppilesGCOrderTypeNavigation).HasConstraintName("FK_JobOrderDtMedicalSuppile_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.JobOrderDtMedicalSuppiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDtMedicalSuppile_Item");

            entity.HasOne(d => d.JobOrderNoNavigation).WithMany(p => p.JobOrderDtMedicalSuppiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDtMedicalSuppile_JobOrderHd");
        });

        modelBuilder.Entity<JobOrderDtMedication>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tr_JobOrderDtMedication");
                    tb.HasTrigger("tr_UpdatePlaningSOAPMedication");
                    tb.HasTrigger("tr_ValidatePrescriptionWNA");
                    tb.HasTrigger("tr_ValidateSaveJobOrderDtMedication");
                    tb.HasTrigger("tr_ValidationToPharmacy");
                });

            entity.Property(e => e.IsChanged).HasDefaultValue(false, "dt_isChanged");
            entity.Property(e => e.RFlag).IsFixedLength();
            entity.Property(e => e.isResulted).HasDefaultValue(false, "dt_isResulted");

            entity.HasOne(d => d.ConsumeUnitNavigation).WithMany(p => p.JobOrderDtMedication).HasConstraintName("FK_JobOrderDtMedication_ItemUnit");

            entity.HasOne(d => d.Embalace).WithMany(p => p.JobOrderDtMedication).HasConstraintName("FK_JobOrderDtMedication_EmbalaceHd");

            entity.HasOne(d => d.GCDrugTypeNavigation).WithMany(p => p.JobOrderDtMedicationGCDrugTypeNavigation).HasConstraintName("FK_JobOrderDtMedication_sysGeneralCode1");

            entity.HasOne(d => d.GCMedicationTypeNavigation).WithMany(p => p.JobOrderDtMedicationGCMedicationTypeNavigation).HasConstraintName("FK_JobOrderDtMedication_sysGeneralCode");

            entity.HasOne(d => d.GCRouteNavigation).WithMany(p => p.JobOrderDtMedicationGCRouteNavigation).HasConstraintName("FK_JobOrderDtMedication_sysGeneralCode_CompoundRoute");

            entity.HasOne(d => d.Item).WithMany(p => p.JobOrderDtMedication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDtMedication_Item");

            entity.HasOne(d => d.JobOrderNoNavigation).WithMany(p => p.JobOrderDtMedication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDtMedication_JobOrderHd");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.JobOrderDtMedication).HasConstraintName("FK_JobOrderDtMedication_Paramedic");
        });

        modelBuilder.Entity<JobOrderDtMonitoring>(entity =>
        {
            entity.HasOne(d => d.JobOrderNoNavigation).WithMany(p => p.JobOrderDtMonitoring)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDtMonitoring_JobOrderHd");

            entity.HasOne(d => d.VitalSignCodeNavigation).WithMany(p => p.JobOrderDtMonitoring)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderDtMonitoring_VitalSignType");
        });

        modelBuilder.Entity<JobOrderHd>(entity =>
        {
            entity.HasOne(d => d.GCOrderTypeNavigation).WithMany(p => p.JobOrderHd).HasConstraintName("FK_JobOrderHd_sysGeneralCode");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.JobOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderHd_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.JobOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderHd_Registration");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.JobOrderHd).HasConstraintName("FK_JobOrderHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.JobOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.JobOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderHd_sysTransactionCode");
        });

        modelBuilder.Entity<JobOrderHdPaymentType>(entity =>
        {
            entity.HasKey(e => e.JobOrderNo).HasName("PK_JobOrderHdPaymentType_2");
        });

        modelBuilder.Entity<JobOrderImagingReference>(entity =>
        {
            entity.HasOne(d => d.JobOrderDt).WithOne(p => p.JobOrderImagingReference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderImagingReference_JobOrderDt");
        });

        modelBuilder.Entity<JobOrderLaboratoryReference>(entity =>
        {
            entity.HasOne(d => d.JobOrderDt).WithOne(p => p.JobOrderLaboratoryReference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderLaboratoryReference_JobOrderDt");
        });

        modelBuilder.Entity<JobOrderOtherExamReference>(entity =>
        {
            entity.HasOne(d => d.JobOrderDt).WithOne(p => p.JobOrderOtherExamReference)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobOrderOtherExamReference_JobOrderDt");
        });

        modelBuilder.Entity<JournalCashBankDt>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_JournalCashBankDt_IsDeleted");

            entity.HasOne(d => d.CoaCodeNavigation).WithMany(p => p.JournalCashBankDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankDt_ChartOfAccount");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.JournalCashBankDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankDt_Department");

            entity.HasOne(d => d.JournalNoNavigation).WithMany(p => p.JournalCashBankDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankDt_JournalCashBankHd");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.JournalCashBankDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankDt_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.JournalCashBankDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankDt_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.JournalCashBankDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankDt_Site");
        });

        modelBuilder.Entity<JournalCashBankHd>(entity =>
        {
            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.JournalCashBankHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankHd_Department");

            entity.HasOne(d => d.GCCashBankTypeNavigation).WithMany(p => p.JournalCashBankHdGCCashBankTypeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.GCJournalTypeNavigation).WithMany(p => p.JournalCashBankHdGCJournalTypeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.JournalCashBankHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankHd_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.JournalCashBankHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.JournalCashBankHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.JournalCashBankHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalCashBankHd_sysTransactionCode");
        });

        modelBuilder.Entity<JournalDt>(entity =>
        {
            entity.HasKey(e => new { e.JournalNo, e.SequenceNo }).HasName("PK_JournalDt_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_JournalDt_IsDeleted");

            entity.HasOne(d => d.CoaCodeNavigation).WithMany(p => p.JournalDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalDt_ChartOfAccount");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.JournalDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalDt_Department");

            entity.HasOne(d => d.JournalNoNavigation).WithMany(p => p.JournalDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalDt_JournalHd");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.JournalDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalDt_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.JournalDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalDt_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.JournalDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalDt_Site");
        });

        modelBuilder.Entity<JournalHd>(entity =>
        {
            entity.HasKey(e => e.JournalNo).HasName("PK_JournalHd_1");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.JournalHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalHd_Department");

            entity.HasOne(d => d.GCJournalTypeNavigation).WithMany(p => p.JournalHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalHd_sysGeneralCode");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.JournalHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalHd_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.JournalHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.JournalHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.JournalHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalHd_sysTransactionCode");
        });

        modelBuilder.Entity<KartuPesertaStatusKB>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.KartuPesertaStatusKB)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KartuPesertaStatusKB_Registration");
        });

        modelBuilder.Entity<KeluhanPPI>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.KeluhanPPI)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KeluhanPPI_RegistrationNo");
        });

        modelBuilder.Entity<KeluhanUtamaPasien>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SnomedCode }).HasName("PK_KeluhanUtamaPasien_1");
        });

        modelBuilder.Entity<KesimpulanDanSaranMCU>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_KesimpulanDanSaranMCU_IsDeleted");
        });

        modelBuilder.Entity<KetersediaanKebutuhanAlkes>(entity =>
        {
            entity.Property(e => e.IdKebutuhan).ValueGeneratedNever();
        });

        modelBuilder.Entity<LOINC>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_LOINC_IsActive");
            entity.Property(e => e.LastUpdatedDateTime).HasDefaultValueSql("(getdate())", "DF_LOINC_LastUpdatedDateTime");
        });

        modelBuilder.Entity<LaboratorySummaryMCU>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_LaboratorySummaryMCU_IsDeleted");
        });

        modelBuilder.Entity<LaporanBulananPasienPoliGizi>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<LaporanKantinBulanan>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<LaporanOperasi>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.LaporanOperasi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LaporanOperasi_Registration");
        });

        modelBuilder.Entity<LaporanPelayananResepEntry>(entity =>
        {
            entity.HasKey(e => new { e.DrugDispensingTime, e.ItemId, e.BusinessPartnerId }).HasName("PK_LaporanPelayananResepEntry_1");
        });

        modelBuilder.Entity<LaporanPengecekanKantinDt1>(entity =>
        {
            entity.Property(e => e.Nomor).ValueGeneratedNever();
        });

        modelBuilder.Entity<LaporanPengecekanKantinDt2>(entity =>
        {
            entity.Property(e => e.Nomor).ValueGeneratedNever();
        });

        modelBuilder.Entity<LaporanPengecekanKantinTable>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<LeaveAdjustmentDt>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.LeaveAdjustmentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveAdjustmentDt_Employee");

            entity.HasOne(d => d.LeaveAdjustmentNoNavigation).WithMany(p => p.LeaveAdjustmentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveAdjustmentDt_LeaveAdjustmentHd");
        });

        modelBuilder.Entity<LeaveAdjustmentHd>(entity =>
        {
            entity.HasOne(d => d.LeaveCodeNavigation).WithMany(p => p.LeaveAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveAdjustmentHd_LeaveType");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.LeaveAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveAdjustmentHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.LeaveAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveAdjustmentHd_sysTransactionCode");
        });

        modelBuilder.Entity<LeaveCashable>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.LeaveCashable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveCashable_Employee");
        });

        modelBuilder.Entity<LeaveHistory>(entity =>
        {
            entity.HasOne(d => d.EmployeeLeave).WithMany(p => p.LeaveHistory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveHistory_EmployeeLeave");
        });

        modelBuilder.Entity<LeaveRequest>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.LeaveRequest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveRequest_Employee");

            entity.HasOne(d => d.LeaveCodeNavigation).WithMany(p => p.LeaveRequest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveRequest_LeaveType");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.LeaveRequest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveRequest_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.LeaveRequest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveRequest_sysTransactionCode");
        });

        modelBuilder.Entity<LeaveType>(entity =>
        {
            entity.HasOne(d => d.GCLeavePeriodNavigation).WithMany(p => p.LeaveType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveType_sysGeneralCode");
        });

        modelBuilder.Entity<ListAdvanceMasterCheck>(entity =>
        {
            entity.Property(e => e.DataResultRemarks).HasDefaultValue("", "DF_ListAdvanceMasterCheck_DataResultRemarks");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationID).HasFillFactor(90);

            entity.HasIndex(e => e.SiteCode, "IX_Location_SiteCode").HasFillFactor(90);

            entity.HasIndex(e => e.LocationCode, "UNIQUE_IX_Location_ItemCode")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Initial).HasDefaultValue("", "DF_Location_Initial");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Location_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_Location_Remarks");
            entity.Property(e => e.ShortName).HasDefaultValue("", "DF_Location_ShortName");

            entity.HasOne(d => d.PermissionCodeNavigation).WithMany(p => p.Location).HasConstraintName("FK_Location_LocationPermissionHd");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.Location)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_Site");
        });

        modelBuilder.Entity<LocationItemRack>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.LocationItemRack)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationItemRack_Item");

            entity.HasOne(d => d.Location).WithMany(p => p.LocationItemRack)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationItemRack_Location");
        });

        modelBuilder.Entity<LocationPermissionHd>(entity =>
        {
            entity.HasKey(e => e.PermissionCode)
                .HasName("PK_LocationPermission")
                .HasFillFactor(90);

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_LocationPermissionHd_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_LocationPermissionHd_Remarks");
        });

        modelBuilder.Entity<LoopTest>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MCUElektrokardiogram>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_MCUElektrokardiogram_IsDeleted");
        });

        modelBuilder.Entity<MCUHealthItemGroup>(entity =>
        {
            entity.HasOne(d => d.Parent).WithMany(p => p.MCUHealthItemGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MCUHealthItemGroup_sysGeneralCode");
        });

        modelBuilder.Entity<MCUHealthSummary>(entity =>
        {
            entity.HasOne(d => d.GCHealthStatusNavigation).WithMany(p => p.MCUHealthSummaryGCHealthStatusNavigation).HasConstraintName("FK_MCUHealthSummary_sysGeneralCode1");

            entity.HasOne(d => d.GCHealthStatusGeneratedNavigation).WithMany(p => p.MCUHealthSummaryGCHealthStatusGeneratedNavigation).HasConstraintName("FK_MCUHealthSummary_sysGeneralCode2");

            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.MCUHealthSummary)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MCUHealthSummary_Registration");
        });

        modelBuilder.Entity<MCUOdontogram>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_MCUOdontogram_IsDeleted");
        });

        modelBuilder.Entity<METargetHd>(entity =>
        {
            entity.HasOne(d => d.GCGroupIndicatorNavigation).WithMany(p => p.METargetHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_METargetHd_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.METargetHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_METargetHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.METargetHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_METargetHd_sysTransactionCode");
        });

        modelBuilder.Entity<MIMSClass>(entity =>
        {
            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation).HasConstraintName("FK_MIMSClass_MIMSClass");
        });

        modelBuilder.Entity<MRPHistoryDt>(entity =>
        {
            entity.HasOne(d => d.MRPHistorySubDt).WithMany(p => p.MRPHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MRPHistoryDt_MRPHistorySubDt");
        });

        modelBuilder.Entity<MRPHistoryHd>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.MRPHistoryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MRPHistoryHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.MRPHistoryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MRPHistoryHd_sysTransactionCode");
        });

        modelBuilder.Entity<MRPHistorySubDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.MRPHistorySubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MRPHistorySubDt_Item");

            entity.HasOne(d => d.MRPNoNavigation).WithMany(p => p.MRPHistorySubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MRPHistorySubDt_MRPHistorySubDt");
        });

        modelBuilder.Entity<MarkUpPrice>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_MarkUpPrice_IsDeleted");

            entity.HasOne(d => d.ClassCategoryCodeNavigation).WithMany(p => p.MarkUpPrice).HasConstraintName("FK_MarkUpPrice_ClassCategory");

            entity.HasOne(d => d.GcItemTypeNavigation).WithMany(p => p.MarkUpPrice).HasConstraintName("FK_MarkUpPrice_sysGeneralCode");

            entity.HasOne(d => d.ItemGroupCodeNavigation).WithMany(p => p.MarkUpPrice).HasConstraintName("FK_MarkUpPrice_ItemGroup");

            entity.HasOne(d => d.Item).WithMany(p => p.MarkUpPrice).HasConstraintName("FK_MarkUpPrice_Item");
        });

        modelBuilder.Entity<MassLeaveDt>(entity =>
        {
            entity.HasOne(d => d.DocumentNoNavigation).WithMany(p => p.MassLeaveDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MassLeaveDt_MassLeaveHd");

            entity.HasOne(d => d.Employee).WithMany(p => p.MassLeaveDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MassLeaveDt_Employee");
        });

        modelBuilder.Entity<MassLeaveHd>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.MassLeaveHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MassLeaveHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.MassLeaveHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MassLeaveHd_sysTransactionCode");
        });

        modelBuilder.Entity<MasterEmployee>(entity =>
        {
            entity.HasKey(e => e.MasterEmployeeID).HasName("PK__MasterEm__C76BE5B460813868");
        });

        modelBuilder.Entity<MasterQoS>(entity =>
        {
            entity.Property(e => e.DataID).ValueGeneratedNever();
        });

        modelBuilder.Entity<MasterReferensiSdm>(entity =>
        {
            entity.Property(e => e.IdKebutuhan).ValueGeneratedNever();
        });

        modelBuilder.Entity<MataAnggaran>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_MataAnggaran_IsActive");
        });

        modelBuilder.Entity<MaterialRequestCompletionDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.MaterialRequestCompletionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.MaterialRequestCompletionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionDt_ItemUnit");

            entity.HasOne(d => d.MRCompletionNoNavigation).WithMany(p => p.MaterialRequestCompletionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionDt_MaterialRequestCompletionHd");

            entity.HasOne(d => d.MaterialRequestDt).WithMany(p => p.MaterialRequestCompletionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionDt_MaterialRequestDt");
        });

        modelBuilder.Entity<MaterialRequestCompletionHd>(entity =>
        {
            entity.HasOne(d => d.CoaCodeDebitNavigation).WithMany(p => p.MaterialRequestCompletionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionHd_ChartOfAccount");

            entity.HasOne(d => d.FromLocation).WithMany(p => p.MaterialRequestCompletionHdFromLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionHd_Location_LocationIdFrom");

            entity.HasOne(d => d.FromServiceUnit).WithMany(p => p.MaterialRequestCompletionHdFromServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionHd_DepartmentServiceUnit_ServiceUnitIdFrom");

            entity.HasOne(d => d.GCMRComplitionTypeNavigation).WithMany(p => p.MaterialRequestCompletionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionHd_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.MaterialRequestCompletionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionHd_Site");

            entity.HasOne(d => d.ToLocation).WithMany(p => p.MaterialRequestCompletionHdToLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionHd_Location_LocationIdTo");

            entity.HasOne(d => d.ToServiceUnit).WithMany(p => p.MaterialRequestCompletionHdToServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestCompletionHd_DepartmentServiceUnit_ServiceUnitIdTo");
        });

        modelBuilder.Entity<MaterialRequestDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.MaterialRequestDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.MaterialRequestDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestDt_ItemUnit");

            entity.HasOne(d => d.MaterialRequestNoNavigation).WithMany(p => p.MaterialRequestDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestDt_MaterialRequestHd");
        });

        modelBuilder.Entity<MaterialRequestHd>(entity =>
        {
            entity.Property(e => e.Notes).HasDefaultValue("", "DF_MaterialRequestHd_Notes");

            entity.HasOne(d => d.FromLocation).WithMany(p => p.MaterialRequestHdFromLocation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromServiceUnit).WithMany(p => p.MaterialRequestHdFromServiceUnit).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.MaterialRequestHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestHd_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.MaterialRequestHd).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToLocation).WithMany(p => p.MaterialRequestHdToLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestHd_Location_ToLocationId");

            entity.HasOne(d => d.ToServiceUnit).WithMany(p => p.MaterialRequestHdToServiceUnit).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.MaterialRequestHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestHd_sysTransactionCode");
        });

        modelBuilder.Entity<McuDateMaster>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_McuDateMaster_id");
        });

        modelBuilder.Entity<McuHealthSummaryPersonal>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.McuHealthSummaryPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_McuHealthSummaryPersonal_Registration");
        });

        modelBuilder.Entity<MedicalRecordList>(entity =>
        {
            entity.HasOne(d => d.GCMedicalRecordCategoryNavigation).WithMany(p => p.MedicalRecordList)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicalRecordList_sysGeneralCode");
        });

        modelBuilder.Entity<MedicationConsumUnit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<MedicationReconciliationAdministration>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_MedicationReconciliationAdministration_1");
        });

        modelBuilder.Entity<MedicationReconciliationHd>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenNo }).HasName("PK_MedicationReconciliationHd_1");
        });

        modelBuilder.Entity<MobileJKNKodeBooking>(entity =>
        {
            entity.HasKey(e => e.KodeBooking).HasName("PK_MobileJKNKodeBooking_2");
        });

        modelBuilder.Entity<MobileJKNMembership>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK_MobileJKNMembership_2");
        });

        modelBuilder.Entity<MobileMembership>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_MobileMembership_IsActive");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.MobileMembership).HasConstraintName("FK_MobileMembership_sysGeneralCode");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.MobileMembership).HasConstraintName("FK_MobileMembership_Patient");
        });

        modelBuilder.Entity<MonitoringAdministration>(entity =>
        {
            entity.HasKey(e => new { e.JobOrderNo, e.SequenceNo, e.VitalSignCode, e.AdministrationDateTime }).HasName("PK_MonitoringAdministration_1");

            entity.HasOne(d => d.VitalSignCodeNavigation).WithMany(p => p.MonitoringAdministration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitoringAdministration_VitalSignType");

            entity.HasOne(d => d.JobOrderDtMonitoring).WithMany(p => p.MonitoringAdministration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitoringAdministration_JobOrderDtMonitoring");
        });

        modelBuilder.Entity<MonitoringKantin>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonitoringKantinOther>(entity =>
        {
            entity.HasOne(d => d.IDNavigation).WithMany(p => p.MonitoringKantinOther)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonitoringKantinOther_MonitoringKantin");
        });

        modelBuilder.Entity<MonitoringSignMCU>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_MonitoringSignMCU_1");
        });

        modelBuilder.Entity<MonitoringStatusFisiologisDt>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_MonitoringStatusFisiologisDt_IsDeleted");
        });

        modelBuilder.Entity<MonitoringStatusFisiologisHd>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_MonitoringStatusFisiologisHd_IsDeleted");
        });

        modelBuilder.Entity<MonthlyHospitalPerformance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MonthlyH__3214EC07E250A715");
        });

        modelBuilder.Entity<Morphology>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Morphology_IsActive");

            entity.HasOne(d => d.DiagnosisCodeNavigation).WithMany(p => p.Morphology).HasConstraintName("FK_Morphology_Diagnosis");
        });

        modelBuilder.Entity<MorseFallScore>(entity =>
        {
            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.MorseFallScore)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MorseFallScore_Patient");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.MorseFallScore).HasConstraintName("FK_MorseFallScore_Registration");
        });

        modelBuilder.Entity<MultiPayerAuthorized>(entity =>
        {
            entity.HasOne(d => d.BussinessPartner).WithMany(p => p.MultiPayerAuthorized)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MultiPayerAuthorized_BusinessPartner");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.MultiPayerAuthorized)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MultiPayerAuthorized_Registration");
        });

        modelBuilder.Entity<Nanda>(entity =>
        {
            entity.HasKey(e => e.NandaCode).HasName("PK_NANDA_1");
        });

        modelBuilder.Entity<NandaCharacteristic>(entity =>
        {
            entity.HasKey(e => e.NandaCharacteristicCode).HasName("PK_NANDACharacteristic_1");

            entity.Property(e => e.LastUpdatedBy).HasDefaultValueSql("((0))", "DF_NandaCharacteristic_LastUpdatedBy");

            entity.HasOne(d => d.NandaCharacteristicGroupCodeNavigation).WithMany(p => p.NandaCharacteristic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaCharacteristic_NandaCharacteristicGroup");

            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NandaCharacteristic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaCharacteristic_Nanda");
        });

        modelBuilder.Entity<NandaCharacteristicGroup>(entity =>
        {
            entity.HasKey(e => e.NandaCharacteristicGroupCode).HasName("PK_NANDACharacteristicGroup");
        });

        modelBuilder.Entity<NandaClass>(entity =>
        {
            entity.HasKey(e => e.NandaClassCode).HasName("PK_NANDAClass_1");

            entity.HasOne(d => d.NandaDomainCodeNavigation).WithMany(p => p.NandaClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaClass_NandaDomain");
        });

        modelBuilder.Entity<NandaDomain>(entity =>
        {
            entity.HasKey(e => e.NandaDomainCode).HasName("PK_NANDADomain");
        });

        modelBuilder.Entity<NandaNicAdditional>(entity =>
        {
            entity.HasKey(e => new { e.NandaCode, e.NicCode }).HasName("PK_NANDANICAdditional");

            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NandaNicAdditional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNicAdditional_Nanda");

            entity.HasOne(d => d.NicCodeNavigation).WithMany(p => p.NandaNicAdditional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNicAdditional_Nic");
        });

        modelBuilder.Entity<NandaNicPriority>(entity =>
        {
            entity.HasKey(e => new { e.NandaCode, e.NicCode }).HasName("PK_NANDANIC");

            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NandaNicPriority)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNicPriority_Nanda");

            entity.HasOne(d => d.NicCodeNavigation).WithMany(p => p.NandaNicPriority)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNicPriority_Nic");
        });

        modelBuilder.Entity<NandaNicSuggested>(entity =>
        {
            entity.HasKey(e => new { e.NandaCode, e.NicCode }).HasName("PK_NANDANICSuggested");

            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NandaNicSuggested)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNicSuggested_Nanda");

            entity.HasOne(d => d.NicCodeNavigation).WithMany(p => p.NandaNicSuggested)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNicSuggested_Nic");
        });

        modelBuilder.Entity<NandaNocAdditional>(entity =>
        {
            entity.HasKey(e => new { e.NandaCode, e.NocCode }).HasName("PK_NANDANOCAdditional");

            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NandaNocAdditional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNocAdditional_Nanda");

            entity.HasOne(d => d.NocCodeNavigation).WithMany(p => p.NandaNocAdditional)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNocAdditional_Noc");
        });

        modelBuilder.Entity<NandaNocSuggested>(entity =>
        {
            entity.HasKey(e => new { e.NandaCode, e.NocCode }).HasName("PK_NANDANOC");

            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NandaNocSuggested)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNocSuggested_Nanda");

            entity.HasOne(d => d.NocCodeNavigation).WithMany(p => p.NandaNocSuggested)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaNocSuggested_Noc");
        });

        modelBuilder.Entity<NandaRelatedFactor>(entity =>
        {
            entity.HasKey(e => e.NandaRelatedFactorCode).HasName("PK_NANDARelatedFactor_1");

            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NandaRelatedFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaRelatedFactor_Nanda");

            entity.HasOne(d => d.NandaRelatedFactorGroupCodeNavigation).WithMany(p => p.NandaRelatedFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaRelatedFactor_NandaRelatedFactorGroup");
        });

        modelBuilder.Entity<NandaRelatedFactorGroup>(entity =>
        {
            entity.HasKey(e => e.NandaRelatedFactorGroupCode).HasName("PK_NANDARelatedFactorGroup");
        });

        modelBuilder.Entity<NandaRiskFactor>(entity =>
        {
            entity.HasKey(e => e.NandaRiskFactorCode).HasName("PK_NANDARiskFactor");

            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NandaRiskFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaRiskFactor_Nanda");

            entity.HasOne(d => d.NandaRiskFactorGroupCodeNavigation).WithMany(p => p.NandaRiskFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaRiskFactor_NandaRiskFactorGroup");
        });

        modelBuilder.Entity<NandaRiskFactorGroup>(entity =>
        {
            entity.HasKey(e => e.NandaRiskFactorGroupCode).HasName("PK_NANDARiskFactorGroup");
        });

        modelBuilder.Entity<NandaTemplateDt>(entity =>
        {
            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NandaTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaTemplateDt_Nanda");

            entity.HasOne(d => d.TemplateCodeNavigation).WithMany(p => p.NandaTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NandaTemplateDt_NandaTemplateHd");
        });

        modelBuilder.Entity<Nic>(entity =>
        {
            entity.HasKey(e => e.NicCode).HasName("PK_NIC");

            entity.HasOne(d => d.NicClassCodeNavigation).WithMany(p => p.Nic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nic_NicClass");
        });

        modelBuilder.Entity<NicActivity>(entity =>
        {
            entity.HasKey(e => e.NicActivityCode).HasName("PK_NICActivity");

            entity.HasOne(d => d.NicCodeNavigation).WithMany(p => p.NicActivity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NicActivity_Nic");
        });

        modelBuilder.Entity<NicClass>(entity =>
        {
            entity.HasKey(e => e.NicClassCode).HasName("PK_NICClass");

            entity.HasOne(d => d.NicDomainCodeNavigation).WithMany(p => p.NicClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NicClass_NicDomain");
        });

        modelBuilder.Entity<NicDomain>(entity =>
        {
            entity.HasKey(e => e.NicDomainCode).HasName("PK_NICDomain");
        });

        modelBuilder.Entity<Noc>(entity =>
        {
            entity.HasKey(e => e.NocCode).HasName("PK_NOC");

            entity.HasOne(d => d.NocClassCodeNavigation).WithMany(p => p.Noc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Noc_NocClass");
        });

        modelBuilder.Entity<NocClass>(entity =>
        {
            entity.HasKey(e => e.NocClassCode).HasName("PK_NOCClass_1");

            entity.HasOne(d => d.NocDomainCodeNavigation).WithMany(p => p.NocClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NocClass_NocDomain");
        });

        modelBuilder.Entity<NocDomain>(entity =>
        {
            entity.HasKey(e => e.NocDomainCode).HasName("PK_NOCDomain");
        });

        modelBuilder.Entity<NocIndicator>(entity =>
        {
            entity.HasKey(e => e.NocIndicatorCode).HasName("PK_NOCIndicator");

            entity.HasOne(d => d.NocCodeNavigation).WithMany(p => p.NocIndicator)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NocIndicator_Noc");

            entity.HasOne(d => d.NocScaleCodeNavigation).WithMany(p => p.NocIndicator)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NocIndicator_NocScale");
        });

        modelBuilder.Entity<NocScale>(entity =>
        {
            entity.HasKey(e => e.NocScaleCode).HasName("PK_NOCScale");
        });

        modelBuilder.Entity<NotaDinasTable>(entity =>
        {
            entity.HasKey(e => e.NomorNota).HasName("PK_NotaDinas");
        });

        modelBuilder.Entity<NotulenRapatFile>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK_NotulenRapatFile_1");
        });

        modelBuilder.Entity<NsDrugAdministration>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsDrugAdministration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsDrugAdministration_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsJobOrderBOMImaging>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsJobOrderBOMImaging)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsJobOrderBOMImaging_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsJobOrderBOMLaboratory>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsJobOrderBOMLaboratory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsJobOrderBOMLaboratory_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsJobOrderBOMOtherExam>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.JobOrderNo, e.SequenceNo, e.ItemID }).HasName("PK_NsJobOrderBOMOtherExam_1");

            entity.HasOne(d => d.Detail).WithMany(p => p.NsJobOrderBOMOtherExam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsJobOrderBOMOtherExam_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsJobOrderDt>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.JobOrderNo, e.SequenceNo }).HasName("PK_NsJobOrderDt_1");

            entity.Property(e => e.CostPrice).HasDefaultValue(0m, "DF_NsJobOrderDt_CostPrice");
            entity.Property(e => e.CustomerCitoCompPrice).HasDefaultValue(0m, "DF_NsJobOrderDt_CustomerCitoCompPrice");
            entity.Property(e => e.CustomerPrice).HasDefaultValue(0m, "DF_NsJobOrderDt_CustomerPrice");
            entity.Property(e => e.DiscountPrice).HasDefaultValue(0m, "DF_NsJobOrderDt_DiscountPrice");
            entity.Property(e => e.OrderNotes).HasDefaultValue("", "DF_NsJobOrderDt_OrderNotes");
            entity.Property(e => e.PersonalCitoCompPrice).HasDefaultValue(0m, "DF_NsJobOrderDt_PersonalCitoCompPrice");
            entity.Property(e => e.PersonalPrice).HasDefaultValue(0m, "DF_NsJobOrderDt_PersonalPrice");
            entity.Property(e => e.StandartPrice).HasDefaultValue(0m, "DF_NsJobOrderDt_StandartPrice");
            entity.Property(e => e.TotalCustomer).HasDefaultValue(0m, "DF_NsJobOrderDt_TotalCustomer");
            entity.Property(e => e.TotalPersonal).HasDefaultValue(0m, "DF_NsJobOrderDt_TotalPersonal");

            entity.HasOne(d => d.Detail).WithMany(p => p.NsJobOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsJobOrderDt_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsJobOrderDtDiagnose>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.JobOrderNo, e.SequenceNo, e.DiagnosisCode }).HasName("PK_NsJobOrderDtDiagnose_1");

            entity.HasOne(d => d.Detail).WithMany(p => p.NsJobOrderDtDiagnose)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsJobOrderDtDiagnose_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsJobOrderDtMedication>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.JobOrderNo, e.SequenceNo }).HasName("PK_NsJobOrderDtMedication_1");

            entity.Property(e => e.RFlag).IsFixedLength();

            entity.HasOne(d => d.Detail).WithMany(p => p.NsJobOrderDtMedication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsJobOrderDtMedication_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsJobOrderDtMonitoring>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.JobOrderNo, e.SequenceNo }).HasName("PK_NsJobOrderDtMonitoring_1");

            entity.HasOne(d => d.Detail).WithMany(p => p.NsJobOrderDtMonitoring)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsJobOrderDtMonitoring_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsJobOrderHd>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.JobOrderNo }).HasName("PK_NsJobOrderHd_1");

            entity.HasOne(d => d.Detail).WithMany(p => p.NsJobOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsJobOrderHd_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsMonitoringAdministration>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsMonitoringAdministration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsMonitoringAdministration_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsNursingCareplan>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsNursingCareplan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsNursingCareplan_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsNursingCareplanCharacteristic>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.NursingCareplanCharacteristicID }).HasName("PK_NsNursingCareplanCharacteristic_1");

            entity.HasOne(d => d.Detail).WithMany(p => p.NsNursingCareplanCharacteristic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsNursingCareplanCharacteristic_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsNursingCareplanIntervention>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsNursingCareplanIntervention)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsNursingCareplanIntervention_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsNursingCareplanInterventionActivity>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsNursingCareplanInterventionActivity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsNursingCareplanInterventionActivity_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsNursingCareplanOutcome>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsNursingCareplanOutcome)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsNursingCareplanOutcome_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsNursingCareplanOutcomeResult>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsNursingCareplanOutcomeResult)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsNursingCareplanOutcomeResult_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsNursingCareplanRelatedFactor>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsNursingCareplanRelatedFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsNursingCareplanRelatedFactor_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsNursingCareplanRiskFactor>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsNursingCareplanRiskFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsNursingCareplanRiskFactor_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NsOtherExamResultAttachment>(entity =>
        {
            entity.HasOne(d => d.Detail).WithMany(p => p.NsOtherExamResultAttachment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NsOtherExamResultAttachment_NurseShiftTransferHistoryDt");
        });

        modelBuilder.Entity<NurseShiftTransferHistoryDt>(entity =>
        {
            entity.Property(e => e.DetailId).ValueGeneratedNever();

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.NurseShiftTransferHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NurseShiftTransferHistoryDt_Registration");

            entity.HasOne(d => d.Transfer).WithMany(p => p.NurseShiftTransferHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NurseShiftTransferHistoryDt_NurseShiftTransferHistoryHd");
        });

        modelBuilder.Entity<NurseShiftTransferHistoryHd>(entity =>
        {
            entity.Property(e => e.TransferId).ValueGeneratedNever();

            entity.HasOne(d => d.FromNurse).WithMany(p => p.NurseShiftTransferHistoryHdFromNurse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NurseShiftTransferHistoryHd_Paramedic");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.NurseShiftTransferHistoryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NurseShiftTransferHistoryHd_DepartmentServiceUnit");

            entity.HasOne(d => d.ToNurse).WithMany(p => p.NurseShiftTransferHistoryHdToNurse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NurseShiftTransferHistoryHd_Paramedic1");
        });

        modelBuilder.Entity<NursingCareplan>(entity =>
        {
            entity.HasOne(d => d.NandaCodeNavigation).WithMany(p => p.NursingCareplan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplan_Nanda");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.NursingCareplan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplan_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.NursingCareplan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplan_Site");
        });

        modelBuilder.Entity<NursingCareplanCharacteristic>(entity =>
        {
            entity.HasKey(e => e.NursingCareplanCharacteristicID).HasName("PK_NursingCareplanCharacteristic_1");

            entity.HasOne(d => d.NandaCharacteristicCodeNavigation).WithMany(p => p.NursingCareplanCharacteristic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanCharacteristic_NandaCharacteristic");

            entity.HasOne(d => d.NursingCareplan).WithMany(p => p.NursingCareplanCharacteristic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanCharacteristic_NursingCareplanCharacteristic");
        });

        modelBuilder.Entity<NursingCareplanIntervention>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.NursingCareplanNo, e.NursingCareplanInterventionNo }).HasName("PK_NursingCareplanIntervention_1");

            entity.HasOne(d => d.NicCodeNavigation).WithMany(p => p.NursingCareplanIntervention)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanIntervention_Nic");

            entity.HasOne(d => d.NursingCareplan).WithMany(p => p.NursingCareplanIntervention)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanIntervention_NursingCareplan");
        });

        modelBuilder.Entity<NursingCareplanInterventionActivity>(entity =>
        {
            entity.HasOne(d => d.NicActivityCodeNavigation).WithMany(p => p.NursingCareplanInterventionActivity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanInterventionActivity_NicActivity");

            entity.HasOne(d => d.NursingCareplanIntervention).WithMany(p => p.NursingCareplanInterventionActivity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanInterventionActivity_NursingCareplanIntervention");
        });

        modelBuilder.Entity<NursingCareplanOutcome>(entity =>
        {
            entity.HasOne(d => d.NocCodeNavigation).WithMany(p => p.NursingCareplanOutcome)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanOutcome_Noc");

            entity.HasOne(d => d.NursingCareplan).WithMany(p => p.NursingCareplanOutcome)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanOutcome_NursingCareplan");
        });

        modelBuilder.Entity<NursingCareplanOutcomeResult>(entity =>
        {
            entity.HasOne(d => d.NocIndicatorCodeNavigation).WithMany(p => p.NursingCareplanOutcomeResult)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanOutcomeResult_NocIndicator");

            entity.HasOne(d => d.NursingCareplanOutcome).WithMany(p => p.NursingCareplanOutcomeResult)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanOutcomeResult_NursingCareplanOutcome");
        });

        modelBuilder.Entity<NursingCareplanRelatedFactor>(entity =>
        {
            entity.HasKey(e => e.NursingCareplanRelatedFactorID).HasName("PK_NursingCareplanRelatedFactor_1");

            entity.HasOne(d => d.NandaRelatedFactorCodeNavigation).WithMany(p => p.NursingCareplanRelatedFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanRelatedFactor_NandaRelatedFactor");

            entity.HasOne(d => d.NursingCareplan).WithMany(p => p.NursingCareplanRelatedFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanRelatedFactor_NursingCareplan");
        });

        modelBuilder.Entity<NursingCareplanRiskFactor>(entity =>
        {
            entity.HasKey(e => e.NursingCareplanRiskFactorID).HasName("PK_NursingCareplanRiskFactor_1");

            entity.HasOne(d => d.NandaRiskFactorCodeNavigation).WithMany(p => p.NursingCareplanRiskFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanRiskFactor_NandaRiskFactor");

            entity.HasOne(d => d.NursingCareplan).WithMany(p => p.NursingCareplanRiskFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NursingCareplanRiskFactor_NursingCareplan");
        });

        modelBuilder.Entity<OTProgressInformation>(entity =>
        {
            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_OTProgressInformation_OTProgressInformation");
        });

        modelBuilder.Entity<OTReportConfiguration>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK_OTReportConfiguration_1");
        });

        modelBuilder.Entity<OdontogramMCU>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_OdontogramMCU_IsDeleted");

            entity.HasOne(d => d.GCToothNavigation).WithMany(p => p.OdontogramMCUGCToothNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OdontogramMCU_SysGeneralCode_Tooth");

            entity.HasOne(d => d.GCToothProblemNavigation).WithMany(p => p.OdontogramMCUGCToothProblemNavigation).HasConstraintName("FK_OdontogramMCU_SysGeneralCode_ToothProblem");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.OdontogramMCU)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OdontogramMCU_Patient");

            entity.HasOne(d => d.ProcedureCodeNavigation).WithMany(p => p.OdontogramMCU).HasConstraintName("FK_OdontogramMCU_Procedure");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.OdontogramMCU).HasConstraintName("FK_OdontogramMCU_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.OdontogramMCU).HasConstraintName("FK_OdontogramMCU_OdontogramMCU");
        });

        modelBuilder.Entity<OrderMenuDiitHd>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.OrderMenuDiitHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderMenuDiitHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.OrderMenuDiitHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderMenuDiitHd_Site");
        });

        modelBuilder.Entity<OrderableDrugFormV3>(entity =>
        {
            entity.HasKey(e => new { e.Code, e.ReferrenceCode }).HasName("PK_OrderableDrugFormV3_1");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Organization_IsActive");

            entity.HasOne(d => d.OrganizationHeadNavigation).WithMany(p => p.Organization).HasConstraintName("FK_Organization_Employee");

            entity.HasOne(d => d.ParentOrganizationNavigation).WithMany(p => p.InverseParentOrganizationNavigation).HasConstraintName("FK_Organization_Organization1");
        });

        modelBuilder.Entity<OtherExamResultAttachment>(entity =>
        {
            entity.HasOne(d => d.JobOrderBOMOtherExam).WithMany(p => p.OtherExamResultAttachment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OtherExamResultAttachment_JobOrderBOMOtherExam");
        });

        modelBuilder.Entity<OutstandingDODt>(entity =>
        {
            entity.HasOne(d => d.DistributionOrderNoNavigation).WithMany(p => p.OutstandingDODt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDODt_DistributionOrderHd");

            entity.HasOne(d => d.Item).WithMany(p => p.OutstandingDODt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDODt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.OutstandingDODt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDODt_ItemUnit");
        });

        modelBuilder.Entity<OutstandingDOHd>(entity =>
        {
            entity.Property(e => e.IsReviewed).HasDefaultValue(false, "DF_OutstandingDOHd_IsReviewed");

            entity.HasOne(d => d.FromLocation).WithMany(p => p.OutstandingDOHdFromLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDOHd_Location");

            entity.HasOne(d => d.FromServiceUnit).WithMany(p => p.OutstandingDOHdFromServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDOHd_DepartmentServiceUnit_FromServiceUnit");

            entity.HasOne(d => d.FromSiteCodeNavigation).WithMany(p => p.OutstandingDOHdFromSiteCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDOHd_Site_FromSite");

            entity.HasOne(d => d.FromSiteDepartment).WithMany(p => p.OutstandingDOHdFromSiteDepartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDOHd_SiteDepartment_FromSiteDepartment");

            entity.HasOne(d => d.GCDistributionOrderTypeNavigation).WithMany(p => p.OutstandingDOHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDOHd_sysGeneralCode");

            entity.HasOne(d => d.ToLocation).WithMany(p => p.OutstandingDOHdToLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDOHd_Location1");

            entity.HasOne(d => d.ToServiceUnit).WithMany(p => p.OutstandingDOHdToServiceUnit).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToSiteCodeNavigation).WithMany(p => p.OutstandingDOHdToSiteCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToSiteDepartment).WithMany(p => p.OutstandingDOHdToSiteDepartment).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.OutstandingDOHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OutstandingDOHd_sysTransactionCode");
        });

        modelBuilder.Entity<OvertimeWorkOrder>(entity =>
        {
            entity.HasOne(d => d.ShiftCodeNavigation).WithMany(p => p.OvertimeWorkOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimeWorkOrder_WorkShiftHrd");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.OvertimeWorkOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimeWorkOrder_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.OvertimeWorkOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimeWorkOrder_sysTransactionCode");
        });

        modelBuilder.Entity<OvertimeWorkOrderDt>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.OvertimeWorkOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimeWorkOrderDt_Employee");

            entity.HasOne(d => d.WorkOrderNoNavigation).WithMany(p => p.OvertimeWorkOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OvertimeWorkOrderDt_OvertimeWorkOrder");
        });

        modelBuilder.Entity<PMKPMasterIndicatorHd>(entity =>
        {
            entity.Property(e => e.MasterIndicatorID).ValueGeneratedNever();
        });

        modelBuilder.Entity<PMKPMasterRealisasi>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<PMKPTargetDt>(entity =>
        {
            entity.HasKey(e => new { e.Period, e.SequenceNo }).HasName("PK_PMKPTargetDt_1");
        });

        modelBuilder.Entity<PPITargetDt>(entity =>
        {
            entity.HasKey(e => e.SequenceNo).HasName("PK_PPITargetDt_1");
        });

        modelBuilder.Entity<PPITargetHd>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PPITargetHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PPITargetHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PPITargetHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PPITargetHd_sysTransactionCode");
        });

        modelBuilder.Entity<PackageTreatmentDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.PackageTreatmentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackageTreatmentDt_Item");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PackageTreatmentDt).HasConstraintName("FK_PackageTreatmentDt_Paramedic");
        });

        modelBuilder.Entity<PackageTreatmentHd>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.PackageTreatmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackageTreatmentHd_Item");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PackageTreatmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackageTreatmentHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PackageTreatmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackageTreatmentHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PackageTreatmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackageTreatmentHd_sysTransactionCode");
        });

        modelBuilder.Entity<Paramedic>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Paramedic_IsActive");
            entity.Property(e => e.IsAvailable).HasDefaultValue(true, "DF_Paramedic_IsAvailable");
            entity.Property(e => e.LicenseNo).HasDefaultValue("", "DF_Paramedic_LicenseNo");
            entity.Property(e => e.ParamedicInitial).HasDefaultValue("", "DF_Paramedic_ParamedicInitial");
            entity.Property(e => e.PictureFileName).HasDefaultValue("", "DF_Paramedic_PictureFile");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_Paramedic_Remarks");
            entity.Property(e => e.TaxRegistrantNo).HasDefaultValue("", "DF_Paramedic_TaxRegistrantNo");

            entity.HasOne(d => d.GCEmploymentStatusNavigation).WithMany(p => p.ParamedicGCEmploymentStatusNavigation).HasConstraintName("FK_Paramedic_sysGeneralCode_EmploymentStatus");

            entity.HasOne(d => d.GCNationalityNavigation).WithMany(p => p.ParamedicGCNationalityNavigation).HasConstraintName("FK_Paramedic_sysGeneralCode_Nationality");

            entity.HasOne(d => d.GCParamedicTypeNavigation).WithMany(p => p.ParamedicGCParamedicTypeNavigation).HasConstraintName("FK_Paramedic_sysGeneralCode_ParamedicType");

            entity.HasOne(d => d.GCReligionNavigation).WithMany(p => p.ParamedicGCReligionNavigation).HasConstraintName("FK_Paramedic_sysGeneralCode_Religion");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.ParamedicGCSexNavigation).HasConstraintName("FK_Paramedic_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.Paramedic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Paramedic_Site");

            entity.HasOne(d => d.SpecialtyCodeNavigation).WithMany(p => p.Paramedic).HasConstraintName("FK_Paramedic_Specialty");
        });

        modelBuilder.Entity<ParamedicAutoBill>(entity =>
        {
            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.ParamedicAutoBill).HasConstraintName("FK_ParamedicAutoBill_Department");

            entity.HasOne(d => d.Item).WithMany(p => p.ParamedicAutoBill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParamedicAutoBill_Item");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.ParamedicAutoBill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParamedicAutoBill_Paramedic");
        });

        modelBuilder.Entity<ParamedicCertificate>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.ParamedicCertificate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParamedicCertificate_Paramedic");
        });

        modelBuilder.Entity<ParamedicItemMcu>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ParamedicItemMcuItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParamedicItemMcu_Item");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.ParamedicItemMcu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParamedicItemMcu_Paramedic");

            entity.HasOne(d => d.ParentItem).WithMany(p => p.ParamedicItemMcuParentItem).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ParamedicItemMcu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParamedicItemMcu_Site");
        });

        modelBuilder.Entity<ParamedicSignature>(entity =>
        {
            entity.Property(e => e.ParamedicID).IsFixedLength();
        });

        modelBuilder.Entity<ParamedicTypeNote>(entity =>
        {
            entity.HasKey(e => new { e.GCParamedicType, e.GCNote }).HasName("PK_ParamedicNote");

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ParamedicNote_IsActive");
        });

        modelBuilder.Entity<ParamedicVisitType>(entity =>
        {
            entity.HasKey(e => new { e.ParamedicID, e.ServiceUnitID, e.VisitTypeCode }).HasName("PK_ParamedicVisitType_1");

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ParamedicVisitType_IsActive");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.ParamedicVisitType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParamedicVisitType_Paramedic");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ParamedicVisitType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParamedicVisitType_DepartmentServiceUnit");

            entity.HasOne(d => d.VisitTypeCodeNavigation).WithMany(p => p.ParamedicVisitType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParamedicVisitType_VisitType");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("tgrPatientlookUp"));

            entity.Property(e => e.BloodRhesus).IsFixedLength();
            entity.Property(e => e.CityOfBirth).HasDefaultValue("", "DF_Patient_CityOfBirth");
            entity.Property(e => e.Company).HasDefaultValue("", "DF_Patient_Company");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Patient_IsActive");
            entity.Property(e => e.IsAlive).HasDefaultValue(true, "DF_Patient_IsAlive");
            entity.Property(e => e.LastName).HasDefaultValue("", "DF_Patient_LastName");
            entity.Property(e => e.MiddleName).HasDefaultValue("", "DF_Patient_MiddleName");
            entity.Property(e => e.Notes).HasDefaultValue("", "DF_Patient_Notes");
            entity.Property(e => e.OldMedicalNo).HasDefaultValue("", "DF_Patient_OldMedicalNo");
            entity.Property(e => e.PictureFileName).HasDefaultValue("", "DF_Patient_PictureFileName");
            entity.Property(e => e.PreferredName).HasDefaultValue("", "DF_Patient_PreferredName");
            entity.Property(e => e.SSN).HasDefaultValue("", "DF_Patient_SSN");

            entity.HasOne(d => d.GCBloodTypeNavigation).WithMany(p => p.PatientGCBloodTypeNavigation).HasConstraintName("FK_Patient_sysGeneralCode_BloodType");

            entity.HasOne(d => d.GCDependentTypeNavigation).WithMany(p => p.PatientGCDependentTypeNavigation).HasConstraintName("FK_Patient_sysGeneralCode_DependentType");

            entity.HasOne(d => d.GCEducationNavigation).WithMany(p => p.PatientGCEducationNavigation).HasConstraintName("FK_Patient_sysGeneralCode_Education");

            entity.HasOne(d => d.GCMaritalStatusNavigation).WithMany(p => p.PatientGCMaritalStatusNavigation).HasConstraintName("FK_Patient_sysGeneralCode_MaritalStatus");

            entity.HasOne(d => d.GCNationalityNavigation).WithMany(p => p.PatientGCNationalityNavigation).HasConstraintName("FK_Patient_sysGeneralCode_Nationality");

            entity.HasOne(d => d.GCOccupationNavigation).WithMany(p => p.PatientGCOccupationNavigation).HasConstraintName("FK_Patient_sysGeneralCode_Occupation");

            entity.HasOne(d => d.GCPatientCategoryNavigation).WithMany(p => p.PatientGCPatientCategoryNavigation).HasConstraintName("FK_Patient_sysGeneralCode_PatientCategory");

            entity.HasOne(d => d.GCRaceNavigation).WithMany(p => p.PatientGCRaceNavigation).HasConstraintName("FK_Patient_sysGeneralCode_Race");

            entity.HasOne(d => d.GCReligionNavigation).WithMany(p => p.PatientGCReligionNavigation).HasConstraintName("FK_Patient_sysGeneralCode_Religion");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.PatientGCSexNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Patient_sysGeneralCode_Sex");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.Patient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Patient_Site");
        });

        modelBuilder.Entity<Patient23>(entity =>
        {
            entity.Property(e => e.CleanedName).HasComputedColumnSql("([dbo].[fn_CleanNameKompleks]([PatientName]))", true);
        });

        modelBuilder.Entity<PatientAPGAR>(entity =>
        {
            entity.HasOne(d => d.GCAPGARTypeNavigation).WithMany(p => p.PatientAPGARGCAPGARTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAPGAR_sysGeneralCode_APGARType");

            entity.HasOne(d => d.GCActivityMuscleToneNavigation).WithMany(p => p.PatientAPGARGCActivityMuscleToneNavigation).HasConstraintName("FK_PatientAPGAR_sysGeneralCode_ActivityMuscleTone");

            entity.HasOne(d => d.GCAppearanceSkinColorNavigation).WithMany(p => p.PatientAPGARGCAppearanceSkinColorNavigation).HasConstraintName("FK_PatientAPGAR_sysGeneralCode_AppearanceSkinColor");

            entity.HasOne(d => d.GCGrimaceReflexIrritabilityNavigation).WithMany(p => p.PatientAPGARGCGrimaceReflexIrritabilityNavigation).HasConstraintName("FK_PatientAPGAR_sysGeneralCode_GrimaceReflexIrritability");

            entity.HasOne(d => d.GCPulseHeartRateNavigation).WithMany(p => p.PatientAPGARGCPulseHeartRateNavigation).HasConstraintName("FK_PatientAPGAR_sysGeneralCode_PulseHeartRate");

            entity.HasOne(d => d.GCRespirationBreathingNavigation).WithMany(p => p.PatientAPGARGCRespirationBreathingNavigation).HasConstraintName("FK_PatientAPGAR_sysGeneralCode_RespirationBreathing");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientAPGAR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAPGAR_Patient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientAPGAR)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAPGAR_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientAPGAR).HasConstraintName("FK_PatientAPGAR_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientAPGAR).HasConstraintName("FK_PatientAPGAR_Site");
        });

        modelBuilder.Entity<PatientAllergy>(entity =>
        {
            entity.HasKey(e => new { e.MedicalNo, e.SequenceNo }).HasName("PK_PatientAllergy2");

            entity.HasOne(d => d.GCAllergenTypeNavigation).WithMany(p => p.PatientAllergyGCAllergenTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAllergy_sysGeneralCode_AllergenType");

            entity.HasOne(d => d.GCAllergySeverityNavigation).WithMany(p => p.PatientAllergyGCAllergySeverityNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAllergy_sysGeneralCode_AllergySeverity");

            entity.HasOne(d => d.GCAllergySourceNavigation).WithMany(p => p.PatientAllergyGCAllergySourceNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAllergy_sysGeneralCode_AllergySource");

            entity.HasOne(d => d.GCAllergyStatusNavigation).WithMany(p => p.PatientAllergyGCAllergyStatusNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAllergy_sysGeneralCode_AllergyStatus");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientAllergy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAllergy_Patient");
        });

        modelBuilder.Entity<PatientAntibiotik>(entity =>
        {
            entity.HasOne(d => d.GCStatusNavigation).WithMany(p => p.PatientAntibiotik)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAntibiotik_sysGeneralCode");

            entity.HasOne(d => d.Generic).WithMany(p => p.PatientAntibiotik)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAntibiotik_ItemGeneric");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientAntibiotik)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAntibiotik_Patient");
        });

        modelBuilder.Entity<PatientAppointmentVsAdmission>(entity =>
        {
            entity.HasKey(e => new { e.MedicalNo, e.ActivityNo, e.ActivityDateTime }).HasName("PK__PatientA__9CA51487A5AD634D");
        });

        modelBuilder.Entity<PatientAppointmentVsAdmissionY>(entity =>
        {
            entity.HasKey(e => new { e.ServiceUnitCode, e.ParamedicID, e.MedicalNo, e.ActivityPeriod }).HasName("PK__PatientA__8F455349F07E3B62");
        });

        modelBuilder.Entity<PatientAttendance>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientAttendance).HasConstraintName("FK_PatientAttendance_Paramedic");

            entity.HasOne(d => d.Room).WithMany(p => p.PatientAttendance).HasConstraintName("FK_PatientAttendance_ServiceRoom");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.PatientAttendance).HasConstraintName("FK_PatientAttendance_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientAttendance).HasConstraintName("FK_PatientAttendance_Site");

            entity.HasOne(d => d.Status).WithMany(p => p.PatientAttendance)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientAttendance_StatusPriority");

            entity.HasOne(d => d.VisitTypeCodeNavigation).WithMany(p => p.PatientAttendance).HasConstraintName("FK_PatientAttendance_VisitType");
        });

        modelBuilder.Entity<PatientBPU>(entity =>
        {
            entity.HasOne(d => d.GCFrictionAndShearNavigation).WithMany(p => p.PatientBPUGCFrictionAndShearNavigation).HasConstraintName("FK_PatientBPU_sysGeneralCode_FrictionAndShear");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientBPU)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientBPU_Patient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientBPU)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientBPU_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientBPU).HasConstraintName("FK_PatientBPU_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientBPU).HasConstraintName("FK_PatientBPU_Site");
        });

        modelBuilder.Entity<PatientBackup20240130>(entity =>
        {
            entity.Property(e => e.BloodRhesus).IsFixedLength();
        });

        modelBuilder.Entity<PatientBirthRecord>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_PatientBirthRecord_1");

            entity.HasOne(d => d.GCBornConditionNavigation).WithMany(p => p.PatientBirthRecordGCBornConditionNavigation).HasConstraintName("FK_PatientBirthRecord_sysGeneralCode_BornCondition");

            entity.HasOne(d => d.GCCaesarMethodNavigation).WithMany(p => p.PatientBirthRecordGCCaesarMethodNavigation).HasConstraintName("FK_PatientBirthRecord_sysGeneralCode_CaesarMethod");

            entity.HasOne(d => d.GCDeliveryLocationNavigation).WithMany(p => p.PatientBirthRecordGCDeliveryLocationNavigation).HasConstraintName("FK_PatientBirthRecord_sysGeneralCode_DeliveryLocation");

            entity.HasOne(d => d.GCDeliveryMethodNavigation).WithMany(p => p.PatientBirthRecordGCDeliveryMethodNavigation).HasConstraintName("FK_PatientBirthRecord_sysGeneralCode_DeliveryMethod");

            entity.HasOne(d => d.GCParamedicTypeNavigation).WithMany(p => p.PatientBirthRecordGCParamedicTypeNavigation).HasConstraintName("FK_PatientBirthRecord_sysGeneralCode_ParamedicType");

            entity.HasOne(d => d.GCStatusRLPerinatologyNavigation).WithMany(p => p.PatientBirthRecordGCStatusRLPerinatologyNavigation).HasConstraintName("FK_PatientBirthRecord_sysGeneralCode");

            entity.HasOne(d => d.MotherMedicalNoNavigation).WithMany(p => p.PatientBirthRecord).HasConstraintName("FK_PatientBirthRecord_Patient");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientBirthRecordRegistrationNoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientBirthRecord_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientBirthRecord).HasConstraintName("FK_PatientBirthRecord_Site");
        });

        modelBuilder.Entity<PatientBlackList>(entity =>
        {
            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientBlackList)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientBlackList_Patient");
        });

        modelBuilder.Entity<PatientCAPPIRO>(entity =>
        {
            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientCAPPIRO)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCAPPIRO_Patient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientCAPPIRO)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCAPPIRO_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientCAPPIRO).HasConstraintName("FK_PatientCAPPIRO_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientCAPPIRO).HasConstraintName("FK_PatientCAPPIRO_Site");
        });

        modelBuilder.Entity<PatientCHDRisk>(entity =>
        {
            entity.HasOne(d => d.CholesterolValueNavigation).WithMany(p => p.PatientCHDRiskCholesterolValueNavigation).HasConstraintName("FK_PatientCHDRisk_CHDPredictor_Cholesterol");

            entity.HasOne(d => d.DiabetesValueNavigation).WithMany(p => p.PatientCHDRiskDiabetesValueNavigation).HasConstraintName("FK_PatientCHDRisk_CHDPredictor_Diabetes");

            entity.HasOne(d => d.GCDiastolicNavigation).WithMany(p => p.PatientCHDRiskGCDiastolicNavigation).HasConstraintName("FK_PatientCHDRisk_sysGeneralCode_Diastolic");

            entity.HasOne(d => d.GCSystolicNavigation).WithMany(p => p.PatientCHDRiskGCSystolicNavigation).HasConstraintName("FK_PatientCHDRisk_sysGeneralCode_Systolic");

            entity.HasOne(d => d.HDLValueNavigation).WithMany(p => p.PatientCHDRiskHDLValueNavigation).HasConstraintName("FK_PatientCHDRisk_CHDPredictor_HDL");

            entity.HasOne(d => d.LDLValueNavigation).WithMany(p => p.PatientCHDRiskLDLValueNavigation).HasConstraintName("FK_PatientCHDRisk_CHDPredictor_LDL");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientCHDRisk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCHDRisk_Patient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientCHDRisk).HasConstraintName("FK_PatientCHDRisk_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientCHDRisk).HasConstraintName("FK_PatientCHDRisk_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientCHDRisk).HasConstraintName("FK_PatientCHDRisk_Site");

            entity.HasOne(d => d.SmokerValueNavigation).WithMany(p => p.PatientCHDRiskSmokerValueNavigation).HasConstraintName("FK_PatientCHDRisk_CHDPredictor_Smoker");
        });

        modelBuilder.Entity<PatientCancel>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientCancel).HasConstraintName("FK_PatientCancel_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.PatientCancel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCancel_Registration");
        });

        modelBuilder.Entity<PatientCorporateEligibility>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.PatientCorporateEligibility)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCorporateEligibility_BusinessPartner");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientCorporateEligibility)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCorporateEligibility_Registration");
        });

        modelBuilder.Entity<PatientDocument>(entity =>
        {
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_PatientDocument_Remarks");

            entity.HasOne(d => d.GCDocumentTypeNavigation).WithMany(p => p.PatientDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientDocument_sysGeneralCode_DocumentType");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientDocument_Patient");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientDocument_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientDocument).HasConstraintName("FK_PatientDocument_Site");
        });

        modelBuilder.Entity<PatientDocumentDetail>(entity =>
        {
            entity.HasOne(d => d.PatientDocument).WithMany(p => p.PatientDocumentDetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientDocumentDetail_PatientDocument");
        });

        modelBuilder.Entity<PatientFCS>(entity =>
        {
            entity.HasOne(d => d.GCBrainstemReflexesNavigation).WithMany(p => p.PatientFCSGCBrainstemReflexesNavigation).HasConstraintName("FK_PatientFCS_sysGeneralCode_BrainstemReflexes");

            entity.HasOne(d => d.GCEyeResponseNavigation).WithMany(p => p.PatientFCSGCEyeResponseNavigation).HasConstraintName("FK_PatientFCS_sysGeneralCode_EyeResponse");

            entity.HasOne(d => d.GCMotorResponseFCSNavigation).WithMany(p => p.PatientFCSGCMotorResponseFCSNavigation).HasConstraintName("FK_PatientFCS_sysGeneralCode_MotorResponseFCS");

            entity.HasOne(d => d.GCRespirationFCSNavigation).WithMany(p => p.PatientFCSGCRespirationFCSNavigation).HasConstraintName("FK_PatientFCS_sysGeneralCode_RespirationFCS");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientFCS)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientFCS_Patient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientFCS)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientFCS_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientFCS).HasConstraintName("FK_PatientFCS_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientFCS).HasConstraintName("FK_PatientFCS_Site");
        });

        modelBuilder.Entity<PatientFamily>(entity =>
        {
            entity.HasOne(d => d.FamilyMedicalNoNavigation).WithMany(p => p.PatientFamilyFamilyMedicalNoNavigation).HasConstraintName("FK_PatientFamily_Patient1");

            entity.HasOne(d => d.GCRelationShipNavigation).WithMany(p => p.PatientFamily).HasConstraintName("FK_PatientFamily_sysGeneralCode");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientFamilyMedicalNoNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientFamily_Patient");
        });

        modelBuilder.Entity<PatientGCS>(entity =>
        {
            entity.HasOne(d => d.GCEyeOpeningNavigation).WithMany(p => p.PatientGCSGCEyeOpeningNavigation).HasConstraintName("FK_PatientGCS_sysGeneralCode_EyeOpening");

            entity.HasOne(d => d.GCMotorResponseNavigation).WithMany(p => p.PatientGCSGCMotorResponseNavigation).HasConstraintName("FK_PatientGCS_sysGeneralCode_MotorResponse");

            entity.HasOne(d => d.GCVerbalResponseNavigation).WithMany(p => p.PatientGCSGCVerbalResponseNavigation).HasConstraintName("FK_PatientGCS_sysGeneralCode_VerbalResponse");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientGCS)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientGCS_Patient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientGCS)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientGCS_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientGCS).HasConstraintName("FK_PatientGCS_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientGCS).HasConstraintName("FK_PatientGCS_Site");
        });

        modelBuilder.Entity<PatientGCSPediatric>(entity =>
        {
            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientGCSPediatric)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientGCSPediatric_Patient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientGCSPediatric)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientGCSPediatric_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientGCSPediatric).HasConstraintName("FK_PatientGCSPediatric_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientGCSPediatric).HasConstraintName("FK_PatientGCSPediatric_Site");
        });

        modelBuilder.Entity<PatientInfectiousDisease>(entity =>
        {
            entity.HasOne(d => d.InfectiousDiseaseCodeNavigation).WithMany(p => p.PatientInfectiousDisease)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientInfectiousDisease_InfectiousDisease");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientInfectiousDisease)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientInfectiousDisease_Patient");

            entity.HasOne(d => d.EpisodeDiagnosis).WithOne(p => p.PatientInfectiousDisease)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientInfectiousDisease_EpisodeDiagnosis");
        });

        modelBuilder.Entity<PatientLookUp>(entity =>
        {
            entity.Property(e => e.IsAlive).HasDefaultValue(true, "DF_PatientLookUp_IsAlive");
        });

        modelBuilder.Entity<PatientMCUCompileDt>(entity =>
        {
            entity.HasOne(d => d.PatientMCUCompileHd).WithMany(p => p.PatientMCUCompileDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientMCUCompileDt_PatientMCUCompileHd");
        });

        modelBuilder.Entity<PatientMCUCompileDtRecommendation>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_PatientMCUCompileDtRecommendation_1");
        });

        modelBuilder.Entity<PatientMCUCompileHd>(entity =>
        {
            entity.HasOne(d => d.GCCompileTypeNavigation).WithMany(p => p.PatientMCUCompileHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientMCUCompileHd_sysGeneralCode");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientMCUCompileHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientMCUCompileHd_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientMCUCompileHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientMCUCompileHd_Registration");
        });

        modelBuilder.Entity<PatientMergeLog>(entity =>
        {
            entity.Property(e => e.ActionType).IsFixedLength();
        });

        modelBuilder.Entity<PatientNotes>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_PatientNotes_1");

            entity.HasOne(d => d.GCInstructionByNavigation).WithMany(p => p.PatientNotesGCInstructionByNavigation).HasConstraintName("FK_PatientNotes_sysGeneralCode1");

            entity.HasOne(d => d.GCPatientNotesTypeNavigation).WithMany(p => p.PatientNotesGCPatientNotesTypeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientNotes_sysGeneralCode");

            entity.HasOne(d => d.GCRefferenceTypeNavigation).WithMany(p => p.PatientNotesGCRefferenceTypeNavigation).HasConstraintName("FK_PatientNotes_sysGeneralCode2");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientNotesParamedic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientNotes_Paramedic");

            entity.HasOne(d => d.ParamedicToNavigation).WithMany(p => p.PatientNotesParamedicToNavigation).HasConstraintName("FK_PatientNotes_Paramedic1");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientNotes_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientNotes_Site");
        });

        modelBuilder.Entity<PatientOdontogram>(entity =>
        {
            entity.HasOne(d => d.GCToothNavigation).WithMany(p => p.PatientOdontogramGCToothNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientOdontogram_SysGeneralCode_Tooth");

            entity.HasOne(d => d.GCToothProblemNavigation).WithMany(p => p.PatientOdontogramGCToothProblemNavigation).HasConstraintName("FK_PatientOdontogram_SysGeneralCode_ToothProblem");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientOdontogram)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientOdontogram_Patient");

            entity.HasOne(d => d.ProcedureCodeNavigation).WithMany(p => p.PatientOdontogram).HasConstraintName("FK_PatientOdontogram_Procedure");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientOdontogram).HasConstraintName("FK_PatientOdontogram_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientOdontogram).HasConstraintName("FK_PatientOdontogram_PatientOdontogram");
        });

        modelBuilder.Entity<PatientOdontogramNew>(entity =>
        {
            entity.Property(e => e.IsReviewed).HasDefaultValue(false);

            entity.HasOne(d => d.GCToothNavigation).WithMany(p => p.PatientOdontogramNewGCToothNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientOdontogramNew_SysGeneralCode_Tooth");

            entity.HasOne(d => d.GCToothProblemNavigation).WithMany(p => p.PatientOdontogramNewGCToothProblemNavigation).HasConstraintName("FK_PatientOdontogramNew_SysGeneralCode_ToothProblem");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientOdontogramNew)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientOdontogramNew_Patient");

            entity.HasOne(d => d.ProcedureCodeNavigation).WithMany(p => p.PatientOdontogramNew).HasConstraintName("FK_PatientOdontogramNew_Procedure");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientOdontogramNew).HasConstraintName("FK_PatientOdontogramNew_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientOdontogramNew).HasConstraintName("FK_PatientOdontogramNew_PatientOdontogramNew");
        });

        modelBuilder.Entity<PatientOralMucosa>(entity =>
        {
            entity.HasOne(d => d.GCOralMucosaNavigation).WithMany(p => p.PatientOralMucosa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientOralMucosa_sysGeneralCode_OralMucosa");

            entity.HasOne(d => d.ProcedureCodeNavigation).WithMany(p => p.PatientOralMucosa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientOralMucosa_Procedures");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientOralMucosa).HasConstraintName("FK_PatientOralMucosa_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientOralMucosa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientOralMucosa_Site");
        });

        modelBuilder.Entity<PatientPPAInstruction>(entity =>
        {
            entity.HasOne(d => d.PatientNotes).WithMany(p => p.PatientPPAInstruction)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientPPAInstruction_PatientNotes");
        });

        modelBuilder.Entity<PatientPayerCard>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_PatientPayerCard_IsActive");

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.PatientPayerCard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientPayerCard_BusinessPartner");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientPayerCard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientPayerCard_Patient");
        });

        modelBuilder.Entity<PatientProblem>(entity =>
        {
            entity.HasOne(d => d.DiagnosisCodeNavigation).WithMany(p => p.PatientProblem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientProblem_Diagnosis");

            entity.HasOne(d => d.GCChronicityNavigation).WithMany(p => p.PatientProblemGCChronicityNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientProblem_sysGeneralCode_Chronicity");

            entity.HasOne(d => d.GCProblemStatusNavigation).WithMany(p => p.PatientProblemGCProblemStatusNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientProblem_sysGeneralCode_ProblemStatus");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientProblem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientProblem_Patient");
        });

        modelBuilder.Entity<PatientQuestionaireDt>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientQuestionaireDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientQuestionaireDt_Site");

            entity.HasOne(d => d.QuestionAnswer).WithMany(p => p.PatientQuestionaireDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientQuestionaireDt_QuestionAnswer");

            entity.HasOne(d => d.PatientQuestionaireHd).WithMany(p => p.PatientQuestionaireDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientQuestionaireDt_PatientQuestionaireHd");
        });

        modelBuilder.Entity<PatientQuestionaireHd>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_PatientQuestionaireHd_1");

            entity.ToTable(tb => tb.HasTrigger("tr_PatientQuestionaireHd"));

            entity.HasOne(d => d.Form).WithMany(p => p.PatientQuestionaireHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientQuestionaireHd_QuestionaireForm");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PatientQuestionaireHd).HasConstraintName("FK_PatientQuestionaireHd_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientQuestionaireHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientQuestionaireHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientQuestionaireHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientQuestionaireHd_Site");
        });

        modelBuilder.Entity<PatientResponsibleLog>(entity =>
        {
            entity.HasOne(d => d.OriginPhyisician).WithMany(p => p.PatientResponsibleLogOriginPhyisician).HasConstraintName("FK_PatientResponsibleLog_Paramedic_OriginPhysicianID");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientResponsibleLog)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientResponsibleLog_Registration");
        });

        modelBuilder.Entity<PatientResumeDtCPOE>(entity =>
        {
            entity.HasOne(d => d.PatientResumeHd).WithMany(p => p.PatientResumeDtCPOE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientResumeDtCPOE_PatientResumeHd");
        });

        modelBuilder.Entity<PatientResumeDtNotes>(entity =>
        {
            entity.HasOne(d => d.PatientResumeHd).WithOne(p => p.PatientResumeDtNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientResumeDtNotes_PatientResumeHd");
        });

        modelBuilder.Entity<PatientResumeKeadaanPulang>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_PatientResumeKeadaanPulang_2");
        });

        modelBuilder.Entity<PatientSatuSehatConsent>(entity =>
        {
            entity.Property(e => e.IsSendSatuSehat).HasDefaultValue(false, "DF_PatientSatuSehatConsent_IsSendSatuSehat");
        });

        modelBuilder.Entity<PatientSummaryControl>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(false, "DF_PatientSummaryControl_IsActive");
        });

        modelBuilder.Entity<PatientSummaryControlParamedicType>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(false, "DF_PatientSummaryControlParamedicType_IsActive");

            entity.HasOne(d => d.GCParamedicTypeNavigation).WithMany(p => p.PatientSummaryControlParamedicType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientSummaryControlParamedicType_PatientSummaryParamedicType");

            entity.HasOne(d => d.PatientSummaryControlCodeNavigation).WithMany(p => p.PatientSummaryControlParamedicType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientSummaryControlParamedicType_PatientSummaryControl");
        });

        modelBuilder.Entity<PatientSummaryParamedicType>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(false, "DF_PatientSummaryParamedicType_IsActive");
            entity.Property(e => e.OrderNo).HasDefaultValue(0, "DF_PatientSummaryParamedicType_OrderNo");
        });

        modelBuilder.Entity<PatientSurgeryStatus>(entity =>
        {
            entity.HasOne(d => d.GCPatientStatusNavigation).WithMany(p => p.PatientSurgeryStatusGCPatientStatusNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientSurgeryStatus_sysGeneralCode2");

            entity.HasOne(d => d.GCStatusFromNavigation).WithMany(p => p.PatientSurgeryStatusGCStatusFromNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientSurgeryStatus_sysGeneralCode3");

            entity.HasOne(d => d.GCTransferFromNavigation).WithMany(p => p.PatientSurgeryStatusGCTransferFromNavigation).HasConstraintName("FK_PatientSurgeryStatus_sysGeneralCode");

            entity.HasOne(d => d.GCTransferToNavigation).WithMany(p => p.PatientSurgeryStatusGCTransferToNavigation).HasConstraintName("FK_PatientSurgeryStatus_sysGeneralCode1");

            entity.HasOne(d => d.ReservationNoNavigation).WithMany(p => p.PatientSurgeryStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientSurgeryStatus_SurgeryReservation");
        });

        modelBuilder.Entity<PatientSurvey>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientSurvey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientSurvey_Registration");
        });

        modelBuilder.Entity<PatientTagField>(entity =>
        {
            entity.HasOne(d => d.MedicalNoNavigation).WithOne(p => p.PatientTagField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientTagField_Patient");
        });

        modelBuilder.Entity<PatientVaccination>(entity =>
        {
            entity.Property(e => e.ParamedicName).HasDefaultValue("", "DF_PatientVaccination_ParamedicName");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_PatientVaccination_Remarks");

            entity.HasOne(d => d.Item).WithMany(p => p.PatientVaccination).HasConstraintName("FK_PatientVaccination_Item");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientVaccination)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientVaccination_Patient");

            entity.HasOne(d => d.VaccinationTypeCodeNavigation).WithMany(p => p.PatientVaccination)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientVaccination_VaccinationType");
        });

        modelBuilder.Entity<PatientVision>(entity =>
        {
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_PatientVision_Remarks");

            entity.HasOne(d => d.GCColorBlindnessNavigation).WithMany(p => p.PatientVision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientVision_sysGeneralCode_ColorBlindness");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.PatientVision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientVision_Patient");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PatientVision).HasConstraintName("FK_PatientVision_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PatientVision).HasConstraintName("FK_PatientVision_Site");
        });

        modelBuilder.Entity<PatientVisitItem>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithOne(p => p.PatientVisitItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientVisitItem_Item");
        });

        modelBuilder.Entity<PatientYankes223>(entity =>
        {
            entity.Property(e => e.CleanedName).HasComputedColumnSql("([dbo].[fn_CleanNameKompleks]([PatientName]))", true);
        });

        modelBuilder.Entity<PaymentPlanAPGiro>(entity =>
        {
            entity.HasKey(e => new { e.BusinessPartnerID, e.PaymentPlanNo }).HasName("PK_PaymentPlanGiro");
        });

        modelBuilder.Entity<PaymentPlanRSGiro>(entity =>
        {
            entity.Property(e => e.CekGiro).IsFixedLength();
        });

        modelBuilder.Entity<PaymentReceiptDt>(entity =>
        {
            entity.HasOne(d => d.GCPaymentTypeNavigation).WithMany(p => p.PaymentReceiptDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentReceiptDt_sysGeneralCode");

            entity.HasOne(d => d.PaymentReceiptNoNavigation).WithMany(p => p.PaymentReceiptDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentReceiptDt_PaymentReceiptHd");
        });

        modelBuilder.Entity<PaymentReceiptHd>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PaymentReceiptHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentReceiptHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PaymentReceiptHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentReceiptHd_sysTransactionCode");
        });

        modelBuilder.Entity<PaymentRefund>(entity =>
        {
            entity.HasOne(d => d.Bank).WithMany(p => p.PaymentRefund).HasConstraintName("FK_PaymentRefund_Bank");

            entity.HasOne(d => d.GCReferenceTransferBankNavigation).WithMany(p => p.PaymentRefund).HasConstraintName("FK_PaymentRefund_sysGeneralCode");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PaymentRefund).HasConstraintName("FK_PaymentRefund_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PaymentRefund)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentRefund_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PaymentRefund)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentRefund_sysTransactionCode");
        });

        modelBuilder.Entity<PaymentRefundMedication>(entity =>
        {
            entity.HasOne(d => d.Bank).WithMany(p => p.PaymentRefundMedication).HasConstraintName("FK_PaymentRefundMedication_Bank");

            entity.HasOne(d => d.GCReferenceTransferBankNavigation).WithMany(p => p.PaymentRefundMedication).HasConstraintName("FK_PaymentRefundMedication_sysGeneralCode");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PaymentRefundMedication).HasConstraintName("FK_PaymentRefundMedication_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PaymentRefundMedication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentRefundMedication_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PaymentRefundMedication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentRefundMedication_sysTransactionCode");
        });

        modelBuilder.Entity<PayrollPaymentPlanDt>(entity =>
        {
            entity.HasKey(e => new { e.PaymentPlanNo, e.SequenceNo }).HasName("PK_PayrollPaymentPlanDt_1");

            entity.HasOne(d => d.PayrollProcessNoNavigation).WithMany(p => p.PayrollPaymentPlanDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollPaymentPlanDt_PayrollProcessHd1");

            entity.HasOne(d => d.PayrollProcessSubDt).WithMany(p => p.PayrollPaymentPlanDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollPaymentPlanDt_PayrollProcessSubDt");
        });

        modelBuilder.Entity<PayrollPaymentPlanHd>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PayrollPaymentPlanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollPaymentPlanHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PayrollPaymentPlanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollPaymentPlanHd_sysTransactionCode");
        });

        modelBuilder.Entity<PayrollPeriodDt>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.PayrollPeriodDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollPeriodDt_PayrollPeriodHd");
        });

        modelBuilder.Entity<PayrollPeriodHd>(entity =>
        {
            entity.HasOne(d => d.GCPeriodTypeNavigation).WithMany(p => p.PayrollPeriodHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollPeriodHd_sysGeneralCode");
        });

        modelBuilder.Entity<PayrollProcessDt>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollProcessDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollProcessDt_Employee");

            entity.HasOne(d => d.SalaryCodeNavigation).WithMany(p => p.PayrollProcessDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollProcessDt_SalaryComponent");
        });

        modelBuilder.Entity<PayrollProcessHd>(entity =>
        {
            entity.HasKey(e => e.PayrollProcessNo).HasName("PK_PayrollProcessHd_1");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PayrollProcessHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollProcessHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PayrollProcessHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollProcessHd_sysTransactionCode");
        });

        modelBuilder.Entity<PayrollProcessSubDt>(entity =>
        {
            entity.HasKey(e => new { e.PayrollProcessNo, e.EmployeeId }).HasName("PK_PayrollProcessSubDt_1");

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollProcessSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollProcessSubDt_Employee");

            entity.HasOne(d => d.GCAGCEmployeeNavigation).WithMany(p => p.PayrollProcessSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollProcessSubDt_sysGeneralCode");

            entity.HasOne(d => d.PayrollProcessNoNavigation).WithMany(p => p.PayrollProcessSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollProcessSubDt_PayrollProcessHd");
        });

        modelBuilder.Entity<PediatricChart>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PediatricChart)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PediatricChart_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PediatricChart)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PediatricChart_Site");
        });

        modelBuilder.Entity<PelayananKerohanian>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.PelayananKerohanian)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PelayananKerohanian_Registration");
        });

        modelBuilder.Entity<PemeriksaanFisikMCU>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.ExaminationType }).HasName("PK_PemeriksaanFisikMCU_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_PemeriksaanFisikMCU_IsDeleted");
        });

        modelBuilder.Entity<PemeriksaanFisikOHIS>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_PemeriksaanFisikOHIS_1");
        });

        modelBuilder.Entity<PemeriksaanInfeksi>(entity =>
        {
            entity.Property(e => e.PasienID).ValueGeneratedNever();

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.PemeriksaanInfeksi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PemeriksaanInfeksi_Department");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PemeriksaanInfeksi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PemeriksaanInfeksi_Registration");
        });

        modelBuilder.Entity<PemeriksaanInfeksiHd>(entity =>
        {
            entity.HasOne(d => d.GCPemakaianAlatMedisNavigation).WithMany(p => p.PemeriksaanInfeksiHdGCPemakaianAlatMedisNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PemeriksaanInfeksiHd_GCPemeriksaanAlatMedis");

            entity.HasOne(d => d.GCPosisiPasangNavigation).WithMany(p => p.PemeriksaanInfeksiHdGCPosisiPasangNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PemeriksaanInfeksiHd_GCPosisiPasang");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PemeriksaanInfeksiHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PemeriksaanInfeksiHd_Registration1");
        });

        modelBuilder.Entity<PemeriksaanMataMCU>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF__Pemeriksa__IsDel__33CEF03E");
            entity.Property(e => e.LastUpdatedDateTime).HasDefaultValueSql("(getdate())", "DF__Pemeriksa__LastU__34C31477");
        });

        modelBuilder.Entity<PencegahanStandarJatuhDetail>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo, e.GeneralCodeID }).HasName("PK_PencegahanPasienJatuhRisikoTDetail1");
        });

        modelBuilder.Entity<PermohonanPelayananKontrasepsi>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.PermohonanPelayananKontrasepsi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PermohonanPelayananKontrasepsi_Registration");
        });

        modelBuilder.Entity<PharmacyVerificationByDepartment>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<PhysicianBilling>(entity =>
        {
            entity.HasOne(d => d.Asset).WithMany(p => p.PhysicianBilling).HasConstraintName("FK_PhysicianBilling_Assets");

            entity.HasOne(d => d.Item).WithMany(p => p.PhysicianBilling)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianBilling_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.PhysicianBilling)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianBilling_ItemUnit");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianBilling)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianBilling_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PhysicianBilling)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianBilling_Registration");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.PhysicianBilling)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianBilling_DepartmentServiceUnit");
        });

        modelBuilder.Entity<PhysicianBillingTemplateDt>(entity =>
        {
            entity.HasOne(d => d.Template).WithMany(p => p.PhysicianBillingTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianBillingTemplateDt_PhysicianBillingTemplateHd");
        });

        modelBuilder.Entity<PhysicianBillingTemplateHd>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_PhysicianBillingTemplateHd_IsActive");
        });

        modelBuilder.Entity<PhysicianChargesByClass>(entity =>
        {
            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.PhysicianChargesByClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianChargesByClass_Class");

            entity.HasOne(d => d.Item).WithMany(p => p.PhysicianChargesByClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianChargesByClass_Item");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianChargesByClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianChargesByClass_Paramedic");
        });

        modelBuilder.Entity<PhysicianFeeAdditionalFee>(entity =>
        {
            entity.HasOne(d => d.VerificationNoNavigation).WithMany(p => p.PhysicianFeeAdditionalFee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeeAdditionalFee_PhysicianFeeVerification");
        });

        modelBuilder.Entity<PhysicianFeeItem>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianFeeItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeeItem_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PhysicianFeeItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeeItem_Registration");

            entity.HasOne(d => d.VerificationNoNavigation).WithMany(p => p.PhysicianFeeItem).HasConstraintName("FK_PhysicianFeeItem_PhysicianFeeVerification");
        });

        modelBuilder.Entity<PhysicianFeeItemJobOrder>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianFeeItemJobOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeeItemJobOrder_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PhysicianFeeItemJobOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeeItemJobOrder_Registration");

            entity.HasOne(d => d.VerificationNoNavigation).WithMany(p => p.PhysicianFeeItemJobOrder).HasConstraintName("FK_PhysicianFeeItemJobOrder_PhysicianFeeVerification");
        });

        modelBuilder.Entity<PhysicianFeePaymentPlanDt>(entity =>
        {
            entity.HasOne(d => d.PaymentPlanNoNavigation).WithMany(p => p.PhysicianFeePaymentPlanDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeePaymentPlanDt_PhysicianFeePaymentPlanHd");

            entity.HasOne(d => d.VerificationNoNavigation).WithMany(p => p.PhysicianFeePaymentPlanDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeePaymentPlanDt_PhysicianFeeVerification");
        });

        modelBuilder.Entity<PhysicianFeePaymentPlanHd>(entity =>
        {
            entity.Property(e => e.PaymentMethod).IsFixedLength();

            entity.HasOne(d => d.Bank).WithMany(p => p.PhysicianFeePaymentPlanHd).HasConstraintName("FK_PhysicianFeePaymentPlanHd_Bank");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianFeePaymentPlanHd).HasConstraintName("FK_PhysicianFeePaymentPlanHd_Paramedic");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PhysicianFeePaymentPlanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeePaymentPlanHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PhysicianFeePaymentPlanHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeePaymentPlanHd_sysTransactionCode");
        });

        modelBuilder.Entity<PhysicianFeeVerification>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianFeeVerification)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeeVerification_Paramedic");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PhysicianFeeVerification)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeeVerification_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PhysicianFeeVerification)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianFeeVerification_sysTransactionCode");
        });

        modelBuilder.Entity<PhysicianItem>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.PhysicianItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianItem_Item");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianItem_Paramedic");
        });

        modelBuilder.Entity<PhysicianRMO>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_PhysicianRMO_IsActive");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianRMO)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianRMO_Paramedic");
        });

        modelBuilder.Entity<PhysicianTaxSummaryDt>(entity =>
        {
            entity.HasOne(d => d.VerificationNoNavigation).WithMany(p => p.PhysicianTaxSummaryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianTaxSummaryDt_PhysicianFeeVerification");

            entity.HasOne(d => d.PhysicianTaxSummaryHd).WithMany(p => p.PhysicianTaxSummaryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianTaxSummaryDt_PhysicianTaxSummaryHd");
        });

        modelBuilder.Entity<PhysicianTaxSummaryHd>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianTaxSummaryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianTaxSummaryHd_Paramedic");
        });

        modelBuilder.Entity<PhysicianTeam>(entity =>
        {
            entity.Property(e => e.IsAutoCharges).HasDefaultValue(true, "DF_PhysicianTeam_IsAutoCharges");

            entity.HasOne(d => d.GCPhysicianTypeNavigation).WithMany(p => p.PhysicianTeam).HasConstraintName("FK_PhysicianTeam_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.PhysicianTeam).HasConstraintName("FK_PhysicianTeam_Item");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianTeam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianTeam_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PhysicianTeam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianTeam_Registration");
        });

        modelBuilder.Entity<PhysicianTeamSurgery>(entity =>
        {
            entity.HasOne(d => d.GCSurgeryParamedicTypeNavigation).WithMany(p => p.PhysicianTeamSurgery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianTeamSurgery_sysGeneralCode");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PhysicianTeamSurgery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianTeamSurgery_Paramedic");

            entity.HasOne(d => d.ReservationNoNavigation).WithMany(p => p.PhysicianTeamSurgery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianTeamSurgery_SurgeryReservation");

            entity.HasOne(d => d.SurgeryTeamCodeNavigation).WithMany(p => p.PhysicianTeamSurgery).HasConstraintName("FK_PhysicianTeamSurgery_SurgeryTeamTemplateHd");
        });

        modelBuilder.Entity<PointRewardRedeemDt>(entity =>
        {
            entity.HasKey(e => new { e.TransactionNo, e.SequenceNo }).HasName("PK_PointRewardRedeemDt_1");
        });

        modelBuilder.Entity<PointRewardRedeemHD>(entity =>
        {
            entity.Property(e => e.IsReviewed).HasDefaultValue(false, "DF_PointRewardRedeemHD_IsReviewed");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Position_IsActive");

            entity.HasOne(d => d.ParentPositionCodeNavigation).WithMany(p => p.InverseParentPositionCodeNavigation).HasConstraintName("FK_Position_Position");
        });

        modelBuilder.Entity<PraProcessDt>(entity =>
        {
            entity.Property(e => e.MaxVariablePrice).HasDefaultValue(9999999999999.9999m, "DF_PraProcessDt_MaxVariablePrice");

            entity.HasOne(d => d.ClassCategoryCodeNavigation).WithMany(p => p.PraProcessDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PraProcessDt_ClassCategory");

            entity.HasOne(d => d.DocumentNoNavigation).WithMany(p => p.PraProcessDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PraProcessDt_PraProcessHd");

            entity.HasOne(d => d.GCMemberNavigation).WithMany(p => p.PraProcessDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PraProcessDt_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.PraProcessDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PraProcessDt_Item");
        });

        modelBuilder.Entity<PraProcessHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.PraProcessHd).HasConstraintName("FK_PraProcessHd_Customer");
        });

        modelBuilder.Entity<PregnancyStatus>(entity =>
        {
            entity.HasKey(e => e.MedicalNo).HasName("PK_PregnancyStatus_1");
        });

        modelBuilder.Entity<PrescriptionCronic>(entity =>
        {
            entity.HasKey(e => e.JobOrderNo).HasName("PK_PrescriptionCronic_2");
        });

        modelBuilder.Entity<PrescriptionIterationDt>(entity =>
        {
            entity.Property(e => e.LastUpdatedBy).HasDefaultValueSql("((0))", "DF_PrescriptionIterationDt_LastUpdatedBy");
        });

        modelBuilder.Entity<PrescriptionIterationHd>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_PrescriptionIterationHd_IsDeleted");
        });

        modelBuilder.Entity<PrescriptionPayment>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.PrescriptionPayment).HasConstraintName("FK_PrescriptionPayment_BusinessPartner");

            entity.HasOne(d => d.GCPaymentTypeNavigation).WithMany(p => p.PrescriptionPayment).HasConstraintName("FK_PrescriptionPayment_sysGeneralCode");

            entity.HasOne(d => d.JobOrderNoNavigation).WithOne(p => p.PrescriptionPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrescriptionPayment_JobOrderHd");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PrescriptionPayment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrescriptionPayment_Registration");

            entity.HasOne(d => d.Room).WithMany(p => p.PrescriptionPayment).HasConstraintName("FK_PrescriptionPayment_ServiceRoom");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.PrescriptionPayment).HasConstraintName("FK_PrescriptionPayment_DepartmentServiceUnit");
        });

        modelBuilder.Entity<PrescriptionTemplateDt>(entity =>
        {
            entity.Property(e => e.RFlag).IsFixedLength();

            entity.HasOne(d => d.Embalace).WithMany(p => p.PrescriptionTemplateDt).HasConstraintName("FK_PrescriptionTemplateDt_EmbalaceHd");

            entity.HasOne(d => d.Item).WithMany(p => p.PrescriptionTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrescriptionTemplateDt_Item");

            entity.HasOne(d => d.Template).WithMany(p => p.PrescriptionTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrescriptionTemplateDt_PrescriptionTemplateHd");
        });

        modelBuilder.Entity<PrescriptionTemplateHd>(entity =>
        {
            entity.Property(e => e.TemplateId).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_PrescriptionTemplateHd_IsActive");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.PrescriptionTemplateHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrescriptionTemplateHd_Paramedic");
        });

        modelBuilder.Entity<PrintedArchive>(entity =>
        {
            entity.Property(e => e.ReportType).HasDefaultValue("", "DF_PrintedArchive_Remarks");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.PrintedArchive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrintedArchive_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PrintedArchive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrintedArchive_Site");
        });

        modelBuilder.Entity<PrintedArchiveMCUCorporate>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PrintedArchiveMCUCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrintedArchiveMCUCorporate_Site");
        });

        modelBuilder.Entity<Procedures>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Procedures_IsActive");

            entity.HasOne(d => d.ICDCMBlock).WithMany(p => p.Procedures).HasConstraintName("FK_Procedures_ICDCMBlock");
        });

        modelBuilder.Entity<ProceduresMostFrequent>(entity =>
        {
            entity.HasOne(d => d.ProcedureCodeNavigation).WithMany(p => p.ProceduresMostFrequent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProceduresMostFrequent_Procedures");
        });

        modelBuilder.Entity<ProductLine>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ProductLine_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_ProductLine_Remarks");
        });

        modelBuilder.Entity<ProductionDt>(entity =>
        {
            entity.HasOne(d => d.CoaCodeDebitNavigation).WithMany(p => p.ProductionDt).HasConstraintName("FK_ProductionDt_ChartOfAccount");

            entity.HasOne(d => d.GCReasonOutNavigation).WithMany(p => p.ProductionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionDt_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.ProductionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ProductionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionDt_ItemUnit");

            entity.HasOne(d => d.ProductionNoNavigation).WithMany(p => p.ProductionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionDt_ProductionHd");

            entity.HasOne(d => d.TemplateProductionDt).WithMany(p => p.ProductionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionDt_TemplateProductionDt");
        });

        modelBuilder.Entity<ProductionHd>(entity =>
        {
            entity.Property(e => e.IsOneToMany).HasDefaultValue(false, "DF_ProductionHd_IsOneToMany");

            entity.HasOne(d => d.CoaCodeCreditNavigation).WithMany(p => p.ProductionHd).HasConstraintName("FK_ProductionHd_ChartOfAccount");

            entity.HasOne(d => d.GCReasonInNavigation).WithMany(p => p.ProductionHd).HasConstraintName("FK_ProductionHd_SysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.ProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionHd_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionHd_ItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.ProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionHd_Location");

            entity.HasOne(d => d.ProductionCodeNavigation).WithMany(p => p.ProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionHd_TemplateProductionHd");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionHd_SiteCode");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionHd_TransactionCode");
        });

        modelBuilder.Entity<ProformaInvoice>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.ProformaInvoice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProformaInvoice_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ProformaInvoice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProformaInvoice_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ProformaInvoice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProformaInvoice_sysTransactionCode");
        });

        modelBuilder.Entity<Prognisis>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_Prognisis_2");
        });

        modelBuilder.Entity<PrognosisPasien>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SnomedCode }).HasName("PK_PrognosisPasien_1");
        });

        modelBuilder.Entity<ProjectMCUCorporate>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.ProjectMCUCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectMCUCorporate_BusinessPartner");

            entity.HasOne(d => d.DocumentNoNavigation).WithMany(p => p.ProjectMCUCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectMCUCorporate_CustomerContract");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ProjectMCUCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectMCUCorporate_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ProjectMCUCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectMCUCorporate_sysTransactionCode");
        });

        modelBuilder.Entity<Promo>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Promo__3214EC277A2998F5");
        });

        modelBuilder.Entity<PurchaseOrderDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.PurchaseOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.PurchaseOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderDt_ItemUnit");

            entity.HasOne(d => d.PurchaseOrderNoNavigation).WithMany(p => p.PurchaseOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderDt_PurchaseOrderHd");
        });

        modelBuilder.Entity<PurchaseOrderHd>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("tr_po"));

            entity.Property(e => e.POAmount).HasComputedColumnSql("([TransactionAmount]-[DiscountAmount])", false);

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.PurchaseOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderHd_Supplier");

            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.PurchaseOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderHd_sysGeneralCode");

            entity.HasOne(d => d.Location).WithMany(p => p.PurchaseOrderHd).HasConstraintName("FK_PurchaseOrderHd_Location");

            entity.HasOne(d => d.RFPNoNavigation).WithMany(p => p.PurchaseOrderHd).HasConstraintName("FK_PurchaseOrderHd_RequestForProposalHd");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.PurchaseOrderHd).HasConstraintName("FK_PurchaseOrderHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PurchaseOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PurchaseOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderHd_sysTransactionCode");
        });

        modelBuilder.Entity<PurchaseOrderPlanned>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.PurchaseOrderPlanned)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderPlanned_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PurchaseOrderPlanned)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderPlanned_Site");
        });

        modelBuilder.Entity<PurchaseOrderReceiptDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.PurchaseOrderReceiptDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderReceiptDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.PurchaseOrderReceiptDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderReceiptDt_ItemUnit");

            entity.HasOne(d => d.POReceiptNoNavigation).WithMany(p => p.PurchaseOrderReceiptDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderReceiptDt_PurchaseOrderReceiptHd");

            entity.HasOne(d => d.PurchaseOrderNoNavigation).WithMany(p => p.PurchaseOrderReceiptDt).HasConstraintName("FK_PurchaseOrderReceiptDt_PurchaseOrderHd");
        });

        modelBuilder.Entity<PurchaseOrderReceiptHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.PurchaseOrderReceiptHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderReceiptHd_Supplier");

            entity.HasOne(d => d.Location).WithMany(p => p.PurchaseOrderReceiptHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderReceiptHd_Location");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.PurchaseOrderReceiptHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderReceiptHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.PurchaseOrderReceiptHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderReceiptHd_sysTransactionCode");
        });

        modelBuilder.Entity<PurchaseRequestHd>(entity =>
        {
            entity.Property(e => e.Notes).HasDefaultValue("", "DF_PurchaseRequestHd_Notes");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionID).HasName("PK285");

            entity.Property(e => e.QuestionID).HasDefaultValue("", "DF__Question__Questi__40E5634A");
            entity.Property(e => e.AnswerType).HasDefaultValue("RADIO", "DF__Question__Answer__469E3CA0");
            entity.Property(e => e.GCValueCodeID).HasDefaultValue("", "DF_Question_GCValueCodeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Question_IsActive");
            entity.Property(e => e.ParentID).HasDefaultValue("", "DF__Question__Parent__41D98783");
            entity.Property(e => e.QuestionGroupID).HasDefaultValue("", "DF__Question__Questi__42CDABBC");
            entity.Property(e => e.QuestionOrder).HasDefaultValueSql("('')", "DF__Question__Questi__43C1CFF5");
            entity.Property(e => e.QuestionText).HasDefaultValue("", "DF__Question__Questi__44B5F42E");

            entity.HasOne(d => d.QuestionGroup).WithMany(p => p.Question)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuestionGroup_Question");
        });

        modelBuilder.Entity<QuestionAnswer>(entity =>
        {
            entity.HasKey(e => new { e.QuestionID, e.AnswerID }).HasName("PK286");

            entity.Property(e => e.QuestionID).HasDefaultValue("", "DF__QuestionA__Quest__4D4B3A2F");
            entity.Property(e => e.AnswerID).HasDefaultValue("", "DF__QuestionA__Answe__4E3F5E68");
            entity.Property(e => e.AnswerText).HasDefaultValue("", "DF__QuestionA__Answe__53041385");
            entity.Property(e => e.AnswerType).HasDefaultValue("", "DF__QuestionA__Answe__54EC5BF7");
            entity.Property(e => e.GCValueCodeID).HasDefaultValue("", "DF_QuestionAnswer_GCValueCodeID");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_QuestionAnswer_IsActive");
            entity.Property(e => e.IsRequired).HasDefaultValue(true, "DF_QuestionAnswer_IsRequired_1");
            entity.Property(e => e.ParentID).HasDefaultValue("", "DF__QuestionA__Paren__4F3382A1");
            entity.Property(e => e.PrefixText).HasDefaultValue("", "DF__QuestionA__Prefi__520FEF4C");
            entity.Property(e => e.SuffixText).HasDefaultValue("", "DF__QuestionA__Suffi__53F837BE");

            entity.HasOne(d => d.Question).WithMany(p => p.QuestionAnswer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuestionAnswer_Question");
        });

        modelBuilder.Entity<QuestionBRM>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_QuestionBRM_IsActive");
        });

        modelBuilder.Entity<QuestionGroup>(entity =>
        {
            entity.HasKey(e => e.QuestionGroupID).HasName("PK282");

            entity.Property(e => e.QuestionGroupID).HasDefaultValue("", "DF__QuestionG__Quest__58BCECDB");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_QuestionGroup_IsActive");
            entity.Property(e => e.IsShowSetValue).HasDefaultValue(true, "DF_QuestionGroup_IsActive1");
            entity.Property(e => e.ParentID).HasDefaultValue("", "DF__QuestionG__Paren__59B11114");
            entity.Property(e => e.QuestionGroupName).HasDefaultValue("", "DF__QuestionG__Quest__5B995986");
            entity.Property(e => e.SummarizeGroupText).HasDefaultValue("", "DF__QuestionG__Summa__5C8D7DBF");
        });

        modelBuilder.Entity<QuestionGroupInForm>(entity =>
        {
            entity.HasKey(e => new { e.FormID, e.QuestionGroupID }).HasName("PK284");

            entity.Property(e => e.FormID).HasDefaultValue("", "DF__QuestionG__FormI__5F69EA6A");
            entity.Property(e => e.QuestionGroupID).HasDefaultValue("", "DF__QuestionG__Quest__605E0EA3");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_QuestionGroupInForm_IsActive");

            entity.HasOne(d => d.Form).WithMany(p => p.QuestionGroupInForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuestionGroupInForm_QuestionaireForm");

            entity.HasOne(d => d.QuestionGroup).WithMany(p => p.QuestionGroupInForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuestionGroupInForm_QuestionGroup");
        });

        modelBuilder.Entity<QuestionaireForm>(entity =>
        {
            entity.HasKey(e => e.FormID).HasName("PK283");

            entity.Property(e => e.FormID).HasDefaultValue("", "DF__Questiona__FormI__497AA94B");
            entity.Property(e => e.FormName).HasDefaultValue("", "DF__Questiona__FormN__4A6ECD84");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_QuestionaireForm_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_QuestionaireForm_Remarks");

            entity.HasOne(d => d.GCFormTypeNavigation).WithMany(p => p.QuestionaireForm).HasConstraintName("FK_QuestionaireForm_SysGeneralCode");
        });

        modelBuilder.Entity<Queuing>(entity =>
        {
            entity.HasOne(d => d.Paramedic).WithMany(p => p.Queuing).HasConstraintName("FK_Queuing_Paramedic");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.Queuing).HasConstraintName("FK_Queuing_DepartmentServiceUnit");
        });

        modelBuilder.Entity<QueuingJKN>(entity =>
        {
            entity.Property(e => e.IsApproved).HasDefaultValue(false, "DF_QueuingJKN_IsApproved");
            entity.Property(e => e.IsAttend).HasDefaultValue(false, "DF_QueuingJKN_IsAttend");
        });

        modelBuilder.Entity<QueuingParameter>(entity =>
        {
            entity.HasKey(e => e.ParamedicID).HasName("QueuingParameter_1_2");

            entity.Property(e => e.ParamedicID).ValueGeneratedNever();
        });

        modelBuilder.Entity<QueuingReference>(entity =>
        {
            entity.Property(e => e.QueuingId).ValueGeneratedNever();
        });

        modelBuilder.Entity<QueuingSlot>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_QueuingSlot_IsDeleted");
        });

        modelBuilder.Entity<QueuingTVGeneralCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_QueuingTVGeneralCode_Id");
        });

        modelBuilder.Entity<RL1BayiTabung>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1BayiTabung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1BayiTabung_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1BayiTabung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1BayiTabung_RLReportTemplate");
        });

        modelBuilder.Entity<RL1CaraPembayaran>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1CaraPembayaran)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1CaraPembayaran_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1CaraPembayaran)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1CaraPembayaran_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KebidananPerinatologi>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KebidananPerinatologi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KebidananPerinatologi_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KebidananPerinatologi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KebidananPerinatologi_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KegiatanFarmasi>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KegiatanFarmasi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KegiatanFarmasi_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KegiatanFarmasi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KegiatanFarmasi_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KegiatanPelayananKhusus>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KegiatanPelayananKhusus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KegiatanPelayananKhusus_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KegiatanPelayananKhusus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KegiatanPelayananKhusus_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KegiatanRadiologi>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KegiatanRadiologi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KegiatanRadiologi_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KegiatanRadiologi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KegiatanRadiologi_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KegiatanRujukan>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KegiatanRujukan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KegiatanRujukan_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KegiatanRujukan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KegiatanRujukan_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KeluargaBerencana>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KeluargaBerencana)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KeluargaBerencana_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KeluargaBerencana)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KeluargaBerencana_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KesehatanGigiMulut>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KesehatanGigiMulut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KesehatanGigiMulut_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KesehatanGigiMulut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KesehatanGigiMulut_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KesehatanJiwa>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KesehatanJiwa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KesehatanJiwa_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KesehatanJiwa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KesehatanJiwa_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KunjunganRJ>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KunjunganRJ)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KunjunganRJ_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KunjunganRJ)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KunjunganRJ_RLReportTemplate");
        });

        modelBuilder.Entity<RL1KunjunganRumah>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1KunjunganRumah)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KunjunganRumah_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1KunjunganRumah)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1KunjunganRumah_RLReportTemplate");
        });

        modelBuilder.Entity<RL1PelayananRI>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1PelayananRI)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PelayananRI_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1PelayananRI)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PelayananRI_RLReportTemplate");
        });

        modelBuilder.Entity<RL1PemantauanDokter>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1PemantauanDokter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PemantauanDokter_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1PemantauanDokter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PemantauanDokter_RLReportTemplate");
        });

        modelBuilder.Entity<RL1Pembedahan>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1Pembedahan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1Pembedahan_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1Pembedahan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1Pembedahan_RLReportTemplate");
        });

        modelBuilder.Entity<RL1PembedahanMata>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1PembedahanMata)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PembedahanMata_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1PembedahanMata)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PembedahanMata_RLReportTemplate");
        });

        modelBuilder.Entity<RL1PemeriksaanLaboratorium>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1PemeriksaanLaboratorium)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PemeriksaanLaboratorium_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1PemeriksaanLaboratorium)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PemeriksaanLaboratorium_RLReportTemplate");
        });

        modelBuilder.Entity<RL1Pengunjung>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1Pengunjung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1Pengunjung_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1Pengunjung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1Pengunjung_RLReportTemplate");
        });

        modelBuilder.Entity<RL1PenyalahgunaanNAPZA>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1PenyalahgunaanNAPZA)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PenyalahgunaanNAPZA_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1PenyalahgunaanNAPZA)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PenyalahgunaanNAPZA_RLReportTemplate");
        });

        modelBuilder.Entity<RL1PenyuluhanKesehatan>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1PenyuluhanKesehatan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PenyuluhanKesehatan_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1PenyuluhanKesehatan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1PenyuluhanKesehatan_RLReportTemplate");
        });

        modelBuilder.Entity<RL1RehabilitasiMedik>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1RehabilitasiMedik)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1RehabilitasiMedik_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1RehabilitasiMedik)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1RehabilitasiMedik_RLReportTemplate");
        });

        modelBuilder.Entity<RL1Training>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1Training)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1Training_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1Training)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1Training_RLReportTemplate");
        });

        modelBuilder.Entity<RL1TranfusiDarah>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL1TranfusiDarah)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1TranfusiDarah_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL1TranfusiDarah)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL1TranfusiDarah_RLReportTemplate");
        });

        modelBuilder.Entity<RL2Imunisasi>(entity =>
        {
            entity.Property(e => e.IsAlive).HasDefaultValue(true, "DF_RL2Imunisasi_IsAlive");
            entity.Property(e => e.Sex).IsFixedLength();
            entity.Property(e => e.StatusImunisasi).HasDefaultValue("TK", "DF_RL2Imunisasi_StatusImunisasi");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.RL2Imunisasi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL2Imunisasi_Patient");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL2Imunisasi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL2Imunisasi_Site");
        });

        modelBuilder.Entity<RL2Morbiditas>(entity =>
        {
            entity.Property(e => e.NumberOfPatientOut).HasComment("(NumberOfMale+NumberOfFemale)");

            entity.HasOne(d => d.DTDNoNavigation).WithMany(p => p.RL2Morbiditas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL2Morbiditas_DTD");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL2Morbiditas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL2Morbiditas_Site");
        });

        modelBuilder.Entity<RL310PelayananKhususHd>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RL33GigiDt>(entity =>
        {
            entity.HasKey(e => e.IdDetail).HasName("PK_RL33GigiDt_2");
        });

        modelBuilder.Entity<RL33GigiHd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RL33GigiHd_2");
        });

        modelBuilder.Entity<RL35PerinatologiHd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RL35PerinatologiHd_2");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RL3DataDasarRumahSakit>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL3DataDasarRumahSakit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL3DataDasarRumahSakit_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL3DataDasarRumahSakit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL3DataDasarRumahSakit_RLReportTemplate");
        });

        modelBuilder.Entity<RL4DataKetenagaan>(entity =>
        {
            entity.HasOne(d => d.GCRL4TypeNavigation).WithMany(p => p.RL4DataKetenagaan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL4DataKetenagaan_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL4DataKetenagaan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL4DataKetenagaan_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL4DataKetenagaan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL4DataKetenagaan_RLReportTemplate");
        });

        modelBuilder.Entity<RL5DataKesehatan>(entity =>
        {
            entity.Property(e => e.DokumenQ1).HasDefaultValue("", "DF_RL5DataKesehatan_DokumenQ1");
            entity.Property(e => e.DokumenQ2).HasDefaultValue("", "DF_RL5DataKesehatan_DokumenQ2");
            entity.Property(e => e.LimbahCairQ1).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahCairQ1");
            entity.Property(e => e.LimbahCairQ2).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahCairQ2");
            entity.Property(e => e.LimbahCairQ3Kuartal1).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahCairQ3Kuartal1");
            entity.Property(e => e.LimbahCairQ3Kuartal2).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahCairQ3Kuartal2");
            entity.Property(e => e.LimbahCairQ3Kuartal3).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahCairQ3Kuartal3");
            entity.Property(e => e.LimbahCairQ4).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahCairQ4");
            entity.Property(e => e.LimbahCairQ5).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahCairQ5");
            entity.Property(e => e.LimbahPadatQ1).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahPadatQ1");
            entity.Property(e => e.LimbahPadatQ2).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahPadatQ2");
            entity.Property(e => e.LimbahPadatQ3).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahPadatQ3");
            entity.Property(e => e.LimbahPadatQ4).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahPadatQ4");
            entity.Property(e => e.LimbahPadatQ5).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahPadatQ5");
            entity.Property(e => e.LimbahPadatQ6).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahPadatQ6");
            entity.Property(e => e.LimbahPadatQ7).HasDefaultValue("", "DF_RL5DataKesehatan_LimbahPadatQ7");
            entity.Property(e => e.PenyehatanAirQ1).HasDefaultValue("", "DF_RL5DataKesehatan_PenyehatanAirQ1");
            entity.Property(e => e.PenyehatanAirQ2).HasDefaultValue("", "DF_RL5DataKesehatan_PenyehatanAirQ2");
            entity.Property(e => e.PenyehatanAirQ3).HasDefaultValue("", "DF_RL5DataKesehatan_PenyehatanAirQ3");
            entity.Property(e => e.PenyehatanAirQ4Kuartal1).HasDefaultValue("", "DF_RL5DataKesehatan_PenyehatanAirQ4Kuartal1");
            entity.Property(e => e.PenyehatanAirQ4Kuartal2).HasDefaultValue("", "DF_RL5DataKesehatan_PenyehatanAirQ4Kuartal2");
            entity.Property(e => e.PenyehatanAirQ4Kuartal3).HasDefaultValue("", "DF_RL5DataKesehatan_PenyehatanAirQ4Kuartal3");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL5DataKesehatan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL5DataKesehatan_Site");
        });

        modelBuilder.Entity<RL5DataPeralatanMedik>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL5DataPeralatanMedik)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL5DataPeralatanMedik_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL5DataPeralatanMedik)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL5DataPeralatanMedik_RLReportTemplate");
        });

        modelBuilder.Entity<RL6InfeksiNosokomial>(entity =>
        {
            entity.HasOne(d => d.GCRL6TypeNavigation).WithMany(p => p.RL6InfeksiNosokomial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL6InfeksiNosokomial_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RL6InfeksiNosokomial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL6InfeksiNosokomial_Site");

            entity.HasOne(d => d.RLReportTemplate).WithMany(p => p.RL6InfeksiNosokomial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RL6InfeksiNosokomial_RLReportTemplate");
        });

        modelBuilder.Entity<RLData>(entity =>
        {
            entity.HasKey(e => new { e.ReportID, e.RowId, e.Periode }).HasName("PK_RLData_1");

            entity.HasOne(d => d.Report).WithMany(p => p.RLData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RLData_RLTemplateHd");

            entity.HasOne(d => d.Row).WithMany(p => p.RLData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RLData_RLTemplateDt");
        });

        modelBuilder.Entity<RLReportTemplate>(entity =>
        {
            entity.HasOne(d => d.GCRLTypeNavigation).WithMany(p => p.RLReportTemplate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RLReportTemplate_sysGeneralCode");
        });

        modelBuilder.Entity<RLTemplateDt>(entity =>
        {
            entity.HasOne(d => d.Report).WithMany(p => p.RLTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RLTemplateDt_RLTemplateHd");
        });

        modelBuilder.Entity<RLTemplateHd>(entity =>
        {
            entity.HasKey(e => e.ReportID).HasName("PK_RLTemplateHd_1");
        });

        modelBuilder.Entity<RLTemplateSubDt>(entity =>
        {
            entity.HasKey(e => new { e.ReportID, e.FieldName }).HasName("PK_RLTemplateSubDt_1");

            entity.Property(e => e.GroupHeader).HasDefaultValue("", "DF__RLTemplat__Group__6803F475");

            entity.HasOne(d => d.Report).WithMany(p => p.RLTemplateSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RLTemplateSubDt_RLTemplateHd");
        });

        modelBuilder.Entity<Radiologi>(entity =>
        {
            entity.HasKey(e => new { e.Tahun, e.No }).HasName("PK_Radiologi_2");
        });

        modelBuilder.Entity<RealizationFood>(entity =>
        {
            entity.Property(e => e.RealizationId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RecalculationDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.RecalculationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationDt_Item");

            entity.HasOne(d => d.RecalculationNoNavigation).WithMany(p => p.RecalculationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationDt_RecalculationHd");

            entity.HasOne(d => d.TransactionChargesDt).WithMany(p => p.RecalculationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationDt_TransactionChargesDt");
        });

        modelBuilder.Entity<RecalculationDtBom>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.RecalculationDtBomItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationDtBom_Item");

            entity.HasOne(d => d.ParentItem).WithMany(p => p.RecalculationDtBomParentItem).HasConstraintName("FK_RecalculationDtBom_Item1");

            entity.HasOne(d => d.RecalculationNoNavigation).WithMany(p => p.RecalculationDtBom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationDtBom_RecalculationHd");

            entity.HasOne(d => d.ServiceUnitIdAfterNavigation).WithMany(p => p.RecalculationDtBomServiceUnitIdAfterNavigation).HasConstraintName("FK_RecalculationDtBom_DepartmentServiceUnit1");

            entity.HasOne(d => d.ServiceUnitIdBeforeNavigation).WithMany(p => p.RecalculationDtBomServiceUnitIdBeforeNavigation).HasConstraintName("FK_RecalculationDtBom_DepartmentServiceUnit");

            entity.HasOne(d => d.TransactionChargesDt).WithMany(p => p.RecalculationDtBom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationDtBom_TransactionChargesDt");
        });

        modelBuilder.Entity<RecalculationHd>(entity =>
        {
            entity.Property(e => e.IsByPayerChanges).HasDefaultValue(true, "DF_RecalculationHd_IsByPayerChanges");

            entity.HasOne(d => d.BusinessPartnerIDAfterNavigation).WithMany(p => p.RecalculationHdBusinessPartnerIDAfterNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationHd_BusinessPartner1");

            entity.HasOne(d => d.BusinessPartnerIDBeforeNavigation).WithMany(p => p.RecalculationHdBusinessPartnerIDBeforeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationHd_BusinessPartner");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.RecalculationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RecalculationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.RecalculationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecalculationHd_sysTransactionCode");
        });

        modelBuilder.Entity<ReceivedUnplannedDt>(entity =>
        {
            entity.Property(e => e.BaseQuantity).HasDefaultValue(0m, "DF_ReceivedUnplannedDt_BaseQuantity");

            entity.HasOne(d => d.BaseItemUnitCodeNavigation).WithMany(p => p.ReceivedUnplannedDtBaseItemUnitCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceivedUnplannedDt_ItemUnit_BaseItemUnit");

            entity.HasOne(d => d.Item).WithMany(p => p.ReceivedUnplannedDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceivedUnplannedDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ReceivedUnplannedDtItemUnitCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceivedUnplannedDt_ItemUnit");

            entity.HasOne(d => d.ReceivedUnplannedNoNavigation).WithMany(p => p.ReceivedUnplannedDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceivedUnplannedDt_ReceivedUnplannedHd");
        });

        modelBuilder.Entity<ReceivedUnplannedHd>(entity =>
        {
            entity.HasOne(d => d.CoaCodeDebitNavigation).WithMany(p => p.ReceivedUnplannedHdCoaCodeDebitNavigation).HasConstraintName("FK_ReceivedUnplannedHd_ChartOfAccount_CoaCodeDebet");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.ReceivedUnplannedHd).HasConstraintName("FK_ReceivedUnplannedHd_Department");

            entity.HasOne(d => d.GCReceivedUnplannedTypeNavigation).WithMany(p => p.ReceivedUnplannedHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceivedUnplannedHd_sysGeneralCode");

            entity.HasOne(d => d.Location).WithMany(p => p.ReceivedUnplannedHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceivedUnplannedHd_Location");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.ReceivedUnplannedHd).HasConstraintName("FK_ReceivedUnplannedHd_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ReceivedUnplannedHd).HasConstraintName("FK_ReceivedUnplannedHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ReceivedUnplannedHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceivedUnplannedHd_Site");

            entity.HasOne(d => d.SiteDepartment).WithMany(p => p.ReceivedUnplannedHd).HasConstraintName("FK_ReceivedUnplannedHd_SiteDepartment");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ReceivedUnplannedHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceivedUnplannedHd_sysTransactionCode");
        });

        modelBuilder.Entity<ReconciliationDt>(entity =>
        {
            entity.HasOne(d => d.GCTransactionTypeNavigation).WithMany(p => p.ReconciliationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationDt_sysGeneralCode");

            entity.HasOne(d => d.ReconciliationNoNavigation).WithMany(p => p.ReconciliationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationDt_ReconciliationHd");
        });

        modelBuilder.Entity<ReconciliationHd>(entity =>
        {
            entity.HasOne(d => d.CoaCodeNavigation).WithMany(p => p.ReconciliationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationHd_ChartOfAccount");

            entity.HasOne(d => d.GCProviderNavigation).WithMany(p => p.ReconciliationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationHd_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ReconciliationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ReconciliationHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReconciliationHd_sysTransactionCode");
        });

        modelBuilder.Entity<RecuringDt>(entity =>
        {
            entity.HasOne(d => d.JournalNoNavigation).WithMany(p => p.RecuringDt).HasConstraintName("FK_RecuringDt_JournalHd");

            entity.HasOne(d => d.Recuring).WithMany(p => p.RecuringDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecuringDt_RecuringHd");
        });

        modelBuilder.Entity<RecuringSubDt>(entity =>
        {
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_RecuringSubDt_Remarks");

            entity.HasOne(d => d.CoaCodeNavigation).WithMany(p => p.RecuringSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecuringSubDt_ChartOfAccount");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.RecuringSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecuringSubDt_Department");

            entity.HasOne(d => d.Recuring).WithMany(p => p.RecuringSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecuringSubDt_RecuringHd");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.RecuringSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecuringSubDt_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.RecuringSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecuringSubDt_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RecuringSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecuringSubDt_Site");
        });

        modelBuilder.Entity<ReferToConsult>(entity =>
        {
            entity.HasOne(d => d.ParamedicIDFromNavigation).WithMany(p => p.ReferToConsultParamedicIDFromNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ParamedicIDToNavigation).WithMany(p => p.ReferToConsultParamedicIDToNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.ReferToConsult)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReferToConsult_Registration");
        });

        modelBuilder.Entity<ReferToSisruteHd>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_ReferToSisrute");
        });

        modelBuilder.Entity<ReferensiDokter>(entity =>
        {
            entity.HasKey(e => new { e.BusinessPartnerID, e.ParamedicID }).HasName("PK_ReferensiDokter_2");
        });

        modelBuilder.Entity<Referral>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Referral_IsActive");

            entity.HasOne(d => d.GCReferralTypeNavigation).WithMany(p => p.Referral)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Referral_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.Referral)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Referral_Site");
        });

        modelBuilder.Entity<ReferralAproved>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ReferralAproved_1");
        });

        modelBuilder.Entity<ReferralPatient>(entity =>
        {
            entity.HasOne(d => d.GCReferralTypeNavigation).WithMany(p => p.ReferralPatient).HasConstraintName("FK_ReferralPatient_sysGeneralCode");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.ReferralPatient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReferralPatient_Patient");

            entity.HasOne(d => d.OriginRegistrationNoNavigation).WithMany(p => p.ReferralPatient).HasConstraintName("FK_ReferralPatient_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ReferralPatient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReferralPatient_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ReferralPatient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReferralPatient_sysTransactionCode");
        });

        modelBuilder.Entity<Registration>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_Registration_1");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tr_Registration");
                    tb.HasTrigger("tr_ValidateHoliday");
                    tb.HasTrigger("tr_ValidateOutPatienAndEmergency");
                });

            entity.HasOne(d => d.AppointmentNoNavigation).WithMany(p => p.Registration).HasConstraintName("FK_Registration_Appointment");

            entity.HasOne(d => d.Bed).WithMany(p => p.RegistrationBed).HasConstraintName("FK_Registration_Bed");

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.Registration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_BusinessPartner");

            entity.HasOne(d => d.ChargeClassCodeNavigation).WithMany(p => p.RegistrationChargeClassCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.RegistrationClassCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_Class");

            entity.HasOne(d => d.CustomerDocumentNoNavigation).WithMany(p => p.Registration).HasConstraintName("FK_Registration_CustomerContract");

            entity.HasOne(d => d.GCDependentTypeNavigation).WithMany(p => p.RegistrationGCDependentTypeNavigation).HasConstraintName("FK_Registration_sysGeneralCode_DependentType");

            entity.HasOne(d => d.GCDischargeConditionNavigation).WithMany(p => p.RegistrationGCDischargeConditionNavigation).HasConstraintName("FK_Registration_sysGeneralCode_DischargeCondition");

            entity.HasOne(d => d.GCDischargeMethodNavigation).WithMany(p => p.RegistrationGCDischargeMethodNavigation).HasConstraintName("FK_Registration_sysGeneralCode_DischargeMethod");

            entity.HasOne(d => d.GCERCaseTypeNavigation).WithMany(p => p.RegistrationGCERCaseTypeNavigation).HasConstraintName("FK_Registration_sysGeneralCode_ERCaseType");

            entity.HasOne(d => d.GCOriginOfPatientRegNavigation).WithMany(p => p.RegistrationGCOriginOfPatientRegNavigation).HasConstraintName("FK_Registration_sysGeneralCode_OriginOfPatientReg");

            entity.HasOne(d => d.GCPatientCategoryNavigation).WithMany(p => p.RegistrationGCPatientCategoryNavigation).HasConstraintName("FK_Registration_sysGeneralCode_PatientCategory");

            entity.HasOne(d => d.GCPatientInTypeNavigation).WithMany(p => p.RegistrationGCPatientInTypeNavigation).HasConstraintName("FK_Registration_sysGeneralCode_PatientInType");

            entity.HasOne(d => d.GCReferralTypeNavigation).WithMany(p => p.RegistrationGCReferralTypeNavigation).HasConstraintName("FK_Registration_sysGeneralCode_ReferralFrom");

            entity.HasOne(d => d.GCShift).WithMany(p => p.RegistrationGCShift).HasConstraintName("FK_Registration_sysGeneralCode_ShiftID");

            entity.HasOne(d => d.GCTriageNavigation).WithMany(p => p.RegistrationGCTriageNavigation).HasConstraintName("FK_Registration_sysGeneralCode_Triage");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.Registration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_Patient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.RegistrationParamedic).HasConstraintName("FK_Registration_Paramedic");

            entity.HasOne(d => d.ReferralNoNavigation).WithMany(p => p.Registration).HasConstraintName("FK_Registration_ReferralPatient");

            entity.HasOne(d => d.ReservationNoNavigation).WithMany(p => p.Registration).HasConstraintName("FK_Registration_BedReservation");

            entity.HasOne(d => d.Room).WithMany(p => p.Registration).HasConstraintName("FK_Registration_ServiceRoom");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.RegistrationServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.Registration)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registration_Site");

            entity.HasOne(d => d.SpecialtyCodeNavigation).WithMany(p => p.RegistrationSpecialtyCodeNavigation).HasConstraintName("FK_Registration_Specialty");

            entity.HasOne(d => d.Status).WithMany(p => p.Registration).HasConstraintName("FK_Registration_StatusPriority");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.Registration).HasConstraintName("FK_Registration_sysTransactionCode");

            entity.HasOne(d => d.VisitReasonCodeNavigation).WithMany(p => p.Registration).HasConstraintName("FK_Registration_VisitReason");

            entity.HasOne(d => d.VisitTypeCodeNavigation).WithMany(p => p.Registration).HasConstraintName("FK_Registration_VisitType");

            entity.HasOne(d => d.WorkStationCodeNavigation).WithMany(p => p.Registration).HasConstraintName("FK_Registration_WorkStation");
        });

        modelBuilder.Entity<RegistrationInformation>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.RegistrationInformation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistrationInformation_Registration");
        });

        modelBuilder.Entity<RekapDataHarianPasienDirawatTanpaKomorBid>(entity =>
        {
            entity.Property(e => e.LastUpdatedBy).IsFixedLength();
        });

        modelBuilder.Entity<RekapDataHarianPasienMasuk>(entity =>
        {
            entity.Property(e => e.LastUpdatedBy).IsFixedLength();
        });

        modelBuilder.Entity<RekapDataHarianPasienMasukEntry>(entity =>
        {
            entity.Property(e => e.LastUpdatedBy).IsFixedLength();
        });

        modelBuilder.Entity<RencanaKontrol>(entity =>
        {
            entity.HasKey(e => new { e.MRN, e.NoSurat }).HasName("PK_RencanaKontrol_1");
        });

        modelBuilder.Entity<ReplacementDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ReplacementDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplacementDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ReplacementDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplacementDt_ItemUnit");

            entity.HasOne(d => d.ReplacementNoNavigation).WithMany(p => p.ReplacementDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplacementDt_ReplacementHd");
        });

        modelBuilder.Entity<ReplacementHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.ReplacementHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplacementHd_BusinessPartner");

            entity.HasOne(d => d.Location).WithMany(p => p.ReplacementHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplacementHd_Location");

            entity.HasOne(d => d.ReturnToSupplierNoNavigation).WithMany(p => p.ReplacementHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplacementHd_ReturnToSupplierHd");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ReplacementHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplacementHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ReplacementHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplacementHd_sysTransactionCode");
        });

        modelBuilder.Entity<ReportHistoryPatient>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.MedicalNo, e.ItemId, e.ItemGroupCode, e.GCItemType, e.TransactionDate }).HasName("PK__ReportHi__9FB0147F006C36D2");
        });

        modelBuilder.Entity<ReportHistoryPatientY>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.MedicalNo, e.ItemId, e.TransactionPeriod }).HasName("PK__ReportHi__5596AA6E719B761C");
        });

        modelBuilder.Entity<ReportedMedication>(entity =>
        {
            entity.Property(e => e.Dosage).HasDefaultValue("", "DF_ReportedMedication_Dosage");
            entity.Property(e => e.IsDiscontinue).HasDefaultValue(true, "DF_ReportedMedication_IsDiscontinue");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.ReportedMedication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportedMedication_Patient");
        });

        modelBuilder.Entity<RequestForProposalDt>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.RequestForProposalDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestForProposalDt_Supplier");

            entity.HasOne(d => d.GCCreditTermsNavigation).WithMany(p => p.RequestForProposalDt).HasConstraintName("FK_RequestForProposalDt_sysGeneralCode");

            entity.HasOne(d => d.RequestForProposalSubDt).WithMany(p => p.RequestForProposalDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestForProposalDt_RequestForProposalSubDt");
        });

        modelBuilder.Entity<RequestForProposalHd>(entity =>
        {
            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.RequestForProposalHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestForProposalHd_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RequestForProposalHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestForProposalHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.RequestForProposalHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestForProposalHd_sysTransactionCode");
        });

        modelBuilder.Entity<RequestForProposalSubDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.RequestForProposalSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestForProposalSubDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.RequestForProposalSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestForProposalSubDt_ItemUnit");

            entity.HasOne(d => d.RFPNoNavigation).WithMany(p => p.RequestForProposalSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestForProposalSubDt_RequestForProposalHd");
        });

        modelBuilder.Entity<ReturnToSupplierDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ReturnToSupplierDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnToSupplierDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ReturnToSupplierDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnToSupplierDt_ItemUnit");

            entity.HasOne(d => d.ReturnToSupplierNoNavigation).WithMany(p => p.ReturnToSupplierDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnToSupplierDt_ReturnToSupplierHd");
        });

        modelBuilder.Entity<ReturnToSupplierHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.ReturnToSupplierHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnToSupplierHd_Supplier");

            entity.HasOne(d => d.GCReturnToSupplierTypeNavigation).WithMany(p => p.ReturnToSupplierHd).HasConstraintName("FK_ReturnToSupplierHd_sysGeneralCode");

            entity.HasOne(d => d.Location).WithMany(p => p.ReturnToSupplierHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnToSupplierHd_Location");

            entity.HasOne(d => d.POReceiptNoNavigation).WithMany(p => p.ReturnToSupplierHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnToSupplierHd_PurchaseOrderReceiptHd");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ReturnToSupplierHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnToSupplierHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ReturnToSupplierHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReturnToSupplierHd_sysTransactionCode");
        });

        modelBuilder.Entity<RevenueByAnciliariesSupportY>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.TransactionPeriod }).HasName("PK__RevenueB__BEF95D4E2A2E6A02");
        });

        modelBuilder.Entity<RevenueByDepartmentCommunity>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.DepartmentCode, e.CommunityId, e.MedicalNo, e.TransactionDate }).HasName("PK__RevenueB__D0DA5D719DCC35CC");
        });

        modelBuilder.Entity<RevenueByDepartmentCommunityY>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentCode, e.CommunityId, e.MedicalNo, e.TransactionPeriod }).HasName("PK__RevenueB__20E37033A54DC400");
        });

        modelBuilder.Entity<RevenueByDepartmentServiceUnit>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.DepartmentCode, e.ServiceUnitCode, e.MedicalNo, e.TransactionDate }).HasName("PK__RevenueB__CCC91E4602CE1602");
        });

        modelBuilder.Entity<RevenueByDepartmentServiceUnitY>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentCode, e.ServiceUnitCode, e.MedicalNo, e.TransactionPeriod }).HasName("PK__RevenueB__E1D74342229A2397");
        });

        modelBuilder.Entity<RevenueByItemType>(entity =>
        {
            entity.HasKey(e => new { e.BusinessPartnerId, e.TransactionDate, e.ItemId, e.RegistrationNo }).HasName("PK_Table_1_1");
        });

        modelBuilder.Entity<RevenueByPayerType>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.BusinessPartnerID, e.TransactionDate, e.GCCustomerType, e.ServiceUnitCode }).HasName("PK__RevenueB__DE0D7BB1FEECB818");
        });

        modelBuilder.Entity<RevenueByPayerTypePeriode>(entity =>
        {
            entity.HasKey(e => new { e.TransactionDate, e.RegistrationNo, e.GCItemType }).HasName("PK__RevenueB__517FA3597E826CB3");
        });

        modelBuilder.Entity<RevenueByPayerTypeY>(entity =>
        {
            entity.HasKey(e => new { e.BusinessPartnerID, e.TransactionPeriod, e.GCCustomerType, e.ServiceUnitCode }).HasName("PK__RevenueB__172AA6E8E863B7AA");
        });

        modelBuilder.Entity<RevenueByServiceUnitItem>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentCode, e.ServiceUnitCode, e.ItemID, e.RegistrationNo, e.TransactionDate }).HasName("PK__RevenueB__BD7FCC3AA07EFDC5");
        });

        modelBuilder.Entity<RevenueByServiceUnitItemY>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentCode, e.ServiceUnitCode, e.ItemID, e.TransactionPeriod }).HasName("PK__RevenueB__0CE8E6F680189706");
        });

        modelBuilder.Entity<RevenueBySpecialistPhysician>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SpecialtyCode, e.ParamedicID, e.ServiceUnitCode, e.TransactionDate }).HasName("PK__RevenueB__AF57811E5FC0310A");
        });

        modelBuilder.Entity<RevenueBySpecialistPhysicianY>(entity =>
        {
            entity.HasKey(e => new { e.SpecialtyCode, e.ParamedicID, e.ServiceUnitCode, e.TransactionPeriod }).HasName("PK__RevenueB__D83EB6C400FF4172");
        });

        modelBuilder.Entity<RiskFallDt>(entity =>
        {
            entity.HasOne(d => d.RiskFallHd).WithMany(p => p.RiskFallDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskFallDt_RiskFallHd");
        });

        modelBuilder.Entity<RiskFallHd>(entity =>
        {
            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.RiskFallHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskFallHd_Patient");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.RiskFallHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskFallHd_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.RiskFallHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskFallHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.RiskFallHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskFallHd_Site");
        });

        modelBuilder.Entity<RiwayatKesehatanMCUDataList>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_RiwayatKesehatanMCUDataList_IsDeleted");
            entity.Property(e => e.IsShow).HasDefaultValue(true, "DF_RiwayatKesehatanMCUDataList_IsShow");
        });

        modelBuilder.Entity<RiwayatPengobatanPasien>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.ItemID, e.KFACode }).HasName("PK_RiwayatPengobatanPasien_1");
        });

        modelBuilder.Entity<RujukBalikBPJSDT>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.ItemID }).HasName("PK_RujukBalikBPJSDT_2");
        });

        modelBuilder.Entity<RuleLabDashboard>(entity =>
        {
            entity.HasKey(e => e.RuleId).HasName("PK__RuleLabD__110458E2EC6B4C54");

            entity.Property(e => e.Sex).IsFixedLength();
        });

        modelBuilder.Entity<RulesMCUHd>(entity =>
        {
            entity.HasOne(d => d.ProblemCodeNavigation).WithMany(p => p.RulesMCUHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RulesMCUHd_ItemCompileMCU");
        });

        modelBuilder.Entity<RulesMCUParameterDt>(entity =>
        {
            entity.Property(e => e.IsNumeric).HasDefaultValue(false, "DF_RulesMCUParameterDt_IsNumeric");
        });

        modelBuilder.Entity<RulesMCURecommendationDt>(entity =>
        {
            entity.HasOne(d => d.RecommendationCodeNavigation).WithMany(p => p.RulesMCURecommendationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RulesMCURecommendationDt_ItemCompileMCU");

            entity.HasOne(d => d.Rules).WithMany(p => p.RulesMCURecommendationDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RulesMCURecommendationDt_RulesMCUHd");
        });

        modelBuilder.Entity<SalaryAdjustment>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.SalaryAdjustment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryAdjustment_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.SalaryAdjustment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryAdjustment_sysTransactionCode");
        });

        modelBuilder.Entity<SalaryComponent>(entity =>
        {
            entity.HasOne(d => d.GCOccursNavigation).WithMany(p => p.SalaryComponentGCOccursNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryComponent_sysGeneralCode2");

            entity.HasOne(d => d.GCSalaryComponentTaxNavigation).WithMany(p => p.SalaryComponentGCSalaryComponentTaxNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryComponent_sysGeneralCode1");

            entity.HasOne(d => d.GCSalaryGroupNavigation).WithMany(p => p.SalaryComponentGCSalaryGroupNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryComponent_sysGeneralCode");
        });

        modelBuilder.Entity<SalaryComponentEmployee>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.SalaryComponentEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryComponentEmployee_Employee");

            entity.HasOne(d => d.SalaryCodeNavigation).WithMany(p => p.SalaryComponentEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalaryComponentEmployee_SalaryComponent");
        });

        modelBuilder.Entity<Sample>(entity =>
        {
            entity.Property(e => e.IsDisplayedOnReport).HasDefaultValue(true, "DF_Sample_IsDisplayedOnReport");
        });

        modelBuilder.Entity<SatuSehatAnamnesisGolonganDarah>(entity =>
        {
            entity.HasKey(e => e.GolonganDarahID).HasName("PK_SatuSehatAnamnesisGolonganDarah_2");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatAnamnesisGolonganDarah_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatAnamnesisResus>(entity =>
        {
            entity.HasKey(e => e.ResusID).HasName("PK_SatuSehatAnamnesisResus_2");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatAnamnesisResus_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatAnamnesisStatusKehamilan>(entity =>
        {
            entity.HasKey(e => e.StatusKehamilanID).HasName("PK_SatuSehatAnamnesisStatusKehamilan_2");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatAnamnesisStatusKehamilan_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatCompositDiet>(entity =>
        {
            entity.HasKey(e => e.CompositDietID).HasName("PK_SatuSehatCompositDiet_1");
        });

        modelBuilder.Entity<SatuSehatDepartmentServiceUnit>(entity =>
        {
            entity.HasKey(e => e.ServiceUnitID).HasName("PK_SatuSehatDepartmentServiceUnit_1");

            entity.Property(e => e.ServiceUnitID).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_SatuSehatDepartmentServiceUnit_IsActive_1");
        });

        modelBuilder.Entity<SatuSehatDiagnosticReport>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatDiagnosticReport_IsDeleted");
        });

        modelBuilder.Entity<SatuSehatDiagnosticReportRadiology>(entity =>
        {
            entity.HasKey(e => e.DiagnosticReportID).HasName("PK_SatuSehatDiagnosticReportRadiology_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatDiagnosticReportRadiology_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatEpisodeDiagnosis>(entity =>
        {
            entity.HasKey(e => e.ConditionIHSNo).HasName("PK_SatuSehatEpisodeDiagnosis_1");
        });

        modelBuilder.Entity<SatuSehatImagingSingleImage>(entity =>
        {
            entity.HasKey(e => e.ImagingSingleImageID).HasName("PK_SatuSehatImagingSingleImage_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatImagingSingleImage_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatImagingStudyRadiology>(entity =>
        {
            entity.HasKey(e => e.ImagingStudyID).HasName("PK_SatuSehatImagingStudyRadiology_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatImagingStudyRadiology_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatInstruksiMedikDanKeperawatanPasien>(entity =>
        {
            entity.HasKey(e => e.InstruksiMedikKeperawatanID).HasName("PK_SatuSehatInstruksiMedikDanKeperawatanPasien_1");
        });

        modelBuilder.Entity<SatuSehatKeluhanUtama>(entity =>
        {
            entity.HasKey(e => e.KeluhanUtamaID).HasName("PK_SatuSehatKeluhanUtama_1");
        });

        modelBuilder.Entity<SatuSehatMedicationAdministration>(entity =>
        {
            entity.HasKey(e => e.MedicationAdminNo).HasName("PK__SatuSeha__3E565B0A3C81C5A5");
        });

        modelBuilder.Entity<SatuSehatMedicationCreateExp>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatMedicationCreateExp_IsDeleted");
        });

        modelBuilder.Entity<SatuSehatMedicationCreateOne>(entity =>
        {
            entity.HasKey(e => e.ItemID).HasName("PK_SatuSehatMedicationCreateOne_1");

            entity.Property(e => e.ItemID).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatMedicationCreateOne_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatMedicationDispense>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatMedicationDispense_IsDeleted");
        });

        modelBuilder.Entity<SatuSehatMedicationRequest>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatMedicationRequest_IsDeleted");
        });

        modelBuilder.Entity<SatuSehatMedicationVariasiDt>(entity =>
        {
            entity.HasOne(d => d.MedicationCreate).WithMany(p => p.SatuSehatMedicationVariasiDt).HasConstraintName("FK_SatuSehatMedicationVariasiDt_SatuSehatMedicationVariasiHd");
        });

        modelBuilder.Entity<SatuSehatObservasiKesadaran>(entity =>
        {
            entity.HasKey(e => e.ObservationID).HasName("PK_SatuSehatObservasiKesadaran_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatObservasiKesadaran_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatObservation>(entity =>
        {
            entity.HasKey(e => e.ObservationID).HasName("PK_SatuSehatObservation_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatObservation_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatObservationRadiology>(entity =>
        {
            entity.HasKey(e => e.ObservationID).HasName("PK_SatuSehatObservationRadiology_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatObservationRadiology_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatParamedic>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatParamedic_IsDeleted");
            entity.Property(e => e.SSN).HasDefaultValue("", "DF_SatuSehatParamedic_SSN");
        });

        modelBuilder.Entity<SatuSehatPatient>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_SatuSehatPatient_IsActive");
            entity.Property(e => e.IsAlive).HasDefaultValue(true, "DF_SatuSehatPatient_IsAlive");
            entity.Property(e => e.SSN).HasDefaultValue("", "DF_SatuSehatPatient_SSN");
        });

        modelBuilder.Entity<SatuSehatPatientAllergy>(entity =>
        {
            entity.HasKey(e => e.PatientAllergenIHSNo).HasName("PK_SatuSehatPatientAllergy_1");
        });

        modelBuilder.Entity<SatuSehatPemeriksaanAntropometri>(entity =>
        {
            entity.HasKey(e => e.PemeriksaanAntropometriID).HasName("PK_SatuSehatPemeriksaanAntropometri_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatPemeriksaanAntropometri_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatPemeriksaanFisik>(entity =>
        {
            entity.HasKey(e => e.PemeriksaanFisikID).HasName("PK_SatuSehatPemeriksaanFisik_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatPemeriksaanFisik_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatPemeriksaanOHIS>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatPemeriksaanOHIS_IsDeleted");
        });

        modelBuilder.Entity<SatuSehatPemeriksaanPsikologis>(entity =>
        {
            entity.HasKey(e => e.PemeriksaanPsikologisID).HasName("PK_SatuSehatPemeriksaanPsikologis_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatPemeriksaanPsikologis_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatProcedureEdukasi>(entity =>
        {
            entity.HasKey(e => new { e.ProcedureEdukasiIHSNo, e.EncounterIHSNo }).HasName("PK_SatuSehatProcedureEdukasi_1");
        });

        modelBuilder.Entity<SatuSehatPrognosis>(entity =>
        {
            entity.HasKey(e => new { e.PrognosisID, e.RegistrationNo, e.SnomedCode }).HasName("PK_SatuSehatPrognosis_1");
        });

        modelBuilder.Entity<SatuSehatReferralPatient>(entity =>
        {
            entity.HasKey(e => e.EncounterIHSNo).HasName("PK_SatuSehatReferralPatient_1");
        });

        modelBuilder.Entity<SatuSehatRegistration>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.SatuSehatRegistration).HasConstraintName("FK_SatuSehatRegistration_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.SatuSehatRegistration).HasConstraintName("FK_SatuSehatRegistration_Site");
        });

        modelBuilder.Entity<SatuSehatRencanaRawatPasien>(entity =>
        {
            entity.HasKey(e => e.RencanaRawatID).HasName("PK_SatuSehatRencanaRawatPasien_1");
        });

        modelBuilder.Entity<SatuSehatRiwayatPengobatan>(entity =>
        {
            entity.HasKey(e => e.RiwayatPengobatanID).HasName("PK_SatuSehatRiwayatPengobatan_1");
        });

        modelBuilder.Entity<SatuSehatRiwayatPenyakit>(entity =>
        {
            entity.HasKey(e => e.RiwayatPenyakitID).HasName("PK_SatuSehatRiwayatPenyakit_1");
        });

        modelBuilder.Entity<SatuSehatServiceRequest>(entity =>
        {
            entity.HasKey(e => e.ServiceRequestID).HasName("PK_SatuSehatServiceRequest_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatServiceRequest_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatServiceRequestPulangKontrol>(entity =>
        {
            entity.HasKey(e => e.ServiceRequestID).HasName("PK_SatuSehatServiceRequestPulangKontrol_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatServiceRequestPulangKontrol_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatServiceRequestRadiology>(entity =>
        {
            entity.HasKey(e => e.ServiceRequestID).HasName("PK_SatuSehatServiceRequestRadiology_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatServiceRequestRadiology_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatServiceRequestRujukanAmbulance>(entity =>
        {
            entity.HasKey(e => e.ServiceRequestID).HasName("PK_SatuSehatServiceRequestRujukanAmbulance_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatServiceRequestRujukanAmbulance_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatSiteDepartment>(entity =>
        {
            entity.Property(e => e.SiteDepartmentID).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_SatuSehatSiteDepartment_IsActive");
        });

        modelBuilder.Entity<SatuSehatSpecimen>(entity =>
        {
            entity.HasKey(e => e.SpecimenID).HasName("PK_SatuSehatSpecimen_1");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatSpecimen_IsDeleted_1");
        });

        modelBuilder.Entity<SatuSehatTerminologiGigiMapping>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_SatuSehatTerminologiGigiMapping_IsActive");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatTerminologiGigiMapping_IsDeleted");
        });

        modelBuilder.Entity<SatuSehatVitalSign>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SatuSehatVitalSign_IsDeleted_1");
        });

        modelBuilder.Entity<ScreeningPatientHighRisk>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.ScreeningPatientHighRisk).HasConstraintName("FK_ScreeningPatientHighRisk_Registration");
        });

        modelBuilder.Entity<SendToAutopackHistoryDt>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_SendToAutopackHistory");

            entity.HasOne(d => d.BaseUnitNavigation).WithMany(p => p.SendToAutopackHistoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SendToAutopackHistoryDt_ItemUnit");
        });

        modelBuilder.Entity<SendToAutopackHistoryHd>(entity =>
        {
            entity.HasKey(e => e.SendToAutopackNo).HasName("PK_SendToAutopackHd");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.SendToAutopackHistoryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SendToAutopackHistoryHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.SendToAutopackHistoryHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SendToAutopackHistoryHd_sysTransactionCode");
        });

        modelBuilder.Entity<SerahTerimaBarang>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.SerahTerimaBarang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerahTerimaBarang_Registration");
        });

        modelBuilder.Entity<ServiceOrderDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ServiceOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderDt_ItemID");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ServiceOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderDt_ItemUnit");

            entity.HasOne(d => d.ServiceOrderNoNavigation).WithMany(p => p.ServiceOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderDt_ServiceOrderHd");

            entity.HasOne(d => d.ServiceOrderRequestDt).WithMany(p => p.ServiceOrderDt).HasConstraintName("FK_ServiceOrderDt_ServiceOrderRequestDt");
        });

        modelBuilder.Entity<ServiceOrderHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.ServiceOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderHd_BusinessPartner");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ServiceOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderHd_SiteCode");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ServiceOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderHd_SysTransaction");
        });

        modelBuilder.Entity<ServiceOrderRequestDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ServiceOrderRequestDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderRequestDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.ServiceOrderRequestDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderRequestDt_ItemUnit");

            entity.HasOne(d => d.ServiceOrderRequestNoNavigation).WithMany(p => p.ServiceOrderRequestDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderRequestDt_ServiceOrderRequestHd");
        });

        modelBuilder.Entity<ServiceOrderRequestHd>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.ServiceOrderRequestHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderRequestHd_BusinessPartner");

            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.ServiceOrderRequestHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderRequestHd_sysGeneralCode");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ServiceOrderRequestHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderRequestHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.ServiceOrderRequestHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOrderRequestHd_sysTransactionCode");
        });

        modelBuilder.Entity<ServiceRoom>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ServiceRoom_IsActive");
        });

        modelBuilder.Entity<ServiceUnit>(entity =>
        {
            entity.HasKey(e => e.ServiceUnitCode).HasName("PK_ServiceUnit_1");

            entity.Property(e => e.Initial).HasDefaultValue("", "DF_ServiceUnit_Initial");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ServiceUnit_IsActive");
            entity.Property(e => e.IsBor).HasDefaultValue(true, "DF_ServiceUnit_IsBor");
            entity.Property(e => e.ShortName).HasDefaultValue("", "DF_ServiceUnit_ShortName");
        });

        modelBuilder.Entity<ServiceUnitItem>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ServiceUnitItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitItem_Item1");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ServiceUnitItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitItem_DepartmentServiceUnit1");
        });

        modelBuilder.Entity<ServiceUnitItemMcu>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.ServiceUnitItemMcuItem).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ParentItem).WithMany(p => p.ServiceUnitItemMcuParentItem).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ServiceUnitItemMcu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitItemMcu_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ServiceUnitItemMcu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitItemMcu_Site");
        });

        modelBuilder.Entity<ServiceUnitJobOrderType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ServiceUnitJobOrderType_1");

            entity.HasOne(d => d.ItemGroupCodeNavigation).WithMany(p => p.ServiceUnitJobOrderType).HasConstraintName("FK_ServiceUnitJobOrderType_ItemGroup");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ServiceUnitJobOrderType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitJobOrderType_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.ServiceUnitJobOrderType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitJobOrderType_Site");

            entity.HasOne(d => d.SiteDepartment).WithMany(p => p.ServiceUnitJobOrderType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitJobOrderType_SiteDepartment");
        });

        modelBuilder.Entity<ServiceUnitLocation>(entity =>
        {
            entity.HasOne(d => d.Location).WithMany(p => p.ServiceUnitLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitLocation_Location");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ServiceUnitLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitLocation_DepartmentServiceUnit");
        });

        modelBuilder.Entity<ServiceUnitOutpatient>(entity =>
        {
            entity.HasKey(e => new { e.No, e.JenisKegiatan }).HasName("PK_ServiceUnitOutpatient_2");
        });

        modelBuilder.Entity<ServiceUnitParamedic>(entity =>
        {
            entity.HasKey(e => new { e.ServiceUnitID, e.ParamedicID }).HasName("PK_ServiceUnitParamedic_1");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.ServiceUnitParamedic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitParamedic_Paramedic");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ServiceUnitParamedic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitParamedic_DepartmentServiceUnit");
        });

        modelBuilder.Entity<ServiceUnitPrinter>(entity =>
        {
            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ServiceUnitPrinter)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitPrinter_DepartmentServiceUnit");
        });

        modelBuilder.Entity<ServiceUnitRoom>(entity =>
        {
            entity.HasOne(d => d.Room).WithMany(p => p.ServiceUnitRoom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitRoom_ServiceRoom");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.ServiceUnitRoom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUnitRoom_DepartmentServiceUnit");
        });

        modelBuilder.Entity<SewaAlat>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<SignatureEffectiveCommunication>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SiklusMenuDt>(entity =>
        {
            entity.HasOne(d => d.GCCategoryNavigation).WithMany(p => p.SiklusMenuDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SiklusMenuDt_sysGeneralCode");

            entity.HasOne(d => d.MenuDiet).WithMany(p => p.SiklusMenuDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SiklusMenuDt_MenuDiet");

            entity.HasOne(d => d.Siklus).WithMany(p => p.SiklusMenuDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SiklusMenuDt_SiklusMenuHd");
        });

        modelBuilder.Entity<SisaObat>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_SisaObat_IsDeleted");
            entity.Property(e => e.IsRealization).HasDefaultValue(false, "DF_SisaObat_IsRealization");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.SiteCode).HasFillFactor(90);

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Site_IsActive");
            entity.Property(e => e.LicenseNo).HasDefaultValue("", "DF_Site_LicenseNo");
            entity.Property(e => e.ShortName).HasDefaultValue("", "DF_Site_ShortName");

            entity.HasOne(d => d.CorporateCodeNavigation).WithMany(p => p.Site)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Site_Corporate");

            entity.HasOne(d => d.GCSiteGroupNavigation).WithMany(p => p.Site).HasConstraintName("FK_Site_sysGeneralCode_SiteGroup");

            entity.HasOne(d => d.LocationNavigation).WithMany(p => p.Site).HasConstraintName("FK_Site_Location");
        });

        modelBuilder.Entity<SiteDepartment>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_SiteDepartment_IsActive");
            entity.Property(e => e.OfficerName).HasDefaultValue("", "DF_SiteDepartment_OfficerName");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.SiteDepartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SiteDepartment_Department");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.SiteDepartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SiteDepartment_Site");
        });

        modelBuilder.Entity<SpecialityChartCategoryHd>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_SpecialityChartCategoryHd_IsActive");
        });

        modelBuilder.Entity<Specialty>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Specialty_IsActive");

            entity.HasOne(d => d.GCSpecialtyGroupNavigation).WithMany(p => p.Specialty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Specialty_sysGeneralCode");
        });

        modelBuilder.Entity<SpecialtyChartCategoryDt>(entity =>
        {
            entity.HasOne(d => d.IdNavigation).WithMany(p => p.SpecialtyChartCategoryDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpecialtyChartCategoryDt_SpecialityChartCategoryHd");
        });

        modelBuilder.Entity<SpecialtyVitalSign>(entity =>
        {
            entity.HasOne(d => d.SpecialtyCodeNavigation).WithMany(p => p.SpecialtyVitalSign)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpecialtyVitalSign_Specialty");

            entity.HasOne(d => d.VitalSignCodeNavigation).WithMany(p => p.SpecialtyVitalSign)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpecialtyVitalSign_VitalSignType");
        });

        modelBuilder.Entity<SpectaclePrescription>(entity =>
        {
            entity.Property(e => e.SequenceNo).HasDefaultValue("", "DF_SpectaclePrescription_SequenceNo");
            entity.Property(e => e.GCLensType).HasDefaultValue("", "DF_SpectaclePrescription_GCLensType");
            entity.Property(e => e.GCSpectaclePresc).HasDefaultValue("", "DF_SpectaclePrescription_GCSpectaclePresc");
            entity.Property(e => e.GCSpectacleType).HasDefaultValue("", "DF_SpectaclePrescription_GCSpectacleType");
            entity.Property(e => e.LeftAdd).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_LeftAdd");
            entity.Property(e => e.LeftBase).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_LeftBase");
            entity.Property(e => e.LeftDistantAxis).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_LeftAxis");
            entity.Property(e => e.LeftDistantCylinder).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_LeftCylinder");
            entity.Property(e => e.LeftDistantPrism).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_LeftPrism");
            entity.Property(e => e.LeftDistantSphere).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_LeftSphere");
            entity.Property(e => e.RightAdd).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_RightAdd");
            entity.Property(e => e.RightBase).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_RightBase");
            entity.Property(e => e.RightDistantAxis).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_RightAxis");
            entity.Property(e => e.RightDistantCylinder).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_RightCylinder");
            entity.Property(e => e.RightDistantPrism).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_RightPrism");
            entity.Property(e => e.RightDistantSphere).HasDefaultValueSql("((0))", "DF_SpectaclePrescription_RightSphere");

            entity.HasOne(d => d.GCLensTypeNavigation).WithMany(p => p.SpectaclePrescriptionGCLensTypeNavigation).HasConstraintName("FK_SpectaclePrescription_SysgeneralCode_LensType");

            entity.HasOne(d => d.GCSpectaclePrescNavigation).WithMany(p => p.SpectaclePrescriptionGCSpectaclePrescNavigation).HasConstraintName("FK_SpectaclePrescription_SysGeneralCode_SpectaclePres");

            entity.HasOne(d => d.GCSpectacleTypeNavigation).WithMany(p => p.SpectaclePrescriptionGCSpectacleTypeNavigation).HasConstraintName("FK_SpectaclePrescription_SysGeneralCode_SpectacleType");

            entity.HasOne(d => d.MedicalNoNavigation).WithMany(p => p.SpectaclePrescription)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpectaclePrescription_Patient");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.SpectaclePrescription)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpectaclePrescription_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.SpectaclePrescription).HasConstraintName("FK_SpectaclePrescription_Site");
        });

        modelBuilder.Entity<StandardCostVsActualCost>(entity =>
        {
            entity.HasOne(d => d.CoaCodeNavigation).WithMany(p => p.StandardCostVsActualCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StandardCostVsActualCost_ChartOfAccount");

            entity.HasOne(d => d.CostTypeNavigation).WithMany(p => p.StandardCostVsActualCost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StandardCostVsActualCost_sysGeneralCode");
        });

        modelBuilder.Entity<StandartFilterMCU>(entity =>
        {
            entity.HasKey(e => e.filtercode).HasName("PK_StandartFilterMCU_filtercode");
        });

        modelBuilder.Entity<StewardScoreAnak>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_StewardScoreAnak_IsDeleted");
        });

        modelBuilder.Entity<StockAdjustmentDt>(entity =>
        {
            entity.HasOne(d => d.AdjustmentNoNavigation).WithMany(p => p.StockAdjustmentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentDt_StockAdjustmentHd");

            entity.HasOne(d => d.BaseItemUnitCodeNavigation).WithMany(p => p.StockAdjustmentDtBaseItemUnitCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Item).WithMany(p => p.StockAdjustmentDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.StockAdjustmentDtItemUnitCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentDt_ItemUnit");
        });

        modelBuilder.Entity<StockAdjustmentHd>(entity =>
        {
            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.StockAdjustmentHd).HasConstraintName("FK_StockAdjustmentHd_Department");

            entity.HasOne(d => d.GCAdjustmentTypeNavigation).WithMany(p => p.StockAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentHd_sysGeneralCode_AdjustmentType");

            entity.HasOne(d => d.Location).WithMany(p => p.StockAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentHd_Location");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.StockAdjustmentHd).HasConstraintName("FK_StockAdjustmentHd_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.StockAdjustmentHd).HasConstraintName("FK_StockAdjustmentHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.StockAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.StockAdjustmentHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockAdjustmentHd_sysTransactionCode");
        });

        modelBuilder.Entity<StockTakingDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.StockTakingDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTakingDt_Item");

            entity.HasOne(d => d.StockTakingNoNavigation).WithMany(p => p.StockTakingDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTakingDt_StockTakingHd");
        });

        modelBuilder.Entity<StockTakingHd>(entity =>
        {
            entity.Property(e => e.AbcClass).IsFixedLength();

            entity.HasOne(d => d.AbcClassNavigation).WithMany(p => p.StockTakingHd).HasConstraintName("FK_StockTakingHd_AbcClass");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.StockTakingHd).HasConstraintName("FK_StockTakingHd_Department");

            entity.HasOne(d => d.GCItemTypeNavigation).WithMany(p => p.StockTakingHd).HasConstraintName("FK_StockTakingHd_sysGeneralCode");

            entity.HasOne(d => d.ItemGroupCodeNavigation).WithMany(p => p.StockTakingHd).HasConstraintName("FK_StockTakingHd_ItemGroup");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.StockTakingHd).HasConstraintName("FK_StockTakingHd_ItemUnitCode");

            entity.HasOne(d => d.ServiceUnitCodeNavigation).WithMany(p => p.StockTakingHd).HasConstraintName("FK_StockTakingHd_ServiceUnit");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.StockTakingHd).HasConstraintName("FK_StockTakingHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.StockTakingHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTakingHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.StockTakingHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTakingHd_sysTransactionCode");
        });

        modelBuilder.Entity<StockTakingQR>(entity =>
        {
            entity.HasKey(e => new { e.ProcessDateTime, e.SequenceNo }).HasName("PK_StockTakingQR_1");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.BusinessPartnerID).ValueGeneratedNever();

            entity.HasOne(d => d.BusinessPartner).WithOne(p => p.Supplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Supplier_BusinessPartner1");

            entity.HasOne(d => d.GCSupplierTypeNavigation).WithMany(p => p.Supplier).HasConstraintName("FK_Supplier_sysGeneralCode");
        });

        modelBuilder.Entity<SupplierItem>(entity =>
        {
            entity.HasKey(e => new { e.BusinessPartnerID, e.ItemID }).HasFillFactor(90);

            entity.HasIndex(e => e.BusinessPartnerID, "IX_SupplierItem_BusinessPartnerID").HasFillFactor(90);

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.SupplierItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierItem_BusinessPartner1");

            entity.HasOne(d => d.Item).WithMany(p => p.SupplierItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierItem_Item1");
        });

        modelBuilder.Entity<SupplierItemPrice>(entity =>
        {
            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.SupplierItemPrice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierItemPrice_BusinessPartner");

            entity.HasOne(d => d.Item).WithMany(p => p.SupplierItemPrice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierItemPrice_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.SupplierItemPrice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierItemPrice_ItemUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.SupplierItemPrice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierItemPrice_Site");
        });

        modelBuilder.Entity<SupplierItemPriceDt>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<SuratKetDatangDalamKeadaanMeninggal>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.SuratKetDatangDalamKeadaanMeninggal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SuratKetDatangDalamKeadaanMeninggal_Registration");
        });

        modelBuilder.Entity<SuratKeteranganLayakTerbangTabel>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_SuratKeteranganLayakTerbangTabel_1");
        });

        modelBuilder.Entity<SuratKeteranganMeninggal>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.SuratKeteranganMeninggal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SuratKeteranganMeninggal_Registration");
        });

        modelBuilder.Entity<SuratKeteranganPenerbangan>(entity =>
        {
            entity.Property(e => e.LetterId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SuratKeteranganSakitElisabeth>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithOne(p => p.SuratKeteranganSakitElisabeth)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SuratKeteranganSakitElisabeth_Registration");
        });

        modelBuilder.Entity<SuratPenolakanTindakanKedokteran>(entity =>
        {
            entity.Property(e => e.SaksiKeluarga).IsFixedLength();
        });

        modelBuilder.Entity<SuratPernyataanRujukan>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_SuratPernyataanRujukan_RegistrationNo");
        });

        modelBuilder.Entity<SuratRujukanKeluar>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_SuratRujukanKeluar_1");
        });

        modelBuilder.Entity<SurgeryReportDiagnosisEMR>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_SurgeryReportDiagnosisEMR_2");
        });

        modelBuilder.Entity<SurgeryReservation>(entity =>
        {
            entity.HasOne(d => d.CategoryCodeNavigation).WithMany(p => p.SurgeryReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgeryReservation_SurgeryCategory");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.SurgeryReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgeryReservation_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.SurgeryReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgeryReservation_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.SurgeryReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgeryReservation_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.SurgeryReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgeryReservation_sysTransactionCode");

            entity.HasOne(d => d.WorkStationCodeNavigation).WithMany(p => p.SurgeryReservation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgeryReservation_WorkStation");
        });

        modelBuilder.Entity<SurgeryTeamTemplateDt>(entity =>
        {
            entity.HasOne(d => d.GCSurgeryParamedicTypeNavigation).WithMany(p => p.SurgeryTeamTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgeryTeamTemplateDt_sysGeneralCode");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.SurgeryTeamTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgeryTeamTemplateDt_Paramedic");

            entity.HasOne(d => d.SurgeryTeamCodeNavigation).WithMany(p => p.SurgeryTeamTemplateDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurgeryTeamTemplateDt_SurgeryTeamTemplateHd");
        });

        modelBuilder.Entity<SurgeryTeamTemplateHd>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("tr_ValidateSysTeam"));
        });

        modelBuilder.Entity<SysPatientMergeDt>(entity =>
        {
            entity.Property(e => e.PrimaryKeyField1).HasDefaultValue("", "DF_SysPatientMergeDt_PrimaryKeyField1");
            entity.Property(e => e.PrimaryKeyField2).HasDefaultValue("", "DF_SysPatientMergeDt_PrimaryKeyField11");
            entity.Property(e => e.TableRelated).HasDefaultValue("", "DF_SysPatientMergeDt_TableRelated");
            entity.Property(e => e.TableRelatedKey).HasDefaultValue("", "DF_SysPatientMergeDt_TableRelatedKey");
            entity.Property(e => e.TableRelatedPrimaryKey1).HasDefaultValue("", "DF_SysPatientMergeDt_TableRelatedPrimaryKey1");
            entity.Property(e => e.TableRelatedPrimaryKey2).HasDefaultValue("", "DF_SysPatientMergeDt_TableRelatedPrimaryKey2");
            entity.Property(e => e.UpdateFieldNonPrimaryKey).HasDefaultValue("", "DF_SysPatientMergeDt_UpadatedField");
            entity.Property(e => e.UpdateValueNonPrimaryKey).HasDefaultValue("", "DF_SysPatientMergeDt_UpadatedValueNonPrimaryKey");
        });

        modelBuilder.Entity<THTHidungMCU>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_THT_Hidung");
        });

        modelBuilder.Entity<THTLeherMCU>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_THT_Leher");
        });

        modelBuilder.Entity<THTTelingaMCU>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_THT_Telinga");
        });

        modelBuilder.Entity<THTTenggorokanMCU>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_THT_Tenggorokan");
        });

        modelBuilder.Entity<TReceiptDt>(entity =>
        {
            entity.Property(e => e.Amount).HasDefaultValue(0m, "DF__TempRecei__Amoun__798155F7");
            entity.Property(e => e.ReqAmount).HasDefaultValue(0m, "DF__TempRecei__ReqAm__788D31BE");
            entity.Property(e => e.ReviewAmount).HasDefaultValue(0m, "DF_TReceiptDt_ApproveAmount");
            entity.Property(e => e.SettleAmount).HasDefaultValue(0m, "DF_TReceiptDt_SettleAmount");
            entity.Property(e => e.isDeleted).HasDefaultValue(false, "DF_TReceiptDt_isDeleted");
        });

        modelBuilder.Entity<TReceiptHd>(entity =>
        {
            entity.HasKey(e => e.TransactionNo).HasName("PK__TReceipt__554342D8307932FC");

            entity.Property(e => e.BGAmount).HasDefaultValue(0m, "DF__TReceiptH__BGAmo__72002FC0");
            entity.Property(e => e.CashPaymentAmount).HasDefaultValue(0m, "DF__TReceiptH__CashP__710C0B87");
            entity.Property(e => e.ReturnAmount).HasDefaultValue(0m, "DF__TReceiptH__Retur__72F453F9");
            entity.Property(e => e.Total).HasDefaultValue(0m, "DF__TReceiptH__Total__7017E74E");
            entity.Property(e => e.isApproved).HasDefaultValue(false, "DF__TReceiptH__isApp__73E87832");
            entity.Property(e => e.isClosed).HasDefaultValue(false, "DF__TReceiptH__isClo__74DC9C6B");
            entity.Property(e => e.isDeleted).HasDefaultValue(false, "DF__TReceiptH__isDel__75D0C0A4");
        });

        modelBuilder.Entity<TReceiptRequestHd>(entity =>
        {
            entity.HasKey(e => e.TransactionNo).HasName("PK_TReceiptRequestHd_1");
        });

        modelBuilder.Entity<Table_1>(entity =>
        {
            entity.HasKey(e => e.ParamedicID).HasName("PK_Table_1_2");

            entity.Property(e => e.ParamedicID).ValueGeneratedNever();
        });

        modelBuilder.Entity<Table_5>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_Table_5_1");
        });

        modelBuilder.Entity<Table_6>(entity =>
        {
            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Table_6_IsActive");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_Table_6_IsDeleted");
            entity.Property(e => e.LastUpdatedDateTime).HasDefaultValueSql("(getdate())", "DF_Table_6_LastUpdatedDateTime");

            entity.HasOne(d => d.User).WithOne(p => p.Table_6)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_6_sysUser");
        });

        modelBuilder.Entity<TatBarcodeScan>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.TatBarcodeScan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TatBarcodeScan_Registration");

            entity.HasOne(d => d.Sample).WithMany(p => p.TatBarcodeScan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TatBarcodeScan_Sample");
        });

        modelBuilder.Entity<TatReport>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.TatReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TatReport_Registration");
        });

        modelBuilder.Entity<TempItemTemplateLab>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Temp_Patient>(entity =>
        {
            entity.Property(e => e.BloodRhesus).IsFixedLength();
        });

        modelBuilder.Entity<TemplateOtherExam>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_TemplateOtherExam_IsActive");

            entity.HasOne(d => d.Item).WithMany(p => p.TemplateOtherExam).HasConstraintName("FK_TemplateOtherExam_Item");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.TemplateOtherExam).HasConstraintName("FK_TemplateOtherExam_Paramedic");
        });

        modelBuilder.Entity<TemplateProductionDt>(entity =>
        {
            entity.HasOne(d => d.CoaCodeDebitNavigation).WithMany(p => p.TemplateProductionDt).HasConstraintName("FK_TemplateProductionDt_ChartOfAccount");

            entity.HasOne(d => d.GCReasonOutNavigation).WithMany(p => p.TemplateProductionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateProductionDt_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.TemplateProductionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateProductionDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.TemplateProductionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateProductionDt_ItemUnit");

            entity.HasOne(d => d.ProductionCodeNavigation).WithMany(p => p.TemplateProductionDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateProductionDt_TemplateProductionHd");
        });

        modelBuilder.Entity<TemplateProductionHd>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_TemplateProductionHd_IsActive");
            entity.Property(e => e.IsOneToMany).HasDefaultValue(false, "DF_TemplateProductionHd_IsOneToMany");

            entity.HasOne(d => d.CoaCodeCreditNavigation).WithMany(p => p.TemplateProductionHd).HasConstraintName("FK_TemplateProductionHd_ChartOfAccount");

            entity.HasOne(d => d.GCReasonInNavigation).WithMany(p => p.TemplateProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateProductionHd_sysGeneralCode");

            entity.HasOne(d => d.Item).WithMany(p => p.TemplateProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateProductionHd_Item");

            entity.HasOne(d => d.ProductionUnitNavigation).WithMany(p => p.TemplateProductionHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateProductionHd_ItemUnit");
        });

        modelBuilder.Entity<TemplateRadiology>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_TemplateRadiology_IsActive");

            entity.HasOne(d => d.Item).WithMany(p => p.TemplateRadiology).HasConstraintName("FK_TemplateRadiology_Item");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.TemplateRadiology).HasConstraintName("FK_TemplateRadiology_Paramedic");
        });

        modelBuilder.Entity<TemplateTariffDt>(entity =>
        {
            entity.HasOne(d => d.ClassCategoryCodeNavigation).WithMany(p => p.TemplateTariffDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateTariffDt_ClassCategory");

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.TemplateTariffDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateTariffDt_Class");

            entity.HasOne(d => d.Item).WithMany(p => p.TemplateTariffDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateTariffDt_Item");

            entity.HasOne(d => d.Parent).WithMany(p => p.TemplateTariffDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemplateTariffDt_TemplateTariffHd");
        });

        modelBuilder.Entity<TemplateTariffHd>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_TemplateTariffHd_IsDeleted");

            entity.HasOne(d => d.BusinessPartner).WithMany(p => p.TemplateTariffHd).HasConstraintName("FK_TemplateTariffHd_BusinessPartner");

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.TemplateTariffHd).HasConstraintName("FK_TemplateTariffHd_Class");
        });

        modelBuilder.Entity<TemplateText>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_TemplateText_IsActive");

            entity.HasOne(d => d.GCTemplateGroupNavigation).WithMany(p => p.TemplateText).HasConstraintName("FK_TemplateText_sysGeneralCode_TemplateGroup");
        });

        modelBuilder.Entity<Term>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Term_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_Term_Remarks");
        });

        modelBuilder.Entity<TimeAttendanceRecapDetailDt>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.TimeAttendanceRecapDetailDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeAttendanceRecapDetailDt_Employee");

            entity.HasOne(d => d.Header).WithMany(p => p.TimeAttendanceRecapDetailDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeAttendanceRecapDetailDt_TimeAttendaceRecapDetailHd");

            entity.HasOne(d => d.ShiftCodeNavigation).WithMany(p => p.TimeAttendanceRecapDetailDt).HasConstraintName("FK_TimeAttendanceRecapDetailDt_WorkShiftHrd");
        });

        modelBuilder.Entity<TimeAttendanceRecapDetailHd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TimeAttendaceRecapDetailHd");
        });

        modelBuilder.Entity<TimeAttendanceRecapDt>(entity =>
        {
            entity.HasOne(d => d.DocumentNoNavigation).WithMany(p => p.TimeAttendanceRecapDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeAttendanceRecapDt_TimeAttendanceRecapHd");

            entity.HasOne(d => d.Employee).WithMany(p => p.TimeAttendanceRecapDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeAttendanceRecapDt_Employee");
        });

        modelBuilder.Entity<TimeAttendanceRecapHd>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.TimeAttendanceRecapHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeAttendanceRecapHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.TimeAttendanceRecapHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimeAttendanceRecapHd_sysTransactionCode");
        });

        modelBuilder.Entity<TingkatKesadaranMapping>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_TingkatKesadaranMapping_IsActive");
        });

        modelBuilder.Entity<TingkatkepuasanPelanggan>(entity =>
        {
            entity.HasOne(d => d.Template).WithMany(p => p.TingkatkepuasanPelanggan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TingkatkepuasanPelanggan_TemplateTingkatKepuasanPelanggan");
        });

        modelBuilder.Entity<ToothStatusRule>(entity =>
        {
            entity.HasOne(d => d.GCToothStatusNavigation).WithMany(p => p.ToothStatusRuleGCToothStatusNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToothStatusRule_sysGeneralCode");

            entity.HasOne(d => d.ValidGCToothStatusNavigation).WithMany(p => p.ToothStatusRuleValidGCToothStatusNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToothStatusRule_sysGeneralCode1");
        });

        modelBuilder.Entity<TransactionChargesDt>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("tr_ValidateHoldTransaction"));

            entity.HasIndex(e => new { e.TransactionNo, e.IsDiscontinued }, "IX_TransactionChargesDt").HasFillFactor(90);

            entity.Property(e => e.IsShow).HasDefaultValue(true, "DF_TransactionChargesDt_IsShow");
            entity.Property(e => e.IsVerifiedRevenue).HasDefaultValue(false, "DF_TransactionChargesDt_IsVerifiedRevenue");

            entity.HasOne(d => d.Asset).WithMany(p => p.TransactionChargesDt).HasConstraintName("FK_TransactionChargesDt_Assets");

            entity.HasOne(d => d.FromRegistrationNoNavigation).WithMany(p => p.TransactionChargesDt).HasConstraintName("FK_TransactionChargesDt_Registration");

            entity.HasOne(d => d.Item).WithMany(p => p.TransactionChargesDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionChargesDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.TransactionChargesDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionChargesDt_ItemUnit");

            entity.HasOne(d => d.Location).WithMany(p => p.TransactionChargesDt).HasConstraintName("FK_TransactionChargesDt_Location");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.TransactionChargesDt).HasConstraintName("FK_TransactionChargesDt_Paramedic");

            entity.HasOne(d => d.TransactionNoNavigation).WithMany(p => p.TransactionChargesDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionChargesDt_TransactionChargesHd");
        });

        modelBuilder.Entity<TransactionChargesDtBOM>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.TransactionChargesDtBOMItem).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.TransactionChargesDtBOM).HasConstraintName("FK_TransactionChargesDtBOM_DepartmentServiceUnit");

            entity.HasOne(d => d.TransactionChargesDt).WithMany(p => p.TransactionChargesDtBOM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionChargesDtBOM_TransactionChargesDt");
        });

        modelBuilder.Entity<TransactionChargesHd>(entity =>
        {
            entity.HasIndex(e => new { e.SiteCode, e.RegistrationNo, e.IsDeleted }, "IX_TransactionChargesHd_SiteCode_RegNo_IsDeleted").HasFillFactor(90);

            entity.HasOne(d => d.Bed).WithMany(p => p.TransactionChargesHd).HasConstraintName("FK_TransactionChargesHd_Bed");

            entity.HasOne(d => d.ChargeClassCodeNavigation).WithMany(p => p.TransactionChargesHdChargeClassCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ClassCodeNavigation).WithMany(p => p.TransactionChargesHdClassCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.TransactionChargesHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionChargesHd_Registration");

            entity.HasOne(d => d.Room).WithMany(p => p.TransactionChargesHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionChargesHd_ServiceRoom");

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.TransactionChargesHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionChargesHd_DepartmentServiceUnit");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.TransactionChargesHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionChargesHd_Site");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.TransactionChargesHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionChargesHd_sysTransactionCode");
        });

        modelBuilder.Entity<TransactionCodeCOA>(entity =>
        {
            entity.HasKey(e => new { e.TransactionCode, e.SequenceNo }).HasName("PK_TransactionCodeCOA_1");

            entity.Property(e => e.WhereClause).HasDefaultValue("", "DF_TransactionCodeCOA_WhereClause");

            entity.HasOne(d => d.AGCItemCodeNavigation).WithMany(p => p.TransactionCodeCOA).HasConstraintName("FK_TransactionCodeCOA_AGCItem");

            entity.HasOne(d => d.COACodeNavigation).WithMany(p => p.TransactionCodeCOA).HasConstraintName("FK_TransactionCodeCOA_ChartOfAccount");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.TransactionCodeCOA)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionCodeCOA_sysTransactionCode");
        });

        modelBuilder.Entity<TransactionCodeSource>(entity =>
        {
            entity.Property(e => e.Description).HasDefaultValue("", "DF_TransactionCodeSource_Description");
            entity.Property(e => e.WhereClause).HasDefaultValue("", "DF_TransactionCodeSource_WhereClause");

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.TransactionCodeSource)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionCodeSource_sysTransactionCode");
        });

        modelBuilder.Entity<TransactionNonCPOEServiceUnit>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();

            entity.HasOne(d => d.ServiceUnit).WithMany(p => p.TransactionNonCPOEServiceUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionNonCPOEServiceUnit_DepartmentServiceUnit");
        });

        modelBuilder.Entity<TransaksiPMKP>(entity =>
        {
            entity.Property(e => e.DeminatorName).IsFixedLength();
            entity.Property(e => e.GroupType).IsFixedLength();
            entity.Property(e => e.IndikatorName).IsFixedLength();
            entity.Property(e => e.NominatorName).IsFixedLength();
            entity.Property(e => e.PeriodeName).IsFixedLength();
        });

        modelBuilder.Entity<TransferOrderDt>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.TransferOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrderDt_Item");

            entity.HasOne(d => d.ItemUnitCodeNavigation).WithMany(p => p.TransferOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrderDt_ItemUnit");

            entity.HasOne(d => d.TransferOrderNoNavigation).WithMany(p => p.TransferOrderDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrderDt_TransferOrderHd");
        });

        modelBuilder.Entity<TransferOrderHd>(entity =>
        {
            entity.HasOne(d => d.FromLocation).WithMany(p => p.TransferOrderHdFromLocation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromServiceUnit).WithMany(p => p.TransferOrderHdFromServiceUnit).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromSiteCodeNavigation).WithMany(p => p.TransferOrderHdFromSiteCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FromSiteDepartment).WithMany(p => p.TransferOrderHdFromSiteDepartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrderHd_SiteDepartment_fromSiteDepartmentID");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.TransferOrderHdSiteCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToLocation).WithMany(p => p.TransferOrderHdToLocation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToServiceUnit).WithMany(p => p.TransferOrderHdToServiceUnit).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToSiteCodeNavigation).WithMany(p => p.TransferOrderHdToSiteCodeNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ToSiteDepartment).WithMany(p => p.TransferOrderHdToSiteDepartment).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TransactionCodeNavigation).WithMany(p => p.TransferOrderHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferOrderHd_sysTransactionCode");
        });

        modelBuilder.Entity<TreadmilTest>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_TreadmilTest_IsDeleted");
        });

        modelBuilder.Entity<UnfitRulesMCUCorporate>(entity =>
        {
            entity.HasOne(d => d.Rules).WithMany(p => p.UnfitRulesMCUCorporate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnfitRulesMCUCorporate_RulesMCUHd");
        });

        modelBuilder.Entity<UnitDoseStatus>(entity =>
        {
            entity.HasKey(e => new { e.JobOrderNo, e.SequenceNo }).HasName("PK_UnitDoseStatus_1");
        });

        modelBuilder.Entity<UnitOfMeasure>(entity =>
        {
            entity.HasKey(e => e.UnitOfMeasureCode).HasName("PK_UnitOfMeasure_1");

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_UnitOfMeasure_IsActive_1");
            entity.Property(e => e.LastUpdatedDateTime).HasDefaultValueSql("(getdate())", "DF_UnitOfMeasure_LastUpdatedDateTime");
        });

        modelBuilder.Entity<UploadDocumentInacbgCovid>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_UploadDocumentInacbgCovid_IsDeleted_1");
        });

        modelBuilder.Entity<UserNotificationStatus>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK_UserNotificationStatus_1");
        });

        modelBuilder.Entity<Vaccination>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Vaccination_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_Vaccination_Remarks");
        });

        modelBuilder.Entity<VaccinationShotDt>(entity =>
        {
            entity.HasOne(d => d.GCVaccinationStatusNavigation).WithMany(p => p.VaccinationShotDt).HasConstraintName("FK_VaccinationShotDt_SysGeneralCode_VaccinationStatus");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.VaccinationShotDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotDt_Site");

            entity.HasOne(d => d.VaccinationTypeCodeNavigation).WithMany(p => p.VaccinationShotDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotDt_VaccinationType");

            entity.HasOne(d => d.VaccinationShotSubDt).WithMany(p => p.VaccinationShotDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotDt_VaccinationShotHd");
        });

        modelBuilder.Entity<VaccinationShotHd>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_VaccinationShotHd_1");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.VaccinationShotHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotHd_Paramedic");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.VaccinationShotHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.VaccinationShotHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotHd_Site");
        });

        modelBuilder.Entity<VaccinationShotSubDt>(entity =>
        {
            entity.HasOne(d => d.GCInjectionSiteNavigation).WithMany(p => p.VaccinationShotSubDtGCInjectionSiteNavigation).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.InventoryUnitCodeNavigation).WithMany(p => p.VaccinationShotSubDt).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Item).WithMany(p => p.VaccinationShotSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotSubDt_Item");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.VaccinationShotSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotSubDt_Site");

            entity.HasOne(d => d.VaccinationCodeNavigation).WithMany(p => p.VaccinationShotSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotSubDt_Vaccination");

            entity.HasOne(d => d.VaccinationShotHd).WithMany(p => p.VaccinationShotSubDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationShotSubDt_Registration");
        });

        modelBuilder.Entity<VaccinationType>(entity =>
        {
            entity.HasKey(e => e.VaccinationTypeCode).HasFillFactor(90);

            entity.Property(e => e.GCVaccinationGroup).HasDefaultValue("", "DF_VaccinationType_GCVaccinationGroup");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_VaccinationType_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_VaccinationType_Remarks");

            entity.HasOne(d => d.GCVaccinationGroupNavigation).WithMany(p => p.VaccinationType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VaccinationType_SysGeneralCode_VaccinationGroup");
        });

        modelBuilder.Entity<ViewEMRLog>(entity =>
        {
            entity.HasOne(d => d.GCReasonToViewEMRNavigation).WithMany(p => p.ViewEMRLog)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ViewEMRLog_sysGeneralCode");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.ViewEMRLog)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ViewEMRLog_Registration");
        });

        modelBuilder.Entity<VisitReason>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_VisitReason_IsActive");
        });

        modelBuilder.Entity<VisitType>(entity =>
        {
            entity.HasKey(e => e.VisitTypeCode).HasFillFactor(90);

            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_VisitType_IsActive");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_VisitType_Remarks");
        });

        modelBuilder.Entity<VitalSignCodeVs3>(entity =>
        {
            entity.HasOne(d => d.ItemServiceNavigation).WithMany(p => p.VitalSignCodeVs3).HasConstraintName("FK_VitalSignCodeVs3_ItemService");

            entity.HasOne(d => d.VitalSignCodeNavigation).WithMany(p => p.VitalSignCodeVs3)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VitalSignCodeVs3_VitalSignType");
        });

        modelBuilder.Entity<VitalSignDt>(entity =>
        {
            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.VitalSignDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VitalSignDt_Site");

            entity.HasOne(d => d.VitalSignCodeNavigation).WithMany(p => p.VitalSignDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VitalSignDt_VitalSignType");

            entity.HasOne(d => d.VitalSignHd).WithMany(p => p.VitalSignDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VitalSignDt_VitalSignHd");
        });

        modelBuilder.Entity<VitalSignDtFromVs3>(entity =>
        {
            entity.HasOne(d => d.VitalSignCodeNavigation).WithMany(p => p.VitalSignDtFromVs3).HasConstraintName("FK_VitalSignDtFromVs3_VitalSignType");

            entity.HasOne(d => d.VitalSignHdFromVs3).WithMany(p => p.VitalSignDtFromVs3)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VitalSignDtFromVs3_VitalSignHdFromVs3");
        });

        modelBuilder.Entity<VitalSignHd>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SequenceNo }).HasName("PK_VitalSignHd_1");

            entity.HasOne(d => d.JobOrderNoNavigation).WithMany(p => p.VitalSignHd).HasConstraintName("FK_VitalSignHd_JobOrderHd");

            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.VitalSignHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VitalSignHd_Registration");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.VitalSignHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VitalSignHd_Site");
        });

        modelBuilder.Entity<VitalSignHdFromVs3>(entity =>
        {
            entity.HasOne(d => d.RegistrationNoNavigation).WithMany(p => p.VitalSignHdFromVs3)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VitalSignHdFromVs3_Registration");
        });

        modelBuilder.Entity<VitalSignMachineDt>(entity =>
        {
            entity.Property(e => e.IsDeleted).IsFixedLength();
        });

        modelBuilder.Entity<VitalSignType>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_VitalSignType_IsActive");
            entity.Property(e => e.VitalSignUnit).HasDefaultValue("", "DF_VitalSignType_VitalSignUnit");

            entity.HasOne(d => d.GCValueCode).WithMany(p => p.VitalSignType).HasConstraintName("FK_VitalSignType_sysGeneralCode");

            entity.HasOne(d => d.SpecialtyCodeNavigation).WithMany(p => p.VitalSignType).HasConstraintName("FK_VitalSignType_Specialty");

            entity.HasOne(d => d.UnitOfMeasureCodeNavigation).WithMany(p => p.VitalSignType).HasConstraintName("FK_VitalSignType_UnitOfMeasure");
        });

        modelBuilder.Entity<VitalSignValueVs3>(entity =>
        {
            entity.HasOne(d => d.VitalSignCodeNavigation).WithMany(p => p.VitalSignValueVs3)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VitalSignValueVs3_VitalSignType");
        });

        modelBuilder.Entity<WaBlastMessage>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Waste>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<WaterConsumption>(entity =>
        {
            entity.HasKey(e => new { e.NomorIDPelanggan, e.SequenceNo }).HasName("PK_WaterConsumption_1");
        });

        modelBuilder.Entity<WordPattern>(entity =>
        {
            entity.Property(e => e.ActionNo).ValueGeneratedNever();
        });

        modelBuilder.Entity<WordRelated>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<WorkCycleDt>(entity =>
        {
            entity.HasOne(d => d.CycleCodeNavigation).WithMany(p => p.WorkCycleDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkCycleDt_WorkCycleHd");

            entity.HasOne(d => d.ShiftCodeNavigation).WithMany(p => p.WorkCycleDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkCycleDt_WorkShiftHrd");
        });

        modelBuilder.Entity<WorkOffPermission>(entity =>
        {
            entity.HasOne(d => d.Employee).WithMany(p => p.WorkOffPermission)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOffPermission_Employee");
        });

        modelBuilder.Entity<WorkShift>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_WorkShift_IsActive");
        });

        modelBuilder.Entity<WorkStation>(entity =>
        {
            entity.HasOne(d => d.GCWorkCenterNavigation).WithMany(p => p.WorkStation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkStation_sysGeneralCode");

            entity.HasOne(d => d.Paramedic).WithMany(p => p.WorkStation).HasConstraintName("FK_WorkStation_Paramedic");

            entity.HasOne(d => d.Room).WithMany(p => p.WorkStation).HasConstraintName("FK_WorkStation_ServiceRoom");

            entity.HasOne(d => d.SiteCodeNavigation).WithMany(p => p.WorkStation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkStation_Site");
        });

        modelBuilder.Entity<ZipCodes>(entity =>
        {
            entity.Property(e => e.City).HasDefaultValue("", "DF_ZipCodes_City");
            entity.Property(e => e.County).HasDefaultValue("", "DF_ZipCodes_County");
            entity.Property(e => e.District).HasDefaultValue("", "DF_ZipCodes_District");
            entity.Property(e => e.GCProvince).HasDefaultValue("", "DF_ZipCodes_GCProvince");
            entity.Property(e => e.Line1).HasDefaultValue("", "DF_ZipCodes_Line1");
            entity.Property(e => e.Line2).HasDefaultValue("", "DF_ZipCodes_Line2");

            entity.HasOne(d => d.GCProvinceNavigation).WithMany(p => p.ZipCodes).HasConstraintName("FK_ZipCodes_sysGeneralCode_Province");
        });

        modelBuilder.Entity<_LoadTestRegistration>(entity =>
        {
            entity.Property(e => e.RecordID).ValueGeneratedNever();
        });

        modelBuilder.Entity<_imp_mims_ATCClass>(entity =>
        {
            entity.HasKey(e => e.ATCClassCode).HasName("PK_imp_mims_ATCClass");
        });

        modelBuilder.Entity<_imp_mims_DrugInteraction>(entity =>
        {
            entity.HasKey(e => e.DrugInteractionID).HasName("PK_imp_mims_DrugInteraction");

            entity.Property(e => e.DrugInteractionID).ValueGeneratedNever();
        });

        modelBuilder.Entity<_imp_mims_Item>(entity =>
        {
            entity.HasKey(e => e.ItemID)
                .HasName("PK_imp_mims_Item")
                .HasFillFactor(90);

            entity.Property(e => e.ItemID).ValueGeneratedNever();
            entity.Property(e => e.ABCClass).IsFixedLength();
        });

        modelBuilder.Entity<_imp_mims_ItemBrand>(entity =>
        {
            entity.HasKey(e => e.BrandCode).HasName("PK_imp_mims_ItemBrand");
        });

        modelBuilder.Entity<_imp_mims_ItemBrandGeneric>(entity =>
        {
            entity.HasKey(e => new { e.BrandCode, e.GenericID }).HasName("PK_imp_mims_ItemBrandGeneric");
        });

        modelBuilder.Entity<_imp_mims_ItemDrug>(entity =>
        {
            entity.HasKey(e => e.ItemID).HasName("PK_imp_mims_ItemDrug");

            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<_imp_mims_ItemGeneric>(entity =>
        {
            entity.HasKey(e => e.GenericID).HasName("PK_imp_mims_ItemGeneric");

            entity.Property(e => e.GenericID).ValueGeneratedNever();
        });

        modelBuilder.Entity<_imp_mims_ItemUnitConversion>(entity =>
        {
            entity.HasKey(e => new { e.ItemID, e.AlternateItemUnit })
                .HasName("PK_imp_mims_ItemUnitConversion")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<_mims_DrugInteraction>(entity =>
        {
            entity.HasKey(e => e.DrugInteractionID).HasName("PK__mims_DrugInteraction_1");

            entity.Property(e => e.ActionsToBeTaken).HasDefaultValue("", "DF__mims_DrugInteraction_ActionsToBeTaken");
            entity.Property(e => e.AdverseEffect).HasDefaultValue("", "DF__mims_DrugInteraction_AdverseEffect");
            entity.Property(e => e.ProbableMechanism).HasDefaultValue("", "DF__mims_DrugInteraction_ProbableMechanism");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF__mims_DrugInteraction_Remarks");
        });

        modelBuilder.Entity<_mims_ItemBrand>(entity =>
        {
            entity.Property(e => e.ReferenceID).ValueGeneratedNever();
        });

        modelBuilder.Entity<_mims_ItemDrug>(entity =>
        {
            entity.HasKey(e => e.ReferenceID).HasName("PK__mims_ItemDrug_1");

            entity.Property(e => e.ReferenceID).ValueGeneratedNever();
            entity.Property(e => e.Dosage).HasDefaultValue(0m, "DF__mims_ItemDrug_Dosage");
            entity.Property(e => e.IsFormulariumItem).HasDefaultValue(false, "DF__mims_ItemDrug_IsFormulariumItem");
            entity.Property(e => e.IsGenericDrug).HasDefaultValue(false, "DF__mims_ItemDrug_IsGenericDrug");
        });

        modelBuilder.Entity<_mims_ItemGeneric>(entity =>
        {
            entity.Property(e => e.ReferenceID).ValueGeneratedNever();
        });

        modelBuilder.Entity<_mims_Product>(entity =>
        {
            entity.Property(e => e.ProductID).ValueGeneratedNever();
        });

        modelBuilder.Entity<_tmp_ImportDiagnosis>(entity =>
        {
            entity.HasKey(e => e.DiagnosisCode).HasName("PK_tmp_ImportDiagnosis");
        });

        modelBuilder.Entity<bu_RLTemplateDt_20230710>(entity =>
        {
            entity.Property(e => e.RowId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<sysAuditLog>(entity =>
        {
            entity.HasKey(e => e.AuditLogID).HasName("PK_AuditLog");

            entity.Property(e => e.ActionType).IsFixedLength();
        });

        modelBuilder.Entity<sysCHDRiskChart>(entity =>
        {
            entity.HasKey(e => new { e.GCSex, e.Age }).HasName("PK_CHDRiskChart");

            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.sysCHDRiskChart)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHDRiskChart_sysGeneralCode_GCSex");
        });

        modelBuilder.Entity<sysGeneralCode>(entity =>
        {
            entity.Property(e => e.GeneralCodeName2).HasDefaultValue("", "DF_sysGeneralCode_GeneralCodeName2");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysGeneralCode_IsActive");
            entity.Property(e => e.IsUsedBySystem).HasDefaultValue(true, "DF_sysGeneralCode_IsUsedBySystem");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_sysGeneralCode_Remarks");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_sysGeneralCode_sysGeneralCode");
        });

        modelBuilder.Entity<sysGrowthChartPoint>(entity =>
        {
            entity.HasOne(d => d.GCSexNavigation).WithMany(p => p.sysGrowthChartPoint)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysGrowthChartPoint_sysGeneralCode");
        });

        modelBuilder.Entity<sysParamedicNameFormat>(entity =>
        {
            entity.Property(e => e.NameID).ValueGeneratedNever();
        });

        modelBuilder.Entity<sysParameter>(entity =>
        {
            entity.Property(e => e.ParameterValue).HasDefaultValue("", "DF_sysParameter_ParameterValue");
        });

        modelBuilder.Entity<sysParameterPerSite>(entity =>
        {
            entity.Property(e => e.ParameterValue).HasDefaultValue("", "DF_sysParameterPerSite_ParameterValue");
        });

        modelBuilder.Entity<sysPatientNameFormat>(entity =>
        {
            entity.Property(e => e.NameID).ValueGeneratedNever();
        });

        modelBuilder.Entity<sysRecordEdited>(entity =>
        {
            entity.HasKey(e => new { e.TableName, e.PrimaryKeyData }).HasName("PK_RecordEdited");

            entity.ToTable(tb => tb.HasTrigger("trg_SysRecordEdited_Deleted"));

            entity.Property(e => e.ProcessType).IsFixedLength();
        });

        modelBuilder.Entity<sysRecordEditedLog>(entity =>
        {
            entity.Property(e => e.ProcessType).IsFixedLength();
        });

        modelBuilder.Entity<sysTable>(entity =>
        {
            entity.Property(e => e.TableID).ValueGeneratedNever();
        });

        modelBuilder.Entity<sysTagField>(entity =>
        {
            entity.Property(e => e.TagField1).HasDefaultValue("", "DF_sysTagField_TagField1");
            entity.Property(e => e.TagField10).HasDefaultValue("", "DF_sysTagField_TagField10");
            entity.Property(e => e.TagField11).HasDefaultValue("", "DF_sysTagField_TagField11");
            entity.Property(e => e.TagField12).HasDefaultValue("", "DF_sysTagField_TagField12");
            entity.Property(e => e.TagField13).HasDefaultValue("", "DF_sysTagField_TagField13");
            entity.Property(e => e.TagField14).HasDefaultValue("", "DF_sysTagField_TagField14");
            entity.Property(e => e.TagField15).HasDefaultValue("", "DF_sysTagField_TagField15");
            entity.Property(e => e.TagField16).HasDefaultValue("", "DF_sysTagField_TagField16");
            entity.Property(e => e.TagField17).HasDefaultValue("", "DF_sysTagField_TagField17");
            entity.Property(e => e.TagField18).HasDefaultValue("", "DF_sysTagField_TagField18");
            entity.Property(e => e.TagField19).HasDefaultValue("", "DF_sysTagField_TagField19");
            entity.Property(e => e.TagField2).HasDefaultValue("", "DF_sysTagField_TagField2");
            entity.Property(e => e.TagField20).HasDefaultValue("", "DF_sysTagField_TagField20");
            entity.Property(e => e.TagField3).HasDefaultValue("", "DF_sysTagField_TagField3");
            entity.Property(e => e.TagField4).HasDefaultValue("", "DF_sysTagField_TagField4");
            entity.Property(e => e.TagField5).HasDefaultValue("", "DF_sysTagField_TagField5");
            entity.Property(e => e.TagField6).HasDefaultValue("", "DF_sysTagField_TagField6");
            entity.Property(e => e.TagField7).HasDefaultValue("", "DF_sysTagField_TagField7");
            entity.Property(e => e.TagField8).HasDefaultValue("", "DF_sysTagField_TagField8");
            entity.Property(e => e.TagField9).HasDefaultValue("", "DF_sysTagField_TagField9");

            entity.HasOne(d => d.GCBusinessObjectNavigation).WithOne(p => p.sysTagField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysTagField_sysGeneralCode");
        });

        modelBuilder.Entity<sysTransactionCode>(entity =>
        {
            entity.Property(e => e.Delimeter1).HasDefaultValue("", "DF_sysTransactionCode_Delimeter1");
            entity.Property(e => e.Delimeter2).HasDefaultValue("", "DF_sysTransactionCode_Delimeter2");
            entity.Property(e => e.NumberingMethod).HasDefaultValue("DAILY", "DF_sysTransactionCode_NumberingMethod");
        });

        modelBuilder.Entity<sysUser>(entity =>
        {
            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysUser_IsActive");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_sysUser_IsDeleted");
        });

        modelBuilder.Entity<sysUserAndroid>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysUserAndroid_IsActive");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_sysUserAndroid_IsDelete");
        });

        modelBuilder.Entity<sysUserPIN>(entity =>
        {
            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysUserPIN_IsActive");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_sysUserPIN_IsDeleted");
            entity.Property(e => e.LastUpdatedDateTime).HasDefaultValueSql("(getdate())", "DF_sysUserPIN_LastUpdatedDateTime");

            entity.HasOne(d => d.User).WithOne(p => p.sysUserPIN)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysUserPIN_sysUser");
        });

        modelBuilder.Entity<tempMaterialCost_Hero>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<tempMaterialCost_RecallPwa>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<uvwRegistration>(entity =>
        {
            entity.ToView("uvwRegistration");
        });

        modelBuilder.Entity<vw_AccountReceivable>(entity =>
        {
            entity.ToView("vw_AccountReceivable");
        });

        modelBuilder.Entity<vw_Bed>(entity =>
        {
            entity.ToView("vw_Bed");
        });

        modelBuilder.Entity<vw_BedTransfer>(entity =>
        {
            entity.ToView("vw_BedTransfer");
        });

        modelBuilder.Entity<vw_CycleCounting>(entity =>
        {
            entity.ToView("vw_CycleCounting");

            entity.Property(e => e.ABC_Class).IsFixedLength();
        });

        modelBuilder.Entity<vw_Finance_DebitNoteCreditNote>(entity =>
        {
            entity.ToView("vw_Finance_DebitNoteCreditNote");
        });

        modelBuilder.Entity<vw_Finance_Invoiced>(entity =>
        {
            entity.ToView("vw_Finance_Invoiced");
        });

        modelBuilder.Entity<vw_Finance_Journal>(entity =>
        {
            entity.ToView("vw_Finance_Journal");
        });

        modelBuilder.Entity<vw_Finance_Un_Invoiced>(entity =>
        {
            entity.ToView("vw_Finance_Un_Invoiced");
        });

        modelBuilder.Entity<vw_Finance_WriteOff>(entity =>
        {
            entity.ToView("vw_Finance_WriteOff");
        });

        modelBuilder.Entity<vw_Inventory_PurchaseOrderReceipt>(entity =>
        {
            entity.ToView("vw_Inventory_PurchaseOrderReceipt");
        });

        modelBuilder.Entity<vw_InvoicePayment>(entity =>
        {
            entity.ToView("vw_InvoicePayment");
        });

        modelBuilder.Entity<vw_Item>(entity =>
        {
            entity.ToView("vw_Item");
        });

        modelBuilder.Entity<vw_ItemTransactionHistory>(entity =>
        {
            entity.ToView("vw_ItemTransactionHistory");
        });

        modelBuilder.Entity<vw_MasterAddress>(entity =>
        {
            entity.ToView("vw_MasterAddress");
        });

        modelBuilder.Entity<vw_MasterBed>(entity =>
        {
            entity.ToView("vw_MasterBed");
        });

        modelBuilder.Entity<vw_MasterBusinessPartner>(entity =>
        {
            entity.ToView("vw_MasterBusinessPartner");
        });

        modelBuilder.Entity<vw_MasterClass>(entity =>
        {
            entity.ToView("vw_MasterClass");
        });

        modelBuilder.Entity<vw_MasterCorporate>(entity =>
        {
            entity.ToView("vw_MasterCorporate");
        });

        modelBuilder.Entity<vw_MasterDepartmentServiceUnit>(entity =>
        {
            entity.ToView("vw_MasterDepartmentServiceUnit");
        });

        modelBuilder.Entity<vw_MasterItem>(entity =>
        {
            entity.ToView("vw_MasterItem");
        });

        modelBuilder.Entity<vw_MasterLocation>(entity =>
        {
            entity.ToView("vw_MasterLocation");
        });

        modelBuilder.Entity<vw_MasterParamedic>(entity =>
        {
            entity.ToView("vw_MasterParamedic");
        });

        modelBuilder.Entity<vw_MasterPatient>(entity =>
        {
            entity.ToView("vw_MasterPatient");
        });

        modelBuilder.Entity<vw_MasterRoom>(entity =>
        {
            entity.ToView("vw_MasterRoom");
        });

        modelBuilder.Entity<vw_MasterSite>(entity =>
        {
            entity.ToView("vw_MasterSite");
        });

        modelBuilder.Entity<vw_Master_ChartOfAccount>(entity =>
        {
            entity.ToView("vw_Master_ChartOfAccount");

            entity.Property(e => e.NormalPosition).IsFixedLength();
        });

        modelBuilder.Entity<vw_OtherExamTransaction>(entity =>
        {
            entity.ToView("vw_OtherExamTransaction");
        });

        modelBuilder.Entity<vw_Patient_Deposit>(entity =>
        {
            entity.ToView("vw_Patient_Deposit");
        });

        modelBuilder.Entity<vw_Patient_DiscountPhysician>(entity =>
        {
            entity.ToView("vw_Patient_DiscountPhysician");
        });

        modelBuilder.Entity<vw_Patient_Payment>(entity =>
        {
            entity.ToView("vw_Patient_Payment");
        });

        modelBuilder.Entity<vw_Patient_Registration>(entity =>
        {
            entity.ToView("vw_Patient_Registration");
        });

        modelBuilder.Entity<vw_Patient_TransactionCharges>(entity =>
        {
            entity.ToView("vw_Patient_TransactionCharges");
        });

        modelBuilder.Entity<vw_Patient_TransactionCharges_Hero>(entity =>
        {
            entity.ToView("vw_Patient_TransactionCharges_Hero");
        });

        modelBuilder.Entity<vw_PhysicianItem>(entity =>
        {
            entity.ToView("vw_PhysicianItem");
        });

        modelBuilder.Entity<vw_PurchaseOrder>(entity =>
        {
            entity.ToView("vw_PurchaseOrder");
        });

        modelBuilder.Entity<vw_Registration>(entity =>
        {
            entity.ToView("vw_Registration");
        });

        modelBuilder.Entity<vw_RegistrationInvoice>(entity =>
        {
            entity.ToView("vw_RegistrationInvoice");
        });

        modelBuilder.Entity<vw_RegistrationOutstanding>(entity =>
        {
            entity.ToView("vw_RegistrationOutstanding");
        });

        modelBuilder.Entity<vw_RegistrationReferral>(entity =>
        {
            entity.ToView("vw_RegistrationReferral");
        });

        modelBuilder.Entity<vw_SiencePatientRegistration>(entity =>
        {
            entity.ToView("vw_SiencePatientRegistration");
        });

        modelBuilder.Entity<vw_Transaction>(entity =>
        {
            entity.ToView("vw_Transaction");
        });

        modelBuilder.Entity<vw_TransactionCharges>(entity =>
        {
            entity.ToView("vw_TransactionCharges");
        });

        modelBuilder.Entity<vw_TransactionMCU>(entity =>
        {
            entity.ToView("vw_TransactionMCU");
        });

        modelBuilder.Entity<vw_address>(entity =>
        {
            entity.ToView("vw_address");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
