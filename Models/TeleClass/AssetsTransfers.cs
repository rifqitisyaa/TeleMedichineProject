using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetsTransfers
{
    [Key]
    public int AssetsTransferId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    public int AssetsID { get; set; }

    public int? TransferFrom { get; set; }

    public int? TransferTo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AssetsCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string AssetsName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? BookCode { get; set; }

    public int? ServiceUnitId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ServiceDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DepreciationStartDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransactionNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AcquisitionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? SalvageAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DepreciationAmount { get; set; }

    public int? ComponentQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DispositionDate { get; set; }

    [Unicode(false)]
    public string? DispositionReason { get; set; }

    [Unicode(false)]
    public string? SoldFor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MeterInitializationDate { get; set; }

    public int? MeterInitializationQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransferDate { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal? DepreciationQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? OutstandingDepreciation { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetsID")]
    [InverseProperty("AssetsTransfers")]
    public virtual Assets Assets { get; set; } = null!;
}
