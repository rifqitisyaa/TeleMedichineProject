using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RLTemplateHd
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ReportID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ReportName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? RLVersion { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    public bool IsUseMonthPeriod { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? StoredProceduredName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MenuId { get; set; }

    [InverseProperty("Report")]
    public virtual ICollection<RLData> RLData { get; set; } = new List<RLData>();

    [InverseProperty("Report")]
    public virtual ICollection<RLTemplateDt> RLTemplateDt { get; set; } = new List<RLTemplateDt>();

    [InverseProperty("Report")]
    public virtual ICollection<RLTemplateSubDt> RLTemplateSubDt { get; set; } = new List<RLTemplateSubDt>();
}
