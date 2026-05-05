using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimItemType
{
    [Key]
    public int ItemTypeID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ItemTypeCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ItemTypeName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("ItemType")]
    public virtual ICollection<DW_DimItem> DW_DimItem { get; set; } = new List<DW_DimItem>();
}
