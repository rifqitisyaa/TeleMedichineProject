using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "ExaminationType")]
public partial class PemeriksaanFisikMCU
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ExaminationType { get; set; } = null!;

    public int? Sequence { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ExaminationName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ExaminationGroup { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsShow { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
