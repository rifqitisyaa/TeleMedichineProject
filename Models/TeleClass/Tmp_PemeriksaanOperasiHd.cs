using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Tmp_PemeriksaanOperasiHd
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int? RoomId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCPemakaianAlatMedis { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TglOperasi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglSelesaiOperasi { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RuangOperasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisOperasi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DiagnosisOperasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProsedurOperasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AsaScore { get; set; }

    [Unicode(false)]
    public string? Keterangan { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
