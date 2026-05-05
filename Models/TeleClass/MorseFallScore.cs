using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class MorseFallScore
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

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RiwayatJatuhValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DiagnosaSkunderValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? BantuanBerjalanValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? MenggunakanInfusValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? CaraBerjalanValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? StatusMentalValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? MorseFallScaleValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? KategoriRisiko { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaPerawat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalMorseFallScale { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("MorseFallScore")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("MorseFallScore")]
    public virtual Registration? RegistrationNoNavigation { get; set; }
}
