using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BillingComparisonID", "SequenceNo")]
public partial class BillingComparisonDt
{
    [Key]
    public int BillingComparisonID { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string TransactionSequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ChargesQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal DispenseQty { get; set; }

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
    public decimal CustomerCitoCompPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalCitoCompPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnCustomer { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnPersonal { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalCustomer { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalPersonal { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
