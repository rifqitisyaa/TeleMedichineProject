using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class FisikMCU
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RambutStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? RambutKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KulitKepalaStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? KulitKepalaKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MataKiStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MataKiKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MataKaStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MataKaKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KGBUkuranLokasiStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? KGBUkuranLokasiKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KGBPembesaranStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? KGBPembesaranKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LidahStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LidahKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GigiStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GigiKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LeherStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LeherKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? StrumaStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? StrumaKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LeherKelainanStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LeherKelainanKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CerumenStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CerumenKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ObstruksiStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ObstruksiKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GendangTelingaStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GendangTelingaKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IntakStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? IntakKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PerforasiStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PerforasiKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KonkaStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? KonkaKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DeviasiSeptumStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DeviasiSeptumKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PolipStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PolipKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TenggorokanHiperemisStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TenggorokanHiperemisKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TenggorokanKelainanStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TenggorokanKelainanKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TonsilStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TonsilKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TonsilTStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TonsilTKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MammaeStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MammaeKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PergerakanStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PergerakanKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BunyiJantungStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BunyiJantungKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BisingJantungStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BisingJantungKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SatuIIMurniStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SatuIIMurniKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VesikulerStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? VesikulerKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RonkiStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? RonkiKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WheezingStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WheezingKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LimpaStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LimpaKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HeparStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? HeparKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NyeriKetokStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NyeriKetokKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PeristalticStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PeristalticKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MasaTumorStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MasaTumorKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SimetrisStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SimetrisKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReflekFisiologisStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ReflekFisiologisKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReflekPatologisStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ReflekPatologisKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SensibilitasStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SensibilitasKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HerniaInguinalisStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? HerniaInguinalisKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LowBackPainStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LowBackPainKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PatrickStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PatrickKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ContraPatrickStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ContraPatrickKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LaesecStatus { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LaesecKeterangan { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Kesimpulan { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Saran { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ParamedicName { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
