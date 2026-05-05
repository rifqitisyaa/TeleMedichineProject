using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganDokter
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Nama_Pasien { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Jenis_Kelamin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MeicalNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tanggal_lahir { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BeratBdn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TinggiBdn { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Golongan_Darah { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Buta_Warna { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
