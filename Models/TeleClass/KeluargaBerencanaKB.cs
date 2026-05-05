using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "No")]
public partial class KeluargaBerencanaKB
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    public int No { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Metoda { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalKB { get; set; }

    public bool? KonselingAnc { get; set; }

    public bool? KonselingPascaPersalinan { get; set; }

    public bool? KBBaruDgCaraMasukBknRujukan { get; set; }

    public bool? KBBaruDgCaraMasukRujukanRanap { get; set; }

    public bool? KBBaruDgCaraMasukRujukanRajal { get; set; }

    public bool? KBBaruDgCaraMasukTotal { get; set; }

    public bool? KBBaruDgKondisiNifas { get; set; }

    public bool? KBBaruDgKondisiAbortus { get; set; }

    public bool? KBBaruDgKondisiLainnya { get; set; }

    public bool? KunjunganUlang { get; set; }

    public bool? KeluhanEfekSampingJumlah { get; set; }

    public bool? KeluhanEfekSampingDirujuk { get; set; }
}
