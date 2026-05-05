using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SatuSehatPengkajianResep
{
    [StringLength(100)]
    [Unicode(false)]
    public string? PengkajianResepNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientIHSNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EncounterIHSNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MedicationRequestID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? JobOrderNo { get; set; }

    public bool? IsDeleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
