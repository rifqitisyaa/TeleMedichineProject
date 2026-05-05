using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganLayakTerbangNewTabel
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Unicode(false)]
    public string? NamaPasien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLahir { get; set; }

    [Unicode(false)]
    public string? NoRekamMedis { get; set; }

    [Unicode(false)]
    public string? Kebangsaan { get; set; }

    [Unicode(false)]
    public string? Alamat { get; set; }

    [Unicode(false)]
    public string? DiagnosaPenyakit { get; set; }

    public bool? chk1 { get; set; }

    public bool? chk2 { get; set; }

    [Unicode(false)]
    public string? Petugas { get; set; }

    [Unicode(false)]
    public string? Tujuan { get; set; }

    [Unicode(false)]
    public string? Kebutuhan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglTandaTangan { get; set; }

    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
