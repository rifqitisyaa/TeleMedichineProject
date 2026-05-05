using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("MenuID", "ReportTemplateCode")]
public partial class SysReportInReportTemplate
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ReportTemplateCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MenuID")]
    [InverseProperty("SysReportInReportTemplate")]
    public virtual sysReport Menu { get; set; } = null!;

    [ForeignKey("ReportTemplateCode")]
    [InverseProperty("SysReportInReportTemplate")]
    public virtual ReportTemplate ReportTemplateCodeNavigation { get; set; } = null!;
}
