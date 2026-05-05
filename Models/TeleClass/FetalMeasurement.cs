using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "DetailNo")]
public partial class FetalMeasurement
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    public byte PregnancyNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? BiparietalDiameter { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? OccipitofrontalDiameter { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? AbdominalCircumference { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? EstimatedFetalWeight { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? HeadCircumference { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? FemurLength { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? HumerusLength { get; set; }

    [Unicode(false)]
    public string? MenstrualHistory { get; set; }

    [Unicode(false)]
    public string? PreviousIllness { get; set; }

    [Unicode(false)]
    public string? SpecialRemarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MedicalNo, PregnancyNo, SequenceNo")]
    [InverseProperty("FetalMeasurement")]
    public virtual CurrentPregnancy CurrentPregnancy { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("FetalMeasurement")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("FetalMeasurement")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
