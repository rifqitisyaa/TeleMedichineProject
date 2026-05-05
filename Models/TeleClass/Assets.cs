using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Assets
{
    [Key]
    public int AssetsID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AssetsCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string AssetsName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ClassCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BookCode { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? BookSequenceNo { get; set; }

    public int? ServiceUnitId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ServiceDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DepreciationStartDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AcquisitionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? SalvageAmount { get; set; }

    public int? ComponentQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DispositionDate { get; set; }

    [Unicode(false)]
    public string? DispositionReason { get; set; }

    [Unicode(false)]
    public string? SoldFor { get; set; }

    public int? ParentID { get; set; }

    public int? LinkItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MeterInitializationDate { get; set; }

    public int? MeterInitializationQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? WarrantyDate { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? WarrantyRemarks { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ServiceContactInformation { get; set; }

    public int? BusinesspartnerID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SupplierAddress { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PurchaseOrderNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? POReceiptNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? SOCSequenceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReceivingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Unicode(false)]
    public string? Custodian { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AssetAccount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AccumulatedExpense { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ConstructionInProcess { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GainOnDisposal { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LossOnDisposal { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AssetSuspense { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? InsuranceCompany { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? InsuranceNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsuranceDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? InsuranceValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ModelAsset { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Manufacture { get; set; }

    public int? YearOfManufacturing { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCountryOfOrigin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DocumentName { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AccumulatedExpense")]
    [InverseProperty("AssetsAccumulatedExpenseNavigation")]
    public virtual ChartOfAccount? AccumulatedExpenseNavigation { get; set; }

    [ForeignKey("AssetAccount")]
    [InverseProperty("AssetsAssetAccountNavigation")]
    public virtual ChartOfAccount? AssetAccountNavigation { get; set; }

    [InverseProperty("Assets")]
    public virtual ICollection<AssetAdjustment> AssetAdjustment { get; set; } = new List<AssetAdjustment>();

    [ForeignKey("BookCode, BookSequenceNo")]
    [InverseProperty("Assets")]
    public virtual AssetBook? AssetBook { get; set; }

    [InverseProperty("Assets")]
    public virtual ICollection<AssetComponent> AssetComponent { get; set; } = new List<AssetComponent>();

    [InverseProperty("Assets")]
    public virtual ICollection<AssetDepreciation> AssetDepreciation { get; set; } = new List<AssetDepreciation>();

    [InverseProperty("Asset")]
    public virtual ICollection<AssetMeter> AssetMeter { get; set; } = new List<AssetMeter>();

    [InverseProperty("Assets")]
    public virtual ICollection<AssetModule> AssetModule { get; set; } = new List<AssetModule>();

    [ForeignKey("AssetSuspense")]
    [InverseProperty("AssetsAssetSuspenseNavigation")]
    public virtual ChartOfAccount? AssetSuspenseNavigation { get; set; }

    [InverseProperty("Assets")]
    public virtual ICollection<AssetsDepreciation> AssetsDepreciation { get; set; } = new List<AssetsDepreciation>();

    [InverseProperty("Assets")]
    public virtual ICollection<AssetsTransfers> AssetsTransfers { get; set; } = new List<AssetsTransfers>();

    [ForeignKey("BusinesspartnerID")]
    [InverseProperty("Assets")]
    public virtual BusinessPartner? Businesspartner { get; set; }

    [ForeignKey("ClassCode")]
    [InverseProperty("Assets")]
    public virtual AssetClassHd? ClassCodeNavigation { get; set; }

    [ForeignKey("ConstructionInProcess")]
    [InverseProperty("AssetsConstructionInProcessNavigation")]
    public virtual ChartOfAccount? ConstructionInProcessNavigation { get; set; }

    [ForeignKey("GCCountryOfOrigin")]
    [InverseProperty("Assets")]
    public virtual sysGeneralCode? GCCountryOfOriginNavigation { get; set; }

    [ForeignKey("GainOnDisposal")]
    [InverseProperty("AssetsGainOnDisposalNavigation")]
    public virtual ChartOfAccount? GainOnDisposalNavigation { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<Assets> InverseParent { get; set; } = new List<Assets>();

    [InverseProperty("Assets")]
    public virtual ICollection<JobOrderBOMImaging> JobOrderBOMImaging { get; set; } = new List<JobOrderBOMImaging>();

    [InverseProperty("Assets")]
    public virtual ICollection<JobOrderBOMLaboratory> JobOrderBOMLaboratory { get; set; } = new List<JobOrderBOMLaboratory>();

    [InverseProperty("Assets")]
    public virtual ICollection<JobOrderBOMOtherExam> JobOrderBOMOtherExam { get; set; } = new List<JobOrderBOMOtherExam>();

    [ForeignKey("LinkItemID")]
    [InverseProperty("Assets")]
    public virtual Item? LinkItem { get; set; }

    [ForeignKey("LossOnDisposal")]
    [InverseProperty("AssetsLossOnDisposalNavigation")]
    public virtual ChartOfAccount? LossOnDisposalNavigation { get; set; }

    [ForeignKey("POReceiptNo")]
    [InverseProperty("Assets")]
    public virtual ServiceOrderHd? POReceiptNoNavigation { get; set; }

    [ForeignKey("ParentID")]
    [InverseProperty("InverseParent")]
    public virtual Assets? Parent { get; set; }

    [InverseProperty("Asset")]
    public virtual ICollection<PhysicianBilling> PhysicianBilling { get; set; } = new List<PhysicianBilling>();

    [ForeignKey("PurchaseOrderNo")]
    [InverseProperty("Assets")]
    public virtual ServiceOrderRequestHd? PurchaseOrderNoNavigation { get; set; }

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("Assets")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [InverseProperty("Asset")]
    public virtual ICollection<TransactionChargesDt> TransactionChargesDt { get; set; } = new List<TransactionChargesDt>();
}
