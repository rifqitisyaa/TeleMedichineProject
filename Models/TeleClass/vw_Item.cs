using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Item
{
    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroupName1 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string GeneralCodeName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName1 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCategoryCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal StandardPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalPrice { get; set; }
}
