using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Id", "LocationID", "ItemID")]
public partial class RecalculationItemInventoryDt
{
    [Key]
    public int Id { get; set; }

    [Key]
    public int LocationID { get; set; }

    [Key]
    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnHandBefore { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnHandAfter { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnRequestBefore { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnRequestAfter { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnGITBefore { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnGITAfter { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnOrderBefore { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnOrderAfter { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyAllocateBefore { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyAllocateAfter { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
