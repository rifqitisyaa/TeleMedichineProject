using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PatientProblemGenerated
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCompileCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Parameter { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Value { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
