using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class KartuPesertaStatusKB
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? NomorKodeKlinikKBPropinsi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NomorKodeKlinikKBKab { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NomorKodeKlinikKBKlinik { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoSeriKartuPesertaKBUrut { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoSeriKartuPesertaKBTahun { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaIstri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaSuami { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UmurIstri { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PendidikanSuami { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PendidikanIstri { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PekerjaanSuami { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PekerjaanIstri { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MacamPesertaKB { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CaraKBterakhir { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JumlahAnakHidupLakiLaki { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JumlahAnakHidupPerempuan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JumlahAnakLahirHidupMeninggalLakiLaki { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JumlahAnakLahirHidupMeninggalPerempuan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KeadaanUmum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TekananDarah { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Haidterakhirtanggal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Beratbadan { get; set; }

    public bool? HamilYa { get; set; }

    public bool? HamilTidak { get; set; }

    public bool? SakitKuningYa { get; set; }

    public bool? SakitKuningTidak { get; set; }

    public bool? PendarahanYa { get; set; }

    public bool? PendarahanTidak { get; set; }

    public bool? TumorPayudaraYa { get; set; }

    public bool? TumorPayudaraTidak { get; set; }

    public bool? TumorRahimYa { get; set; }

    public bool? TumorRahimTidak { get; set; }

    public bool? TumorIndungYa { get; set; }

    public bool? TumorIndungTidak { get; set; }

    public bool? TensiTinggiYa { get; set; }

    public bool? TensiTinggiTidak { get; set; }

    public bool? VaricesYa { get; set; }

    public bool? VaricesTidak { get; set; }

    public bool? PenyakitJantungYa { get; set; }

    public bool? PenyakitJantungTidak { get; set; }

    public bool? TandaKehamilanYa { get; set; }

    public bool? TandaKehamilanTidak { get; set; }

    public bool? TandaRadangYa { get; set; }

    public bool? TandaRadangTidak { get; set; }

    public bool? TumorYa { get; set; }

    public bool? TumorTidak { get; set; }

    public bool? TandaDiabetesYa { get; set; }

    public bool? TandaDiabetesTidak { get; set; }

    public bool? KelahiranPembekuanYa { get; set; }

    public bool? KelahiranPembekuanTidak { get; set; }

    public bool? RadangYa { get; set; }

    public bool? RadangTidak { get; set; }

    public bool? PilKombi { get; set; }

    public bool? PilPro { get; set; }

    public bool? IUD { get; set; }

    public bool? Implant { get; set; }

    public bool? Suntik { get; set; }

    public bool? MO { get; set; }

    public bool? Kondom { get; set; }

    public bool? ObatVaginal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AlatKontrasepsi { get; set; }

    public DateOnly? TanggalDilayani { get; set; }

    public DateOnly? TanggalDipesanKembali { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDDokter { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NIP { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("KartuPesertaStatusKB")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
