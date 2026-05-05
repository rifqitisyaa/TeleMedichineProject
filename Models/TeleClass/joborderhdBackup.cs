using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class joborderhdBackup
{
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

    [StringLength(10)]
    [Unicode(false)]
    public string? TestTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TestDate { get; set; }

    public int? Iteration { get; set; }

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

    public bool? IsSent { get; set; }

    public bool IsVerified { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? VerifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VerifiedDateTime { get; set; }

    public bool? IsChangeToNonAutopack { get; set; }

    public bool? IsUDD { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
