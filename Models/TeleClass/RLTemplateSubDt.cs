using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ReportID", "FieldName")]
public partial class RLTemplateSubDt
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ReportID { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string FieldName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CaptionName { get; set; } = null!;

    public int IndexNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GroupHeader { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GroupHeader1 { get; set; }

    public bool IsEntry { get; set; }

    public bool IsVisible { get; set; }

    public bool? IsTotalRow { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TotalRowFormula { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? ColumnWidth { get; set; }

    [ForeignKey("ReportID")]
    [InverseProperty("RLTemplateSubDt")]
    public virtual RLTemplateHd Report { get; set; } = null!;
}
