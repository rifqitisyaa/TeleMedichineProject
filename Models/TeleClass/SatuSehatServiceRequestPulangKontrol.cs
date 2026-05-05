using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatServiceRequestPulangKontrol
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ServiceRequestID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DiagnosisCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RequesterPractitonerIHSNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PerformerPractitionerIHSNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientIHSNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PatientInstruction { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LocationCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LocationName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LocationReferenceID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LocationReferenceName { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
