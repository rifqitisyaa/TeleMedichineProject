using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganMeninggal
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? NoSurat { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TanggalLahir { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Umur { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Pekerjaan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TanggalMeninggal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PukulMeninggal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DokterMerawat { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("SuratKeteranganMeninggal")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
