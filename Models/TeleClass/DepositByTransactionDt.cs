using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DepositByTransactionNo", "SequenceNo")]
public partial class DepositByTransactionDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DepositByTransactionNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderType { get; set; } = null!;

    public bool? IsSelected { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
