using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProcessDateTime", "SequenceNo")]
public partial class StockTakingQR
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ProcessDateTime { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string BarcodeCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    public int ItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiredDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal CountQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DepartmentCode { get; set; }

    public int? ServiceUnitID { get; set; }

    public int? LocationID { get; set; }

    public bool IsDeleted { get; set; }

    public bool Isprocessed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StockTakingFrom { get; set; }
}
