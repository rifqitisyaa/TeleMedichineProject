using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("InventoryRevaluationNo", "ItemID")]
public partial class InventoryRevaluationDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string InventoryRevaluationNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AmountVariance { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("InventoryRevaluationNo")]
    [InverseProperty("InventoryRevaluationDt")]
    public virtual InventoryRevaluationHd InventoryRevaluationNoNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("InventoryRevaluationDt")]
    public virtual Item Item { get; set; } = null!;
}
