using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class sysGrowthChartPointBackUp
{
    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string AgeGroup { get; set; } = null!;

    public double Age { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SeriesName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SeriesType { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ChartType { get; set; } = null!;

    [Column(TypeName = "numeric(1, 0)")]
    public decimal SeriesWidth { get; set; }

    public double Point { get; set; }
}
