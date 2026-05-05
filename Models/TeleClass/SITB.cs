using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SITB
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? FasyenkesType { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FasyenkesCode { get; set; }

    [Unicode(false)]
    public string? FasyenkesName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FasyenkesProvince { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FasyenkesCity { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IdSITB { get; set; }

    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Kewarganegaraan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NIK { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BPJSNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CityOfBirth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Provinsi { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Kota { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Kecamatan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Kelurahan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MobilePhone { get; set; }

    [Unicode(false)]
    public string? RiwayatPengobatan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NoUrut { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DirujukDikirimOleh { get; set; }

    [Unicode(false)]
    public string? KeteranganRujukan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KriteriaTerduga { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NoIdentitasSediaan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UmurTahun { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UmurBulan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BeratBadan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RiwayatDM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusHIV { get; set; }

    [Unicode(false)]
    public string? PaduanObat { get; set; }

    [Unicode(false)]
    public string? HasilMikroskopis { get; set; }

    [Unicode(false)]
    public string? HasilTesCepat { get; set; }

    [Unicode(false)]
    public string? HasilBiakan { get; set; }

    [Unicode(false)]
    public string? AkhirHasilMikroskopis { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalAkhirPengobatan { get; set; }

    [Unicode(false)]
    public string? HasilAkhirPengobatan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MikroskopisBulan2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MikroskopisBulan3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MikroskopisBulan5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FotoToraks { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
