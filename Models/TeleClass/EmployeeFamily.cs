using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmployeeFamily
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string DependentName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCFamilyRelation { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? TaxRegistrant { get; set; }

    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNo { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsIncludePTKP { get; set; }

    public bool? IsIncludeMedicalBenefit { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("EmployeeFamily")]
    public virtual Employee Employee { get; set; } = null!;

    [InverseProperty("EmployeeFamily")]
    public virtual ICollection<EmployeeMedicalClaim> EmployeeMedicalClaim { get; set; } = new List<EmployeeMedicalClaim>();

    [ForeignKey("GCFamilyRelation")]
    [InverseProperty("EmployeeFamily")]
    public virtual sysGeneralCode GCFamilyRelationNavigation { get; set; } = null!;
}
