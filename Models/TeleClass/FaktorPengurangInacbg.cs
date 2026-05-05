using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class FaktorPengurangInacbg
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public bool? IsAsamLaktat { get; set; }

    public bool? IsProcalcitonin { get; set; }

    public bool? IsCRP { get; set; }

    public bool? IsCulturMO { get; set; }

    public bool? IsDdimer { get; set; }

    public bool? IsPT { get; set; }

    public bool? IsAPTT { get; set; }

    public bool? IsWaktuPendarahan { get; set; }

    public bool? IsAntiHIV { get; set; }

    public bool? IsAnalisaGas { get; set; }

    public bool? IsAlbumin { get; set; }

    public bool? IsThorax { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
