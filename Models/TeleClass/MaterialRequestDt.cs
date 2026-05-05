using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MaterialRequestNo", "SequenceNo")]
public partial class MaterialRequestDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MaterialRequestNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal RequestQuantity { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ApproveQuantity { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal DeliveryQuantity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    public bool IsClosed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("MaterialRequestDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("MaterialRequestDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [InverseProperty("MaterialRequestDt")]
    public virtual ICollection<MaterialRequestCompletionDt> MaterialRequestCompletionDt { get; set; } = new List<MaterialRequestCompletionDt>();

    [ForeignKey("MaterialRequestNo")]
    [InverseProperty("MaterialRequestDt")]
    public virtual MaterialRequestHd MaterialRequestNoNavigation { get; set; } = null!;
}
