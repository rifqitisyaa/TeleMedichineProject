using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "CensusDateTime", "ServiceUnitID")]
public partial class AnalyzeOfCensusTotalBed
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime CensusDateTime { get; set; }

    [Key]
    public int ServiceUnitID { get; set; }

    public int TotalBed { get; set; }

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("AnalyzeOfCensusTotalBed")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("AnalyzeOfCensusTotalBed")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
