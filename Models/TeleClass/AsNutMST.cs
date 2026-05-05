using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class AsNutMST
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

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

    [StringLength(100)]
    [Unicode(false)]
    public string? TurunBBValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AsupanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DiagValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DiagDet { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GiziValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NutrisiScoreValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NutKet { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
