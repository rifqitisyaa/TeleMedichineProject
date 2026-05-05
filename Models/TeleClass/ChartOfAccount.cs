using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ChartOfAccount
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string CoaCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CoaName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? CoaNameOtherLanguage { get; set; }

    public byte CoaLevel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCAccountType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaHeaderCode { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string NormalPosition { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCAccountRecordGroup { get; set; }

    public bool? IsCashFlow { get; set; }

    public bool IsCashBank { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("COACodeNavigation")]
    public virtual ICollection<AGCGroup> AGCGroup { get; set; } = new List<AGCGroup>();

    [InverseProperty("CoaCodeNavigation")]
    public virtual ICollection<AccountAccrualReset> AccountAccrualReset { get; set; } = new List<AccountAccrualReset>();

    [InverseProperty("CoaCodeNavigation")]
    public virtual ICollection<AccountPeriod> AccountPeriod { get; set; } = new List<AccountPeriod>();

    [InverseProperty("CoaCodeNavigation")]
    public virtual ICollection<AllocationCodeDt> AllocationCodeDt { get; set; } = new List<AllocationCodeDt>();

    [InverseProperty("AccumulatedExpenseNavigation")]
    public virtual ICollection<Assets> AssetsAccumulatedExpenseNavigation { get; set; } = new List<Assets>();

    [InverseProperty("AssetAccountNavigation")]
    public virtual ICollection<Assets> AssetsAssetAccountNavigation { get; set; } = new List<Assets>();

    [InverseProperty("AssetSuspenseNavigation")]
    public virtual ICollection<Assets> AssetsAssetSuspenseNavigation { get; set; } = new List<Assets>();

    [InverseProperty("AssetsCoaCodeNavigation")]
    public virtual ICollection<AssetsBook> AssetsBookAssetsCoaCodeNavigation { get; set; } = new List<AssetsBook>();

    [InverseProperty("BurdenCoaCodeNavigation")]
    public virtual ICollection<AssetsBook> AssetsBookBurdenCoaCodeNavigation { get; set; } = new List<AssetsBook>();

    [InverseProperty("CutBackCoaCodeNavigation")]
    public virtual ICollection<AssetsBook> AssetsBookCutBackCoaCodeNavigation { get; set; } = new List<AssetsBook>();

    [InverseProperty("DepreciationCoaCodeNavigation")]
    public virtual ICollection<AssetsBook> AssetsBookDepreciationCoaCodeNavigation { get; set; } = new List<AssetsBook>();

    [InverseProperty("EliminationCoaCodeNavigation")]
    public virtual ICollection<AssetsBook> AssetsBookEliminationCoaCodeNavigation { get; set; } = new List<AssetsBook>();

    [InverseProperty("ExpenseCoaCodeNavigation")]
    public virtual ICollection<AssetsBook> AssetsBookExpenseCoaCodeNavigation { get; set; } = new List<AssetsBook>();

    [InverseProperty("ConstructionInProcessNavigation")]
    public virtual ICollection<Assets> AssetsConstructionInProcessNavigation { get; set; } = new List<Assets>();

    [InverseProperty("GainOnDisposalNavigation")]
    public virtual ICollection<Assets> AssetsGainOnDisposalNavigation { get; set; } = new List<Assets>();

    [InverseProperty("LossOnDisposalNavigation")]
    public virtual ICollection<Assets> AssetsLossOnDisposalNavigation { get; set; } = new List<Assets>();

    [InverseProperty("CoaCodeNavigation")]
    public virtual ICollection<CashFlowStatement> CashFlowStatement { get; set; } = new List<CashFlowStatement>();

    [ForeignKey("CoaHeaderCode")]
    [InverseProperty("InverseCoaHeaderCodeNavigation")]
    public virtual ChartOfAccount? CoaHeaderCodeNavigation { get; set; }

    [ForeignKey("GCAccountRecordGroup")]
    [InverseProperty("ChartOfAccountGCAccountRecordGroupNavigation")]
    public virtual sysGeneralCode? GCAccountRecordGroupNavigation { get; set; }

    [ForeignKey("GCAccountType")]
    [InverseProperty("ChartOfAccountGCAccountTypeNavigation")]
    public virtual sysGeneralCode GCAccountTypeNavigation { get; set; } = null!;

    [InverseProperty("CoaHeaderCodeNavigation")]
    public virtual ICollection<ChartOfAccount> InverseCoaHeaderCodeNavigation { get; set; } = new List<ChartOfAccount>();

    [InverseProperty("CoaCodeCreditNavigation")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHdCoaCodeCreditNavigation { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("CoaCodeDebitNavigation")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHdCoaCodeDebitNavigation { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("COACodeNavigation")]
    public virtual ICollection<ItemTransactionHistoryDt> ItemTransactionHistoryDt { get; set; } = new List<ItemTransactionHistoryDt>();

    [InverseProperty("CoaCodeNavigation")]
    public virtual ICollection<JournalCashBankDt> JournalCashBankDt { get; set; } = new List<JournalCashBankDt>();

    [InverseProperty("CoaCodeNavigation")]
    public virtual ICollection<JournalDt> JournalDt { get; set; } = new List<JournalDt>();

    [InverseProperty("CoaCodeDebitNavigation")]
    public virtual ICollection<MaterialRequestCompletionHd> MaterialRequestCompletionHd { get; set; } = new List<MaterialRequestCompletionHd>();

    [InverseProperty("CoaCodeDebitNavigation")]
    public virtual ICollection<ProductionDt> ProductionDt { get; set; } = new List<ProductionDt>();

    [InverseProperty("CoaCodeCreditNavigation")]
    public virtual ICollection<ProductionHd> ProductionHd { get; set; } = new List<ProductionHd>();

    [InverseProperty("CoaCodeCreditNavigation")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHdCoaCodeCreditNavigation { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("CoaCodeDebitNavigation")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHdCoaCodeDebitNavigation { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("CoaCodeNavigation")]
    public virtual ICollection<ReconciliationHd> ReconciliationHd { get; set; } = new List<ReconciliationHd>();

    [InverseProperty("CoaCodeNavigation")]
    public virtual ICollection<RecuringSubDt> RecuringSubDt { get; set; } = new List<RecuringSubDt>();

    [InverseProperty("CoaCodeNavigation")]
    public virtual ICollection<StandardCostVsActualCost> StandardCostVsActualCost { get; set; } = new List<StandardCostVsActualCost>();

    [InverseProperty("CoaCodeDebitNavigation")]
    public virtual ICollection<TemplateProductionDt> TemplateProductionDt { get; set; } = new List<TemplateProductionDt>();

    [InverseProperty("CoaCodeCreditNavigation")]
    public virtual ICollection<TemplateProductionHd> TemplateProductionHd { get; set; } = new List<TemplateProductionHd>();

    [InverseProperty("COACodeNavigation")]
    public virtual ICollection<TransactionCodeCOA> TransactionCodeCOA { get; set; } = new List<TransactionCodeCOA>();
}
