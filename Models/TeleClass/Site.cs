using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("Initial", Name = "IX_Site", IsUnique = true)]
public partial class Site
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SiteName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CorporateCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSiteGroup { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string LicenseNo { get; set; } = null!;

    public int? Gmt { get; set; }

    public int? LocationID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TaxRegistrantNo { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AccountAccrualReset> AccountAccrualReset { get; set; } = new List<AccountAccrualReset>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AccountPayableAccrual> AccountPayableAccrual { get; set; } = new List<AccountPayableAccrual>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AccountPayableHd> AccountPayableHd { get; set; } = new List<AccountPayableHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AccountPayablePaymentPlanHd> AccountPayablePaymentPlanHd { get; set; } = new List<AccountPayablePaymentPlanHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AccountPeriod> AccountPeriod { get; set; } = new List<AccountPeriod>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AccountReceivableAccrual> AccountReceivableAccrual { get; set; } = new List<AccountReceivableAccrual>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AccountReceivableHd> AccountReceivableHd { get; set; } = new List<AccountReceivableHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AccountReceivablePaymentHd> AccountReceivablePaymentHd { get; set; } = new List<AccountReceivablePaymentHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AccountReceivableWriteOffPlanHd> AccountReceivableWriteOffPlanHd { get; set; } = new List<AccountReceivableWriteOffPlanHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AdministrationNotes> AdministrationNotes { get; set; } = new List<AdministrationNotes>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AllocationCodeDt> AllocationCodeDt { get; set; } = new List<AllocationCodeDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AnalyzeOfCensus> AnalyzeOfCensus { get; set; } = new List<AnalyzeOfCensus>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AnalyzeOfCensusTotalBed> AnalyzeOfCensusTotalBed { get; set; } = new List<AnalyzeOfCensusTotalBed>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<Appointment> Appointment { get; set; } = new List<Appointment>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ApprovalLevel> ApprovalLevel { get; set; } = new List<ApprovalLevel>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AssetAdjustment> AssetAdjustment { get; set; } = new List<AssetAdjustment>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AverageCost> AverageCost { get; set; } = new List<AverageCost>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<AverageCostBySystem> AverageCostBySystem { get; set; } = new List<AverageCostBySystem>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<Bank> Bank { get; set; } = new List<Bank>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<Bed> Bed { get; set; } = new List<Bed>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<BedCleaning> BedCleaning { get; set; } = new List<BedCleaning>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<BedReservation> BedReservation { get; set; } = new List<BedReservation>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<BedTransfer> BedTransfer { get; set; } = new List<BedTransfer>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<BodyPartDt> BodyPartDt { get; set; } = new List<BodyPartDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<BodyPartHd> BodyPartHd { get; set; } = new List<BodyPartHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<BudgetHd> BudgetHd { get; set; } = new List<BudgetHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<CalenderHd> CalenderHd { get; set; } = new List<CalenderHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<CashFlowStatement> CashFlowStatement { get; set; } = new List<CashFlowStatement>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<CashFlowStatementDt> CashFlowStatementDt { get; set; } = new List<CashFlowStatementDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<CensusHistory> CensusHistory { get; set; } = new List<CensusHistory>();

    [ForeignKey("CorporateCode")]
    [InverseProperty("Site")]
    public virtual Corporate CorporateCodeNavigation { get; set; } = null!;

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<CreditNote> CreditNote { get; set; } = new List<CreditNote>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<CustomerContract> CustomerContract { get; set; } = new List<CustomerContract>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<DebitNoteCreditNoteHd> DebitNoteCreditNoteHd { get; set; } = new List<DebitNoteCreditNoteHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<DepositPaymentHd> DepositPaymentHd { get; set; } = new List<DepositPaymentHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<DirectPurchaseHd> DirectPurchaseHd { get; set; } = new List<DirectPurchaseHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<DiscountPhysician> DiscountPhysician { get; set; } = new List<DiscountPhysician>();

    [InverseProperty("FromSiteCodeNavigation")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHdFromSiteCodeNavigation { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("ToSiteCodeNavigation")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHdToSiteCodeNavigation { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("FromSiteCodeNavigation")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlannedFromSiteCodeNavigation { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("ToSiteCodeNavigation")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlannedToSiteCodeNavigation { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<DownPaymentHd> DownPaymentHd { get; set; } = new List<DownPaymentHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<DrugDispensingHd> DrugDispensingHd { get; set; } = new List<DrugDispensingHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<DrugReturnHd> DrugReturnHd { get; set; } = new List<DrugReturnHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<EmployeeLoanHd> EmployeeLoanHd { get; set; } = new List<EmployeeLoanHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<EmployeeLoanProcessHd> EmployeeLoanProcessHd { get; set; } = new List<EmployeeLoanProcessHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<EmployeeMedicalAdjustmentHd> EmployeeMedicalAdjustmentHd { get; set; } = new List<EmployeeMedicalAdjustmentHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<EmployeeRewardHd> EmployeeRewardHd { get; set; } = new List<EmployeeRewardHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<EmployeeTerminate> EmployeeTerminate { get; set; } = new List<EmployeeTerminate>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistory { get; set; } = new List<EmployeeWorkingHistory>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<Engineering> Engineering { get; set; } = new List<Engineering>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<EpisodeDiagnosis> EpisodeDiagnosis { get; set; } = new List<EpisodeDiagnosis>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<EpisodeProcedure> EpisodeProcedure { get; set; } = new List<EpisodeProcedure>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<FetalMeasurement> FetalMeasurement { get; set; } = new List<FetalMeasurement>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<FetalMeasurementHd> FetalMeasurementHd { get; set; } = new List<FetalMeasurementHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ForecastHd> ForecastHd { get; set; } = new List<ForecastHd>();

    [ForeignKey("GCSiteGroup")]
    [InverseProperty("Site")]
    public virtual sysGeneralCode? GCSiteGroupNavigation { get; set; }

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<HL7Message> HL7Message { get; set; } = new List<HL7Message>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<IPAddressQueue> IPAddressQueue { get; set; } = new List<IPAddressQueue>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<IcuIndicatorHd> IcuIndicatorHd { get; set; } = new List<IcuIndicatorHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ImportMCUCorporate> ImportMCUCorporate { get; set; } = new List<ImportMCUCorporate>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<IntakeOutputDt> IntakeOutputDt { get; set; } = new List<IntakeOutputDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<IntakeOutputHd> IntakeOutputHd { get; set; } = new List<IntakeOutputHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<InterimBill> InterimBill { get; set; } = new List<InterimBill>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<InventoryAmountHistory> InventoryAmountHistory { get; set; } = new List<InventoryAmountHistory>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<InventoryRevaluationHd> InventoryRevaluationHd { get; set; } = new List<InventoryRevaluationHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<IpAddressMonitoring> IpAddressMonitoring { get; set; } = new List<IpAddressMonitoring>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHd { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemCost> ItemCost { get; set; } = new List<ItemCost>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemInventory> ItemInventory { get; set; } = new List<ItemInventory>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemPlanningDO> ItemPlanningDO { get; set; } = new List<ItemPlanningDO>();

    [InverseProperty("PoSiteCodeNavigation")]
    public virtual ICollection<ItemPlanning> ItemPlanningPoSiteCodeNavigation { get; set; } = new List<ItemPlanning>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemPlanning> ItemPlanningSiteCodeNavigation { get; set; } = new List<ItemPlanning>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemPurchasePrice> ItemPurchasePrice { get; set; } = new List<ItemPurchasePrice>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemServiceMCURealizationHd> ItemServiceMCURealizationHd { get; set; } = new List<ItemServiceMCURealizationHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemTariffCorporate> ItemTariffCorporate { get; set; } = new List<ItemTariffCorporate>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemTariffMCU> ItemTariffMCU { get; set; } = new List<ItemTariffMCU>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemTariffStandard> ItemTariffStandard { get; set; } = new List<ItemTariffStandard>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemTax> ItemTax { get; set; } = new List<ItemTax>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemTransactionHistoryDt> ItemTransactionHistoryDt { get; set; } = new List<ItemTransactionHistoryDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemTransactionHistoryHd> ItemTransactionHistoryHd { get; set; } = new List<ItemTransactionHistoryHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ItemTransactionMcuHd> ItemTransactionMcuHd { get; set; } = new List<ItemTransactionMcuHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<JobOrderHd> JobOrderHd { get; set; } = new List<JobOrderHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<JournalCashBankDt> JournalCashBankDt { get; set; } = new List<JournalCashBankDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<JournalCashBankHd> JournalCashBankHd { get; set; } = new List<JournalCashBankHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<JournalDt> JournalDt { get; set; } = new List<JournalDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<JournalHd> JournalHd { get; set; } = new List<JournalHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<LeaveAdjustmentHd> LeaveAdjustmentHd { get; set; } = new List<LeaveAdjustmentHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<LeaveRequest> LeaveRequest { get; set; } = new List<LeaveRequest>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<Location> Location { get; set; } = new List<Location>();

    [ForeignKey("LocationID")]
    [InverseProperty("Site")]
    public virtual Location? LocationNavigation { get; set; }

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<METargetHd> METargetHd { get; set; } = new List<METargetHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<MRPHistoryHd> MRPHistoryHd { get; set; } = new List<MRPHistoryHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<MassLeaveHd> MassLeaveHd { get; set; } = new List<MassLeaveHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<MaterialRequestCompletionHd> MaterialRequestCompletionHd { get; set; } = new List<MaterialRequestCompletionHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<MaterialRequestHd> MaterialRequestHd { get; set; } = new List<MaterialRequestHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<NursingCareplan> NursingCareplan { get; set; } = new List<NursingCareplan>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<OdontogramMCU> OdontogramMCU { get; set; } = new List<OdontogramMCU>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<OrderMenuDiitHd> OrderMenuDiitHd { get; set; } = new List<OrderMenuDiitHd>();

    [InverseProperty("FromSiteCodeNavigation")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHdFromSiteCodeNavigation { get; set; } = new List<OutstandingDOHd>();

    [InverseProperty("ToSiteCodeNavigation")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHdToSiteCodeNavigation { get; set; } = new List<OutstandingDOHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<OvertimeWorkOrder> OvertimeWorkOrder { get; set; } = new List<OvertimeWorkOrder>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PPITargetHd> PPITargetHd { get; set; } = new List<PPITargetHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PackageTreatmentHd> PackageTreatmentHd { get; set; } = new List<PackageTreatmentHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<Paramedic> Paramedic { get; set; } = new List<Paramedic>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ParamedicItemMcu> ParamedicItemMcu { get; set; } = new List<ParamedicItemMcu>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<Patient> Patient { get; set; } = new List<Patient>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientAPGAR> PatientAPGAR { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientAttendance> PatientAttendance { get; set; } = new List<PatientAttendance>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientBPU> PatientBPU { get; set; } = new List<PatientBPU>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecord { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientCAPPIRO> PatientCAPPIRO { get; set; } = new List<PatientCAPPIRO>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRisk { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientDocument> PatientDocument { get; set; } = new List<PatientDocument>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientFCS> PatientFCS { get; set; } = new List<PatientFCS>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientGCS> PatientGCS { get; set; } = new List<PatientGCS>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientGCSPediatric> PatientGCSPediatric { get; set; } = new List<PatientGCSPediatric>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientNotes> PatientNotes { get; set; } = new List<PatientNotes>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientOdontogram> PatientOdontogram { get; set; } = new List<PatientOdontogram>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientOdontogramNew> PatientOdontogramNew { get; set; } = new List<PatientOdontogramNew>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientOralMucosa> PatientOralMucosa { get; set; } = new List<PatientOralMucosa>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientQuestionaireDt> PatientQuestionaireDt { get; set; } = new List<PatientQuestionaireDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientQuestionaireHd> PatientQuestionaireHd { get; set; } = new List<PatientQuestionaireHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PatientVision> PatientVision { get; set; } = new List<PatientVision>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PaymentReceiptHd> PaymentReceiptHd { get; set; } = new List<PaymentReceiptHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PaymentRefund> PaymentRefund { get; set; } = new List<PaymentRefund>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PaymentRefundMedication> PaymentRefundMedication { get; set; } = new List<PaymentRefundMedication>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PayrollPaymentPlanHd> PayrollPaymentPlanHd { get; set; } = new List<PayrollPaymentPlanHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PayrollProcessHd> PayrollProcessHd { get; set; } = new List<PayrollProcessHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PediatricChart> PediatricChart { get; set; } = new List<PediatricChart>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PhysicianFeePaymentPlanHd> PhysicianFeePaymentPlanHd { get; set; } = new List<PhysicianFeePaymentPlanHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PhysicianFeeVerification> PhysicianFeeVerification { get; set; } = new List<PhysicianFeeVerification>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PrintedArchive> PrintedArchive { get; set; } = new List<PrintedArchive>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PrintedArchiveMCUCorporate> PrintedArchiveMCUCorporate { get; set; } = new List<PrintedArchiveMCUCorporate>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ProductionHd> ProductionHd { get; set; } = new List<ProductionHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ProformaInvoice> ProformaInvoice { get; set; } = new List<ProformaInvoice>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ProjectMCUCorporate> ProjectMCUCorporate { get; set; } = new List<ProjectMCUCorporate>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PurchaseOrderHd> PurchaseOrderHd { get; set; } = new List<PurchaseOrderHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PurchaseOrderPlanned> PurchaseOrderPlanned { get; set; } = new List<PurchaseOrderPlanned>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<PurchaseOrderReceiptHd> PurchaseOrderReceiptHd { get; set; } = new List<PurchaseOrderReceiptHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1BayiTabung> RL1BayiTabung { get; set; } = new List<RL1BayiTabung>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1CaraPembayaran> RL1CaraPembayaran { get; set; } = new List<RL1CaraPembayaran>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KebidananPerinatologi> RL1KebidananPerinatologi { get; set; } = new List<RL1KebidananPerinatologi>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KegiatanFarmasi> RL1KegiatanFarmasi { get; set; } = new List<RL1KegiatanFarmasi>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KegiatanPelayananKhusus> RL1KegiatanPelayananKhusus { get; set; } = new List<RL1KegiatanPelayananKhusus>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KegiatanRadiologi> RL1KegiatanRadiologi { get; set; } = new List<RL1KegiatanRadiologi>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KegiatanRujukan> RL1KegiatanRujukan { get; set; } = new List<RL1KegiatanRujukan>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KeluargaBerencana> RL1KeluargaBerencana { get; set; } = new List<RL1KeluargaBerencana>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KesehatanGigiMulut> RL1KesehatanGigiMulut { get; set; } = new List<RL1KesehatanGigiMulut>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KesehatanJiwa> RL1KesehatanJiwa { get; set; } = new List<RL1KesehatanJiwa>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KunjunganRJ> RL1KunjunganRJ { get; set; } = new List<RL1KunjunganRJ>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1KunjunganRumah> RL1KunjunganRumah { get; set; } = new List<RL1KunjunganRumah>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1PelayananRI> RL1PelayananRI { get; set; } = new List<RL1PelayananRI>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1PemantauanDokter> RL1PemantauanDokter { get; set; } = new List<RL1PemantauanDokter>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1Pembedahan> RL1Pembedahan { get; set; } = new List<RL1Pembedahan>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1PembedahanMata> RL1PembedahanMata { get; set; } = new List<RL1PembedahanMata>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1PemeriksaanLaboratorium> RL1PemeriksaanLaboratorium { get; set; } = new List<RL1PemeriksaanLaboratorium>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1Pengunjung> RL1Pengunjung { get; set; } = new List<RL1Pengunjung>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1PenyalahgunaanNAPZA> RL1PenyalahgunaanNAPZA { get; set; } = new List<RL1PenyalahgunaanNAPZA>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1PenyuluhanKesehatan> RL1PenyuluhanKesehatan { get; set; } = new List<RL1PenyuluhanKesehatan>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1RehabilitasiMedik> RL1RehabilitasiMedik { get; set; } = new List<RL1RehabilitasiMedik>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1Training> RL1Training { get; set; } = new List<RL1Training>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL1TranfusiDarah> RL1TranfusiDarah { get; set; } = new List<RL1TranfusiDarah>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL2Imunisasi> RL2Imunisasi { get; set; } = new List<RL2Imunisasi>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL2Morbiditas> RL2Morbiditas { get; set; } = new List<RL2Morbiditas>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL3DataDasarRumahSakit> RL3DataDasarRumahSakit { get; set; } = new List<RL3DataDasarRumahSakit>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL4DataKetenagaan> RL4DataKetenagaan { get; set; } = new List<RL4DataKetenagaan>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL5DataKesehatan> RL5DataKesehatan { get; set; } = new List<RL5DataKesehatan>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL5DataPeralatanMedik> RL5DataPeralatanMedik { get; set; } = new List<RL5DataPeralatanMedik>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RL6InfeksiNosokomial> RL6InfeksiNosokomial { get; set; } = new List<RL6InfeksiNosokomial>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RecalculationHd> RecalculationHd { get; set; } = new List<RecalculationHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHd { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ReconciliationHd> ReconciliationHd { get; set; } = new List<ReconciliationHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RecuringSubDt> RecuringSubDt { get; set; } = new List<RecuringSubDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<Referral> Referral { get; set; } = new List<Referral>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ReferralPatient> ReferralPatient { get; set; } = new List<ReferralPatient>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ReplacementHd> ReplacementHd { get; set; } = new List<ReplacementHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RequestForProposalHd> RequestForProposalHd { get; set; } = new List<RequestForProposalHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ReturnToSupplierHd> ReturnToSupplierHd { get; set; } = new List<ReturnToSupplierHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<RiskFallHd> RiskFallHd { get; set; } = new List<RiskFallHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<SalaryAdjustment> SalaryAdjustment { get; set; } = new List<SalaryAdjustment>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<SatuSehatRegistration> SatuSehatRegistration { get; set; } = new List<SatuSehatRegistration>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<SendToAutopackHistoryHd> SendToAutopackHistoryHd { get; set; } = new List<SendToAutopackHistoryHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ServiceOrderHd> ServiceOrderHd { get; set; } = new List<ServiceOrderHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ServiceOrderRequestHd> ServiceOrderRequestHd { get; set; } = new List<ServiceOrderRequestHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ServiceUnitItemMcu> ServiceUnitItemMcu { get; set; } = new List<ServiceUnitItemMcu>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<ServiceUnitJobOrderType> ServiceUnitJobOrderType { get; set; } = new List<ServiceUnitJobOrderType>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<SiteDepartment> SiteDepartment { get; set; } = new List<SiteDepartment>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<SpectaclePrescription> SpectaclePrescription { get; set; } = new List<SpectaclePrescription>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<StockAdjustmentHd> StockAdjustmentHd { get; set; } = new List<StockAdjustmentHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<StockTakingHd> StockTakingHd { get; set; } = new List<StockTakingHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<SupplierItemPrice> SupplierItemPrice { get; set; } = new List<SupplierItemPrice>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<SurgeryReservation> SurgeryReservation { get; set; } = new List<SurgeryReservation>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<TimeAttendanceRecapHd> TimeAttendanceRecapHd { get; set; } = new List<TimeAttendanceRecapHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<TransactionChargesHd> TransactionChargesHd { get; set; } = new List<TransactionChargesHd>();

    [InverseProperty("FromSiteCodeNavigation")]
    public virtual ICollection<TransferOrderHd> TransferOrderHdFromSiteCodeNavigation { get; set; } = new List<TransferOrderHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<TransferOrderHd> TransferOrderHdSiteCodeNavigation { get; set; } = new List<TransferOrderHd>();

    [InverseProperty("ToSiteCodeNavigation")]
    public virtual ICollection<TransferOrderHd> TransferOrderHdToSiteCodeNavigation { get; set; } = new List<TransferOrderHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<VaccinationShotDt> VaccinationShotDt { get; set; } = new List<VaccinationShotDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<VaccinationShotHd> VaccinationShotHd { get; set; } = new List<VaccinationShotHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<VaccinationShotSubDt> VaccinationShotSubDt { get; set; } = new List<VaccinationShotSubDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<VitalSignDt> VitalSignDt { get; set; } = new List<VitalSignDt>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<VitalSignHd> VitalSignHd { get; set; } = new List<VitalSignHd>();

    [InverseProperty("SiteCodeNavigation")]
    public virtual ICollection<WorkStation> WorkStation { get; set; } = new List<WorkStation>();
}
