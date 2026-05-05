using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DNCNNo", "DNCNSequenceNo")]
public partial class DebitNoteCreditNoteDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DNCNNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string DNCNSequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AmountBeforePpn { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DNCNNo")]
    [InverseProperty("DebitNoteCreditNoteDt")]
    public virtual DebitNoteCreditNoteHd DNCNNoNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("DebitNoteCreditNoteDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("TransactionNo, SequenceNo")]
    [InverseProperty("DebitNoteCreditNoteDt")]
    public virtual TransactionChargesDt TransactionChargesDt { get; set; } = null!;
}
