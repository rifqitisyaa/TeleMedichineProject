using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("Year", "Month", "TransactionDate", "SiteCode", "LocationId", "ItemId", Name = "IX_InventoryAmountHistory")]
public partial class InventoryAmountHistory
{
    [Key]
    public int Id { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int LocationId { get; set; }

    public int ItemId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemUnitCode { get; set; }

    public int ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal BeginningQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QuantityChange { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyIn { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOut { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal EndingQty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionSource { get; set; } = null!;

    public long TransactionHistoryID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaterialCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OverheadCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LaborCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BurdenCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SubconCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ItemAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AmountChange { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BalanceAmount { get; set; }

    public bool IsDeleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("InventoryAmountHistory")]
    public virtual ItemUnit? ItemUnitCodeNavigation { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("InventoryAmountHistory")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("InventoryAmountHistory")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("InventoryAmountHistory")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("InventoryAmountHistory")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
