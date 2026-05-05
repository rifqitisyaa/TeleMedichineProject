using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionNo", "SequenceNo")]
public partial class PointRewardRedeemDt
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int MasterPointRewardID { get; set; }

    public int ItemID { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Point { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDatetime { get; set; }
}
