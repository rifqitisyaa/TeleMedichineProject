using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class InformasiAnasthesiDanSedasi
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? DokterPelaksanaTindakan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPemberiInformasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Jabatan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPenerimaInformasi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HubunganDenganPasien { get; set; }

    [Unicode(false)]
    public string? DiagnosisKerja { get; set; }

    [Unicode(false)]
    public string? DiagnosisBanding { get; set; }

    [Unicode(false)]
    public string? Tindakan { get; set; }

    [Unicode(false)]
    public string? IndikasiTindakan { get; set; }

    [Unicode(false)]
    public string? TataCara { get; set; }

    [Unicode(false)]
    public string? ResikoTindakan { get; set; }

    [Unicode(false)]
    public string? Komplikasi { get; set; }

    [Unicode(false)]
    public string? Prognosis { get; set; }

    [Unicode(false)]
    public string? AlternatifResiko { get; set; }

    [Unicode(false)]
    public string? LainLain { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TandaTanganDokter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TandaTanganPasien { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPemberi { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UmurPemberi { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JenisKelaminPemberi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AlamatPemberi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tindakandua { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPenerima { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UmurPenerima { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JenisKelaminPenerima { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AlamatPenerima { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
