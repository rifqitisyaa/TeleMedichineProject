using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProductionNo", "SequenceNo")]
public partial class ProductionDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProductionNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ProductionCode { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string ProductionSequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? IssuedUnplannedNo { get; set; }

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyTemplate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Qty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ItemCost { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCodeDebit { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCReasonOut { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCodeDebit")]
    [InverseProperty("ProductionDt")]
    public virtual ChartOfAccount? CoaCodeDebitNavigation { get; set; }

    [ForeignKey("GCReasonOut")]
    [InverseProperty("ProductionDt")]
    public virtual sysGeneralCode GCReasonOutNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ProductionDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("ProductionDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("ProductionNo")]
    [InverseProperty("ProductionDt")]
    public virtual ProductionHd ProductionNoNavigation { get; set; } = null!;

    [ForeignKey("ProductionCode, ProductionSequenceNo")]
    [InverseProperty("ProductionDt")]
    public virtual TemplateProductionDt TemplateProductionDt { get; set; } = null!;
}
