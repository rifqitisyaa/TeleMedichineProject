using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemGroup
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCItemType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroupName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroupName2 { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? GCCategory { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? FactGroup { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCItemType")]
    [InverseProperty("ItemGroup")]
    public virtual sysGeneralCode? GCItemTypeNavigation { get; set; }

    [InverseProperty("ItemGroupCodeNavigation")]
    public virtual ICollection<IncomeTaxByDepartment> IncomeTaxByDepartment { get; set; } = new List<IncomeTaxByDepartment>();

    [InverseProperty("ItemGroupCodeNavigation")]
    public virtual ICollection<InventoryRevaluationHd> InventoryRevaluationHd { get; set; } = new List<InventoryRevaluationHd>();

    [InverseProperty("ItemGroupCodeNavigation")]
    public virtual ICollection<IpAddressMonitoring> IpAddressMonitoring { get; set; } = new List<IpAddressMonitoring>();

    [InverseProperty("ItemGroupCodeNavigation")]
    public virtual ICollection<Item> Item { get; set; } = new List<Item>();

    [InverseProperty("ItemGroupCodeNavigation")]
    public virtual ICollection<MarkUpPrice> MarkUpPrice { get; set; } = new List<MarkUpPrice>();

    [InverseProperty("ItemGroupCodeNavigation")]
    public virtual ICollection<ServiceUnitJobOrderType> ServiceUnitJobOrderType { get; set; } = new List<ServiceUnitJobOrderType>();

    [InverseProperty("ItemGroupCodeNavigation")]
    public virtual ICollection<StockTakingHd> StockTakingHd { get; set; } = new List<StockTakingHd>();
}
