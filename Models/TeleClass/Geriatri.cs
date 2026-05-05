using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class Geriatri
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
    public DateTime? AssesmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RiwayatJatuhValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RiwayatJatuhValue2 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? StatusMentalValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? StatusMentalValue2 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? StatusMentalValue3 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PenglihatanValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PenglihatanValue2 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PenglihatanValue3 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? KebiasaanBerkemihValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TransferValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? MobilitasValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RisikoJatuhValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaPetugas { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? KategoriRisiko { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalResikoJatuh { get; set; }

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
    public string? JatuhRendah12 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah13 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah14 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhRendah15 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhSedang1 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JatuhSedang2 { get; set; }

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
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
