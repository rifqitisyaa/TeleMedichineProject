using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class MEOWS
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ParamedicID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [Unicode(false)]
    public string? FrekuensiNafas { get; set; }

    [Unicode(false)]
    public string? SpO2 { get; set; }

    [Unicode(false)]
    public string? SumberO2 { get; set; }

    [Unicode(false)]
    public string? Suhu { get; set; }

    [Unicode(false)]
    public string? TDSistolik { get; set; }

    [Unicode(false)]
    public string? TDDiastolik { get; set; }

    [Unicode(false)]
    public string? DenyutJtg { get; set; }

    [Unicode(false)]
    public string? Kesadaran { get; set; }

    [Unicode(false)]
    public string? Discharge { get; set; }

    [Unicode(false)]
    public string? Nyeri { get; set; }

    [Unicode(false)]
    public string? Proteinuria { get; set; }

    [Unicode(false)]
    public string? NamaPetugas { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalMEOWS { get; set; }

    [Unicode(false)]
    public string? MEOWSValue { get; set; }

    public bool? Remarks { get; set; }

    public bool? IsDeleted { get; set; }

    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
