using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TransactionChargesHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDatePrint { get; set; }

    public int ServiceUnitID { get; set; }

    public int RoomID { get; set; }

    public int? BedID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ChargeClassCode { get; set; } = null!;

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    public bool IsFromCPOE { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("TransactionNoNavigation")]
    public virtual ICollection<AccountReceivableAccrualDt> AccountReceivableAccrualDt { get; set; } = new List<AccountReceivableAccrualDt>();

    [ForeignKey("BedID")]
    [InverseProperty("TransactionChargesHd")]
    public virtual Bed? Bed { get; set; }

    [ForeignKey("ChargeClassCode")]
    [InverseProperty("TransactionChargesHdChargeClassCodeNavigation")]
    public virtual Class ChargeClassCodeNavigation { get; set; } = null!;

    [ForeignKey("ClassCode")]
    [InverseProperty("TransactionChargesHdClassCodeNavigation")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("TransactionChargesHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("RoomID")]
    [InverseProperty("TransactionChargesHd")]
    public virtual ServiceRoom Room { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("TransactionChargesHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("TransactionChargesHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("TransactionNoNavigation")]
    public virtual ICollection<TransactionChargesDt> TransactionChargesDt { get; set; } = new List<TransactionChargesDt>();

    [ForeignKey("TransactionCode")]
    [InverseProperty("TransactionChargesHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
