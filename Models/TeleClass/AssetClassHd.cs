using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetClassHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public bool IsDepreciateAssets { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<AssetClassDt> AssetClassDt { get; set; } = new List<AssetClassDt>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<Assets> Assets { get; set; } = new List<Assets>();

    [InverseProperty("AssetClassCodeNavigation")]
    public virtual ICollection<Item> Item { get; set; } = new List<Item>();
}
