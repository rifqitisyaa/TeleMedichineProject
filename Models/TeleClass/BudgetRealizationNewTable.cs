using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BudgetNo", "SequenceNo")]
public partial class BudgetRealizationNewTable
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string BudgetNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? KodeAnggaran { get; set; }

    public int? MonthPeriod { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LabelPeriod { get; set; }

    public int? BussinesPartnerID { get; set; }

    [Unicode(false)]
    public string? SupplierName { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RealizationAmount { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NoSpSpb { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SpSpbDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RealizationDateTime { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NoBast { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BastDateTime { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NoKaruas { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NoSpby { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ImplementationPeriod { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
