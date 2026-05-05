using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatPatientAllergy
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string PatientAllergenIHSNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCAllergenType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string AllergenName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Reaction { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCAllergySource { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCAllergyStatus { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCAllergySeverity { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
