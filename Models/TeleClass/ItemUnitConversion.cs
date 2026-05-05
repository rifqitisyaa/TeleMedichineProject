using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ItemID", "AlternateItemUnit")]
public partial class ItemUnitConversion
{
    [Key]
    public int ItemID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string AlternateItemUnit { get; set; } = null!;

    [Column(TypeName = "numeric(11, 2)")]
    public decimal ConversionFactor { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AlternateItemUnit")]
    [InverseProperty("ItemUnitConversion")]
    public virtual ItemUnit AlternateItemUnitNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ItemUnitConversion")]
    public virtual Item Item { get; set; } = null!;
}
