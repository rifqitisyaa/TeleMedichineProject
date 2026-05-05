using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class EvaluasiNyeriDewasa
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
    public string? Diagnosis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Dpjp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PenyebabNyeri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PerburukNyeri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PeringanNyeri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kualitas { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NoLokasi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Penjalaran { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LokasiNyeri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SkalaNyeri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TipeNyeri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Metode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Efek { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Tempo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Frekuensi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WongValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NrsValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? VasValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NyeriValue { get; set; }

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
