using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatObservationRadiology
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ObservationID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ImagingStudyID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ServiceRequestID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Unicode(false)]
    public string? ValueString { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
