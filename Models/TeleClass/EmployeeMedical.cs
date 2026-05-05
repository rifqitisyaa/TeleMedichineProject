using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeMedical
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    public int BenefitTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartEffectiveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndEffectiveDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BenefitAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal UsedAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BalanceAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BenefitTypeId")]
    [InverseProperty("EmployeeMedical")]
    public virtual MedicalBenefitType BenefitType { get; set; } = null!;

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeMedical")]
    public virtual Employee Employee { get; set; } = null!;

    [InverseProperty("EmployeeMedical")]
    public virtual ICollection<EmployeeMedicalClaim> EmployeeMedicalClaim { get; set; } = new List<EmployeeMedicalClaim>();
}
