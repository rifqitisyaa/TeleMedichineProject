using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("SiteCode", "DepartmentCode", Name = "UNIQUE_IX_SiteDepartment", IsUnique = true)]
public partial class SiteDepartment
{
    [Key]
    public int SiteDepartmentID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string OfficerName { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("SiteDepartment")]
    public virtual ICollection<BudgetHd> BudgetHd { get; set; } = new List<BudgetHd>();

    [ForeignKey("DepartmentCode")]
    [InverseProperty("SiteDepartment")]
    public virtual Department DepartmentCodeNavigation { get; set; } = null!;

    [InverseProperty("SiteDepartment")]
    public virtual ICollection<DepartmentServiceUnit> DepartmentServiceUnit { get; set; } = new List<DepartmentServiceUnit>();

    [InverseProperty("SiteDepartment")]
    public virtual ICollection<DirectPurchaseHd> DirectPurchaseHd { get; set; } = new List<DirectPurchaseHd>();

    [InverseProperty("FromSiteDepartment")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHdFromSiteDepartment { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("ToSiteDepartment")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHdToSiteDepartment { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("FromSiteDepartment")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlannedFromSiteDepartment { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("ToSiteDepartment")]
    public virtual ICollection<DistributionOrderPlanned> DistributionOrderPlannedToSiteDepartment { get; set; } = new List<DistributionOrderPlanned>();

    [InverseProperty("SiteDepartment")]
    public virtual ICollection<ForecastHd> ForecastHd { get; set; } = new List<ForecastHd>();

    [InverseProperty("SiteDepartment")]
    public virtual ICollection<IncomeTaxByDepartment> IncomeTaxByDepartment { get; set; } = new List<IncomeTaxByDepartment>();

    [InverseProperty("SiteDepartment")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHd { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("FromSiteDepartment")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHdFromSiteDepartment { get; set; } = new List<OutstandingDOHd>();

    [InverseProperty("ToSiteDepartment")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHdToSiteDepartment { get; set; } = new List<OutstandingDOHd>();

    [InverseProperty("SiteDepartment")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHd { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("SiteDepartment")]
    public virtual ICollection<ServiceUnitJobOrderType> ServiceUnitJobOrderType { get; set; } = new List<ServiceUnitJobOrderType>();

    [ForeignKey("SiteCode")]
    [InverseProperty("SiteDepartment")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("FromSiteDepartment")]
    public virtual ICollection<TransferOrderHd> TransferOrderHdFromSiteDepartment { get; set; } = new List<TransferOrderHd>();

    [InverseProperty("ToSiteDepartment")]
    public virtual ICollection<TransferOrderHd> TransferOrderHdToSiteDepartment { get; set; } = new List<TransferOrderHd>();
}
