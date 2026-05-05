using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRLType", "RLReportID", "Period")]
public partial class RL1Pembedahan
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

    public int KhususKamarBedah { get; set; }

    public int KhususUnitDarurat { get; set; }

    public int BesarKamarBedah { get; set; }

    public int BesarUnitDarurat { get; set; }

    public int SedangKamarBedah { get; set; }

    public int SedangUnitDarurat { get; set; }

    public int KecilKamarBedah { get; set; }

    public int KecilUnitDarurat { get; set; }

    public int KecilPoliklinik { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCRLType, RLReportID")]
    [InverseProperty("RL1Pembedahan")]
    public virtual RLReportTemplate RLReportTemplate { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL1Pembedahan")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
