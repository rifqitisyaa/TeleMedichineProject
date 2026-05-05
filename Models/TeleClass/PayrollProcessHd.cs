using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PayrollProcessHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PayrollProcessNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PayrollProcessDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PayrollPeriod { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCPayrollGroup { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? LastProcessDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PeriodFromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PeriodToDate { get; set; }

    public bool? IsReviewed { get; set; }

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

    [InverseProperty("PayrollProcessNoNavigation")]
    public virtual ICollection<PayrollPaymentPlanDt> PayrollPaymentPlanDt { get; set; } = new List<PayrollPaymentPlanDt>();

    [InverseProperty("PayrollProcessNoNavigation")]
    public virtual ICollection<PayrollProcessSubDt> PayrollProcessSubDt { get; set; } = new List<PayrollProcessSubDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("PayrollProcessHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("PayrollProcessHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
