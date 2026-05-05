using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("LocationID", "ItemID", "SiteCode", "ExpDate")]
public partial class ItemInventoryExpired
{
    [Key]
    public int LocationID { get; set; }

    [Key]
    public int ItemID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ExpDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnHand { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnRequest { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnGIT { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnOrder { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyAllocate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
