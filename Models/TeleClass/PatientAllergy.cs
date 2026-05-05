using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientAllergy
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
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

    [ForeignKey("GCAllergenType")]
    [InverseProperty("PatientAllergyGCAllergenTypeNavigation")]
    public virtual sysGeneralCode GCAllergenTypeNavigation { get; set; } = null!;

    [ForeignKey("GCAllergySeverity")]
    [InverseProperty("PatientAllergyGCAllergySeverityNavigation")]
    public virtual sysGeneralCode GCAllergySeverityNavigation { get; set; } = null!;

    [ForeignKey("GCAllergySource")]
    [InverseProperty("PatientAllergyGCAllergySourceNavigation")]
    public virtual sysGeneralCode GCAllergySourceNavigation { get; set; } = null!;

    [ForeignKey("GCAllergyStatus")]
    [InverseProperty("PatientAllergyGCAllergyStatusNavigation")]
    public virtual sysGeneralCode GCAllergyStatusNavigation { get; set; } = null!;

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientAllergy")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;
}
