using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class ClinicalPathwayHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ClinicalPathwayDatetime { get; set; }

    public int GuidelineId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCGuidelineType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? InclusionCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string PartName { get; set; } = null!;

    public int? PartId { get; set; }

    public int? GuidelineInclusionId { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [InverseProperty("ClinicalPathwayHd")]
    public virtual ICollection<ClinicalPathwayDt> ClinicalPathwayDt { get; set; } = new List<ClinicalPathwayDt>();

    [ForeignKey("GCGuidelineType")]
    [InverseProperty("ClinicalPathwayHd")]
    public virtual sysGeneralCode GCGuidelineTypeNavigation { get; set; } = null!;

    [ForeignKey("GuidelineId")]
    [InverseProperty("ClinicalPathwayHd")]
    public virtual GuidelineHd Guideline { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("ClinicalPathwayHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
