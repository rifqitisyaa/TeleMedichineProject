using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AccountReceivableWriteOffPlanHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string WriteOffPlanNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime WriteOffPlanDateTime { get; set; }

    public int? BusinessPartnerID { get; set; }

    public byte DueDays { get; set; }

    public DateOnly DueDate { get; set; }

    public byte? RevisionNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Amount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool? IsPrintedList { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedListDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedListByUserID { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool? IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ProceedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProceedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("WriteOffPlanNoNavigation")]
    public virtual ICollection<AccountReceivableWriteOffPlanDt> AccountReceivableWriteOffPlanDt { get; set; } = new List<AccountReceivableWriteOffPlanDt>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("AccountReceivableWriteOffPlanHd")]
    public virtual BusinessPartner? BusinessPartner { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("AccountReceivableWriteOffPlanHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("AccountReceivableWriteOffPlanHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
