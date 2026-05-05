using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class SkalaNyeriMenangisCPS
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [Unicode(false)]
    public string? Menangis { get; set; }

    [Unicode(false)]
    public string? Kebutuhan { get; set; }

    [Unicode(false)]
    public string? Peningkatan { get; set; }

    [Unicode(false)]
    public string? Ekspresi { get; set; }

    [Unicode(false)]
    public string? Tidur { get; set; }

    public int? SkorCPS { get; set; }

    [Unicode(false)]
    public string? Tindakan { get; set; }

    [Unicode(false)]
    public string? NamaPerawat { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
