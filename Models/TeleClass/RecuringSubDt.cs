using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RecuringID", "SequenceNo")]
public partial class RecuringSubDt
{
    [Key]
    public int RecuringID { get; set; }

    [Key]
    [StringLength(5)]
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

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DebitAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CreditAmount { get; set; }

    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCode")]
    [InverseProperty("RecuringSubDt")]
    public virtual ChartOfAccount CoaCodeNavigation { get; set; } = null!;

    [ForeignKey("DepartmentCode")]
    [InverseProperty("RecuringSubDt")]
    public virtual Department DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("RecuringID")]
    [InverseProperty("RecuringSubDt")]
    public virtual RecuringHd Recuring { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("RecuringSubDt")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("RecuringSubDt")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RecuringSubDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
