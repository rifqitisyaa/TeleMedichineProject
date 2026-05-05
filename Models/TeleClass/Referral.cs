using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Referral
{
    [Key]
    public int ReferralID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCReferralType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ReferralBy { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Address { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Referral")]
    public virtual ICollection<CustomerReferal> CustomerReferal { get; set; } = new List<CustomerReferal>();

    [ForeignKey("GCReferralType")]
    [InverseProperty("Referral")]
    public virtual sysGeneralCode GCReferralTypeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("Referral")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
