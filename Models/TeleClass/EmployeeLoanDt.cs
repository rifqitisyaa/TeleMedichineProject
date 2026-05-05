using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("LoanNo", "InstallmentPaymentNo")]
public partial class EmployeeLoanDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string LoanNo { get; set; } = null!;

    [Key]
    public int InstallmentPaymentNo { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BeginningBalance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BasicPaymentAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal InterestAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalPaymentAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal RemainingLoanAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AccumulatedPaidAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("EmployeeLoanDt")]
    public virtual ICollection<EmployeeLoanProcessDt> EmployeeLoanProcessDt { get; set; } = new List<EmployeeLoanProcessDt>();

    [ForeignKey("LoanNo")]
    [InverseProperty("EmployeeLoanDt")]
    public virtual EmployeeLoanHd LoanNoNavigation { get; set; } = null!;
}
