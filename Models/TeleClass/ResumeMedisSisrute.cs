using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ResumeMedisSisrute
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MRN { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string NoRujukan { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? KodeJenisPelayanan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaJenisPelayanan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RiwayatPenyakit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PemeriksaanPenunjang { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? KodeKeadaanKeluar { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaKeadaanKeluar { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? KodeRSRujukan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaRSRujukan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLanjutan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kesadaran { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FrekuensiNafas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suhu { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? KodeInstalasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaInstalasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KeluhanUtama { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PemeriksaanFisik { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? KodeCaraKeluar { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NasihatPulang { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisRujukan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalKeluar { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Diet { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TekananDarah { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SkalaNyeri { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nadi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDateTime { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;
}
