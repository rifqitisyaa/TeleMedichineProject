using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeMedicalClaim
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ClaimDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TreatmentDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ClaimType { get; set; } = null!;

    public int? EmployeeFamilyId { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaxBenefitAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BalanceAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal UsedAmount { get; set; }

    public int BenefitTypeId { get; set; }

    public int EmployeeMedicalId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string HealthcareProvider { get; set; } = null!;

    [Unicode(false)]
    public string? MedicalInformation { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ClaimAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ClaimApprovedAmount { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

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

    [ForeignKey("BenefitTypeId")]
    [InverseProperty("EmployeeMedicalClaim")]
    public virtual MedicalBenefitType BenefitType { get; set; } = null!;

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeMedicalClaim")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("EmployeeFamilyId")]
    [InverseProperty("EmployeeMedicalClaim")]
    public virtual EmployeeFamily? EmployeeFamily { get; set; }

    [ForeignKey("EmployeeMedicalId")]
    [InverseProperty("EmployeeMedicalClaim")]
    public virtual EmployeeMedical EmployeeMedical { get; set; } = null!;
}
