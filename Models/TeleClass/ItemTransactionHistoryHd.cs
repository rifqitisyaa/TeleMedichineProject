using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemTransactionHistoryHd
{
    [Key]
    public long TransactionHistoryID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransactionDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VoucherNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionSource { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string SubTransactionCode { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    public int? LocationID { get; set; }

    public int? ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemUnitCode { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QuantityChange { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal BeginingBalanceLocation { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal EndingBalanceLocation { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal BeginingBalanceSite { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal EndingBalanceSite { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    public int? BusinessPartnerID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaterialCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LaborCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OverheadCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BurdenCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SubconCostPrice { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsPosting { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PostingBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PostingDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DepartmentCode")]
    [InverseProperty("ItemTransactionHistoryHd")]
    public virtual Department DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ItemTransactionHistoryHd")]
    public virtual Item? Item { get; set; }

    [InverseProperty("TransactionHistory")]
    public virtual ICollection<ItemTransactionHistoryDt> ItemTransactionHistoryDt { get; set; } = new List<ItemTransactionHistoryDt>();

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("ItemTransactionHistoryHd")]
    public virtual ItemUnit? ItemUnitCodeNavigation { get; set; }

    [ForeignKey("LocationID")]
    [InverseProperty("ItemTransactionHistoryHd")]
    public virtual Location? Location { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("ItemTransactionHistoryHd")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ItemTransactionHistoryHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("ItemTransactionHistoryHd")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemTransactionHistoryHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
