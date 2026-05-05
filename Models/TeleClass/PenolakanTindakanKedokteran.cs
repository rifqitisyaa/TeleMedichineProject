using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PenolakanTindakanKedokteran
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? DokterPelaksana { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PenerimaInformasi { get; set; }

    [Unicode(false)]
    public string? Diagnosis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckDiagnosis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JenisTindakan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckJenisTindakan { get; set; }

    [Unicode(false)]
    public string? Tujuan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckTujuan { get; set; }

    [Unicode(false)]
    public string? Persiapan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckPersiapan { get; set; }

    [Unicode(false)]
    public string? Risiko { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckRisiko { get; set; }

    [Unicode(false)]
    public string? FaktorPenyulit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckFaktorPenyulit { get; set; }

    [Unicode(false)]
    public string? KondisiSpesifikPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckKondisiSpesifikPasien { get; set; }

    [Unicode(false)]
    public string? EfekSamping { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckEfekSamping { get; set; }

    [Unicode(false)]
    public string? Prognosis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckPrognosis { get; set; }

    [Unicode(false)]
    public string? Alternatif { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckAlternatif { get; set; }

    [Unicode(false)]
    public string? LainLain { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CheckLainLain { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TtdNamaDokter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaPasienKeluarga { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TtdNamaPasienKeluarga { get; set; }

    [Unicode(false)]
    public string? TindakanKedokteran { get; set; }

    [Unicode(false)]
    public string? Terhadap { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GenderPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TempatLahir { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TanggalLahir { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BuktiDiri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [Unicode(false)]
    public string? Alasan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AlasanLainnya { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KeteranganSaya { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DariPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SaksiKeluarga { get; set; }

    [Unicode(false)]
    public string? TempatBuat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalTTD { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPasienTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDPasienTTD { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaKeluargaTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDKeluargaTTD { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPihakRSTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDPihakRSTTD { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaDokterTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDDokterTTD { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
