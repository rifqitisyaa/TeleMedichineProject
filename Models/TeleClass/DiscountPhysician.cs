using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DiscountPhysician
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DiscountPhysicianNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DiscountPhysicianDate { get; set; }

    public int ParamedicID { get; set; }

    public int? ServiceUnitID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ItemName { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountReverseAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PrecentageAmount { get; set; }

    public bool? IsType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VerificationNo { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
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

    [InverseProperty("DiscountPhysicianNoNavigation")]
    public virtual ICollection<DiscountPhysicianReverse> DiscountPhysicianReverse { get; set; } = new List<DiscountPhysicianReverse>();

    [ForeignKey("ParamedicID")]
    [InverseProperty("DiscountPhysician")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("DiscountPhysician")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("DiscountPhysician")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("DiscountPhysician")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("DiscountPhysician")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
