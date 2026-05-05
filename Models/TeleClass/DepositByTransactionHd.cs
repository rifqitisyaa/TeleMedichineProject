using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DepositByTransactionHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DepositByTransactionNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? TransactionNo { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AditionalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ServiceAmount { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    public DateOnly? LastUpdatedDatetime { get; set; }
}
