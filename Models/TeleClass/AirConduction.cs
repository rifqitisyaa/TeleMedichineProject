using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo", "ItemId")]
public partial class AirConduction
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int ItemId { get; set; }

    public int? Right250 { get; set; }

    public int? Right500 { get; set; }

    public int? Right1000 { get; set; }

    public int? Right2000 { get; set; }

    public int? Right3000 { get; set; }

    public int? Right4000 { get; set; }

    public int? Right6000 { get; set; }

    public int? Right8000 { get; set; }

    public int? Left250 { get; set; }

    public int? Left500 { get; set; }

    public int? Left1000 { get; set; }

    public int? Left2000 { get; set; }

    public int? Left3000 { get; set; }

    public int? Left4000 { get; set; }

    public int? Left6000 { get; set; }

    public int? Left8000 { get; set; }

    public int? AverageRight { get; set; }

    public int? AverageLeft { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool? IsReviewed { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }
}
