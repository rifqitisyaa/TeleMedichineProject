using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EtVisumRepertum
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? No { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Hari { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Tanggal { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Pukul { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaTtd { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JabatanTtd { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PermintaanTtd { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NomorsuratTtd { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PerihalTtd { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JkTtd { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPasien { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JkPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UmurPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PekerjaanPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KewarganegaraanPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AgamaPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AlamatPasien { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Anamnese { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PeriksaSadar { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PeriksaTensi { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PeriksaNadi { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PeriksaNapas { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Kepala { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Leher { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Dada { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Punggung { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Perut { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Kelamin { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? GerakAtas { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? GerakBawah { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Periksa { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? KesimpulanDiagnosa { get; set; }

    public bool? OkiA { get; set; }

    public bool? OkiB { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OkiBTanggalDirawat { get; set; }

    public bool? OybA { get; set; }

    public bool? OybB { get; set; }

    public bool? OybC { get; set; }

    public bool? OybD { get; set; }

    public bool? OybE { get; set; }

    public bool? OybF { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
