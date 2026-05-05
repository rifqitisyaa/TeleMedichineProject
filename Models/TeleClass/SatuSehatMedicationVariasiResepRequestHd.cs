using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatMedicationVariasiResepRequestHd
{
    [StringLength(20)]
    [Unicode(false)]
    public string? JobOrderNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string MedicationRequestID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? MedicationCreateID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EncounterID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientIHS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PractitionerIHS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PerformerID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NumberOfRepeatsAllowed { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Intent { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Priority { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ResourceType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ValidityPeriodStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ValidityPeriodEnd { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthoredOn { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDatetime { get; set; }
}
