using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProcessNo", "SequenceNo")]
public partial class EmployeeLoanProcessDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProcessNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string LoanNo { get; set; } = null!;

    public int InstallmentPaymentNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InstalementDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal InstalementAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeLoanProcessDt")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("LoanNo, InstallmentPaymentNo")]
    [InverseProperty("EmployeeLoanProcessDt")]
    public virtual EmployeeLoanDt EmployeeLoanDt { get; set; } = null!;

    [ForeignKey("ProcessNo")]
    [InverseProperty("EmployeeLoanProcessDt")]
    public virtual EmployeeLoanProcessHd ProcessNoNavigation { get; set; } = null!;
}
