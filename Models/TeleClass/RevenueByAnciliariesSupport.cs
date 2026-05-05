using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "ItemId", "TransactionDate")]
public partial class RevenueByAnciliariesSupport
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ItemId { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroup { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
