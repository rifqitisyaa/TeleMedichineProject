using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "PaymentPlanNo")]
public partial class PaymentPlanAPGiro
{
    [Key]
    [StringLength(50)]
    public string PaymentPlanNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string BusinessPartnerID { get; set; } = null!;

    [StringLength(20)]
    public string? BankAccountId { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal PaymentAmount { get; set; }

    [StringLength(20)]
    public string? BGNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CekGiroDueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CekGiroDate { get; set; }

    public bool? IsReconcile { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
