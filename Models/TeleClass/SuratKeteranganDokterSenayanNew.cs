using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganDokterSenayanNew
{
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? NoSurat { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DokterPanggilan { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Saudara { get; set; }

    [StringLength(51)]
    [Unicode(false)]
    public string? NIP { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Pegawai { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Diagnosis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TempatTinggal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WaktuIstirahat { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TanggalSakit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TanggalSakit2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalBuat { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDDokter { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NoSip { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DokterLengkap { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
