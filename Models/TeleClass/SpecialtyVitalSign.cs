using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SpecialtyCode", "VitalSignCode")]
public partial class SpecialtyVitalSign
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("SpecialtyCode")]
    [InverseProperty("SpecialtyVitalSign")]
    public virtual Specialty SpecialtyCodeNavigation { get; set; } = null!;

    [ForeignKey("VitalSignCode")]
    [InverseProperty("SpecialtyVitalSign")]
    public virtual VitalSignType VitalSignCodeNavigation { get; set; } = null!;
}
