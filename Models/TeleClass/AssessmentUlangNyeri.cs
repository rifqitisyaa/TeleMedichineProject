using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class AssessmentUlangNyeri
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

    [StringLength(100)]
    [Unicode(false)]
    public string? PossValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PengkajianUlang { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalAssesment { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SkorNyeri { get; set; }

    public int? SkorSedasi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TekananDarah { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NadiValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SuhuValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PernafasanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPerawat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalIntervensi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ObatIntervensi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DosisIntervensi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RuteIntervensi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? IntervensiNonFarmakologi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPerawatIntervensi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WaktuUlang { get; set; }

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
