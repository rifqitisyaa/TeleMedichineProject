using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "DetailNo", "FetusNo")]
public partial class FetalMeasurementDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    [Key]
    public byte FetusNo { get; set; }

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

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? CrownRumpLength { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? GestationalSac { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? FetalHeartRate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, DetailNo")]
    [InverseProperty("FetalMeasurementDt")]
    public virtual FetalMeasurementHd FetalMeasurementHd { get; set; } = null!;
}
