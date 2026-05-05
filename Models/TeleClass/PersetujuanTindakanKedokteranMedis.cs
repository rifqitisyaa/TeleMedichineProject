using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PersetujuanTindakanKedokteranMedis
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NoRM { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? DokterPelaksanaan { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PenerimaInformasi { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Hubungan { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Diagnosa { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DasarDiagnosa { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Tindakan { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Indikasi { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TataCara { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TujuanManfaat { get; set; }

    public bool? ReaksiAlergi { get; set; }

    public bool? Pendarahan { get; set; }

    public bool? HilangFungsiTubuh { get; set; }

    public bool? EfekSampingObat { get; set; }

    public bool? Infeksi { get; set; }

    public bool? Kematian { get; set; }

    public bool? Lainlain { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TLainlain { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Prognosis { get; set; }

    public bool? PerluasTindakan { get; set; }

    public bool? ProdukDarah { get; set; }

    public bool? KonsulDokter { get; set; }

    public bool? PerawatanICU { get; set; }

    public bool? TidakAda { get; set; }

    public bool? Ada { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TAda { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
