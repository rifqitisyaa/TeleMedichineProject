using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganButaWarna
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Nomor { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TanggalLahirUsia { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Pekerjaan { get; set; }

    [Unicode(false)]
    public string? Alamat { get; set; }

    public bool? TidakButaWarna { get; set; }

    public bool? ButaWarna { get; set; }

    public bool? ButaWarnaParsial { get; set; }

    [Unicode(false)]
    public string? Catatan { get; set; }

    public DateOnly? TanggalPeriksa { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDDokter { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
