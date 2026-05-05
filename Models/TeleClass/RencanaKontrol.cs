using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MRN", "NoSurat")]
public partial class RencanaKontrol
{
    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AppointmentNo { get; set; }

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MRN { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string NamaPasien { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? NIK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoKartu { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoSEP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoClaim { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string NoSurat { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NoTelepon { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KodeDPJP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaDPJP { get; set; }

    [Unicode(false)]
    public string? Keterangan { get; set; }

    [Unicode(false)]
    public string? Saran { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalKontrol { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalSEP { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TempatLahir { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLahir { get; set; }

    [Unicode(false)]
    public string? Diagnosis { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KodeFaskesAsal { get; set; }

    [Unicode(false)]
    public string? NamaFaskesAsal { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSent { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
