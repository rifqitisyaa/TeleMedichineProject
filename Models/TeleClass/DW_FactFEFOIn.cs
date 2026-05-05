using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_FactFEFOIn
{
    [Key]
    public int ID { get; set; }

    public int DateID { get; set; }

    public int SiteID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    public int TransactionDateID { get; set; }

    public int TransactionDateTimeID { get; set; }

    public int LocationID { get; set; }

    public int ItemID { get; set; }

    public int ItemUnitID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal QtyIn { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PWA { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string BatchNo { get; set; } = null!;

    public DateOnly ExpiredDate { get; set; }

    public bool IsGeneratedBatchNo { get; set; }

    public bool IsGeneratedExpiredDate { get; set; }

    public int? ReferenceID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal RemainingQty { get; set; }

    public bool? IsUpdate { get; set; }

    [ForeignKey("DateID")]
    [InverseProperty("DW_FactFEFOInDate")]
    public virtual DW_DimDate Date { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("DW_FactFEFOIn")]
    public virtual DW_DimItem Item { get; set; } = null!;

    [ForeignKey("ItemUnitID")]
    [InverseProperty("DW_FactFEFOIn")]
    public virtual DW_DimItemUnit ItemUnit { get; set; } = null!;

    [ForeignKey("LocationID")]
    [InverseProperty("DW_FactFEFOIn")]
    public virtual DW_DimLocation Location { get; set; } = null!;

    [ForeignKey("SiteID")]
    [InverseProperty("DW_FactFEFOIn")]
    public virtual DW_DimSiteCode Site { get; set; } = null!;

    [ForeignKey("TransactionDateID")]
    [InverseProperty("DW_FactFEFOInTransactionDate")]
    public virtual DW_DimDate TransactionDate { get; set; } = null!;

    [ForeignKey("TransactionDateTimeID")]
    [InverseProperty("DW_FactFEFOIn")]
    public virtual DW_DimTime TransactionDateTime { get; set; } = null!;
}
