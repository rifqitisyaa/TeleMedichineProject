using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ItemID", "AlternateItemUnit")]
public partial class _imp_mims_ItemUnitConversion
{
    [Key]
    public int ItemID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string AlternateItemUnit { get; set; } = null!;

    [Column(TypeName = "numeric(6, 2)")]
    public decimal ConversionFactor { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
