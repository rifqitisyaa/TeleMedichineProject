using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SIteCode", "CensusDateTime", "ClassCode")]
public partial class AnalyzeOfCensusTotalBedClass
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SIteCode { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime CensusDateTime { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    public int TotalBed { get; set; }

    public int IsBor { get; set; }
}
