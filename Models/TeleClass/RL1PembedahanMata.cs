using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRLType", "RLReportID", "Period")]
public partial class RL1PembedahanMata
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

    public int Baik { get; set; }

    public int Sedang { get; set; }

    public int Buruk { get; set; }

    public int TurunObatPositif { get; set; }

    public int TurunObatNegatif { get; set; }

    public int Tetap { get; set; }

    public int PerbaikanAnatromik { get; set; }

    public int PerbaikanVisus { get; set; }

    public int PerbaikanKualitasPositif { get; set; }

    public int PerbaikanKualitasNegatif { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCRLType, RLReportID")]
    [InverseProperty("RL1PembedahanMata")]
    public virtual RLReportTemplate RLReportTemplate { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL1PembedahanMata")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
