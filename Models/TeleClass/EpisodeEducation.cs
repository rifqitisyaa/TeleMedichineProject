using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EpisodeEducation
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public bool? DiagnosaPenyakit { get; set; }

    public bool? RencanaPPP { get; set; }

    public bool? TeknikRehabilitasi { get; set; }

    public bool? InformedConsent { get; set; }

    public bool? PerawatanLuka { get; set; }

    public bool? Pemulangan { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("EpisodeEducation")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
