using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ReplacementNo", "SequenceNo")]
public partial class ReplacementDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReplacementNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string RTSSequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ReplacementDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("ReplacementDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("ReplacementNo")]
    [InverseProperty("ReplacementDt")]
    public virtual ReplacementHd ReplacementNoNavigation { get; set; } = null!;
}
