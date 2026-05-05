using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeLoanProcessHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProcessNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ProcessDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string PayrollPeriod { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InstalementDateFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InstalementDateTo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ProcessNoNavigation")]
    public virtual ICollection<EmployeeLoanProcessDt> EmployeeLoanProcessDt { get; set; } = new List<EmployeeLoanProcessDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("EmployeeLoanProcessHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("EmployeeLoanProcessHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
