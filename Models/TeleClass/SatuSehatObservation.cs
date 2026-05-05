using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatObservation
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ObservationID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? SpecimenID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ServiceRequestID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JenisPanel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ValueCode { get; set; }

    [Unicode(false)]
    public string? Value { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
