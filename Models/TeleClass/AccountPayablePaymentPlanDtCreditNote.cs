using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PaymentPlanNo", "SequenceNo", "APNo", "CreditNoteNo")]
public partial class AccountPayablePaymentPlanDtCreditNote
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentPlanNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string APNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string CreditNoteNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CreditNoteAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("PaymentPlanNo, SequenceNo, APNo")]
    [InverseProperty("AccountPayablePaymentPlanDtCreditNote")]
    public virtual AccountPayablePaymentPlanDt AccountPayablePaymentPlanDt { get; set; } = null!;

    [ForeignKey("CreditNoteNo")]
    [InverseProperty("AccountPayablePaymentPlanDtCreditNote")]
    public virtual CreditNote CreditNoteNoNavigation { get; set; } = null!;
}
