using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo")]
public partial class JobOrderDtMedicalSuppiles
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal OrderQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BaseUnitCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ToBePerformed { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? StartDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCOrderType { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string OrderNotes { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCJobOrderStatus { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? StandartPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CustomerCitoCompPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PersonalCitoCompPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PpnPersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PpnCustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalCustomer { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalPersonal { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? ReturnQty { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BaseUnitCode")]
    [InverseProperty("JobOrderDtMedicalSuppiles")]
    public virtual ItemUnit? BaseUnitCodeNavigation { get; set; }

    [ForeignKey("GCJobOrderStatus")]
    [InverseProperty("JobOrderDtMedicalSuppilesGCJobOrderStatusNavigation")]
    public virtual sysGeneralCode? GCJobOrderStatusNavigation { get; set; }

    [ForeignKey("GCOrderType")]
    [InverseProperty("JobOrderDtMedicalSuppilesGCOrderTypeNavigation")]
    public virtual sysGeneralCode? GCOrderTypeNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("JobOrderDtMedicalSuppiles")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("JobOrderNo")]
    [InverseProperty("JobOrderDtMedicalSuppiles")]
    public virtual JobOrderHd JobOrderNoNavigation { get; set; } = null!;
}
