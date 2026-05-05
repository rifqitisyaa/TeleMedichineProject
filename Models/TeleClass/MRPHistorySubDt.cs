using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MRPNo", "SequenceNo")]
[Index("ItemID", Name = "IX_MRPHistorySubDt_ItemID")]
public partial class MRPHistorySubDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MRPNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartPeriodMRP { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndPeriodMRP { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartPeriod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndPeriod { get; set; }

    public int LeadTime { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ForecastQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal GrossReqQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ScheduleReceiptQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal PurchaseOrderReleaseQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ProjectedOnHand { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal SafetyStock { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyOnHand { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal PlanOrderDue { get; set; }

    public byte PurchasingLeadTime { get; set; }

    public byte ManufactureLeadTime { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsByPeriod { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("MRPHistorySubDt")]
    public virtual Item Item { get; set; } = null!;

    [InverseProperty("MRPHistorySubDt")]
    public virtual ICollection<MRPHistoryDt> MRPHistoryDt { get; set; } = new List<MRPHistoryDt>();

    [ForeignKey("MRPNo")]
    [InverseProperty("MRPHistorySubDt")]
    public virtual MRPHistoryHd MRPNoNavigation { get; set; } = null!;
}
