using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ServiceOrderHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ServiceOrderNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ServiceOrderDate { get; set; }

    public int BusinessPartnerID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountAmount { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public bool? IsReferral { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedByUserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public byte? RevisionNo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("POReceiptNoNavigation")]
    public virtual ICollection<Assets> Assets { get; set; } = new List<Assets>();

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("ServiceOrderHd")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [InverseProperty("ServiceOrderNoNavigation")]
    public virtual ICollection<ServiceOrderDt> ServiceOrderDt { get; set; } = new List<ServiceOrderDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("ServiceOrderHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ServiceOrderHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
