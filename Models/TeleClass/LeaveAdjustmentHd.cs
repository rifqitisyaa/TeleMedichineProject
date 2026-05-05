using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LeaveAdjustmentHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string LeaveAdjustmentNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LeaveAdjustmentDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string LeaveCode { get; set; } = null!;

    public int AdjustQty { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartEffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndEffectiveDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("LeaveAdjustmentNoNavigation")]
    public virtual ICollection<LeaveAdjustmentDt> LeaveAdjustmentDt { get; set; } = new List<LeaveAdjustmentDt>();

    [ForeignKey("LeaveCode")]
    [InverseProperty("LeaveAdjustmentHd")]
    public virtual LeaveType LeaveCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("LeaveAdjustmentHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("LeaveAdjustmentHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
