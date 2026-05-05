using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class InterimBill
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string InterimBillNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InterimBillDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal RemainingAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("InterimBill")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("InterimBill")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
