using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Term
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TermCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TermName { get; set; } = null!;

    public byte TermDay { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("TermOfPaymentNavigation")]
    public virtual ICollection<AccountPayableHd> AccountPayableHd { get; set; } = new List<AccountPayableHd>();

    [InverseProperty("TermCodeNavigation")]
    public virtual ICollection<AccountReceivableHd> AccountReceivableHd { get; set; } = new List<AccountReceivableHd>();

    [InverseProperty("TermCodeNavigation")]
    public virtual ICollection<DebitNoteCreditNoteHd> DebitNoteCreditNoteHd { get; set; } = new List<DebitNoteCreditNoteHd>();
}
