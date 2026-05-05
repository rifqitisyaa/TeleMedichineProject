using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysReport
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReportType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReportPeriod { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? AssemblyName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ClassName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ProcedureName { get; set; }

    public int? IndexNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SubReport { get; set; }

    [ForeignKey("MenuID")]
    [InverseProperty("sysReport")]
    public virtual sysMenu Menu { get; set; } = null!;

    [InverseProperty("Menu")]
    public virtual ICollection<SysReportInReportTemplate> SysReportInReportTemplate { get; set; } = new List<SysReportInReportTemplate>();
}
