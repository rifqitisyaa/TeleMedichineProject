using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class GuidelineInclusionHd
{
    [Key]
    public int GuidelineInclusionId { get; set; }

    public int GuidelineId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCGuidelineType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    public byte NumberOfPart { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PartDescription { get; set; }

    public int? BusinessPartnerID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AgeDescription { get; set; }

    public byte? AgeAboveYear { get; set; }

    public byte? AgeBelowYear { get; set; }

    public byte? AgeAboveMonth { get; set; }

    public byte? AgebelowMonth { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("GuidelineInclusionHd")]
    public virtual BusinessPartner? BusinessPartner { get; set; }

    [ForeignKey("GCGuidelineType")]
    [InverseProperty("GuidelineInclusionHdGCGuidelineTypeNavigation")]
    public virtual sysGeneralCode GCGuidelineTypeNavigation { get; set; } = null!;

    [ForeignKey("GCSex")]
    [InverseProperty("GuidelineInclusionHdGCSexNavigation")]
    public virtual sysGeneralCode? GCSexNavigation { get; set; }

    [ForeignKey("GuidelineId")]
    [InverseProperty("GuidelineInclusionHd")]
    public virtual GuidelineHd Guideline { get; set; } = null!;

    [InverseProperty("GuidelineInclusion")]
    public virtual ICollection<GuidelineDtItem> GuidelineDtItem { get; set; } = new List<GuidelineDtItem>();

    [InverseProperty("GuidelineInclusion")]
    public virtual ICollection<GuidelineSummary> GuidelineSummary { get; set; } = new List<GuidelineSummary>();
}
