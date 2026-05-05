using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("APNo", "CreditNoteNo")]
public partial class AccountPayableDtCreditNote
{
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

    [ForeignKey("APNo")]
    [InverseProperty("AccountPayableDtCreditNote")]
    public virtual AccountPayableHd APNoNavigation { get; set; } = null!;

    [ForeignKey("CreditNoteNo")]
    [InverseProperty("AccountPayableDtCreditNote")]
    public virtual CreditNote CreditNoteNoNavigation { get; set; } = null!;
}
