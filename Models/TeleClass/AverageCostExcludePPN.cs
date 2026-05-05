using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "Year", "Period", "CalculatedDateTime", "ItemID")]
public partial class AverageCostExcludePPN
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int Year { get; set; }

    [Key]
    public int Period { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime CalculatedDateTime { get; set; }

    [Key]
    public int ItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BeforeCalculatedDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal BeginingQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BeginingAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal CurrentInQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CurrentInAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal UnplannedReceiptQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal UnplannedReceiptAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal AdjustmentInQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AdjustmentInAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal CurrentOutQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CurrentOutAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal UnplannedIssueQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal UnplannedIssueAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal AdjustmentOutQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AdjustmentOutAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal EndingQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal EndingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaterialCostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? VarianceAmount { get; set; }

    public bool IsFromAverageCost { get; set; }

    public bool IsFromInventoryRevaluation { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
