using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo")]
public partial class JobOrderDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

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

    [StringLength(20)]
    [Unicode(false)]
    public string? AccessionNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResultDateTime { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ResultNotes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AssetID { get; set; }

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

    [NotMapped]
    public decimal? Qty { get; set; }

    public bool? IsCito { get; set; }

    public bool? IsRead { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCJobOrderStatus")]
    [InverseProperty("JobOrderDtGCJobOrderStatusNavigation")]
    public virtual sysGeneralCode? GCJobOrderStatusNavigation { get; set; }

    [ForeignKey("GCOrderType")]
    [InverseProperty("JobOrderDtGCOrderTypeNavigation")]
    public virtual sysGeneralCode? GCOrderTypeNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("JobOrderDt")]
    public virtual Item Item { get; set; } = null!;

    [InverseProperty("JobOrderDt")]
    public virtual ICollection<JobOrderBOMImaging> JobOrderBOMImaging { get; set; } = new List<JobOrderBOMImaging>();

    [InverseProperty("JobOrderDt")]
    public virtual ICollection<JobOrderBOMLaboratory> JobOrderBOMLaboratory { get; set; } = new List<JobOrderBOMLaboratory>();

    [InverseProperty("JobOrderDt")]
    public virtual ICollection<JobOrderBOMOtherExam> JobOrderBOMOtherExam { get; set; } = new List<JobOrderBOMOtherExam>();

    [InverseProperty("JobOrderDt")]
    public virtual ICollection<JobOrderDtDiagnose> JobOrderDtDiagnose { get; set; } = new List<JobOrderDtDiagnose>();

    [InverseProperty("JobOrderDt")]
    public virtual JobOrderImagingReference? JobOrderImagingReference { get; set; }

    [InverseProperty("JobOrderDt")]
    public virtual JobOrderLaboratoryReference? JobOrderLaboratoryReference { get; set; }

    [ForeignKey("JobOrderNo")]
    [InverseProperty("JobOrderDt")]
    public virtual JobOrderHd JobOrderNoNavigation { get; set; } = null!;

    [InverseProperty("JobOrderDt")]
    public virtual JobOrderOtherExamReference? JobOrderOtherExamReference { get; set; }
}
