using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GCSex", "AgeGroup", "Age", "SeriesName", "SeriesType", "ChartType")]
public partial class sysGrowthChartPoint
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AgeGroup { get; set; } = null!;

    [Key]
    public double Age { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SeriesName { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SeriesType { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ChartType { get; set; } = null!;

    [Column(TypeName = "numeric(1, 0)")]
    public decimal SeriesWidth { get; set; }

    public double Point { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("sysGrowthChartPoint")]
    public virtual sysGeneralCode GCSexNavigation { get; set; } = null!;
}
