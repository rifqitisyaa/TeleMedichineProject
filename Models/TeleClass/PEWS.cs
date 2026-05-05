using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PEWS
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

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FrekuensiValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SpO2Value { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OksigenValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DenyutJantungValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TekananDarahValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CapillaryReturnValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KesadaranValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SuhuValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RentanUmur { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PewsScoreValue { get; set; }

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
