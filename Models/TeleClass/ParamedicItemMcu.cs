using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "ParentItemId", "ItemId", "ParamedicId")]
public partial class ParamedicItemMcu
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
    public int ParamedicId { get; set; }

    public bool IsDefault { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ParamedicItemMcuItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParamedicId")]
    [InverseProperty("ParamedicItemMcu")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("ParentItemId")]
    [InverseProperty("ParamedicItemMcuParentItem")]
    public virtual Item ParentItem { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ParamedicItemMcu")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
