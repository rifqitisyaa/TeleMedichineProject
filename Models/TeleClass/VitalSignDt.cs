using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "DetailNo")]
public partial class VitalSignDt
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

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    [Unicode(false)]
    public string? VitalSignValue { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD { get; set; }

    [InverseProperty("VitalSignDt")]
    public virtual ICollection<EpisodeNutritionalStatus> EpisodeNutritionalStatus { get; set; } = new List<EpisodeNutritionalStatus>();

    [ForeignKey("SiteCode")]
    [InverseProperty("VitalSignDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("VitalSignCode")]
    [InverseProperty("VitalSignDt")]
    public virtual VitalSignType VitalSignCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("VitalSignDt")]
    public virtual VitalSignHd VitalSignHd { get; set; } = null!;
}
