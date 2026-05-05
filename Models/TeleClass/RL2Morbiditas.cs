using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRL2Type", "DTDNo", "Period")]
public partial class RL2Morbiditas
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCRL2Type { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DTDNo { get; set; } = null!;

    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    public int Age0dTo28d { get; set; }

    public int Age28dTo1y { get; set; }

    public int Age1yTo4y { get; set; }

    public int Age5yTo14y { get; set; }

    public int Age15yTo24y { get; set; }

    public int Age25yTo44y { get; set; }

    public int Age45yTo64y { get; set; }

    public int AgeAbove65 { get; set; }

    public int NumberOfMale { get; set; }

    public int NumberOfFemale { get; set; }

    /// <summary>
    /// (NumberOfMale+NumberOfFemale)
    /// </summary>
    public int NumberOfPatientOut { get; set; }

    public int NumberOfPatientDied { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DTDNo")]
    [InverseProperty("RL2Morbiditas")]
    public virtual DTD DTDNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL2Morbiditas")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
