using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RequestNo", "SequenceNo")]
public partial class MaterialEngineering
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RequestNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? ItemQuantity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemUnitCode { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ItemPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TotalPrice { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
