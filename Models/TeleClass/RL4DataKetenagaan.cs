using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRL4Type", "RLReportID", "Period")]
public partial class RL4DataKetenagaan
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCRL4Type { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string RLReportID { get; set; } = null!;

    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    public int FtDepKes { get; set; }

    public int FtPemdaProp { get; set; }

    public int FtPemdaKabKota { get; set; }

    public int FtDepDikNas { get; set; }

    public int FtTniPolri { get; set; }

    public int FtDepLainBUMN { get; set; }

    public int FtPtt { get; set; }

    public int FtSwasta { get; set; }

    public int FtKontrak { get; set; }

    public int FtSubTotal { get; set; }

    public int PtDepKes { get; set; }

    public int PtPemdaProp { get; set; }

    public int PtPemdaKabKota { get; set; }

    public int PtDepDikNas { get; set; }

    public int PtTniPolri { get; set; }

    public int PtDepLainBUMN { get; set; }

    public int PtPtt { get; set; }

    public int PtSwasta { get; set; }

    public int PtSubTotal { get; set; }

    public int Honorer { get; set; }

    public int Total { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCRL4Type")]
    [InverseProperty("RL4DataKetenagaan")]
    public virtual sysGeneralCode GCRL4TypeNavigation { get; set; } = null!;

    [ForeignKey("GCRL4Type, RLReportID")]
    [InverseProperty("RL4DataKetenagaan")]
    public virtual RLReportTemplate RLReportTemplate { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL4DataKetenagaan")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
