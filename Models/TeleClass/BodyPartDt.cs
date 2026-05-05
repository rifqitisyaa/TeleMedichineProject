using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "DiagramCode")]
public partial class BodyPartDt
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
    public string DiagramCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDiagramType { get; set; }

    public short? LeftPosition { get; set; }

    public short? TopPosition { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("BodyPartDt")]
    public virtual ICollection<BodyPartDtPoint> BodyPartDtPoint { get; set; } = new List<BodyPartDtPoint>();

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("BodyPartDt")]
    public virtual BodyPartHd BodyPartHd { get; set; } = null!;

    [ForeignKey("GCDiagramType")]
    [InverseProperty("BodyPartDt")]
    public virtual sysGeneralCode? GCDiagramTypeNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("BodyPartDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
