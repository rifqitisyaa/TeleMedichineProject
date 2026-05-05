using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DirectPurchaseHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DirectPurchaseNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int SiteDepartmentID { get; set; }

    public int ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public byte? RevisionNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DirectPurchaseDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Supplier { get; set; } = null!;

    public int LocationID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmount { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("DirectPurchaseNoNavigation")]
    public virtual ICollection<DirectPurchaseDt> DirectPurchaseDt { get; set; } = new List<DirectPurchaseDt>();

    [ForeignKey("LocationID")]
    [InverseProperty("DirectPurchaseHd")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("DirectPurchaseHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("DirectPurchaseHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteDepartmentID")]
    [InverseProperty("DirectPurchaseHd")]
    public virtual SiteDepartment SiteDepartment { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("DirectPurchaseHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
