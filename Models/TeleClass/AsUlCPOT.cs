using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class AsUlCPOT
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

    [StringLength(50)]
    [Unicode(false)]
    public string? EkspresiValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GerakanValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PenyesuaianValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VokalisasiValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KeteganganValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Tindakan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPerawat { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NyeriScoreValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NyeriCategory { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
