using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "ProcedureCode")]
public partial class InacbgSimulationProcedure
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ProcedureCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? Class { get; set; }

    [Unicode(false)]
    public string? InpatientGroup { get; set; }

    [Unicode(false)]
    public string? OutpatientGroup { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("InacbgSimulationProcedure")]
    public virtual InacbgSimulation InacbgSimulation { get; set; } = null!;

    [ForeignKey("ProcedureCode")]
    [InverseProperty("InacbgSimulationProcedure")]
    public virtual Procedures ProcedureCodeNavigation { get; set; } = null!;
}
