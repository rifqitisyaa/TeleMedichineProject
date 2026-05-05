using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DistributionOrderHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DistributionOrderNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string FromSiteCode { get; set; } = null!;

    public int FromSiteDepartmentID { get; set; }

    public int FromServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly DistributionOrderDate { get; set; }

    public int FromLocationID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ToSiteCode { get; set; } = null!;

    public int ToSiteDepartmentID { get; set; }

    public int ToServiceUnitID { get; set; }

    public int ToLocationID { get; set; }

    public byte RevisionNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PreparedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PreparedDateTime { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCDistributionOrderType { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Notes { get; set; } = null!;

    public bool? IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("DistributionOrderNoNavigation")]
    public virtual ICollection<DistributionOrderDt> DistributionOrderDt { get; set; } = new List<DistributionOrderDt>();

    [ForeignKey("FromLocationID")]
    [InverseProperty("DistributionOrderHdFromLocation")]
    public virtual Location FromLocation { get; set; } = null!;

    [ForeignKey("FromServiceUnitID")]
    [InverseProperty("DistributionOrderHdFromServiceUnit")]
    public virtual DepartmentServiceUnit FromServiceUnit { get; set; } = null!;

    [ForeignKey("FromSiteCode")]
    [InverseProperty("DistributionOrderHdFromSiteCodeNavigation")]
    public virtual Site FromSiteCodeNavigation { get; set; } = null!;

    [ForeignKey("FromSiteDepartmentID")]
    [InverseProperty("DistributionOrderHdFromSiteDepartment")]
    public virtual SiteDepartment FromSiteDepartment { get; set; } = null!;

    [ForeignKey("GCDistributionOrderType")]
    [InverseProperty("DistributionOrderHd")]
    public virtual sysGeneralCode GCDistributionOrderTypeNavigation { get; set; } = null!;

    [ForeignKey("ToLocationID")]
    [InverseProperty("DistributionOrderHdToLocation")]
    public virtual Location ToLocation { get; set; } = null!;

    [ForeignKey("ToServiceUnitID")]
    [InverseProperty("DistributionOrderHdToServiceUnit")]
    public virtual DepartmentServiceUnit ToServiceUnit { get; set; } = null!;

    [ForeignKey("ToSiteCode")]
    [InverseProperty("DistributionOrderHdToSiteCodeNavigation")]
    public virtual Site ToSiteCodeNavigation { get; set; } = null!;

    [ForeignKey("ToSiteDepartmentID")]
    [InverseProperty("DistributionOrderHdToSiteDepartment")]
    public virtual SiteDepartment ToSiteDepartment { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("DistributionOrderHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
