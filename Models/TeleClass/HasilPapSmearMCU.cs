using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class HasilPapSmearMCU
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string RegisterPaNo { get; set; } = null!;

    public bool? AdekuasiMemenuhiSyarat { get; set; }

    public bool? AdekuasiTidakMemenuhiSyarat { get; set; }

    public bool? KategoriNilm { get; set; }

    public bool? KategoriLain { get; set; }

    public bool? KategoriAbnormalSelEpitel { get; set; }

    public bool? KategoriNeoplasiaLain { get; set; }

    public string? Makroskopis { get; set; }

    public string? Mikroskopis { get; set; }

    public bool? InfeksiTrikomonasVaginalis { get; set; }

    public bool? InfeksiCandida { get; set; }

    public bool? InfeksiKokobasilus { get; set; }

    public bool? InfeksiActinomyces { get; set; }

    public bool? InfeksiHerpesSimpleks { get; set; }

    public bool? SelSkuamosaAtipikAsc { get; set; }

    public bool? AscUs { get; set; }

    public bool? AscH { get; set; }

    public bool? Lsil { get; set; }

    public bool? DisplasiaRinganCin1 { get; set; }

    public bool? InfeksiHpvTanpaDisplasia { get; set; }

    public bool? Hsil { get; set; }

    public bool? DisplasiaSedangCin2 { get; set; }

    public bool? DisplasiaBeratCin3KarsinomaInSitu { get; set; }

    public bool? KarsinomaSelSkuamosa { get; set; }

    public bool? ReaksiPeradangan { get; set; }

    public bool? Atrofi { get; set; }

    public bool? Radiasi { get; set; }

    public bool? Iud { get; set; }

    public bool? ReaktifLainLain { get; set; }

    public bool? SelGlandulerAtipikAgc { get; set; }

    public bool? AgcAtipikNos { get; set; }

    public bool? AgcFavorNeoplastik { get; set; }

    public bool? AdenokarsinomaInSituServiks { get; set; }

    public bool? AdenokarsinomaNos { get; set; }

    public string? Kesimpulan { get; set; }

    public string? Anjuran { get; set; }

    public int? ParamedicID { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool? NeoplasmaGanasLainnya { get; set; }

    [StringLength(200)]
    public string? NeoplasmaGanasLainnyaJenis { get; set; }
}
