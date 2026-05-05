using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class InventoryRevaluationHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string InventoryRevaluationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InventoryRevaluationDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CalculatedDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    public int ServiceUnitId { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCItemType")]
    [InverseProperty("InventoryRevaluationHd")]
    public virtual sysGeneralCode GCItemTypeNavigation { get; set; } = null!;

    [InverseProperty("InventoryRevaluationNoNavigation")]
    public virtual ICollection<InventoryRevaluationDt> InventoryRevaluationDt { get; set; } = new List<InventoryRevaluationDt>();

    [ForeignKey("ItemGroupCode")]
    [InverseProperty("InventoryRevaluationHd")]
    public virtual ItemGroup ItemGroupCodeNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("InventoryRevaluationHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("InventoryRevaluationHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("InventoryRevaluationHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
