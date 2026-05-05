using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratRujukanKeluar
{
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateToday { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Dokter { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Rs { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Umur { get; set; }

    [Unicode(false)]
    public string? Keluhan { get; set; }

    [Unicode(false)]
    public string? Diagnose { get; set; }

    [Unicode(false)]
    public string? Terapi { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDDokter { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DokterLengkap { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NomorSurat { get; set; }
}
