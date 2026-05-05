using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Tahun", "Metoda")]
public partial class KeluargaBerencana
{
    [StringLength(50)]
    [Unicode(false)]
    public string? KodeProvinsi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KabKota { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KodeRS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaRS { get; set; }

    [Key]
    public int Tahun { get; set; }

    public int? No { get; set; }

    [Key]
    [StringLength(500)]
    [Unicode(false)]
    public string Metoda { get; set; } = null!;

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KonselingAnc { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KonselingPascaPersalinan { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KBBaruDgCaraMasukBukanRujukan { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KBBaruDgCaraMasukRujukanInap { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KBBaruDgCaraMasukRujukanJalan { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KBBaruDgCaraMasukTotal { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KBBaruDgKondisiPascaPersalinanNifas { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KBBaruDgKondisiAbortus { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KBBaruDgKondisiLainnya { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KunjunganUlang { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KeluhanEfekSampingJumlah { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? KeluhanEfekSampingDirujuk { get; set; }
}
