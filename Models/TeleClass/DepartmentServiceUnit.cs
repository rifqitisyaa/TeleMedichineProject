using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DepartmentServiceUnit
{
    [Key]
    public int ServiceUnitID { get; set; }

    public int SiteDepartmentID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ContactPerson1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ContactPerson2 { get; set; } = null!;

    public int? LocationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GcDefaultOrderType { get; set; }

    public bool? IsLockedLocation { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public int? DefaultPORLocationID { get; set; }

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<AccountAccrualReset> AccountAccrualReset { get; set; } = new List<AccountAccrualReset>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<AccountPeriod> AccountPeriod { get; set; } = new List<AccountPeriod>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<AllocationCodeDt> AllocationCodeDt { get; set; } = new List<AllocationCodeDt>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<AnalyzeOfCensus> AnalyzeOfCensus { get; set; } = new List<AnalyzeOfCensus>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<AnalyzeOfCensusTotalBed> AnalyzeOfCensusTotalBed { get; set; } = new List<AnalyzeOfCensusTotalBed>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<Assets> Assets { get; set; } = new List<Assets>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<AutomationChargesItem> AutomationChargesItem { get; set; } = new List<AutomationChargesItem>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<Bed> Bed { get; set; } = new List<Bed>();

    [InverseProperty("FromServiceUnit")]
    public virtual ICollection<BedTransfer> BedTransferFromServiceUnit { get; set; } = new List<BedTransfer>();

    [InverseProperty("ToServiceUnit")]
    public virtual ICollection<BedTransfer> BedTransferToServiceUnit { get; set; } = new List<BedTransfer>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<BudgetHd> BudgetHd { get; set; } = new List<BudgetHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<CancelPatientVisit> CancelPatientVisit { get; set; } = new List<CancelPatientVisit>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<CensusHistory> CensusHistory { get; set; } = new List<CensusHistory>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<DepartmentServiceUnitParameterDt> DepartmentServiceUnitParameterDt { get; set; } = new List<DepartmentServiceUnitParameterDt>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<DepositPaymentHd> DepositPaymentHd { get; set; } = new List<DepositPaymentHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<DirectPurchaseHd> DirectPurchaseHd { get; set; } = new List<DirectPurchaseHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<DiscountPhysician> DiscountPhysician { get; set; } = new List<DiscountPhysician>();

    [InverseProperty("FromServiceUnit")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHdFromServiceUnit { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("ToServiceUnit")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHdToServiceUnit { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("FromServiceUnit")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlannedFromServiceUnit { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("ToServiceUnit")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlannedToServiceUnit { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<DrugDispensingHd> DrugDispensingHd { get; set; } = new List<DrugDispensingHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<DrugReturnHd> DrugReturnHd { get; set; } = new List<DrugReturnHd>();

    [InverseProperty("CostServiceUnit")]
    public virtual ICollection<Employee> Employee { get; set; } = new List<Employee>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ForecastHd> ForecastHd { get; set; } = new List<ForecastHd>();

    [ForeignKey("GcDefaultOrderType")]
    [InverseProperty("DepartmentServiceUnit")]
    public virtual sysGeneralCode? GcDefaultOrderTypeNavigation { get; set; }

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<IPAddressQueue> IPAddressQueue { get; set; } = new List<IPAddressQueue>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<InventoryAmountHistory> InventoryAmountHistory { get; set; } = new List<InventoryAmountHistory>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<InventoryRevaluationHd> InventoryRevaluationHd { get; set; } = new List<InventoryRevaluationHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<IpAddressIcu> IpAddressIcu { get; set; } = new List<IpAddressIcu>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHd { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ItemServiceMCURealizationHd> ItemServiceMCURealizationHd { get; set; } = new List<ItemServiceMCURealizationHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ItemTransactionHistoryDt> ItemTransactionHistoryDt { get; set; } = new List<ItemTransactionHistoryDt>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ItemTransactionHistoryHd> ItemTransactionHistoryHd { get; set; } = new List<ItemTransactionHistoryHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ItemTransactionMcuDt> ItemTransactionMcuDt { get; set; } = new List<ItemTransactionMcuDt>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<JobOrderHd> JobOrderHd { get; set; } = new List<JobOrderHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<JournalCashBankDt> JournalCashBankDt { get; set; } = new List<JournalCashBankDt>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<JournalCashBankHd> JournalCashBankHd { get; set; } = new List<JournalCashBankHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<JournalDt> JournalDt { get; set; } = new List<JournalDt>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<JournalHd> JournalHd { get; set; } = new List<JournalHd>();

    [ForeignKey("LocationID")]
    [InverseProperty("DepartmentServiceUnit")]
    public virtual Location? Location { get; set; }

    [InverseProperty("FromServiceUnit")]
    public virtual ICollection<MaterialRequestCompletionHd> MaterialRequestCompletionHdFromServiceUnit { get; set; } = new List<MaterialRequestCompletionHd>();

    [InverseProperty("ToServiceUnit")]
    public virtual ICollection<MaterialRequestCompletionHd> MaterialRequestCompletionHdToServiceUnit { get; set; } = new List<MaterialRequestCompletionHd>();

    [InverseProperty("FromServiceUnit")]
    public virtual ICollection<MaterialRequestHd> MaterialRequestHdFromServiceUnit { get; set; } = new List<MaterialRequestHd>();

    [InverseProperty("ToServiceUnit")]
    public virtual ICollection<MaterialRequestHd> MaterialRequestHdToServiceUnit { get; set; } = new List<MaterialRequestHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<NurseShiftTransferHistoryHd> NurseShiftTransferHistoryHd { get; set; } = new List<NurseShiftTransferHistoryHd>();

    [InverseProperty("FromServiceUnit")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHdFromServiceUnit { get; set; } = new List<OutstandingDOHd>();

    [InverseProperty("ToServiceUnit")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHdToServiceUnit { get; set; } = new List<OutstandingDOHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ParamedicVisitType> ParamedicVisitType { get; set; } = new List<ParamedicVisitType>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<PatientAttendance> PatientAttendance { get; set; } = new List<PatientAttendance>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<PhysicianBilling> PhysicianBilling { get; set; } = new List<PhysicianBilling>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<PrescriptionPayment> PrescriptionPayment { get; set; } = new List<PrescriptionPayment>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ProductionHd> ProductionHd { get; set; } = new List<ProductionHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<PurchaseOrderHd> PurchaseOrderHd { get; set; } = new List<PurchaseOrderHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<Queuing> Queuing { get; set; } = new List<Queuing>();

    [InverseProperty("ServiceUnitIdAfterNavigation")]
    public virtual ICollection<RecalculationDtBom> RecalculationDtBomServiceUnitIdAfterNavigation { get; set; } = new List<RecalculationDtBom>();

    [InverseProperty("ServiceUnitIdBeforeNavigation")]
    public virtual ICollection<RecalculationDtBom> RecalculationDtBomServiceUnitIdBeforeNavigation { get; set; } = new List<RecalculationDtBom>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHd { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<RecuringSubDt> RecuringSubDt { get; set; } = new List<RecuringSubDt>();

    [InverseProperty("OriginalServiceUnit")]
    public virtual ICollection<Registration> RegistrationOriginalServiceUnit { get; set; } = new List<Registration>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<Registration> RegistrationServiceUnit { get; set; } = new List<Registration>();

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("DepartmentServiceUnit")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ServiceUnitItem> ServiceUnitItem { get; set; } = new List<ServiceUnitItem>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ServiceUnitItemMcu> ServiceUnitItemMcu { get; set; } = new List<ServiceUnitItemMcu>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ServiceUnitJobOrderType> ServiceUnitJobOrderType { get; set; } = new List<ServiceUnitJobOrderType>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ServiceUnitLocation> ServiceUnitLocation { get; set; } = new List<ServiceUnitLocation>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ServiceUnitParamedic> ServiceUnitParamedic { get; set; } = new List<ServiceUnitParamedic>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ServiceUnitPrinter> ServiceUnitPrinter { get; set; } = new List<ServiceUnitPrinter>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<ServiceUnitRoom> ServiceUnitRoom { get; set; } = new List<ServiceUnitRoom>();

    [ForeignKey("SiteDepartmentID")]
    [InverseProperty("DepartmentServiceUnit")]
    public virtual SiteDepartment SiteDepartment { get; set; } = null!;

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<StockAdjustmentHd> StockAdjustmentHd { get; set; } = new List<StockAdjustmentHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<StockTakingHd> StockTakingHd { get; set; } = new List<StockTakingHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<TransactionChargesDtBOM> TransactionChargesDtBOM { get; set; } = new List<TransactionChargesDtBOM>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<TransactionChargesHd> TransactionChargesHd { get; set; } = new List<TransactionChargesHd>();

    [InverseProperty("ServiceUnit")]
    public virtual ICollection<TransactionNonCPOEServiceUnit> TransactionNonCPOEServiceUnit { get; set; } = new List<TransactionNonCPOEServiceUnit>();

    [InverseProperty("FromServiceUnit")]
    public virtual ICollection<TransferOrderHd> TransferOrderHdFromServiceUnit { get; set; } = new List<TransferOrderHd>();

    [InverseProperty("ToServiceUnit")]
    public virtual ICollection<TransferOrderHd> TransferOrderHdToServiceUnit { get; set; } = new List<TransferOrderHd>();
}
