using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratPersetujuanTindakanTreadmillTest
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public bool? IsParQTest1 { get; set; }

    public bool? IsParQTest2 { get; set; }

    public bool? IsParQTest3 { get; set; }

    public bool? IsParQTest4 { get; set; }

    public bool? IsParQTest5 { get; set; }

    public bool? IsParQTest6 { get; set; }

    public bool? IsParQTest7 { get; set; }

    public bool? IsKontraAbsolut1 { get; set; }

    public bool? IsKontraAbsolut2 { get; set; }

    public bool? IsKontraAbsolut3 { get; set; }

    public bool? IsKontraAbsolut4 { get; set; }

    public bool? IsKontraAbsolut5 { get; set; }

    public bool? IsKontraAbsolut6 { get; set; }

    public bool? IsKontraAbsolut7 { get; set; }

    public bool? IsKontraAbsolut8 { get; set; }

    public bool? IsKontraAbsolut9 { get; set; }

    public bool? IsKontraRelatif1 { get; set; }

    public bool? IsKontraRelatif2 { get; set; }

    public bool? IsKontraRelatif3 { get; set; }

    public bool? IsKontraRelatif4 { get; set; }

    public bool? IsKontraRelatif5 { get; set; }

    public bool? IsKontraRelatif6 { get; set; }

    public bool? IsKontraRelatif7 { get; set; }

    public bool? IsKontraRelatif8 { get; set; }

    public bool? IsKontraRelatif9 { get; set; }

    public bool? IsKesimpulanIzin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalTTDSkrining { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDSkrining { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NamaTTDSkrining { get; set; }

    [Unicode(false)]
    public string? Umur { get; set; }

    [Unicode(false)]
    public string? Saksi1 { get; set; }

    [Unicode(false)]
    public string? Saksi2 { get; set; }

    [Unicode(false)]
    public string? DokterPelaksana { get; set; }

    [Unicode(false)]
    public string? PenerimaInformasi { get; set; }

    [Unicode(false)]
    public string? Diagnosis { get; set; }

    [Unicode(false)]
    public string? CheckDiagnosis { get; set; }

    [Unicode(false)]
    public string? JenisTindakan { get; set; }

    [Unicode(false)]
    public string? CheckJenisTindakan { get; set; }

    [Unicode(false)]
    public string? Tujuan { get; set; }

    [Unicode(false)]
    public string? CheckTujuan { get; set; }

    [Unicode(false)]
    public string? Persiapan { get; set; }

    [Unicode(false)]
    public string? CheckPersiapan { get; set; }

    [Unicode(false)]
    public string? Risiko { get; set; }

    [Unicode(false)]
    public string? CheckRisiko { get; set; }

    [Unicode(false)]
    public string? FaktorPenyulit { get; set; }

    [Unicode(false)]
    public string? CheckFaktorPenyulit { get; set; }

    [Unicode(false)]
    public string? KondisiSpesifikPasien { get; set; }

    [Unicode(false)]
    public string? CheckKondisiSpesifikPasien { get; set; }

    [Unicode(false)]
    public string? EfekSamping { get; set; }

    [Unicode(false)]
    public string? CheckEfekSamping { get; set; }

    [Unicode(false)]
    public string? Prognosis { get; set; }

    [Unicode(false)]
    public string? CheckPrognosis { get; set; }

    [Unicode(false)]
    public string? Alternatif { get; set; }

    [Unicode(false)]
    public string? CheckAlternatif { get; set; }

    [Unicode(false)]
    public string? LainLain { get; set; }

    [Unicode(false)]
    public string? CheckLainLain { get; set; }

    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TtdNamaDokter { get; set; }

    [Unicode(false)]
    public string? NamaPasienKeluarga { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TtdNamaPasienKeluarga { get; set; }

    [Unicode(false)]
    public string? TindakanKedokteran { get; set; }

    [Unicode(false)]
    public string? Terhadap { get; set; }

    [Unicode(false)]
    public string? NamaPasien { get; set; }

    [Unicode(false)]
    public string? GenderPasien { get; set; }

    [Unicode(false)]
    public string? TempatLahir { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLahir { get; set; }

    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [Unicode(false)]
    public string? BuktiDiri { get; set; }

    [Unicode(false)]
    public string? AlamatPasien { get; set; }

    [Unicode(false)]
    public string? Alasan { get; set; }

    [Unicode(false)]
    public string? AlasanLinnya { get; set; }

    [Unicode(false)]
    public string? KeteranganSaya { get; set; }

    [Unicode(false)]
    public string? SaksiKeluarga { get; set; }

    [Unicode(false)]
    public string? TempatBuat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalTTD { get; set; }

    [Unicode(false)]
    public string? NamaPasienTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDPasienTTD { get; set; }

    [Unicode(false)]
    public string? NamaKeluargaTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDKeluargaTTD { get; set; }

    [Unicode(false)]
    public string? NamaPihakRSTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDPihakRSTTD { get; set; }

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
