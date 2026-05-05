using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_MasterItem
{
    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName2 { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? BaseUnitCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PurchaseUnitCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroupName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroupName2 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemTypeName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemTypeName2 { get; set; } = null!;

    public bool IsNonStock { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BrandName { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string Manufacturer { get; set; } = null!;
}
