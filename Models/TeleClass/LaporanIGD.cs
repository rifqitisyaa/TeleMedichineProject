using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LaporanIGD
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Tgl { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? MRN { get; set; }

    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Laki { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Perempuan { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Dokter { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Perawat { get; set; }

    [Unicode(false)]
    public string? DokterMerawat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? T { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? P { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RR { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kesadaran { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? dua { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? empat { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? enam { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? delapan { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? sepuluh { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? rendah { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? sedang { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tinggi { get; set; }

    [Unicode(false)]
    public string? Item { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JamMulai { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JamSelesai { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JamKeluar { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? KLL { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? KK { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? KKK { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? SebabLain { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? GD { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? GTD { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? GTG { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? TGTD { get; set; }

    [Unicode(false)]
    public string? ItemMedication { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Sendiri { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Lain { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Puskesmas { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PraktekDoktera { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? RI { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? RJ { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? RSLain { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PraktekDokter { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? DOA { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? DOE { get; set; }

    [Column(TypeName = "numeric(25, 4)")]
    public decimal? BIAYA { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
