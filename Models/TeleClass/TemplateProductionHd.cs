using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TemplateProductionHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ProductionCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ProductionName { get; set; } = null!;

    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ProductionUnit { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Qty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCodeCredit { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCReasonIn { get; set; } = null!;

    public bool? IsOneToMany { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCodeCredit")]
    [InverseProperty("TemplateProductionHd")]
    public virtual ChartOfAccount? CoaCodeCreditNavigation { get; set; }

    [ForeignKey("GCReasonIn")]
    [InverseProperty("TemplateProductionHd")]
    public virtual sysGeneralCode GCReasonInNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("TemplateProductionHd")]
    public virtual Item Item { get; set; } = null!;

    [InverseProperty("ProductionCodeNavigation")]
    public virtual ICollection<ProductionHd> ProductionHd { get; set; } = new List<ProductionHd>();

    [ForeignKey("ProductionUnit")]
    [InverseProperty("TemplateProductionHd")]
    public virtual ItemUnit ProductionUnitNavigation { get; set; } = null!;

    [InverseProperty("ProductionCodeNavigation")]
    public virtual ICollection<TemplateProductionDt> TemplateProductionDt { get; set; } = new List<TemplateProductionDt>();
}
