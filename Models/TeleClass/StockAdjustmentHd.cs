using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class StockAdjustmentHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AdjustmentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AdjustmentDate { get; set; }

    public int LocationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCAdjustmentType { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DepartmentCode { get; set; }

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

    [ForeignKey("DepartmentCode")]
    [InverseProperty("StockAdjustmentHd")]
    public virtual Department? DepartmentCodeNavigation { get; set; }

    [ForeignKey("GCAdjustmentType")]
    [InverseProperty("StockAdjustmentHd")]
    public virtual sysGeneralCode GCAdjustmentTypeNavigation { get; set; } = null!;

    [ForeignKey("LocationID")]
    [InverseProperty("StockAdjustmentHd")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("StockAdjustmentHd")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("StockAdjustmentHd")]
    public virtual ServiceUnit? ServiceUnitCodeNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("StockAdjustmentHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("AdjustmentNoNavigation")]
    public virtual ICollection<StockAdjustmentDt> StockAdjustmentDt { get; set; } = new List<StockAdjustmentDt>();

    [ForeignKey("TransactionCode")]
    [InverseProperty("StockAdjustmentHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
