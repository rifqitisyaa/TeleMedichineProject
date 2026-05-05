using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ReportID", "RowId", "Periode")]
public partial class RLData
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ReportID { get; set; } = null!;

    [Key]
    public long RowId { get; set; }

    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Periode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string value { get; set; } = null!;

    [ForeignKey("ReportID")]
    [InverseProperty("RLData")]
    public virtual RLTemplateHd Report { get; set; } = null!;

    [ForeignKey("RowId")]
    [InverseProperty("RLData")]
    public virtual RLTemplateDt Row { get; set; } = null!;
}
