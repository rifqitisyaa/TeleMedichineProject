using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PatientResumeKeadaanPulang
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Tensi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nadi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suhu { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RespirationRate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
