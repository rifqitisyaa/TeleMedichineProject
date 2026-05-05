using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class EvaluasiNyeri
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
    public string? DPJP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PenyebabNyeri { get; set; }

    [StringLength(10)]
    public string? Kualitas { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LokasiNyeri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SkalaNyeri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Tempo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KewaspadaanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KetenanganValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DistresPernafasanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MenangisValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PergerakanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TonusOtotValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TeganganWajah { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TekananDarahBasal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DenyutJantungBasal { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EvaluasiValue { get; set; }

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
