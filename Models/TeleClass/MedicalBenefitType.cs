using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MedicalBenefitType
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BenefitName { get; set; } = null!;

    public bool IsPercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaxBenefitAmount { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? PercentageQty { get; set; }

    public int? MaxFrequency { get; set; }

    public int? TakeableAfter { get; set; }

    public bool? IsAutoGenerate { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("BenefitType")]
    public virtual ICollection<EmployeeMedical> EmployeeMedical { get; set; } = new List<EmployeeMedical>();

    [InverseProperty("MedicalBenefit")]
    public virtual ICollection<EmployeeMedicalAdjustmentHd> EmployeeMedicalAdjustmentHd { get; set; } = new List<EmployeeMedicalAdjustmentHd>();

    [InverseProperty("BenefitType")]
    public virtual ICollection<EmployeeMedicalClaim> EmployeeMedicalClaim { get; set; } = new List<EmployeeMedicalClaim>();
}
