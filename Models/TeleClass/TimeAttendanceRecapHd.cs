using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TimeAttendanceRecapHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocumentDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? PayrollPeriod { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("TimeAttendanceRecapHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("DocumentNoNavigation")]
    public virtual ICollection<TimeAttendanceRecapDt> TimeAttendanceRecapDt { get; set; } = new List<TimeAttendanceRecapDt>();

    [ForeignKey("TransactionCode")]
    [InverseProperty("TimeAttendanceRecapHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
