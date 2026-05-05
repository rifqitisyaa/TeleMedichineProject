using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Item
{
    [Key]
    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    public int? ProductLineID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName2 { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsAllowCito { get; set; }

    public bool? IsAllowComplication { get; set; }

    public bool IsAllowVariable { get; set; }

    public bool IsAllowOrder { get; set; }

    public bool? IsAdministrationCalculation { get; set; }

    public bool IsPrintWithDoctorName { get; set; }

    public bool? IsPrintWithClass { get; set; }

    public bool? IsPrintWithServiceUnit { get; set; }

    public bool IsAssetsUtilization { get; set; }

    public bool IsPhysicianFeeItem { get; set; }

    public bool? IsConsignment { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPhysicianFeeItemType { get; set; }

    public int? AssetsGroupID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AssetClassCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BaseUnitCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PurchaseUnitCode { get; set; }

    public bool IsPurchaseItem { get; set; }

    public bool IsNonStock { get; set; }

    public bool IsControlExpired { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ABCClass { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal CycleCountInterval { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal ShelfLife { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SubGroup { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<AccountPayableTransactionDt> AccountPayableTransactionDt { get; set; } = new List<AccountPayableTransactionDt>();

    [ForeignKey("AssetClassCode")]
    [InverseProperty("Item")]
    public virtual AssetClassHd? AssetClassCodeNavigation { get; set; }

    [InverseProperty("LinkItem")]
    public virtual ICollection<Assets> Assets { get; set; } = new List<Assets>();

    [ForeignKey("AssetsGroupID")]
    [InverseProperty("Item")]
    public virtual AssetsGroup? AssetsGroup { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<AutomationChargesItem> AutomationChargesItem { get; set; } = new List<AutomationChargesItem>();

    [InverseProperty("Item")]
    public virtual ICollection<AverageCost> AverageCost { get; set; } = new List<AverageCost>();

    [InverseProperty("Item")]
    public virtual ICollection<AverageCostBySystem> AverageCostBySystem { get; set; } = new List<AverageCostBySystem>();

    [ForeignKey("BaseUnitCode")]
    [InverseProperty("ItemBaseUnitCodeNavigation")]
    public virtual ItemUnit? BaseUnitCodeNavigation { get; set; }

    [InverseProperty("ItemIdAutomationChargesNavigation")]
    public virtual ICollection<Bed> Bed { get; set; } = new List<Bed>();

    [InverseProperty("PhysicianChargesItem")]
    public virtual ICollection<Class> Class { get; set; } = new List<Class>();

    [InverseProperty("Item")]
    public virtual ICollection<ClinicalPathwayDt> ClinicalPathwayDt { get; set; } = new List<ClinicalPathwayDt>();

    [InverseProperty("Item")]
    public virtual ICollection<CompoundTemplateDt> CompoundTemplateDt { get; set; } = new List<CompoundTemplateDt>();

    [InverseProperty("ItemIdHospitalNavigation")]
    public virtual ICollection<CorporateItem> CorporateItem { get; set; } = new List<CorporateItem>();

    [InverseProperty("Item")]
    public virtual ICollection<CustomerAkomodasiKamar> CustomerAkomodasiKamar { get; set; } = new List<CustomerAkomodasiKamar>();

    [InverseProperty("Item")]
    public virtual ICollection<CustomerItem> CustomerItem { get; set; } = new List<CustomerItem>();

    [InverseProperty("Item")]
    public virtual ICollection<DebitNoteCreditNoteDt> DebitNoteCreditNoteDt { get; set; } = new List<DebitNoteCreditNoteDt>();

    [InverseProperty("Item")]
    public virtual ICollection<DirectPurchaseDt> DirectPurchaseDt { get; set; } = new List<DirectPurchaseDt>();

    [InverseProperty("Item")]
    public virtual ICollection<DistributionOrderDt> DistributionOrderDt { get; set; } = new List<DistributionOrderDt>();

    [InverseProperty("Item")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlanned { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("Item")]
    public virtual ICollection<DrugAdministration> DrugAdministration { get; set; } = new List<DrugAdministration>();

    [InverseProperty("Item")]
    public virtual ICollection<DrugDispensingDt> DrugDispensingDt { get; set; } = new List<DrugDispensingDt>();

    [InverseProperty("Item")]
    public virtual ICollection<DrugReturnDt> DrugReturnDt { get; set; } = new List<DrugReturnDt>();

    [InverseProperty("Item")]
    public virtual ICollection<EmbalaceHd> EmbalaceHd { get; set; } = new List<EmbalaceHd>();

    [InverseProperty("Item")]
    public virtual ExpiredDateSimulation? ExpiredDateSimulation { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<ForecastSubDt> ForecastSubDt { get; set; } = new List<ForecastSubDt>();

    [ForeignKey("GCItemType")]
    [InverseProperty("ItemGCItemTypeNavigation")]
    public virtual sysGeneralCode GCItemTypeNavigation { get; set; } = null!;

    [ForeignKey("GCPhysicianFeeItemType")]
    [InverseProperty("ItemGCPhysicianFeeItemTypeNavigation")]
    public virtual sysGeneralCode? GCPhysicianFeeItemTypeNavigation { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<GuidelineDt> GuidelineDt { get; set; } = new List<GuidelineDt>();

    [InverseProperty("Item")]
    public virtual ICollection<GuidelineDtItem> GuidelineDtItem { get; set; } = new List<GuidelineDtItem>();

    [InverseProperty("ItemCodeNavigation")]
    public virtual ICollection<ImportMCUCorporate> ImportMCUCorporate { get; set; } = new List<ImportMCUCorporate>();

    [InverseProperty("Item")]
    public virtual ICollection<InventoryRevaluationDt> InventoryRevaluationDt { get; set; } = new List<InventoryRevaluationDt>();

    [InverseProperty("Item")]
    public virtual ICollection<IssuedUnplannedDt> IssuedUnplannedDt { get; set; } = new List<IssuedUnplannedDt>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemBomDt> ItemBomDt { get; set; } = new List<ItemBomDt>();

    [InverseProperty("Item")]
    public virtual ItemBomHd? ItemBomHd { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<ItemCost> ItemCost { get; set; } = new List<ItemCost>();

    [InverseProperty("Item")]
    public virtual ItemDrug? ItemDrug { get; set; }

    [ForeignKey("ItemGroupCode")]
    [InverseProperty("Item")]
    public virtual ItemGroup ItemGroupCodeNavigation { get; set; } = null!;

    [InverseProperty("Item")]
    public virtual ICollection<ItemInGroup> ItemInGroup { get; set; } = new List<ItemInGroup>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemInventory> ItemInventory { get; set; } = new List<ItemInventory>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemLaboratory> ItemLaboratoryItem { get; set; } = new List<ItemLaboratory>();

    [InverseProperty("ItemCodeNavigation")]
    public virtual ItemLaboratory? ItemLaboratoryItemCodeNavigation { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<ItemMasterIncentive> ItemMasterIncentive { get; set; } = new List<ItemMasterIncentive>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemMostFrequent> ItemMostFrequent { get; set; } = new List<ItemMostFrequent>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemPlanning> ItemPlanning { get; set; } = new List<ItemPlanning>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemPlanningDO> ItemPlanningDO { get; set; } = new List<ItemPlanningDO>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemReference> ItemReference { get; set; } = new List<ItemReference>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemServiceMCURealizationDt> ItemServiceMCURealizationDt { get; set; } = new List<ItemServiceMCURealizationDt>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemTariffCorporate> ItemTariffCorporate { get; set; } = new List<ItemTariffCorporate>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemTariffMCU> ItemTariffMCUItem { get; set; } = new List<ItemTariffMCU>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<ItemTariffMCU> ItemTariffMCUParentItem { get; set; } = new List<ItemTariffMCU>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemTariffStandard> ItemTariffStandard { get; set; } = new List<ItemTariffStandard>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemTax> ItemTax { get; set; } = new List<ItemTax>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemTemplate> ItemTemplate { get; set; } = new List<ItemTemplate>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemTransactionHistoryHd> ItemTransactionHistoryHd { get; set; } = new List<ItemTransactionHistoryHd>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemTransactionMcuDt> ItemTransactionMcuDt { get; set; } = new List<ItemTransactionMcuDt>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<ItemTransactionMcuHd> ItemTransactionMcuHd { get; set; } = new List<ItemTransactionMcuHd>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemUnitConversion> ItemUnitConversion { get; set; } = new List<ItemUnitConversion>();

    [InverseProperty("Item")]
    public virtual ICollection<ItemVaccination> ItemVaccination { get; set; } = new List<ItemVaccination>();

    [InverseProperty("Item")]
    public virtual ICollection<JobOrderBOMImaging> JobOrderBOMImagingItem { get; set; } = new List<JobOrderBOMImaging>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<JobOrderBOMImaging> JobOrderBOMImagingParentItem { get; set; } = new List<JobOrderBOMImaging>();

    [InverseProperty("Item")]
    public virtual ICollection<JobOrderBOMLaboratory> JobOrderBOMLaboratoryItem { get; set; } = new List<JobOrderBOMLaboratory>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<JobOrderBOMLaboratory> JobOrderBOMLaboratoryParentItem { get; set; } = new List<JobOrderBOMLaboratory>();

    [InverseProperty("Item")]
    public virtual ICollection<JobOrderBOMOtherExam> JobOrderBOMOtherExamItem { get; set; } = new List<JobOrderBOMOtherExam>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<JobOrderBOMOtherExam> JobOrderBOMOtherExamParentItem { get; set; } = new List<JobOrderBOMOtherExam>();

    [InverseProperty("Item")]
    public virtual ICollection<JobOrderDt> JobOrderDt { get; set; } = new List<JobOrderDt>();

    [InverseProperty("Item")]
    public virtual ICollection<JobOrderDtMedicalSuppiles> JobOrderDtMedicalSuppiles { get; set; } = new List<JobOrderDtMedicalSuppiles>();

    [InverseProperty("Item")]
    public virtual ICollection<JobOrderDtMedication> JobOrderDtMedication { get; set; } = new List<JobOrderDtMedication>();

    [InverseProperty("Item")]
    public virtual ICollection<LocationItemRack> LocationItemRack { get; set; } = new List<LocationItemRack>();

    [InverseProperty("Item")]
    public virtual ICollection<MRPHistorySubDt> MRPHistorySubDt { get; set; } = new List<MRPHistorySubDt>();

    [InverseProperty("Item")]
    public virtual ICollection<MarkUpPrice> MarkUpPrice { get; set; } = new List<MarkUpPrice>();

    [InverseProperty("Item")]
    public virtual ICollection<MaterialRequestCompletionDt> MaterialRequestCompletionDt { get; set; } = new List<MaterialRequestCompletionDt>();

    [InverseProperty("Item")]
    public virtual ICollection<MaterialRequestDt> MaterialRequestDt { get; set; } = new List<MaterialRequestDt>();

    [InverseProperty("Item")]
    public virtual ICollection<OutstandingDODt> OutstandingDODt { get; set; } = new List<OutstandingDODt>();

    [InverseProperty("Item")]
    public virtual ICollection<PackageTreatmentDt> PackageTreatmentDt { get; set; } = new List<PackageTreatmentDt>();

    [InverseProperty("Item")]
    public virtual ICollection<PackageTreatmentHd> PackageTreatmentHd { get; set; } = new List<PackageTreatmentHd>();

    [InverseProperty("Item")]
    public virtual ICollection<ParamedicAutoBill> ParamedicAutoBill { get; set; } = new List<ParamedicAutoBill>();

    [InverseProperty("Item")]
    public virtual ICollection<ParamedicItemMcu> ParamedicItemMcuItem { get; set; } = new List<ParamedicItemMcu>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<ParamedicItemMcu> ParamedicItemMcuParentItem { get; set; } = new List<ParamedicItemMcu>();

    [InverseProperty("Item")]
    public virtual ICollection<PatientVaccination> PatientVaccination { get; set; } = new List<PatientVaccination>();

    [InverseProperty("Item")]
    public virtual PatientVisitItem? PatientVisitItem { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<PhysicianBilling> PhysicianBilling { get; set; } = new List<PhysicianBilling>();

    [InverseProperty("Item")]
    public virtual ICollection<PhysicianChargesByClass> PhysicianChargesByClass { get; set; } = new List<PhysicianChargesByClass>();

    [InverseProperty("Item")]
    public virtual ICollection<PhysicianItem> PhysicianItem { get; set; } = new List<PhysicianItem>();

    [InverseProperty("Item")]
    public virtual ICollection<PhysicianTeam> PhysicianTeam { get; set; } = new List<PhysicianTeam>();

    [InverseProperty("Item")]
    public virtual ICollection<PraProcessDt> PraProcessDt { get; set; } = new List<PraProcessDt>();

    [InverseProperty("Item")]
    public virtual ICollection<PrescriptionTemplateDt> PrescriptionTemplateDt { get; set; } = new List<PrescriptionTemplateDt>();

    [ForeignKey("ProductLineID")]
    [InverseProperty("Item")]
    public virtual ProductLine? ProductLine { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<ProductionDt> ProductionDt { get; set; } = new List<ProductionDt>();

    [InverseProperty("Item")]
    public virtual ICollection<ProductionHd> ProductionHd { get; set; } = new List<ProductionHd>();

    [InverseProperty("Item")]
    public virtual ICollection<PurchaseOrderDt> PurchaseOrderDt { get; set; } = new List<PurchaseOrderDt>();

    [InverseProperty("Item")]
    public virtual ICollection<PurchaseOrderPlanned> PurchaseOrderPlanned { get; set; } = new List<PurchaseOrderPlanned>();

    [InverseProperty("Item")]
    public virtual ICollection<PurchaseOrderReceiptDt> PurchaseOrderReceiptDt { get; set; } = new List<PurchaseOrderReceiptDt>();

    [ForeignKey("PurchaseUnitCode")]
    [InverseProperty("ItemPurchaseUnitCodeNavigation")]
    public virtual ItemUnit? PurchaseUnitCodeNavigation { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<RecalculationDt> RecalculationDt { get; set; } = new List<RecalculationDt>();

    [InverseProperty("Item")]
    public virtual ICollection<RecalculationDtBom> RecalculationDtBomItem { get; set; } = new List<RecalculationDtBom>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<RecalculationDtBom> RecalculationDtBomParentItem { get; set; } = new List<RecalculationDtBom>();

    [InverseProperty("Item")]
    public virtual ICollection<ReceivedUnplannedDt> ReceivedUnplannedDt { get; set; } = new List<ReceivedUnplannedDt>();

    [InverseProperty("Item")]
    public virtual ICollection<ReplacementDt> ReplacementDt { get; set; } = new List<ReplacementDt>();

    [InverseProperty("Item")]
    public virtual ICollection<RequestForProposalSubDt> RequestForProposalSubDt { get; set; } = new List<RequestForProposalSubDt>();

    [InverseProperty("Item")]
    public virtual ICollection<ReturnToSupplierDt> ReturnToSupplierDt { get; set; } = new List<ReturnToSupplierDt>();

    [InverseProperty("Item")]
    public virtual ICollection<ServiceOrderDt> ServiceOrderDt { get; set; } = new List<ServiceOrderDt>();

    [InverseProperty("Item")]
    public virtual ICollection<ServiceOrderRequestDt> ServiceOrderRequestDt { get; set; } = new List<ServiceOrderRequestDt>();

    [InverseProperty("Item")]
    public virtual ICollection<ServiceUnitItem> ServiceUnitItem { get; set; } = new List<ServiceUnitItem>();

    [InverseProperty("Item")]
    public virtual ICollection<ServiceUnitItemMcu> ServiceUnitItemMcuItem { get; set; } = new List<ServiceUnitItemMcu>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<ServiceUnitItemMcu> ServiceUnitItemMcuParentItem { get; set; } = new List<ServiceUnitItemMcu>();

    [InverseProperty("Item")]
    public virtual ICollection<StockAdjustmentDt> StockAdjustmentDt { get; set; } = new List<StockAdjustmentDt>();

    [InverseProperty("Item")]
    public virtual ICollection<StockTakingDt> StockTakingDt { get; set; } = new List<StockTakingDt>();

    [InverseProperty("Item")]
    public virtual ICollection<SupplierItem> SupplierItem { get; set; } = new List<SupplierItem>();

    [InverseProperty("Item")]
    public virtual ICollection<SupplierItemPrice> SupplierItemPrice { get; set; } = new List<SupplierItemPrice>();

    [InverseProperty("Item")]
    public virtual ICollection<TemplateOtherExam> TemplateOtherExam { get; set; } = new List<TemplateOtherExam>();

    [InverseProperty("Item")]
    public virtual ICollection<TemplateProductionDt> TemplateProductionDt { get; set; } = new List<TemplateProductionDt>();

    [InverseProperty("Item")]
    public virtual ICollection<TemplateProductionHd> TemplateProductionHd { get; set; } = new List<TemplateProductionHd>();

    [InverseProperty("Item")]
    public virtual ICollection<TemplateRadiology> TemplateRadiology { get; set; } = new List<TemplateRadiology>();

    [InverseProperty("Item")]
    public virtual ICollection<TemplateTariffDt> TemplateTariffDt { get; set; } = new List<TemplateTariffDt>();

    [InverseProperty("Item")]
    public virtual ICollection<TransactionChargesDt> TransactionChargesDt { get; set; } = new List<TransactionChargesDt>();

    [InverseProperty("Item")]
    public virtual ICollection<TransactionChargesDtBOM> TransactionChargesDtBOMItem { get; set; } = new List<TransactionChargesDtBOM>();

    [InverseProperty("ParentItem")]
    public virtual ICollection<TransactionChargesDtBOM> TransactionChargesDtBOMParentItem { get; set; } = new List<TransactionChargesDtBOM>();

    [InverseProperty("Item")]
    public virtual ICollection<TransferOrderDt> TransferOrderDt { get; set; } = new List<TransferOrderDt>();

    [InverseProperty("Item")]
    public virtual ICollection<VaccinationShotSubDt> VaccinationShotSubDt { get; set; } = new List<VaccinationShotSubDt>();

    [InverseProperty("ItemServiceNavigation")]
    public virtual ICollection<VitalSignCodeVs3> VitalSignCodeVs3 { get; set; } = new List<VitalSignCodeVs3>();
}
