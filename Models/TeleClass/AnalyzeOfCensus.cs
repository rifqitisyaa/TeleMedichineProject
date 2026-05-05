using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "CensusDateTime", "ServiceUnitID", "ClassCode")]
public partial class AnalyzeOfCensus
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

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    public int PatientBegining { get; set; }

    public int PatientIn { get; set; }

    public int TransferIn { get; set; }

    public int PatientOut { get; set; }

    public int TransferOut { get; set; }

    public int DeathBefore48 { get; set; }

    public int DeathAfter48 { get; set; }

    public int LOS { get; set; }

    public int PatientEnding { get; set; }

    [ForeignKey("ClassCode")]
    [InverseProperty("AnalyzeOfCensus")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("AnalyzeOfCensus")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("AnalyzeOfCensus")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
