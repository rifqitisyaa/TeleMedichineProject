using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRL5Type", "RLReportID", "Period")]
public partial class RL5DataPeralatanMedik
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCRL5Type { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string RLReportID { get; set; } = null!;

    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    public int Jumlah { get; set; }

    public int Umur5th { get; set; }

    public int Umur5sd10th { get; set; }

    public int UmurAtas10th { get; set; }

    public int Kapasitas { get; set; }

    public int KondisiBaik { get; set; }

    public int KondisiRusakRingan { get; set; }

    public int KondisiRusakBerat { get; set; }

    public int IjinAda { get; set; }

    public int IjinTidakAda { get; set; }

    public int SertifikatAda { get; set; }

    public int SertifikatTidakAda { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCRL5Type, RLReportID")]
    [InverseProperty("RL5DataPeralatanMedik")]
    public virtual RLReportTemplate RLReportTemplate { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL5DataPeralatanMedik")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
