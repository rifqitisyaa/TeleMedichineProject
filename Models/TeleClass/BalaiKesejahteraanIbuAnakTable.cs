using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BalaiKesejahteraanIbuAnakTable
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? BKIA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Dokter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bidan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tanggal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Hari { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bulan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tahun { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kecamatan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kelurahan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kampung { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Jalan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bangsa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Agama { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UmurSekarang { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UmurWaktuKawin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DenganSuamiSekarang { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KawinBerapaTahun { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Penghasilan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pekerjaan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AlamatJalan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RW { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nama2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaSuami { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BangsaSuami { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AgamaSuami { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UmurSuami { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PekerjaanSuami { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PenghasilanSuami { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JarakDariBidan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KehamilanKe { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Abortus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PartusPraematurus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LahirMati { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DokterTTD1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DokterTTD2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DokterTTD3 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD1 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD2 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaTTD1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaTTD2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaTTD3 { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalTTD { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("BalaiKesejahteraanIbuAnakTable")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
