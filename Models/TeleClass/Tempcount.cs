using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Tempcount
{
    [Unicode(false)]
    public string? Urut { get; set; }

    [Unicode(false)]
    public string? Tgl { get; set; }

    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [Unicode(false)]
    public string? MRN { get; set; }

    [Unicode(false)]
    public string? Nama { get; set; }

    [Unicode(false)]
    public string? Laki { get; set; }

    [Unicode(false)]
    public string? Perempuan { get; set; }

    [Unicode(false)]
    public string? Dokter { get; set; }

    [Unicode(false)]
    public string? Perawat { get; set; }

    [Unicode(false)]
    public string? DokterMerawat { get; set; }

    [Unicode(false)]
    public string? TD { get; set; }

    [Unicode(false)]
    public string? T { get; set; }

    [Unicode(false)]
    public string? P { get; set; }

    [Unicode(false)]
    public string? RR { get; set; }

    [Unicode(false)]
    public string? Kesadaran { get; set; }

    [Unicode(false)]
    public string? dua { get; set; }

    [Unicode(false)]
    public string? empat { get; set; }

    [Unicode(false)]
    public string? enam { get; set; }

    [Unicode(false)]
    public string? delapan { get; set; }

    [Unicode(false)]
    public string? sepuluh { get; set; }

    [Unicode(false)]
    public string? rendah { get; set; }

    [Unicode(false)]
    public string? sedang { get; set; }

    [Unicode(false)]
    public string? tinggi { get; set; }

    [Unicode(false)]
    public string? Item { get; set; }

    [Unicode(false)]
    public string? JamMulai { get; set; }

    [Unicode(false)]
    public string? JamSelesai { get; set; }

    [Unicode(false)]
    public string? JamKeluar { get; set; }

    [Unicode(false)]
    public string? KLL { get; set; }

    [Unicode(false)]
    public string? KK { get; set; }

    [Unicode(false)]
    public string? KKK { get; set; }

    [Unicode(false)]
    public string? SebabLain { get; set; }

    [Unicode(false)]
    public string? GD { get; set; }

    [Unicode(false)]
    public string? GTD { get; set; }

    [Unicode(false)]
    public string? GTG { get; set; }

    [Unicode(false)]
    public string? TGTD { get; set; }

    [Unicode(false)]
    public string? ItemMedication { get; set; }

    [Unicode(false)]
    public string? Sendiri { get; set; }

    [Unicode(false)]
    public string? Lain { get; set; }

    [Unicode(false)]
    public string? Puskesmas { get; set; }

    [Unicode(false)]
    public string? PraktekDoktera { get; set; }

    [Unicode(false)]
    public string? RI { get; set; }

    [Unicode(false)]
    public string? RJ { get; set; }

    [Unicode(false)]
    public string? RSLain { get; set; }

    [Unicode(false)]
    public string? PraktekDokter { get; set; }

    [Unicode(false)]
    public string? DOA { get; set; }

    [Unicode(false)]
    public string? DOE { get; set; }

    [Column(TypeName = "numeric(25, 4)")]
    public decimal? Biaya { get; set; }

    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
