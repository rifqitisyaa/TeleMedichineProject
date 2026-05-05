using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SatuSehatMedicationVariasiResepRequestDt
{
    [StringLength(100)]
    [Unicode(false)]
    public string? MedicationRequestID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Category { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Display { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Value { get; set; }

    public int? Sequence { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Text { get; set; }

    public int? Frequency { get; set; }

    public int? FrequencyMax { get; set; }

    public int? Period { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PeriodUnit { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
