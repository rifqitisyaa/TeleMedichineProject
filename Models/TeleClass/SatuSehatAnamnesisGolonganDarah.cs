using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatAnamnesisGolonganDarah
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string GolonganDarahID { get; set; } = null!;

    [Unicode(false)]
    public string? EncounterIHSNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LoincCode { get; set; }

    [Unicode(false)]
    public string? LoincName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GolonganDarah { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
