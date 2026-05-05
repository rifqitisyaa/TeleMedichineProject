using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("VitalSignCodeVs3", "VitalSignCode", "VitalSignValue", "VitalSignValueVs31")]
public partial class VitalSignValueVs3
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCodeVs3 { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string VitalSignValue { get; set; } = null!;

    [Key]
    [Column("VitalSignValueVs3")]
    [StringLength(100)]
    [Unicode(false)]
    public string VitalSignValueVs31 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("VitalSignCode")]
    [InverseProperty("VitalSignValueVs3")]
    public virtual VitalSignType VitalSignCodeNavigation { get; set; } = null!;
}
