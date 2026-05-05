using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GuidelineID", "GCGuidelineType", "InclusionCode", "PartName")]
public partial class GuidelineInclusion
{
    [Key]
    public int GuidelineID { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCGuidelineType { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string InclusionCode { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string PartName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AgeDescription { get; set; }

    public byte? AgeAboveYear { get; set; }

    public byte? AgeBelowYear { get; set; }

    public byte? AgeAboveMonth { get; set; }

    public byte? AgeBelowMonth { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCGuidelineType")]
    [InverseProperty("GuidelineInclusionGCGuidelineTypeNavigation")]
    public virtual sysGeneralCode GCGuidelineTypeNavigation { get; set; } = null!;

    [ForeignKey("GCSex")]
    [InverseProperty("GuidelineInclusionGCSexNavigation")]
    public virtual sysGeneralCode? GCSexNavigation { get; set; }

    [ForeignKey("GuidelineID")]
    [InverseProperty("GuidelineInclusion")]
    public virtual GuidelineHd Guideline { get; set; } = null!;

    [InverseProperty("GuidelineInclusion")]
    public virtual ICollection<GuidelineDt> GuidelineDt { get; set; } = new List<GuidelineDt>();
}
