using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Tahun", "JenisPelayanan")]
public partial class RawatInap
{
    [StringLength(50)]
    [Unicode(false)]
    public string? KodeRS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KodePropinsi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KabKota { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaRS { get; set; }

    [Key]
    public int Tahun { get; set; }

    public int? No { get; set; }

    [Key]
    [StringLength(500)]
    [Unicode(false)]
    public string JenisPelayanan { get; set; } = null!;

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? PasienAwalTahun { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? PasienMasuk { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? PasienKeluarHidup { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Kecil48Jam { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Besar48Jam { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? JumlahLamaDirawat { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? PasienAkhirTahun { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? JumlahHariPerawatan { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? VVIP { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? VIP { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? I { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? II { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? III { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KelasKhusus { get; set; }
}
