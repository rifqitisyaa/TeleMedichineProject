using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tempDiagnosisHapusAkreditasi
{
    [StringLength(100)]
    [Unicode(false)]
    public string Department { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public DateOnly? Tgl { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ICDCode_hapus { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Diagnosis_Hapus { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Status_Hapus { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Tipe_Hapus { get; set; } = null!;

    [Column("Dihapus Oleh")]
    [StringLength(250)]
    [Unicode(false)]
    public string Dihapus_Oleh { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ICDCode_Dipakai { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Diagnosis_Dipakai { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Status_Dipakai { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Tipe { get; set; }

    [Column("Diinput Oleh")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Diinput_Oleh { get; set; }
}
