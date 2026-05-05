using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GuidelineID", "GCGuidelineType", "InclusionCode", "PartName", "ItemID")]
public partial class GuidelineDt
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

    [Key]
    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Dose { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Frequency { get; set; }

    public byte? Duration { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCItemType")]
    [InverseProperty("GuidelineDt")]
    public virtual sysGeneralCode GCItemTypeNavigation { get; set; } = null!;

    [ForeignKey("GuidelineID, GCGuidelineType, InclusionCode, PartName")]
    [InverseProperty("GuidelineDt")]
    public virtual GuidelineInclusion GuidelineInclusion { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("GuidelineDt")]
    public virtual Item Item { get; set; } = null!;
}
