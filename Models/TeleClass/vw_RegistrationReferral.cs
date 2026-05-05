using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_RegistrationReferral
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? case_type { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Penjamin { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? OriginRegistrationNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Agama { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Tgl_lahir { get; set; }

    [StringLength(110)]
    [Unicode(false)]
    public string? UmurTahun { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string IsNewPatient { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? telp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? District { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Negara { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kota { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Propinsi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Department { get; set; } = null!;

    [Column("Daftar Ke")]
    [StringLength(100)]
    [Unicode(false)]
    public string Daftar_Ke { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? Dokter { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RoomName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BedCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ClassName { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? MRS { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? KRS { get; set; }

    [StringLength(809)]
    [Unicode(false)]
    public string Rujukan_Dari { get; set; } = null!;

    [Column("Patient From")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Patient_From { get; set; }

    [Column("Registration No From")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Registration_No_From { get; set; }

    [StringLength(809)]
    [Unicode(false)]
    public string? Dirujuk_Ke { get; set; }

    [Column("Diagnosa Rujukan")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Diagnosa_Rujukan { get; set; }

    [Column("Cara keluar")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Cara_keluar { get; set; }

    [Column("Keadaan keluar")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Keadaan_keluar { get; set; }

    public string? Diagnosa { get; set; }

    public string? Procedure { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Estimasi_Tanggal_Operasi { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DischargeNotes { get; set; }

    [Column("Chief Complaint")]
    [Unicode(false)]
    public string? Chief_Complaint { get; set; }

    public string? FamilyContact { get; set; }
}
