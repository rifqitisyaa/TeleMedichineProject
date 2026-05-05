using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Procedures
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ProcedureCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string ProcedureName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ICDCMBlockID { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Unicode(false)]
    public string? AlternateProcedureName { get; set; }

    [InverseProperty("ProcedureCodeNavigation")]
    public virtual ICollection<EpisodeProcedure> EpisodeProcedure { get; set; } = new List<EpisodeProcedure>();

    [ForeignKey("ICDCMBlockID")]
    [InverseProperty("Procedures")]
    public virtual ICDCMBlock? ICDCMBlock { get; set; }

    [InverseProperty("ProcedureCodeNavigation")]
    public virtual ICollection<InacbgSimulationProcedure> InacbgSimulationProcedure { get; set; } = new List<InacbgSimulationProcedure>();

    [InverseProperty("ProcedureCodeNavigation")]
    public virtual ICollection<OdontogramMCU> OdontogramMCU { get; set; } = new List<OdontogramMCU>();

    [InverseProperty("ProcedureCodeNavigation")]
    public virtual ICollection<PatientOdontogram> PatientOdontogram { get; set; } = new List<PatientOdontogram>();

    [InverseProperty("ProcedureCodeNavigation")]
    public virtual ICollection<PatientOdontogramNew> PatientOdontogramNew { get; set; } = new List<PatientOdontogramNew>();

    [InverseProperty("ProcedureCodeNavigation")]
    public virtual ICollection<PatientOralMucosa> PatientOralMucosa { get; set; } = new List<PatientOralMucosa>();

    [InverseProperty("ProcedureCodeNavigation")]
    public virtual ICollection<ProceduresMostFrequent> ProceduresMostFrequent { get; set; } = new List<ProceduresMostFrequent>();
}
