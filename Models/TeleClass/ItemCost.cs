using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "ItemID")]
public partial class ItemCost
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PreviousMaterial { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CurrentMaterial { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal? Material { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PreviousLabor { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CurrentLabor { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal? Labor { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PreviousOverhead { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CurrentOverhead { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal? Overhead { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PreviousSubContract { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CurrentSubContract { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal? SubContract { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PreviousBurden { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CurrentBurden { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal? Burden { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ItemCost")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemCost")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
