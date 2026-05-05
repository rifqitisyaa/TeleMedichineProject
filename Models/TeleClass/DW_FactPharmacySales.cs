using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("DateID", "SiteID", "ItemID", Name = "IX_DW_FactPharmacySales", IsUnique = true)]
public partial class DW_FactPharmacySales
{
    [Key]
    public int ID { get; set; }

    public int DateID { get; set; }

    public int SiteID { get; set; }

    public int ItemID { get; set; }

    public int ItemUnitID { get; set; }

    public int? ItemPlanningID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BeginningBalance { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal QtyIn { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal QtyOut { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal EndingBalance { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalIssue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CalculatedPWA { get; set; }

    public int CountIssue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Average { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PeakIssue { get; set; }

    [ForeignKey("DateID")]
    [InverseProperty("DW_FactPharmacySales")]
    public virtual DW_DimDate Date { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("DW_FactPharmacySales")]
    public virtual DW_DimItem Item { get; set; } = null!;

    [ForeignKey("ItemPlanningID")]
    [InverseProperty("DW_FactPharmacySales")]
    public virtual DW_DimItemPlanning? ItemPlanning { get; set; }

    [ForeignKey("ItemUnitID")]
    [InverseProperty("DW_FactPharmacySales")]
    public virtual DW_DimItemUnit ItemUnit { get; set; } = null!;

    [ForeignKey("SiteID")]
    [InverseProperty("DW_FactPharmacySales")]
    public virtual DW_DimSiteCode Site { get; set; } = null!;
}
