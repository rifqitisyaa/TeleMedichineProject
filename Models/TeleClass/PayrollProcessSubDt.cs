using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PayrollProcessNo", "EmployeeId")]
public partial class PayrollProcessSubDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PayrollProcessNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCAGCEmployee { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalBasicSalaryAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAllowanceAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalTaxAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalJHTAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalAmount { get; set; }

    public int? CostServiceUnitId { get; set; }

    public bool? IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ProceedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProceedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("PayrollProcessSubDt")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("GCAGCEmployee")]
    [InverseProperty("PayrollProcessSubDt")]
    public virtual sysGeneralCode GCAGCEmployeeNavigation { get; set; } = null!;

    [InverseProperty("PayrollProcessSubDt")]
    public virtual ICollection<PayrollPaymentPlanDt> PayrollPaymentPlanDt { get; set; } = new List<PayrollPaymentPlanDt>();

    [ForeignKey("PayrollProcessNo")]
    [InverseProperty("PayrollProcessSubDt")]
    public virtual PayrollProcessHd PayrollProcessNoNavigation { get; set; } = null!;
}
