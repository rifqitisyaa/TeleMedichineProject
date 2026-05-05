using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class InacbgSimulation
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? SimulationName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? InacbgCode { get; set; }

    [Unicode(false)]
    public string? InacbgDescription { get; set; }

    public int? InacbgLos { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal GrouperAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal InacbgAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialProcedureCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialDrugCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialProsthesisCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialInvestigationCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialProcedureGrouper { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialDrugGrouper { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialProsthesisGrouper { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialInvestigationGrouper { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SpecialProcedureAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SpecialDrugAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SpecialProsthesisAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SpecialInvestigationAmount { get; set; }

    public bool IsDefault { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("InacbgSimulation")]
    public virtual ICollection<InacbgSimulationDiagnose> InacbgSimulationDiagnose { get; set; } = new List<InacbgSimulationDiagnose>();

    [InverseProperty("InacbgSimulation")]
    public virtual ICollection<InacbgSimulationProcedure> InacbgSimulationProcedure { get; set; } = new List<InacbgSimulationProcedure>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("InacbgSimulation")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
