using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AssetsDisposalNo", "AssetsId")]
public partial class AssetsDisposalDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AssetsDisposalNo { get; set; } = null!;

    [Key]
    public int AssetsId { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AcquistionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DepreciationAmount { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
