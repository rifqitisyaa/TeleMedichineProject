using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class SurgeryReportDiagnosisEMR
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
    public string? NamPas { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NoRM { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TglLahir { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Ruangan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DokterBedah { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Asisten1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Asisten2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PerawatInstrumen { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DokterAnestesi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AsistenAnestesi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PerawatCirculator { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RuangOK { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DiagnosaPre { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TglOp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DiagnosaPasca { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JamOpMulai { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JamOpSelesai { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Tindakan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Durasi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EmEl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Jenis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PAStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OpKe { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Profilaksis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WaktuPemberian { get; set; }

    [Unicode(false)]
    public string? UraianPembedah { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
