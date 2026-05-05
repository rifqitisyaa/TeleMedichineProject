using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKetDatangDalamKeadaanMeninggal
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? NoSurat { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLahir { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Umur { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pekerjaan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalMati { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? JamMati { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PilihanDokter { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("SuratKetDatangDalamKeadaanMeninggal")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
