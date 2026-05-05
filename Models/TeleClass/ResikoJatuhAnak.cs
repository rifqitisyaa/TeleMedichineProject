using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class ResikoJatuhAnak
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? UmurValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JenisKelaminValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DiagnosaValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? GangguanKognitifValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? FaktorLingkunganValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ResponOperasiValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PenggunaanObatValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RisikoJatuhValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? KategoriRisiko { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaPetugas { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalRisikoJatuh { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah1 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah2 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah3 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah4 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah5 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah6 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah7 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah8 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah9 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah10 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah11 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhTinggi1 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhTinggi2 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhTinggi3 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhTinggi4 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhTinggi5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
