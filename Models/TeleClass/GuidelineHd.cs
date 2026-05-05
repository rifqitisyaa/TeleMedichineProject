using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class GuidelineHd
{
    [Key]
    public int GuildelineID { get; set; }

    [Unicode(false)]
    public string GuideLineName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPathology { get; set; }

    [Unicode(false)]
    public string? LosEstimated { get; set; }

    [Unicode(false)]
    public string? Diagnosis { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Guideline")]
    public virtual ICollection<ClinicalPathwayHd> ClinicalPathwayHd { get; set; } = new List<ClinicalPathwayHd>();

    [ForeignKey("GCPathology")]
    [InverseProperty("GuidelineHd")]
    public virtual sysGeneralCode? GCPathologyNavigation { get; set; }

    [InverseProperty("Guideline")]
    public virtual ICollection<GuidelineInclusion> GuidelineInclusion { get; set; } = new List<GuidelineInclusion>();

    [InverseProperty("Guideline")]
    public virtual ICollection<GuidelineInclusionHd> GuidelineInclusionHd { get; set; } = new List<GuidelineInclusionHd>();
}
