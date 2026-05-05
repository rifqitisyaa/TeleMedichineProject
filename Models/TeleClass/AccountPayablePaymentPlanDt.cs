using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PaymentPlanNo", "SequenceNo", "APNo")]
public partial class AccountPayablePaymentPlanDt
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

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OutstandingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalCreditNoteAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool? isReconciliation { get; set; }

    [ForeignKey("APNo")]
    [InverseProperty("AccountPayablePaymentPlanDt")]
    public virtual AccountPayableHd APNoNavigation { get; set; } = null!;

    [InverseProperty("AccountPayablePaymentPlanDt")]
    public virtual ICollection<AccountPayablePaymentPlanDtCreditNote> AccountPayablePaymentPlanDtCreditNote { get; set; } = new List<AccountPayablePaymentPlanDtCreditNote>();

    [ForeignKey("PaymentPlanNo")]
    [InverseProperty("AccountPayablePaymentPlanDt")]
    public virtual AccountPayablePaymentPlanHd PaymentPlanNoNavigation { get; set; } = null!;
}
