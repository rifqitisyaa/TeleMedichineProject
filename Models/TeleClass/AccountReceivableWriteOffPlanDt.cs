using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("WriteOffPlanNo", "SequenceNo")]
public partial class AccountReceivableWriteOffPlanDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string WriteOffPlanNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ReferenceTransactionCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OutstandingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal WriteOffAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("WriteOffPlanNo")]
    [InverseProperty("AccountReceivableWriteOffPlanDt")]
    public virtual AccountReceivableWriteOffPlanHd WriteOffPlanNoNavigation { get; set; } = null!;
}
