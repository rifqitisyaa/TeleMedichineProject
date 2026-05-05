using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SnomedCode")]
public partial class RiwayatPenyakitPribadiPasien
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string SnomedCode { get; set; } = null!;

    [Unicode(false)]
    public string? SnomedName { get; set; }

    [Unicode(false)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnsetPeriodStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnsetPeriodEnd { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecordedDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
