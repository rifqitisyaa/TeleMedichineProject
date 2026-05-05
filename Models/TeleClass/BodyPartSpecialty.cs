using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PartType", "SpecialtyCode", "GCImageUrl")]
public partial class BodyPartSpecialty
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string PartType { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCImageUrl { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCImageUrl")]
    [InverseProperty("BodyPartSpecialty")]
    public virtual sysGeneralCode GCImageUrlNavigation { get; set; } = null!;

    [ForeignKey("SpecialtyCode")]
    [InverseProperty("BodyPartSpecialty")]
    public virtual Specialty SpecialtyCodeNavigation { get; set; } = null!;
}
