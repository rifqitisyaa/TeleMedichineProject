using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "ItemID", "KFACode")]
public partial class RiwayatPengobatanPasien
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string KFACode { get; set; } = null!;

    [Unicode(false)]
    public string? KFAName { get; set; }

    [Unicode(false)]
    public string? Note { get; set; }

    public int? Frequency { get; set; }

    public int? Period { get; set; }

    public int? PeriodMax { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PeriodUnit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssertedDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Type { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
