using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReceivedUnplannedHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReceivedUnplannedNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly ReceivedUnplannedDate { get; set; }

    public int LocationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCReceivedUnplannedType { get; set; } = null!;

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

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCodeCredit")]
    [InverseProperty("ReceivedUnplannedHdCoaCodeCreditNavigation")]
    public virtual ChartOfAccount? CoaCodeCreditNavigation { get; set; }

    [ForeignKey("CoaCodeDebit")]
    [InverseProperty("ReceivedUnplannedHdCoaCodeDebitNavigation")]
    public virtual ChartOfAccount? CoaCodeDebitNavigation { get; set; }

    [ForeignKey("DepartmentCode")]
    [InverseProperty("ReceivedUnplannedHd")]
    public virtual Department? DepartmentCodeNavigation { get; set; }

    [ForeignKey("GCReceivedUnplannedType")]
    [InverseProperty("ReceivedUnplannedHd")]
    public virtual sysGeneralCode GCReceivedUnplannedTypeNavigation { get; set; } = null!;

    [ForeignKey("LocationID")]
    [InverseProperty("ReceivedUnplannedHd")]
    public virtual Location Location { get; set; } = null!;

    [InverseProperty("ReceivedUnplannedNoNavigation")]
    public virtual ICollection<ReceivedUnplannedDt> ReceivedUnplannedDt { get; set; } = new List<ReceivedUnplannedDt>();

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ReceivedUnplannedHd")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("ReceivedUnplannedHd")]
    public virtual ServiceUnit? ServiceUnitCodeNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("ReceivedUnplannedHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteDepartmentID")]
    [InverseProperty("ReceivedUnplannedHd")]
    public virtual SiteDepartment? SiteDepartment { get; set; }

    [ForeignKey("TransactionCode")]
    [InverseProperty("ReceivedUnplannedHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
