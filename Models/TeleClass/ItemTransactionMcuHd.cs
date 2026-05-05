using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemTransactionMcuHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransactionDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public int ParentItemId { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

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
    public decimal PpnCustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerAmount { get; set; }

    public bool IsAllocateRevenue { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("TransactionNoNavigation")]
    public virtual ICollection<ItemTransactionMcuDt> ItemTransactionMcuDt { get; set; } = new List<ItemTransactionMcuDt>();

    [ForeignKey("ParentItemId")]
    [InverseProperty("ItemTransactionMcuHd")]
    public virtual Item ParentItem { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("ItemTransactionMcuHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemTransactionMcuHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ItemTransactionMcuHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
