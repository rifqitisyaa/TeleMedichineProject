using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MarkUpPrice
{
    [Key]
    public int MarkUpPriceId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ClassCategoryCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GcItemType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    public int? ItemID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? VolumePriceFrom { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? VolumePriceTo { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? MarkUpPercentage { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ClassCategoryCode")]
    [InverseProperty("MarkUpPrice")]
    public virtual ClassCategory? ClassCategoryCodeNavigation { get; set; }

    [ForeignKey("GcItemType")]
    [InverseProperty("MarkUpPrice")]
    public virtual sysGeneralCode? GcItemTypeNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("MarkUpPrice")]
    public virtual Item? Item { get; set; }

    [ForeignKey("ItemGroupCode")]
    [InverseProperty("MarkUpPrice")]
    public virtual ItemGroup? ItemGroupCodeNavigation { get; set; }
}
