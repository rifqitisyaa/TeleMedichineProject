using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class StockTakingHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string StockTakingNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly StockTakingDate { get; set; }

    public int LocationID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AbcClass { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCItemType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ItemName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemUnitCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ItemUnitName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? RackLocation { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DepartmentCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ServiceUnitCode { get; set; }

    public int? ServiceUnitID { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? InventoryAccuracyInPercentage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AbcClass")]
    [InverseProperty("StockTakingHd")]
    public virtual AbcClass? AbcClassNavigation { get; set; }

    [ForeignKey("DepartmentCode")]
    [InverseProperty("StockTakingHd")]
    public virtual Department? DepartmentCodeNavigation { get; set; }

    [ForeignKey("GCItemType")]
    [InverseProperty("StockTakingHd")]
    public virtual sysGeneralCode? GCItemTypeNavigation { get; set; }

    [ForeignKey("ItemGroupCode")]
    [InverseProperty("StockTakingHd")]
    public virtual ItemGroup? ItemGroupCodeNavigation { get; set; }

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("StockTakingHd")]
    public virtual ItemUnit? ItemUnitCodeNavigation { get; set; }

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("StockTakingHd")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("StockTakingHd")]
    public virtual ServiceUnit? ServiceUnitCodeNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("StockTakingHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("StockTakingNoNavigation")]
    public virtual ICollection<StockTakingDt> StockTakingDt { get; set; } = new List<StockTakingDt>();

    [ForeignKey("TransactionCode")]
    [InverseProperty("StockTakingHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
