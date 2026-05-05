using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class sysTransactionCode
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TransactionName { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string TransactionInitial { get; set; } = null!;

    public bool IsInventoryTransaction { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string FieldName1 { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string FieldName2 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NumberingMethod { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Delimeter1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Delimeter2 { get; set; } = null!;

    public bool IsNumberingByDepartment { get; set; }

    public bool IsNumberingByServiceUnit { get; set; }

    public bool IsNeedApproval { get; set; }

    public bool? IsCreateJournal { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<AccountPayableAccrual> AccountPayableAccrual { get; set; } = new List<AccountPayableAccrual>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<AccountPayableHd> AccountPayableHd { get; set; } = new List<AccountPayableHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<AccountPayablePaymentPlanHd> AccountPayablePaymentPlanHd { get; set; } = new List<AccountPayablePaymentPlanHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<AccountReceivableAccrual> AccountReceivableAccrual { get; set; } = new List<AccountReceivableAccrual>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<AccountReceivableDtReverse> AccountReceivableDtReverse { get; set; } = new List<AccountReceivableDtReverse>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<AccountReceivableHd> AccountReceivableHd { get; set; } = new List<AccountReceivableHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<AccountReceivablePaymentHd> AccountReceivablePaymentHd { get; set; } = new List<AccountReceivablePaymentHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<AccountReceivableWriteOffPlanHd> AccountReceivableWriteOffPlanHd { get; set; } = new List<AccountReceivableWriteOffPlanHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<Appointment> Appointment { get; set; } = new List<Appointment>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ApprovalLevel> ApprovalLevel { get; set; } = new List<ApprovalLevel>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<AssetAdjustment> AssetAdjustment { get; set; } = new List<AssetAdjustment>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<BedCleaning> BedCleaning { get; set; } = new List<BedCleaning>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<BedReservation> BedReservation { get; set; } = new List<BedReservation>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<BedTransfer> BedTransfer { get; set; } = new List<BedTransfer>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<BudgetHd> BudgetHd { get; set; } = new List<BudgetHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<CreditNote> CreditNote { get; set; } = new List<CreditNote>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<CustomerContract> CustomerContract { get; set; } = new List<CustomerContract>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DebitNoteCreditNoteHd> DebitNoteCreditNoteHd { get; set; } = new List<DebitNoteCreditNoteHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DebitNoteCreditNoteHdReverse> DebitNoteCreditNoteHdReverse { get; set; } = new List<DebitNoteCreditNoteHdReverse>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DepositPaymentDtReverse> DepositPaymentDtReverse { get; set; } = new List<DepositPaymentDtReverse>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DepositPaymentHd> DepositPaymentHd { get; set; } = new List<DepositPaymentHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DirectPurchaseHd> DirectPurchaseHd { get; set; } = new List<DirectPurchaseHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DiscountPhysician> DiscountPhysician { get; set; } = new List<DiscountPhysician>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHd { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DownPaymentHd> DownPaymentHd { get; set; } = new List<DownPaymentHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DrugDispensingHd> DrugDispensingHd { get; set; } = new List<DrugDispensingHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<DrugReturnHd> DrugReturnHd { get; set; } = new List<DrugReturnHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<EmployeeLoanHd> EmployeeLoanHd { get; set; } = new List<EmployeeLoanHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<EmployeeLoanProcessHd> EmployeeLoanProcessHd { get; set; } = new List<EmployeeLoanProcessHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<EmployeeMedicalAdjustmentHd> EmployeeMedicalAdjustmentHd { get; set; } = new List<EmployeeMedicalAdjustmentHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<EmployeeRewardHd> EmployeeRewardHd { get; set; } = new List<EmployeeRewardHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<EmployeeTerminate> EmployeeTerminate { get; set; } = new List<EmployeeTerminate>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistory { get; set; } = new List<EmployeeWorkingHistory>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<Engineering> Engineering { get; set; } = new List<Engineering>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ForecastHd> ForecastHd { get; set; } = new List<ForecastHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ImportMCUCorporate> ImportMCUCorporate { get; set; } = new List<ImportMCUCorporate>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<InventoryRevaluationHd> InventoryRevaluationHd { get; set; } = new List<InventoryRevaluationHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHd { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ItemServiceMCURealizationHd> ItemServiceMCURealizationHd { get; set; } = new List<ItemServiceMCURealizationHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ItemTransactionMcuHd> ItemTransactionMcuHd { get; set; } = new List<ItemTransactionMcuHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<JobOrderHd> JobOrderHd { get; set; } = new List<JobOrderHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<JournalCashBankHd> JournalCashBankHd { get; set; } = new List<JournalCashBankHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<JournalHd> JournalHd { get; set; } = new List<JournalHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<LeaveAdjustmentHd> LeaveAdjustmentHd { get; set; } = new List<LeaveAdjustmentHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<LeaveRequest> LeaveRequest { get; set; } = new List<LeaveRequest>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<METargetHd> METargetHd { get; set; } = new List<METargetHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<MRPHistoryHd> MRPHistoryHd { get; set; } = new List<MRPHistoryHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<MassLeaveHd> MassLeaveHd { get; set; } = new List<MassLeaveHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<MaterialRequestHd> MaterialRequestHd { get; set; } = new List<MaterialRequestHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHd { get; set; } = new List<OutstandingDOHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<OvertimeWorkOrder> OvertimeWorkOrder { get; set; } = new List<OvertimeWorkOrder>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PPITargetHd> PPITargetHd { get; set; } = new List<PPITargetHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PackageTreatmentHd> PackageTreatmentHd { get; set; } = new List<PackageTreatmentHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PaymentReceiptHd> PaymentReceiptHd { get; set; } = new List<PaymentReceiptHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PaymentRefund> PaymentRefund { get; set; } = new List<PaymentRefund>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PaymentRefundMedication> PaymentRefundMedication { get; set; } = new List<PaymentRefundMedication>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PayrollPaymentPlanHd> PayrollPaymentPlanHd { get; set; } = new List<PayrollPaymentPlanHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PayrollProcessHd> PayrollProcessHd { get; set; } = new List<PayrollProcessHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PhysicianFeePaymentPlanHd> PhysicianFeePaymentPlanHd { get; set; } = new List<PhysicianFeePaymentPlanHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PhysicianFeeVerification> PhysicianFeeVerification { get; set; } = new List<PhysicianFeeVerification>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ProductionHd> ProductionHd { get; set; } = new List<ProductionHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ProformaInvoice> ProformaInvoice { get; set; } = new List<ProformaInvoice>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ProjectMCUCorporate> ProjectMCUCorporate { get; set; } = new List<ProjectMCUCorporate>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PurchaseOrderHd> PurchaseOrderHd { get; set; } = new List<PurchaseOrderHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<PurchaseOrderReceiptHd> PurchaseOrderReceiptHd { get; set; } = new List<PurchaseOrderReceiptHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<RecalculationHd> RecalculationHd { get; set; } = new List<RecalculationHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHd { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ReconciliationHd> ReconciliationHd { get; set; } = new List<ReconciliationHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ReferralPatient> ReferralPatient { get; set; } = new List<ReferralPatient>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ReplacementHd> ReplacementHd { get; set; } = new List<ReplacementHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<RequestForProposalHd> RequestForProposalHd { get; set; } = new List<RequestForProposalHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ReturnToSupplierHd> ReturnToSupplierHd { get; set; } = new List<ReturnToSupplierHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<SalaryAdjustment> SalaryAdjustment { get; set; } = new List<SalaryAdjustment>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<SendToAutopackHistoryHd> SendToAutopackHistoryHd { get; set; } = new List<SendToAutopackHistoryHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ServiceOrderHd> ServiceOrderHd { get; set; } = new List<ServiceOrderHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<ServiceOrderRequestHd> ServiceOrderRequestHd { get; set; } = new List<ServiceOrderRequestHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<StockAdjustmentHd> StockAdjustmentHd { get; set; } = new List<StockAdjustmentHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<StockTakingHd> StockTakingHd { get; set; } = new List<StockTakingHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<SurgeryReservation> SurgeryReservation { get; set; } = new List<SurgeryReservation>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<TimeAttendanceRecapHd> TimeAttendanceRecapHd { get; set; } = new List<TimeAttendanceRecapHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<TransactionChargesHd> TransactionChargesHd { get; set; } = new List<TransactionChargesHd>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<TransactionCodeCOA> TransactionCodeCOA { get; set; } = new List<TransactionCodeCOA>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<TransactionCodeSource> TransactionCodeSource { get; set; } = new List<TransactionCodeSource>();

    [InverseProperty("TransactionCodeNavigation")]
    public virtual ICollection<TransferOrderHd> TransferOrderHd { get; set; } = new List<TransferOrderHd>();
}
