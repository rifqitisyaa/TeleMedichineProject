using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "ParentItemId", "ItemId", "ServiceUnitId")]
public partial class ServiceUnitItemMcu
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int ParentItemId { get; set; }

    [Key]
    public int ItemId { get; set; }

    [Key]
    public int ServiceUnitId { get; set; }

    public bool IsDefault { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ServiceUnitItemMcuItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParentItemId")]
    [InverseProperty("ServiceUnitItemMcuParentItem")]
    public virtual Item ParentItem { get; set; } = null!;

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("ServiceUnitItemMcu")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ServiceUnitItemMcu")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
