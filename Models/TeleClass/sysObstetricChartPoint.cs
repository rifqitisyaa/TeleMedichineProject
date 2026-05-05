using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SeriesType", "SeriesName", "Age", "Point")]
public partial class sysObstetricChartPoint
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SeriesType { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SeriesName { get; set; } = null!;

    [Key]
    [Column(TypeName = "numeric(6, 2)")]
    public decimal Age { get; set; }

    [Key]
    [Column(TypeName = "numeric(6, 2)")]
    public decimal Point { get; set; }
}
