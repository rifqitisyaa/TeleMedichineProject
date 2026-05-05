using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JournalNo", "SequenceNo")]
public partial class JournalCashBankDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JournalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CoaCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Notes { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Debit { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Credit { get; set; }

    public bool IsHeader { get; set; }

    public bool IsVerification { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCode")]
    [InverseProperty("JournalCashBankDt")]
    public virtual ChartOfAccount CoaCodeNavigation { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("JournalCashBankDt")]
    public virtual Department DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("JournalNo")]
    [InverseProperty("JournalCashBankDt")]
    public virtual JournalCashBankHd JournalNoNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("JournalCashBankDt")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("JournalCashBankDt")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("JournalCashBankDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
