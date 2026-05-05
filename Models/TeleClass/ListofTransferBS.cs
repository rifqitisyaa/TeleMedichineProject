using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ListofTransferBS
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    public int? BankFromID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankTo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccountNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AccountName { get; set; }

    public bool? IsReconcile { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
