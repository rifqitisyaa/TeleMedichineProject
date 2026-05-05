using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("MenuID", "ParameterName")]
public partial class sysReportParameter
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ParameterName { get; set; } = null!;

    public bool IsVariable { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ParameterValue { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string CaptionOrMessage { get; set; } = null!;

    public int IndexNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
