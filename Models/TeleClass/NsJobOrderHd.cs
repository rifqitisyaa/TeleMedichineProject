using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DetailId", "JobOrderNo")]
public partial class NsJobOrderHd
{
    [Key]
    public long DetailId { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderType { get; set; } = null!;

    public int ParamedicID { get; set; }

    public int? ServiceUnitID { get; set; }

    public int? LocationID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime JobOrderDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public int? GestationalAge { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IP { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCOrderType { get; set; }

    public bool? IsCito { get; set; }

    public bool? IsReviewed { get; set; }

    public bool? IsSelected { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SelectedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SelectedDateTime { get; set; }

    public bool IsCanceled { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CanceledBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CanceledDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DetailId")]
    [InverseProperty("NsJobOrderHd")]
    public virtual NurseShiftTransferHistoryDt Detail { get; set; } = null!;
}
