using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganSenayanNew
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Nomorsurat { get; set; }

    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Tanggallahir { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pekerjaan { get; set; }

    [Unicode(false)]
    public string? Tempattinggal { get; set; }

    public bool? Keterangansurat { get; set; }

    [Unicode(false)]
    public string? Kegunaansurat { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Tinggibadan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Beratbadan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Tekanandarah { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Nadi { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Suhu { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Tanggalcetak { get; set; }

    [Unicode(false)]
    public string? Pemeriksaanlain { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD { get; set; }

    [Unicode(false)]
    public string? Dokter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OldMedicalNo { get; set; }
}
