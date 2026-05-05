using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatMedicationDispense
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string MedicationDispenseID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? MedicationCreateID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JobOrderNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    public int? ItemID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PerformerPractitonerIHSNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientIHSNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Status { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
