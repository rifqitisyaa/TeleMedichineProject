using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_FactBalanceStock
{
    [Key]
    public int Id { get; set; }

    public int DateId { get; set; }

    public int SiteId { get; set; }

    public int LocationId { get; set; }

    public int ItemId { get; set; }

    public int ItemUnitId { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Amount { get; set; }

    [ForeignKey("DateId")]
    [InverseProperty("DW_FactBalanceStock")]
    public virtual DW_DimDate Date { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("DW_FactBalanceStock")]
    public virtual DW_DimItem Item { get; set; } = null!;

    [ForeignKey("ItemUnitId")]
    [InverseProperty("DW_FactBalanceStock")]
    public virtual DW_DimItemUnit ItemUnit { get; set; } = null!;

    [ForeignKey("LocationId")]
    [InverseProperty("DW_FactBalanceStock")]
    public virtual DW_DimLocation Location { get; set; } = null!;

    [ForeignKey("SiteId")]
    [InverseProperty("DW_FactBalanceStock")]
    public virtual DW_DimSiteCode Site { get; set; } = null!;
}
