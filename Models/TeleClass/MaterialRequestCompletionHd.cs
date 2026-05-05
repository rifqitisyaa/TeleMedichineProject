using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MaterialRequestCompletionHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MRCompletionNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly MRCompletionDate { get; set; }

    public int FromServiceUnitId { get; set; }

    public int ToServiceUnitId { get; set; }

    public int FromLocationId { get; set; }

    public int ToLocationId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCMRComplitionType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CoaCodeDebit { get; set; } = null!;

    public byte RevisionNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

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

    [ForeignKey("CoaCodeDebit")]
    [InverseProperty("MaterialRequestCompletionHd")]
    public virtual ChartOfAccount CoaCodeDebitNavigation { get; set; } = null!;

    [ForeignKey("FromLocationId")]
    [InverseProperty("MaterialRequestCompletionHdFromLocation")]
    public virtual Location FromLocation { get; set; } = null!;

    [ForeignKey("FromServiceUnitId")]
    [InverseProperty("MaterialRequestCompletionHdFromServiceUnit")]
    public virtual DepartmentServiceUnit FromServiceUnit { get; set; } = null!;

    [ForeignKey("GCMRComplitionType")]
    [InverseProperty("MaterialRequestCompletionHd")]
    public virtual sysGeneralCode GCMRComplitionTypeNavigation { get; set; } = null!;

    [InverseProperty("MRCompletionNoNavigation")]
    public virtual ICollection<MaterialRequestCompletionDt> MaterialRequestCompletionDt { get; set; } = new List<MaterialRequestCompletionDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("MaterialRequestCompletionHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("ToLocationId")]
    [InverseProperty("MaterialRequestCompletionHdToLocation")]
    public virtual Location ToLocation { get; set; } = null!;

    [ForeignKey("ToServiceUnitId")]
    [InverseProperty("MaterialRequestCompletionHdToServiceUnit")]
    public virtual DepartmentServiceUnit ToServiceUnit { get; set; } = null!;
}
