using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatKeluhanUtama
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string KeluhanUtamaID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? EncounterIHSNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [Unicode(false)]
    public string? SnomedCode { get; set; }

    [Unicode(false)]
    public string? SnomedName { get; set; }

    [Unicode(false)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnsetDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecordedDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
