using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatReferralPatient
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string EncounterIHSNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferralNo { get; set; }

    [Unicode(false)]
    public string? ReferralHealthcareName { get; set; }

    public bool? IsSent { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
