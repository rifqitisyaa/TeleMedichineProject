using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _imp_mims_Item
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

    public bool? IsAdministrationCalculation { get; set; }

    public bool IsPrintWithDoctorName { get; set; }

    public bool IsAssetsUtilization { get; set; }

    public bool IsPhysicianFeeItem { get; set; }

    public int? AssetsGroupID { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
