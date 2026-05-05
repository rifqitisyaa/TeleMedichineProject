using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReplacementHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReplacementNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int LocationID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ReplacementDateTime { get; set; }

    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReturnToSupplierNo { get; set; } = null!;

    public byte? RevisionNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("ReplacementHd")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("LocationID")]
    [InverseProperty("ReplacementHd")]
    public virtual Location Location { get; set; } = null!;

    [InverseProperty("ReplacementNoNavigation")]
    public virtual ICollection<ReplacementDt> ReplacementDt { get; set; } = new List<ReplacementDt>();

    [ForeignKey("ReturnToSupplierNo")]
    [InverseProperty("ReplacementHd")]
    public virtual ReturnToSupplierHd ReturnToSupplierNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ReplacementHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ReplacementHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
