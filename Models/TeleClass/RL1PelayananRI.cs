using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRLType", "RLReportID", "Period")]
public partial class RL1PelayananRI
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

    public int AwalTriwulan { get; set; }

    public int Masuk { get; set; }

    public int KeluarHidup { get; set; }

    public int KeluarMatiKurang48 { get; set; }

    public int KeluarMatiLebih48 { get; set; }

    public int LamaDirawat { get; set; }

    public int AkhirTriwulan { get; set; }

    public int HariPerawatan { get; set; }

    public int KelasUtama { get; set; }

    public int Kelas1 { get; set; }

    public int Kelas2 { get; set; }

    public int Kelas3 { get; set; }

    public int NonKelas { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCRLType, RLReportID")]
    [InverseProperty("RL1PelayananRI")]
    public virtual RLReportTemplate RLReportTemplate { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL1PelayananRI")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
