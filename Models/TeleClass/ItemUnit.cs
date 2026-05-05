using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemUnit
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemUnitName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    public bool IsInventoryUnit { get; set; }

    public bool IsConsumeUnit { get; set; }

    public bool IsDrugForm { get; set; }

    public bool IsService { get; set; }

    public bool IsDosageUnit { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<DirectPurchaseDt> DirectPurchaseDt { get; set; } = new List<DirectPurchaseDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<DistributionOrderDt> DistributionOrderDt { get; set; } = new List<DistributionOrderDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlanned { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("ConsumeUnitNavigation")]
    public virtual ICollection<DrugDispensingDt> DrugDispensingDt { get; set; } = new List<DrugDispensingDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<DrugReturnDt> DrugReturnDt { get; set; } = new List<DrugReturnDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<InventoryAmountHistory> InventoryAmountHistory { get; set; } = new List<InventoryAmountHistory>();

    [InverseProperty("BaseItemUnitCodeNavigation")]
    public virtual ICollection<IssuedUnplannedDt> IssuedUnplannedDtBaseItemUnitCodeNavigation { get; set; } = new List<IssuedUnplannedDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<IssuedUnplannedDt> IssuedUnplannedDtItemUnitCodeNavigation { get; set; } = new List<IssuedUnplannedDt>();

    [InverseProperty("BaseUnitCodeNavigation")]
    public virtual ICollection<Item> ItemBaseUnitCodeNavigation { get; set; } = new List<Item>();

    [InverseProperty("DosageUnitCodeNavigation")]
    public virtual ICollection<ItemBrandGeneric> ItemBrandGeneric { get; set; } = new List<ItemBrandGeneric>();

    [InverseProperty("DefaultConsumeUnitNavigation")]
    public virtual ICollection<ItemDrug> ItemDrugDefaultConsumeUnitNavigation { get; set; } = new List<ItemDrug>();

    [InverseProperty("DosageUnitCodeNavigation")]
    public virtual ICollection<ItemDrug> ItemDrugDosageUnitCodeNavigation { get; set; } = new List<ItemDrug>();

    [InverseProperty("DrugFormCodeNavigation")]
    public virtual ICollection<ItemDrug> ItemDrugDrugFormCodeNavigation { get; set; } = new List<ItemDrug>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ItemPurchasePrice> ItemPurchasePrice { get; set; } = new List<ItemPurchasePrice>();

    [InverseProperty("PurchaseUnitCodeNavigation")]
    public virtual ICollection<Item> ItemPurchaseUnitCodeNavigation { get; set; } = new List<Item>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ItemServiceMCURealizationDt> ItemServiceMCURealizationDt { get; set; } = new List<ItemServiceMCURealizationDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ItemTransactionHistoryHd> ItemTransactionHistoryHd { get; set; } = new List<ItemTransactionHistoryHd>();

    [InverseProperty("AlternateItemUnitNavigation")]
    public virtual ICollection<ItemUnitConversion> ItemUnitConversion { get; set; } = new List<ItemUnitConversion>();

    [InverseProperty("BaseUnitCodeNavigation")]
    public virtual ICollection<JobOrderDtMedicalSuppiles> JobOrderDtMedicalSuppiles { get; set; } = new List<JobOrderDtMedicalSuppiles>();

    [InverseProperty("ConsumeUnitNavigation")]
    public virtual ICollection<JobOrderDtMedication> JobOrderDtMedication { get; set; } = new List<JobOrderDtMedication>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<MaterialRequestCompletionDt> MaterialRequestCompletionDt { get; set; } = new List<MaterialRequestCompletionDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<MaterialRequestDt> MaterialRequestDt { get; set; } = new List<MaterialRequestDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<OutstandingDODt> OutstandingDODt { get; set; } = new List<OutstandingDODt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<PhysicianBilling> PhysicianBilling { get; set; } = new List<PhysicianBilling>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ProductionDt> ProductionDt { get; set; } = new List<ProductionDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ProductionHd> ProductionHd { get; set; } = new List<ProductionHd>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<PurchaseOrderDt> PurchaseOrderDt { get; set; } = new List<PurchaseOrderDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<PurchaseOrderReceiptDt> PurchaseOrderReceiptDt { get; set; } = new List<PurchaseOrderReceiptDt>();

    [InverseProperty("BaseItemUnitCodeNavigation")]
    public virtual ICollection<ReceivedUnplannedDt> ReceivedUnplannedDtBaseItemUnitCodeNavigation { get; set; } = new List<ReceivedUnplannedDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ReceivedUnplannedDt> ReceivedUnplannedDtItemUnitCodeNavigation { get; set; } = new List<ReceivedUnplannedDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ReplacementDt> ReplacementDt { get; set; } = new List<ReplacementDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<RequestForProposalSubDt> RequestForProposalSubDt { get; set; } = new List<RequestForProposalSubDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ReturnToSupplierDt> ReturnToSupplierDt { get; set; } = new List<ReturnToSupplierDt>();

    [InverseProperty("BaseUnitNavigation")]
    public virtual ICollection<SendToAutopackHistoryDt> SendToAutopackHistoryDt { get; set; } = new List<SendToAutopackHistoryDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ServiceOrderDt> ServiceOrderDt { get; set; } = new List<ServiceOrderDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<ServiceOrderRequestDt> ServiceOrderRequestDt { get; set; } = new List<ServiceOrderRequestDt>();

    [InverseProperty("BaseItemUnitCodeNavigation")]
    public virtual ICollection<StockAdjustmentDt> StockAdjustmentDtBaseItemUnitCodeNavigation { get; set; } = new List<StockAdjustmentDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<StockAdjustmentDt> StockAdjustmentDtItemUnitCodeNavigation { get; set; } = new List<StockAdjustmentDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<StockTakingHd> StockTakingHd { get; set; } = new List<StockTakingHd>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<SupplierItemPrice> SupplierItemPrice { get; set; } = new List<SupplierItemPrice>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<TemplateProductionDt> TemplateProductionDt { get; set; } = new List<TemplateProductionDt>();

    [InverseProperty("ProductionUnitNavigation")]
    public virtual ICollection<TemplateProductionHd> TemplateProductionHd { get; set; } = new List<TemplateProductionHd>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<TransactionChargesDt> TransactionChargesDt { get; set; } = new List<TransactionChargesDt>();

    [InverseProperty("ItemUnitCodeNavigation")]
    public virtual ICollection<TransferOrderDt> TransferOrderDt { get; set; } = new List<TransferOrderDt>();

    [InverseProperty("InventoryUnitCodeNavigation")]
    public virtual ICollection<VaccinationShotSubDt> VaccinationShotSubDt { get; set; } = new List<VaccinationShotSubDt>();
}
