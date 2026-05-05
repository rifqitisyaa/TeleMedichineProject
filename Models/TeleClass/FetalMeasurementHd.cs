using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "DetailNo")]
public partial class FetalMeasurementHd
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

    [Unicode(false)]
    public string? MenstrualHistory { get; set; }

    [Unicode(false)]
    public string? PreviousIllness { get; set; }

    [Unicode(false)]
    public string? SpecialRemarks { get; set; }

    [Unicode(false)]
    public string? AmountOfPlasenta { get; set; }

    [Unicode(false)]
    public string? ConditionOfPlasenta { get; set; }

    [Unicode(false)]
    public string? PositionOfPlasenta { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? AfiKuadrat1 { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? AfiKuadrat2 { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? AfiKuadrat3 { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? AfiKuadrat4 { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? TotalAfi { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GcAfiStatus { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MedicalNo, PregnancyNo, SequenceNo")]
    [InverseProperty("FetalMeasurementHd")]
    public virtual CurrentPregnancy CurrentPregnancy { get; set; } = null!;

    [InverseProperty("FetalMeasurementHd")]
    public virtual ICollection<FetalMeasurementDt> FetalMeasurementDt { get; set; } = new List<FetalMeasurementDt>();

    [ForeignKey("GcAfiStatus")]
    [InverseProperty("FetalMeasurementHd")]
    public virtual sysGeneralCode? GcAfiStatusNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("FetalMeasurementHd")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("FetalMeasurementHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("FetalMeasurementHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
