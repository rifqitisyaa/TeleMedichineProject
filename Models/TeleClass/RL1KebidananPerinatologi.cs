using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRLType", "RLReportID", "Period")]
public partial class RL1KebidananPerinatologi
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCRLType { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string RLReportID { get; set; } = null!;

    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    public int BeratBayiLebih2500 { get; set; }

    public int BeratBayiKurang2500 { get; set; }

    public int JumlahRujukan { get; set; }

    public int RujukanMati { get; set; }

    public int JumlahNonRujukan { get; set; }

    public int NonRujukanMati { get; set; }

    public int DirujukKeAtas { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCRLType, RLReportID")]
    [InverseProperty("RL1KebidananPerinatologi")]
    public virtual RLReportTemplate RLReportTemplate { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL1KebidananPerinatologi")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
