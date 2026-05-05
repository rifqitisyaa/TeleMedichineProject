using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "ItemID")]
public partial class ItemPlanning
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCOrderPolicy { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal OrderQty { get; set; }

    public short OrderPeriod { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal SafetyStock { get; set; }

    public short SafetyTime { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal MinOrderQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal MaxOrderQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal OrderMultiply { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ReorderPoint { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal TolerancePercentage { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Buyer { get; set; } = null!;

    public int? BusinessPartnerID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PoSiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PurchasingOrManufacturing { get; set; } = null!;

    public byte PurchasingLeadTime { get; set; }

    public byte ManufactureLeadTime { get; set; }

    public byte CumulativeLeadTime { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal ReceivingPercentage { get; set; }

    public int? PeriodeInventory { get; set; }

    public bool IsMasterSchedule { get; set; }

    public bool IsPlanOrders { get; set; }

    public bool IsMRPRequired { get; set; }

    public bool IsIssuePolicy { get; set; }

    public bool IsPhantom { get; set; }

    public short TimeFence { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal OrderPriceTolerance { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("ItemPlanning")]
    public virtual BusinessPartner? BusinessPartner { get; set; }

    [ForeignKey("GCOrderPolicy")]
    [InverseProperty("ItemPlanning")]
    public virtual sysGeneralCode GCOrderPolicyNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ItemPlanning")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("PoSiteCode")]
    [InverseProperty("ItemPlanningPoSiteCodeNavigation")]
    public virtual Site? PoSiteCodeNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemPlanningSiteCodeNavigation")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
