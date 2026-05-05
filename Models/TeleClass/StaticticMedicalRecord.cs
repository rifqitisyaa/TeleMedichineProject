using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class StaticticMedicalRecord
{
    [Column(TypeName = "datetime")]
    public DateTime? RegistrationDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OldMedicalNo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SSN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Agama { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Suku { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kebangsaan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FamilyName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PasienLamaBaru { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WaktuDaftar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalMasuk { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalPulang { get; set; }

    public int? LOS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLahir { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Umur { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KelompokUmur { get; set; }

    [Unicode(false)]
    public string? DiagnosaMasuk { get; set; }

    [Unicode(false)]
    public string? DiagnosisPrimer { get; set; }

    [Unicode(false)]
    public string? ICDPrimer { get; set; }

    [Unicode(false)]
    public string? DiagnosisSekunder { get; set; }

    [Unicode(false)]
    public string? ICDSekunder { get; set; }

    [Unicode(false)]
    public string? Tindakan { get; set; }

    [Unicode(false)]
    public string? ICD_9CM { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LamaOperasi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RujukanDariFaskes { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DPJP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DepartmentName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ServiceUnitName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kelas { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ChargeKelas { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Penjamin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CoverClass { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CaraPulang { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaRSyangdirujuk { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MobilePhone { get; set; }

    [Unicode(false)]
    public string? Alamat { get; set; }

    public int? RawatkeJumlahkunjungan { get; set; }
}
