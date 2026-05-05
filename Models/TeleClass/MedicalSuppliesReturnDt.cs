using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalSuppliesReturnNo", "SequenceNo")]
public partial class MedicalSuppliesReturnDt
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string MedicalSuppliesReturnNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? JobOrderNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JobOrderSequenceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

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
    public decimal PpnPersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PPnCustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
