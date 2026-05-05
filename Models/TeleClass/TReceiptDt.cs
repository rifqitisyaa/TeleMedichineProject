using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionNo", "SequenceNo")]
public partial class TReceiptDt
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Payment { get; set; } = null!;

    public int? ServiceUnitID { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? ReqAmount { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? Amount { get; set; }

    public int Line { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? ReviewAmount { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? ApproveAmount { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? SettleAmount { get; set; }

    public bool? HaveReceipt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CoaCode { get; set; }

    public bool? IsCanceled { get; set; }

    public bool? isDeleted { get; set; }
}
