using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class ReportTemplate
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ReportTemplateCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ReportTemplateName { get; set; } = null!;

    public int IndexNo { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ReportTemplateCodeNavigation")]
    public virtual ICollection<SysReportInReportTemplate> SysReportInReportTemplate { get; set; } = new List<SysReportInReportTemplate>();
}
