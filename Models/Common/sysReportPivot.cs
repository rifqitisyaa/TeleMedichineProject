using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("MenuID", "PivotArea", "Caption")]
public partial class sysReportPivot
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [Key]
    public int PivotArea { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Caption { get; set; } = null!;

    public int IndexNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FieldName { get; set; } = null!;

    public int GroupInterval { get; set; }

    public int SummaryType { get; set; }

    public int FormatType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FormatString { get; set; } = null!;
}
