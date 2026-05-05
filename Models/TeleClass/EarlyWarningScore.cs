using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class EarlyWarningScore
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
    public string? FrekNafas { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SpO2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SumberO2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Suhu { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TDSistolik { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EwsValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DenyutJtg { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kesadaran { get; set; }
}
