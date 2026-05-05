using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Organization
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string OrganizationCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? OrganizationHead { get; set; }

    public int OrganizationLevel { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ParentOrganization { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? OrganizationPercentage { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("OrganizationCodeNavigation")]
    public virtual ICollection<Employee> Employee { get; set; } = new List<Employee>();

    [InverseProperty("OrganitationCodeFromNavigation")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistoryOrganitationCodeFromNavigation { get; set; } = new List<EmployeeWorkingHistory>();

    [InverseProperty("OrganitationCodeToNavigation")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistoryOrganitationCodeToNavigation { get; set; } = new List<EmployeeWorkingHistory>();

    [InverseProperty("ParentOrganizationNavigation")]
    public virtual ICollection<Organization> InverseParentOrganizationNavigation { get; set; } = new List<Organization>();

    [ForeignKey("OrganizationHead")]
    [InverseProperty("Organization")]
    public virtual Employee? OrganizationHeadNavigation { get; set; }

    [ForeignKey("ParentOrganization")]
    [InverseProperty("InverseParentOrganizationNavigation")]
    public virtual Organization? ParentOrganizationNavigation { get; set; }
}
