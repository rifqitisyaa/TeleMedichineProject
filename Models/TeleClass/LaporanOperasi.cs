using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class LaporanOperasi
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaRuangan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Tanggal { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Jam { get; set; }

    [Unicode(false)]
    public string? NamaOperator { get; set; }

    [Unicode(false)]
    public string? Asisten1 { get; set; }

    [Unicode(false)]
    public string? Asisten2 { get; set; }

    [Unicode(false)]
    public string? NamaAhliAnestesi { get; set; }

    [Unicode(false)]
    public string? JenisAnestesi { get; set; }

    [Unicode(false)]
    public string? SifatOperasi { get; set; }

    [Unicode(false)]
    public string? GolonganOperasi { get; set; }

    [Unicode(false)]
    public string? DiagnosaPraOperasi { get; set; }

    [Unicode(false)]
    public string? DiagnosaPaskaOperasi { get; set; }

    [Unicode(false)]
    public string? IndikasiOperasi { get; set; }

    [Unicode(false)]
    public string? TindakanOperasi { get; set; }

    [Unicode(false)]
    public string? JaringanYangDieksisi { get; set; }

    [Unicode(false)]
    public string? PemeriksaanPA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalOperasi { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? JamOperasiMulai { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? JamOperasiSelesai { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DurasiOperasi { get; set; }

    [Unicode(false)]
    public string? KomplikasiOperasi { get; set; }

    [Unicode(false)]
    public string? JumlahPerdarahan { get; set; }

    [Unicode(false)]
    public string? Transfusi { get; set; }

    [Unicode(false)]
    public string? PemasanganImplan { get; set; }

    [Unicode(false)]
    public string? NamaImplan { get; set; }

    [Unicode(false)]
    public string? NoSeri { get; set; }

    [Unicode(false)]
    public string? RencanaBuka { get; set; }

    [Unicode(false)]
    public string? KlasifikasiOperasi { get; set; }

    [Unicode(false)]
    public string? PerawatanOperasi { get; set; }

    [Column("LaporanOperasi")]
    [Unicode(false)]
    public string? LaporanOperasi1 { get; set; }

    [Unicode(false)]
    public string? Aseptik { get; set; }

    [Unicode(false)]
    public string? Droping { get; set; }

    [Unicode(false)]
    public string? Insisi { get; set; }

    [Unicode(false)]
    public string? InstruksiPaskaBedah { get; set; }

    [Unicode(false)]
    public string? Diet { get; set; }

    [Unicode(false)]
    public string? IVFD { get; set; }

    [Unicode(false)]
    public string? Obat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JamSelesai { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("LaporanOperasi")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
