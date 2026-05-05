using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class JournalHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JournalNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCJournalType { get; set; } = null!;

    public DateOnly JournalDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public bool IsGenerated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewDateTime { get; set; }

    public bool IsReviewed { get; set; }

    public bool IsPosting { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PostingBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PostingDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DepartmentCode")]
    [InverseProperty("JournalHd")]
    public virtual Department DepartmentCodeNavigation { get; set; } = null!;

    [ForeignKey("GCJournalType")]
    [InverseProperty("JournalHd")]
    public virtual sysGeneralCode GCJournalTypeNavigation { get; set; } = null!;

    [InverseProperty("JournalNoNavigation")]
    public virtual ICollection<JournalDt> JournalDt { get; set; } = new List<JournalDt>();

    [InverseProperty("JournalNoNavigation")]
    public virtual ICollection<RecuringDt> RecuringDt { get; set; } = new List<RecuringDt>();

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("JournalHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("JournalHd")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("JournalHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("JournalHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
