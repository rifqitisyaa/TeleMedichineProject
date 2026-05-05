using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class IssuedUnplannedHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string IssuedUnplannedNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly IssuedUnplannedDate { get; set; }

    public int LocationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCIssuedUnplannedType { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCodeDebit { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CoaCodeCredit { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DepartmentCode { get; set; }

    public int? SiteDepartmentID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ServiceUnitCode { get; set; }

    public int? ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    public bool? IsReviewed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCodeCredit")]
    [InverseProperty("IssuedUnplannedHdCoaCodeCreditNavigation")]
    public virtual ChartOfAccount? CoaCodeCreditNavigation { get; set; }

    [ForeignKey("CoaCodeDebit")]
    [InverseProperty("IssuedUnplannedHdCoaCodeDebitNavigation")]
    public virtual ChartOfAccount? CoaCodeDebitNavigation { get; set; }

    [ForeignKey("DepartmentCode")]
    [InverseProperty("IssuedUnplannedHd")]
    public virtual Department? DepartmentCodeNavigation { get; set; }

    [ForeignKey("GCIssuedUnplannedType")]
    [InverseProperty("IssuedUnplannedHd")]
    public virtual sysGeneralCode GCIssuedUnplannedTypeNavigation { get; set; } = null!;

    [InverseProperty("IssuedUnplannedNoNavigation")]
    public virtual ICollection<IssuedUnplannedDt> IssuedUnplannedDt { get; set; } = new List<IssuedUnplannedDt>();

    [ForeignKey("LocationID")]
    [InverseProperty("IssuedUnplannedHd")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("IssuedUnplannedHd")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("IssuedUnplannedHd")]
    public virtual ServiceUnit? ServiceUnitCodeNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("IssuedUnplannedHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteDepartmentID")]
    [InverseProperty("IssuedUnplannedHd")]
    public virtual SiteDepartment? SiteDepartment { get; set; }

    [ForeignKey("TransactionCode")]
    [InverseProperty("IssuedUnplannedHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
