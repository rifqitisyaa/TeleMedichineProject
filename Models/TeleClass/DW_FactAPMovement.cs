using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_FactAPMovement
{
    [Key]
    public int ID { get; set; }

    public int SiteID { get; set; }

    public int TransactionDateID { get; set; }

    public int TransactionDateTimeID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionSource { get; set; } = null!;

    public int SupplierID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BeginningBalance { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Discount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal VAT { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal IncomeTax { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CNAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal EndingBalance { get; set; }

    [ForeignKey("SiteID")]
    [InverseProperty("DW_FactAPMovement")]
    public virtual DW_DimSiteCode Site { get; set; } = null!;

    [ForeignKey("SupplierID")]
    [InverseProperty("DW_FactAPMovement")]
    public virtual DW_DimSupplier Supplier { get; set; } = null!;

    [ForeignKey("TransactionDateID")]
    [InverseProperty("DW_FactAPMovement")]
    public virtual DW_DimDate TransactionDate { get; set; } = null!;

    [ForeignKey("TransactionDateTimeID")]
    [InverseProperty("DW_FactAPMovement")]
    public virtual DW_DimTime TransactionDateTime { get; set; } = null!;
}
