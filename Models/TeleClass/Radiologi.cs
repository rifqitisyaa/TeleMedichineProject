using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Tahun", "No")]
public partial class Radiologi
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

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string No { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? JenisKegiatan { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Jumlah { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Urutan { get; set; }
}
