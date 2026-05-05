using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimItemGroup
{
    [Key]
    public int ItemGroupID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroupName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroupName2 { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("ItemGroup")]
    public virtual ICollection<DW_DimItem> DW_DimItem { get; set; } = new List<DW_DimItem>();
}
