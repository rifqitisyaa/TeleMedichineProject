using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatEpisodeOfCare1
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string EpisodeOfCare1ID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? EncounterIHSNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SnomedCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SnomedName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }
}
