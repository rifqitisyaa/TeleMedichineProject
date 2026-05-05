using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DepositPaymentHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DepositNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DepositDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public int? ServiceUnitID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DepositAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DepositReverseAmount { get; set; }

    [Unicode(false)]
    public string? Note { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public bool? IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("DepositNoNavigation")]
    public virtual ICollection<DepositPaymentDt> DepositPaymentDt { get; set; } = new List<DepositPaymentDt>();

    [InverseProperty("DepositNoNavigation")]
    public virtual ICollection<DepositPaymentDtReverse> DepositPaymentDtReverse { get; set; } = new List<DepositPaymentDtReverse>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("DepositPaymentHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("DepositPaymentHd")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("DepositPaymentHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("DepositPaymentHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
