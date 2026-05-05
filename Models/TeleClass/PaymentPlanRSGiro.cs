using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ParamedicId", "PaymentPlanNo")]
public partial class PaymentPlanRSGiro
{
    [Key]
    public int ParamedicId { get; set; }

    [Key]
    [StringLength(20)]
    public string PaymentPlanNo { get; set; } = null!;

    [StringLength(20)]
    public string? BankAccountId { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? PaymentAmount { get; set; }

    [StringLength(20)]
    public string? BGNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CekGiroRSDueDate { get; set; }

    [StringLength(10)]
    public string? CekGiro { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
