using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PaymentPlanNo", "SequenceNo")]
public partial class PayrollPaymentPlanDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentPlanNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string PayrollProcessNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OutstandingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("PayrollProcessNo")]
    [InverseProperty("PayrollPaymentPlanDt")]
    public virtual PayrollProcessHd PayrollProcessNoNavigation { get; set; } = null!;

    [ForeignKey("PayrollProcessNo, EmployeeId")]
    [InverseProperty("PayrollPaymentPlanDt")]
    public virtual PayrollProcessSubDt PayrollProcessSubDt { get; set; } = null!;
}
