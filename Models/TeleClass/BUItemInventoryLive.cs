using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BUItemInventoryLive
{
    public int LocationID { get; set; }

    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyOnHand { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyOnRequest { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyOnGIT { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyOnOrder { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? QtyAllocate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
