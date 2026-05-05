using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("FromLocationID", "ItemID")]
public partial class DistributionOrderPlanned
{
    [Key]
    public int FromLocationID { get; set; }

    [Key]
    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FromSiteCode { get; set; } = null!;

    public int FromSiteDepartmentID { get; set; }

    public int FromServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ToSiteCode { get; set; }

    public int? ToSiteDepartmentID { get; set; }

    public int? ToServiceUnitID { get; set; }

    public int? ToLocationID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnHand { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnRequest { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnCalculation { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    public bool IsProcess { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("FromLocationID")]
    [InverseProperty("DistributionOrderPlannedFromLocation")]
    public virtual Location FromLocation { get; set; } = null!;

    [ForeignKey("FromServiceUnitID")]
    [InverseProperty("DistributionOrderPlannedFromServiceUnit")]
    public virtual DepartmentServiceUnit FromServiceUnit { get; set; } = null!;

    [ForeignKey("FromSiteCode")]
    [InverseProperty("DistributionOrderPlannedFromSiteCodeNavigation")]
    public virtual Site FromSiteCodeNavigation { get; set; } = null!;

    [ForeignKey("FromSiteDepartmentID")]
    [InverseProperty("DistributionOrderPlannedFromSiteDepartment")]
    public virtual SiteDepartment FromSiteDepartment { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("DistributionOrderPlanned")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("DistributionOrderPlanned")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("ToLocationID")]
    [InverseProperty("DistributionOrderPlannedToLocation")]
    public virtual Location? ToLocation { get; set; }

    [ForeignKey("ToServiceUnitID")]
    [InverseProperty("DistributionOrderPlannedToServiceUnit")]
    public virtual DepartmentServiceUnit? ToServiceUnit { get; set; }

    [ForeignKey("ToSiteCode")]
    [InverseProperty("DistributionOrderPlannedToSiteCodeNavigation")]
    public virtual Site? ToSiteCodeNavigation { get; set; }

    [ForeignKey("ToSiteDepartmentID")]
    [InverseProperty("DistributionOrderPlannedToSiteDepartment")]
    public virtual SiteDepartment? ToSiteDepartment { get; set; }
}
