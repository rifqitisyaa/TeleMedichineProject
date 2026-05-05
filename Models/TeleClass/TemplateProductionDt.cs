using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProductionCode", "SequenceNo")]
public partial class TemplateProductionDt
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ProductionCode { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemId { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Qty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

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
    [InverseProperty("TemplateProductionDt")]
    public virtual ChartOfAccount? CoaCodeDebitNavigation { get; set; }

    [ForeignKey("GCReasonOut")]
    [InverseProperty("TemplateProductionDt")]
    public virtual sysGeneralCode GCReasonOutNavigation { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("TemplateProductionDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("TemplateProductionDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("ProductionCode")]
    [InverseProperty("TemplateProductionDt")]
    public virtual TemplateProductionHd ProductionCodeNavigation { get; set; } = null!;

    [InverseProperty("TemplateProductionDt")]
    public virtual ICollection<ProductionDt> ProductionDt { get; set; } = new List<ProductionDt>();
}
