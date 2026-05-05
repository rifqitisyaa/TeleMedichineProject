using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo", "ItemID")]
public partial class JobOrderBOMOtherExam
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

    [Unicode(false)]
    public string? Notes { get; set; }

    [Unicode(false)]
    public string? Kesimpulan { get; set; }

    public int? AutorizedById { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResultDateTime { get; set; }

    public int? AssetsID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostPrice { get; set; }

    public bool IsCancel { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool? IsReviewed { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsAbnormal { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    [ForeignKey("AssetsID")]
    [InverseProperty("JobOrderBOMOtherExam")]
    public virtual Assets? Assets { get; set; }

    [InverseProperty("JobOrderBOMOtherExam")]
    public virtual Audiometri? Audiometri { get; set; }

    [ForeignKey("AutorizedById")]
    [InverseProperty("JobOrderBOMOtherExam")]
    public virtual Paramedic? AutorizedBy { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("JobOrderBOMOtherExamItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("JobOrderNo, SequenceNo")]
    [InverseProperty("JobOrderBOMOtherExam")]
    public virtual JobOrderDt JobOrderDt { get; set; } = null!;

    [InverseProperty("JobOrderBOMOtherExam")]
    public virtual ICollection<OtherExamResultAttachment> OtherExamResultAttachment { get; set; } = new List<OtherExamResultAttachment>();

    [ForeignKey("ParentItemID")]
    [InverseProperty("JobOrderBOMOtherExamParentItem")]
    public virtual Item? ParentItem { get; set; }
}
