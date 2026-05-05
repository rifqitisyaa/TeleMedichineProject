using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratPenolakanTindakanKedokteran
{
    [Key]
    [StringLength(50)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    public string? NamaKeluarga { get; set; }

    [StringLength(50)]
    public string? UmurKeluarga { get; set; }

    [StringLength(50)]
    public string? JenisKelamin { get; set; }

    public string? Alamat { get; set; }

    [StringLength(50)]
    public string? HubunganDenganPasien { get; set; }

    public string? Diagnosis { get; set; }

    public string? RencanaTindakan { get; set; }

    public string? Komplikasi { get; set; }

    public string? RisikoBilaTidakDilakukan { get; set; }

    [StringLength(50)]
    public string? Terhadap { get; set; }

    public string? AlasanLain { get; set; }

    [StringLength(50)]
    public string? Sebagai { get; set; }

    [StringLength(10)]
    public string? SaksiKeluarga { get; set; }
}
