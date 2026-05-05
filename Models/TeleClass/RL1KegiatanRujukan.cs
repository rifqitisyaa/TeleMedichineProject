using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRLType", "RLReportID", "Period")]
public partial class RL1KegiatanRujukan
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

    public int RumahSakitTotalKali { get; set; }

    public int RumahSakitTotalR { get; set; }

    public int PuskesmasTotalKali { get; set; }

    public int PuskesmasTotal { get; set; }

    public int KunjunganDokterAhli { get; set; }

    public int KunjunganDokterAhliAsing { get; set; }

    public int TotalPasienDilayani { get; set; }

    public int DiterimaDariPuskesmas { get; set; }

    public int DiterimaDariFasilitasLain { get; set; }

    public int DitemiaDariRumahSakitLain { get; set; }

    public int DikembalikanKePuskesmas { get; set; }

    public int DikembalikanKeFasilitasLain { get; set; }

    public int DikembalikanKeRumahSakitAsal { get; set; }

    public int PasienRujukan { get; set; }

    public int PasienDatangSendiri { get; set; }

    public int DiterimaKembali { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCRLType, RLReportID")]
    [InverseProperty("RL1KegiatanRujukan")]
    public virtual RLReportTemplate RLReportTemplate { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL1KegiatanRujukan")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
