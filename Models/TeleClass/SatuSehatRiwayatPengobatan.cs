using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatRiwayatPengobatan
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string RiwayatPengobatanID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? MedicationDispenseID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EncounterIHSNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Type { get; set; }

    public int? ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KFACode { get; set; }

    [Unicode(false)]
    public string? KFAName { get; set; }

    [Unicode(false)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssertedDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
