using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "CoaCode")]
public partial class AccountAccrualReset
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string CoaCode { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCode")]
    [InverseProperty("AccountAccrualReset")]
    public virtual ChartOfAccount CoaCodeNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("AccountAccrualReset")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("AccountAccrualReset")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
