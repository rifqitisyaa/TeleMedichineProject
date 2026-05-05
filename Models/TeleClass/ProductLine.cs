using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("ProductLineCode", Name = "UNIQUE_IX_ProductLine", IsUnique = true)]
public partial class ProductLine
{
    [Key]
    public int ProductLineID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ProductLineCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ProductLineName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? Inventory { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? COGS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Purchase { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PurchaseReturn { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PurchaseDiscount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Sales { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SalesReturn { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SalesDiscount { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ProductLine")]
    public virtual ICollection<Item> Item { get; set; } = new List<Item>();
}
