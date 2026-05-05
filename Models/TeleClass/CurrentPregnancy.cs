using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "PregnancyNo", "SequenceNo")]
public partial class CurrentPregnancy
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    public byte PregnancyNo { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public byte NumberOfFetus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HusbandName { get; set; }

    public DateOnly FirstDayLMP { get; set; }

    public byte? AgeMarriage { get; set; }

    public bool IsBorn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualDeliveryDate { get; set; }

    public DateOnly EstimatedDeliveryDate { get; set; }

    public byte Gravida { get; set; }

    public byte Para { get; set; }

    public byte Abortion { get; set; }

    public byte Life { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("CurrentPregnancy")]
    public virtual ICollection<FetalMeasurement> FetalMeasurement { get; set; } = new List<FetalMeasurement>();

    [InverseProperty("CurrentPregnancy")]
    public virtual ICollection<FetalMeasurementHd> FetalMeasurementHd { get; set; } = new List<FetalMeasurementHd>();

    [ForeignKey("MedicalNo")]
    [InverseProperty("CurrentPregnancy")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;
}
