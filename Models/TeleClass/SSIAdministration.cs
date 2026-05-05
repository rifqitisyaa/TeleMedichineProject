using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class SSIAdministration
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TanggalMRS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalOperasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LamaOperasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisOperasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OperasiKarenaTrauma { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RuangOperasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProsedurOperasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BeratBadan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KualifikasiDokterBedah { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MultiprosudurYangSama { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ASAScore { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KlasifikasiLuka { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SuhuPasien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Albumin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GulaDarah { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SteroidJangkaPanjang { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PasienMerokok { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PenyakitPasienSaatIni { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RadioterapiSebelumnya { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PenyakitInfeksiLain { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ScreeningMRSA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HasilMRSA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pencukuran { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WaktuPencukuran { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MechanicalBowel { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MandiSebelumOpersi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Profilaksis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DosisProfilaksis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JamProfilaksis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SirkulasiUdaraOT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TekananUdaraOT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SuhuRuang { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AirCountOT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JamurAC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KelembapanRuangOT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Drain { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Implant { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SterilisasiCSSD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AntibiotikTambahan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DosisAntibiotik { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JamAntibiotik { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JumlahStaf { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DisinfeksiKulit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IndikatorInstrumen { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Keluhan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
