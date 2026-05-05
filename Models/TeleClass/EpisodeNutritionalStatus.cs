using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "DetailNo", "Category", "Type")]
public partial class EpisodeNutritionalStatus
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string StatusGiziName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, SequenceNo, DetailNo")]
    [InverseProperty("EpisodeNutritionalStatus")]
    public virtual VitalSignDt VitalSignDt { get; set; } = null!;
}
