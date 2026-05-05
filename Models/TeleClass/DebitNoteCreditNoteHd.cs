using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DebitNoteCreditNoteHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DNCNNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public DateOnly DNCNDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TermCode { get; set; }

    public DateOnly DNCNDueDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DNCNAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DNCNReverseAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCForceCloseReason { get; set; }

    public bool IsForceClose { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CloseBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDateTime { get; set; }

    public bool? IsPlafon { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("DebitNoteCreditNoteHd")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [InverseProperty("DNCNNoNavigation")]
    public virtual ICollection<DebitNoteCreditNoteDt> DebitNoteCreditNoteDt { get; set; } = new List<DebitNoteCreditNoteDt>();

    [InverseProperty("DNCNNoNavigation")]
    public virtual ICollection<DebitNoteCreditNoteHdReverse> DebitNoteCreditNoteHdReverse { get; set; } = new List<DebitNoteCreditNoteHdReverse>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("DebitNoteCreditNoteHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("DebitNoteCreditNoteHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TermCode")]
    [InverseProperty("DebitNoteCreditNoteHd")]
    public virtual Term? TermCodeNavigation { get; set; }

    [ForeignKey("TransactionCode")]
    [InverseProperty("DebitNoteCreditNoteHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
