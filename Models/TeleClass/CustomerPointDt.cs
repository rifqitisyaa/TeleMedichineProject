using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class CustomerPointDt
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CustomerCategoryCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TranscationAmount { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal PointQtyChange { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BeginingAmount { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal BeginingPointQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal EndingAmount { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal EndingPointQty { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransactionType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDateFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDateTo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDatetime { get; set; }
}
