using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EpisodeDokterGigi
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public bool? GigitKapas { get; set; }

    public bool? MinumAntibiotik { get; set; }

    public bool? TidakKumur { get; set; }

    public bool? TidakMakan { get; set; }

    public bool? TidakHisapLuka { get; set; }

    public bool? LukaTidakDikorek { get; set; }

    public bool? TidakMeludah { get; set; }

    public bool? Kompres { get; set; }

    public bool? Pendarahan { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
