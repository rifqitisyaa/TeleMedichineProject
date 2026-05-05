using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ProductionHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProductionNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ProductionDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ProductionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ReceivedUnplannedNo { get; set; }

    public int ServiceUnitID { get; set; }

    public int LocationID { get; set; }

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyTemplate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyProduction { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCodeCredit { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReasonIn { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsOneToMany { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCodeCredit")]
    [InverseProperty("ProductionHd")]
    public virtual ChartOfAccount? CoaCodeCreditNavigation { get; set; }

    [ForeignKey("GCReasonIn")]
    [InverseProperty("ProductionHd")]
    public virtual sysGeneralCode? GCReasonInNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ProductionHd")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("ProductionHd")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("LocationID")]
    [InverseProperty("ProductionHd")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("ProductionCode")]
    [InverseProperty("ProductionHd")]
    public virtual TemplateProductionHd ProductionCodeNavigation { get; set; } = null!;

    [InverseProperty("ProductionNoNavigation")]
    public virtual ICollection<ProductionDt> ProductionDt { get; set; } = new List<ProductionDt>();

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ProductionHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ProductionHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ProductionHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
