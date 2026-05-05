using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MaterialRequestHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MaterialRequestNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MaterialRequestDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    public int FromLocationID { get; set; }

    public int ToLocationID { get; set; }

    public int FromServiceUnitID { get; set; }

    public int ToServiceUnitID { get; set; }

    public bool IsDifferentSite { get; set; }

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

    [Unicode(false)]
    public string Notes { get; set; } = null!;

    public bool IsApproved { get; set; }

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
    [InverseProperty("MaterialRequestHdFromLocation")]
    public virtual Location FromLocation { get; set; } = null!;

    [ForeignKey("FromServiceUnitID")]
    [InverseProperty("MaterialRequestHdFromServiceUnit")]
    public virtual DepartmentServiceUnit FromServiceUnit { get; set; } = null!;

    [ForeignKey("GCItemType")]
    [InverseProperty("MaterialRequestHd")]
    public virtual sysGeneralCode GCItemTypeNavigation { get; set; } = null!;

    [InverseProperty("MaterialRequestNoNavigation")]
    public virtual ICollection<MaterialRequestDt> MaterialRequestDt { get; set; } = new List<MaterialRequestDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("MaterialRequestHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("ToLocationID")]
    [InverseProperty("MaterialRequestHdToLocation")]
    public virtual Location ToLocation { get; set; } = null!;

    [ForeignKey("ToServiceUnitID")]
    [InverseProperty("MaterialRequestHdToServiceUnit")]
    public virtual DepartmentServiceUnit ToServiceUnit { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("MaterialRequestHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
