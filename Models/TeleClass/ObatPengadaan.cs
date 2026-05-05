using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Tahun", "GolonganObat")]
public partial class ObatPengadaan
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
    public string GolonganObat { get; set; } = null!;

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? TotalItemObat { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? JumlahItemObatYangTersediaDiRS { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? JumlahItemObatFormulariumTersedia { get; set; }
}
