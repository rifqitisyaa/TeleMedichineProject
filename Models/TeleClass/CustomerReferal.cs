using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ReferralID")]
public partial class CustomerReferal
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    public int ReferralID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CustomerReferalCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string CustomerReferalName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("CustomerReferal")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("ReferralID")]
    [InverseProperty("CustomerReferal")]
    public virtual Referral Referral { get; set; } = null!;
}
