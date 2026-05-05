using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "ItemID", "POReleaseDate", "SequenceNo", "LocationID")]
public partial class PurchaseOrderPlannedByLocation
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Key]
    public DateOnly POReleaseDate { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int LocationID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnHand { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnRequest { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnOrder { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyCalculation { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    public int? BusinessPartnerID { get; set; }

    public DateOnly PODueDate { get; set; }

    public bool IsProcess { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
