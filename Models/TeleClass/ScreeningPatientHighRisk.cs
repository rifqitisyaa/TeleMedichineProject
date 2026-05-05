using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ScreeningPatientHighRisk
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? Name { get; set; }

    public int? Age { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    public bool? IsAgeAbove60AndBelow18 { get; set; }

    public bool? IsLeftChestPain { get; set; }

    public bool? IsHadFeverAbove38 { get; set; }

    public bool? IsHadCoughLastFewDay { get; set; }

    public bool? IsHadTreatmentRespiratory { get; set; }

    public bool? IsHadPulmonaryMedication { get; set; }

    public bool? IsHadExperiencedWeightLoss { get; set; }

    public bool? IsHadExcessiveSweating { get; set; }

    public bool? IsHadGlands { get; set; }

    public bool? IsHadContactWithRespiratoryTractInfection { get; set; }

    public bool? IsHadPositiveSwabOrAbnormalXray { get; set; }

    public bool? IsHadContactWithSmallpoxInfection { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("ScreeningPatientHighRisk")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
