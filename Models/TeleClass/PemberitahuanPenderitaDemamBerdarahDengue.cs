using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PemberitahuanPenderitaDemamBerdarahDengue
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Umur { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaOrtu { get; set; }

    [Unicode(false)]
    public string? AlamatRumah { get; set; }

    [Unicode(false)]
    public string? Kelurahan { get; set; }

    [Unicode(false)]
    public string? Kecamatan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglMulaiSakit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglMasukRS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglMeninggalkanRS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Demam { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pendarahan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pembesaran { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Syok { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Trombosit1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Trombosit2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Trombosit3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Trombosit4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Hermatokrit1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Hermatokrit2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Hermatokrit3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Hermatokrit4 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalHariIni { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Dengue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Diagnosa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kondisi { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? DokterMerawat { get; set; }

    [Unicode(false)]
    public string? HHB { get; set; }
}
