using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AssetsID", "Period")]
public partial class AssetsDepreciation
{
    [Key]
    public int AssetsID { get; set; }

    [Key]
    public byte Period { get; set; }

    public DateOnly DepreciationDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BookValue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DepreciationValue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AccumulatedValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetsID")]
    [InverseProperty("AssetsDepreciation")]
    public virtual Assets Assets { get; set; } = null!;
}
