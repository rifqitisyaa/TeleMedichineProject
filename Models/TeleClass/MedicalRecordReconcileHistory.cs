using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MedicalRecordReconcileHistory
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? FromRegistration { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? ToRegistration { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
