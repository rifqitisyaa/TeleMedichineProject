using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SurgeryTeamTemplateHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SurgeryTeamCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SurgeryTeamName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("SurgeryTeamCodeNavigation")]
    public virtual ICollection<EpisodeProcedure> EpisodeProcedure { get; set; } = new List<EpisodeProcedure>();

    [InverseProperty("SurgeryTeamCodeNavigation")]
    public virtual ICollection<PhysicianTeamSurgery> PhysicianTeamSurgery { get; set; } = new List<PhysicianTeamSurgery>();

    [InverseProperty("SurgeryTeamCodeNavigation")]
    public virtual ICollection<SurgeryTeamTemplateDt> SurgeryTeamTemplateDt { get; set; } = new List<SurgeryTeamTemplateDt>();
}
