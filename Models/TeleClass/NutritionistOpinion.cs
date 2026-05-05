using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class NutritionistOpinion
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Weight { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Height { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? UpperArm { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? BMI { get; set; }

    [Unicode(false)]
    public string? Biokimia { get; set; }

    [Unicode(false)]
    public string? KlinisFisik { get; set; }

    [Unicode(false)]
    public string? RiwayatGizi { get; set; }

    [Unicode(false)]
    public string? RiwayatPersonal { get; set; }

    [Unicode(false)]
    public string? DiagnosisGizi { get; set; }

    [Unicode(false)]
    public string? Tujuan { get; set; }

    [Unicode(false)]
    public string? Intervensi { get; set; }

    [Unicode(false)]
    public string? Edukasi { get; set; }

    [Unicode(false)]
    public string? MonitoringEvaluation { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
