using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReferToSisruteHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MRN { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? NIK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoJKN { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TempatLahir { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLahir { get; set; }

    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ContactNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalRencanaKunjungan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalBerlakuKunjungan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TipeRujukan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisRujukan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KdPoliRujukan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KodeFaskesRujukan { get; set; }

    [Unicode(false)]
    public string? FaskesTujuanRujukan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AlasanRujukan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DiagnosisName { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? DiagnosisCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PermintaanLayanan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Transportasi { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PilihanAmbulance { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ProcedureName { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? ProcedureCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Nyeri { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Kesadaran { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Suhu { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TekananDarah { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FrekuensiNadi { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FrekuensiNafas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Alergi { get; set; }

    [Unicode(false)]
    public string? KeteranganLainnya { get; set; }

    [Unicode(false)]
    public string? HasilLab { get; set; }

    [Unicode(false)]
    public string? HasilAnamnesis { get; set; }

    [Unicode(false)]
    public string? HasilRadiologi { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NoRujukan { get; set; }

    public bool? IsSentBPJS { get; set; }

    public bool? IsSentSisrute { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSent { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
