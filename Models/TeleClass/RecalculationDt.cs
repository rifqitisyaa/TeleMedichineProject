using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RecalculationNo", "TransactionNo", "SequenceNo")]
public partial class RecalculationDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RecalculationNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string? RecalculationSequenceNo { get; set; }

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal StandardPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalCitoCompPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerCitoCompPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnPersonalPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnCustomerPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal StandardPriceAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalPriceAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalCitoCompPriceAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerPriceAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerCitoCompPriceAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountPriceAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnPersonalPriceAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnCustomerPriceAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalCustomerBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalPersonalBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalCustomerAfter { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalPersonalAfter { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("RecalculationDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("RecalculationNo")]
    [InverseProperty("RecalculationDt")]
    public virtual RecalculationHd RecalculationNoNavigation { get; set; } = null!;

    [ForeignKey("TransactionNo, SequenceNo")]
    [InverseProperty("RecalculationDt")]
    public virtual TransactionChargesDt TransactionChargesDt { get; set; } = null!;
}
