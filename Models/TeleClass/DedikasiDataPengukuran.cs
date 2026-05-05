using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class DedikasiDataPengukuran
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? SistoleValues { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? SistoleUnit { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DiastoleValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DiastoleUnit { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? BBValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? BBUnit { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TBValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TBUnit { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ImtValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ImtUnit { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LingkarPerutValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LingkarPerutUnit { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? GdsValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? GdsUnit { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? KolesterolValue { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? KolesterolUnit { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
