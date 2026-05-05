using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionNo", "SequenceNo")]
public partial class ItemServiceMCURealizationDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    public int? ParamedicID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ChargesQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal DispenseQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LaborCost { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal StandardPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalCustomer { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalPersonal { get; set; }

    public bool? IsVerifiedRevenue { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ItemServiceMCURealizationDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("ItemServiceMCURealizationDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("ItemServiceMCURealizationDt")]
    public virtual Paramedic? Paramedic { get; set; }

    [ForeignKey("TransactionNo")]
    [InverseProperty("ItemServiceMCURealizationDt")]
    public virtual ItemServiceMCURealizationHd TransactionNoNavigation { get; set; } = null!;
}
