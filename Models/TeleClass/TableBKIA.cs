using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class TableBKIA
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UmurKwn { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? suamiNow { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? bulanSamaSuami { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? tahunKawin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? bulanKawin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? namaSuami { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? partusPra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? lahirMati { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? hamilKe { get; set; }

    [Unicode(false)]
    public string? abort { get; set; }

    [Unicode(false)]
    public string? abortus { get; set; }

    [Unicode(false)]
    public string? riwayat { get; set; }

    [Unicode(false)]
    public string? puerperium { get; set; }

    [Unicode(false)]
    public string? ditolong { get; set; }

    [Unicode(false)]
    public string? umurAnak { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? hariHaid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tafsiran { get; set; }

    public bool? IsSaveNewEpisode { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedTime { get; set; }
}
