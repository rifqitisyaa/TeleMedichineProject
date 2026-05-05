using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TransferOrderHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransferOrderNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransferOrderDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FromSiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ToSiteCode { get; set; } = null!;

    public int FromLocationID { get; set; }

    public int ToLocationID { get; set; }

    public int FromSiteDepartmentID { get; set; }

    public int ToSiteDepartmentID { get; set; }

    public int FromServiceUnitID { get; set; }

    public int ToServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public byte? RevisionNo { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal POAmount { get; set; }

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

    [ForeignKey("FromLocationID")]
    [InverseProperty("TransferOrderHdFromLocation")]
    public virtual Location FromLocation { get; set; } = null!;

    [ForeignKey("FromServiceUnitID")]
    [InverseProperty("TransferOrderHdFromServiceUnit")]
    public virtual DepartmentServiceUnit FromServiceUnit { get; set; } = null!;

    [ForeignKey("FromSiteCode")]
    [InverseProperty("TransferOrderHdFromSiteCodeNavigation")]
    public virtual Site FromSiteCodeNavigation { get; set; } = null!;

    [ForeignKey("FromSiteDepartmentID")]
    [InverseProperty("TransferOrderHdFromSiteDepartment")]
    public virtual SiteDepartment FromSiteDepartment { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("TransferOrderHdSiteCodeNavigation")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("ToLocationID")]
    [InverseProperty("TransferOrderHdToLocation")]
    public virtual Location ToLocation { get; set; } = null!;

    [ForeignKey("ToServiceUnitID")]
    [InverseProperty("TransferOrderHdToServiceUnit")]
    public virtual DepartmentServiceUnit ToServiceUnit { get; set; } = null!;

    [ForeignKey("ToSiteCode")]
    [InverseProperty("TransferOrderHdToSiteCodeNavigation")]
    public virtual Site ToSiteCodeNavigation { get; set; } = null!;

    [ForeignKey("ToSiteDepartmentID")]
    [InverseProperty("TransferOrderHdToSiteDepartment")]
    public virtual SiteDepartment ToSiteDepartment { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("TransferOrderHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;

    [InverseProperty("TransferOrderNoNavigation")]
    public virtual ICollection<TransferOrderDt> TransferOrderDt { get; set; } = new List<TransferOrderDt>();
}
