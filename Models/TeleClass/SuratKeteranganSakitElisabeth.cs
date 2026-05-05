using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganSakitElisabeth
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? NoSurat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaPasien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TGLLahir { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pekerjaan { get; set; }

    [Unicode(false)]
    public string? Alamat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TGLAwal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TGLAkhir { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [Unicode(false)]
    public string? KetLain { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("SuratKeteranganSakitElisabeth")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
