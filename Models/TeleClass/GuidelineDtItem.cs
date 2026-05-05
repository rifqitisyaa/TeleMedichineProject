using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class GuidelineDtItem
{
    [Key]
    public long Id { get; set; }

    public int GuidelineInclusionId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string PartId { get; set; } = null!;

    public int? ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VitalSignCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Dose { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Frequency { get; set; }

    public byte? Duration { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCItemType")]
    [InverseProperty("GuidelineDtItem")]
    public virtual sysGeneralCode GCItemTypeNavigation { get; set; } = null!;

    [ForeignKey("GuidelineInclusionId")]
    [InverseProperty("GuidelineDtItem")]
    public virtual GuidelineInclusionHd GuidelineInclusion { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("GuidelineDtItem")]
    public virtual Item? Item { get; set; }

    [ForeignKey("VitalSignCode")]
    [InverseProperty("GuidelineDtItem")]
    public virtual VitalSignType? VitalSignCodeNavigation { get; set; }
}
