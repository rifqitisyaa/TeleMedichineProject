using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo", "ItemID")]
public partial class JobOrderBOMImaging
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    public int? ParentItemID { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? QtyTaken { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostPrice { get; set; }

    [Unicode(false)]
    public string? ResultValue { get; set; }

    [Unicode(false)]
    public string? OutdatedResultValue { get; set; }

    [Unicode(false)]
    public string? Kesimpulan { get; set; }

    [Unicode(false)]
    public string? Saran { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResultDateTime { get; set; }

    public int? AssetsID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AccessionNo { get; set; }

    public int? ReviewByParamedic { get; set; }

    public bool IsCancel { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetsID")]
    [InverseProperty("JobOrderBOMImaging")]
    public virtual Assets? Assets { get; set; }

    [InverseProperty("JobOrderBOMImaging")]
    public virtual ICollection<ImagingExamAdministration> ImagingExamAdministration { get; set; } = new List<ImagingExamAdministration>();

    [ForeignKey("ItemID")]
    [InverseProperty("JobOrderBOMImagingItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("JobOrderNo, SequenceNo")]
    [InverseProperty("JobOrderBOMImaging")]
    public virtual JobOrderDt JobOrderDt { get; set; } = null!;

    [ForeignKey("ParentItemID")]
    [InverseProperty("JobOrderBOMImagingParentItem")]
    public virtual Item? ParentItem { get; set; }

    [ForeignKey("ReviewByParamedic")]
    [InverseProperty("JobOrderBOMImaging")]
    public virtual Paramedic? ReviewByParamedicNavigation { get; set; }
}
