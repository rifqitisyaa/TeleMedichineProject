using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Location
{
    [Key]
    public int LocationID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string LocationCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string LocationName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? PermissionCode { get; set; }

    public int? ParentID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsAllowOverIssued { get; set; }

    public bool IsNettable { get; set; }

    public bool IsHoldForTransaction { get; set; }

    public bool? IsDisplayStock { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Location")]
    public virtual ICollection<DepartmentServiceUnit> DepartmentServiceUnit { get; set; } = new List<DepartmentServiceUnit>();

    [InverseProperty("Location")]
    public virtual ICollection<DirectPurchaseHd> DirectPurchaseHd { get; set; } = new List<DirectPurchaseHd>();

    [InverseProperty("FromLocation")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHdFromLocation { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("ToLocation")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHdToLocation { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("FromLocation")]
    public virtual ICollection<DistributionOrderLocationTemplate> DistributionOrderLocationTemplateFromLocation { get; set; } = new List<DistributionOrderLocationTemplate>();

    [InverseProperty("ToLocation")]
    public virtual ICollection<DistributionOrderLocationTemplate> DistributionOrderLocationTemplateToLocation { get; set; } = new List<DistributionOrderLocationTemplate>();

    [InverseProperty("FromLocation")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlannedFromLocation { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("ToLocation")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlannedToLocation { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("Location")]
    public virtual ICollection<DrugDispensingDt> DrugDispensingDt { get; set; } = new List<DrugDispensingDt>();

    [InverseProperty("Location")]
    public virtual ICollection<DrugDispensingHd> DrugDispensingHd { get; set; } = new List<DrugDispensingHd>();

    [InverseProperty("Location")]
    public virtual ICollection<DrugReturnHd> DrugReturnHd { get; set; } = new List<DrugReturnHd>();

    [InverseProperty("Location")]
    public virtual ICollection<InventoryAmountHistory> InventoryAmountHistory { get; set; } = new List<InventoryAmountHistory>();

    [InverseProperty("Location")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHd { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("Location")]
    public virtual ICollection<ItemInventory> ItemInventory { get; set; } = new List<ItemInventory>();

    [InverseProperty("Location")]
    public virtual ICollection<ItemPlanningDO> ItemPlanningDO { get; set; } = new List<ItemPlanningDO>();

    [InverseProperty("Location")]
    public virtual ICollection<ItemTransactionHistoryHd> ItemTransactionHistoryHd { get; set; } = new List<ItemTransactionHistoryHd>();

    [InverseProperty("Location")]
    public virtual ICollection<LocationItemRack> LocationItemRack { get; set; } = new List<LocationItemRack>();

    [InverseProperty("FromLocation")]
    public virtual ICollection<MaterialRequestCompletionHd> MaterialRequestCompletionHdFromLocation { get; set; } = new List<MaterialRequestCompletionHd>();

    [InverseProperty("ToLocation")]
    public virtual ICollection<MaterialRequestCompletionHd> MaterialRequestCompletionHdToLocation { get; set; } = new List<MaterialRequestCompletionHd>();

    [InverseProperty("FromLocation")]
    public virtual ICollection<MaterialRequestHd> MaterialRequestHdFromLocation { get; set; } = new List<MaterialRequestHd>();

    [InverseProperty("ToLocation")]
    public virtual ICollection<MaterialRequestHd> MaterialRequestHdToLocation { get; set; } = new List<MaterialRequestHd>();

    [InverseProperty("FromLocation")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHdFromLocation { get; set; } = new List<OutstandingDOHd>();

    [InverseProperty("ToLocation")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHdToLocation { get; set; } = new List<OutstandingDOHd>();

    [ForeignKey("PermissionCode")]
    [InverseProperty("Location")]
    public virtual LocationPermissionHd? PermissionCodeNavigation { get; set; }

    [InverseProperty("Location")]
    public virtual ICollection<ProductionHd> ProductionHd { get; set; } = new List<ProductionHd>();

    [InverseProperty("Location")]
    public virtual ICollection<PurchaseOrderHd> PurchaseOrderHd { get; set; } = new List<PurchaseOrderHd>();

    [InverseProperty("Location")]
    public virtual ICollection<PurchaseOrderReceiptHd> PurchaseOrderReceiptHd { get; set; } = new List<PurchaseOrderReceiptHd>();

    [InverseProperty("Location")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHd { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("Location")]
    public virtual ICollection<ReplacementHd> ReplacementHd { get; set; } = new List<ReplacementHd>();

    [InverseProperty("Location")]
    public virtual ICollection<ReturnToSupplierHd> ReturnToSupplierHd { get; set; } = new List<ReturnToSupplierHd>();

    [InverseProperty("Location")]
    public virtual ICollection<ServiceUnitLocation> ServiceUnitLocation { get; set; } = new List<ServiceUnitLocation>();

    [InverseProperty("LocationNavigation")]
    public virtual ICollection<Site> Site { get; set; } = new List<Site>();

    [ForeignKey("SiteCode")]
    [InverseProperty("Location")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("Location")]
    public virtual ICollection<StockAdjustmentHd> StockAdjustmentHd { get; set; } = new List<StockAdjustmentHd>();

    [InverseProperty("Location")]
    public virtual ICollection<TransactionChargesDt> TransactionChargesDt { get; set; } = new List<TransactionChargesDt>();

    [InverseProperty("FromLocation")]
    public virtual ICollection<TransferOrderHd> TransferOrderHdFromLocation { get; set; } = new List<TransferOrderHd>();

    [InverseProperty("ToLocation")]
    public virtual ICollection<TransferOrderHd> TransferOrderHdToLocation { get; set; } = new List<TransferOrderHd>();
}
